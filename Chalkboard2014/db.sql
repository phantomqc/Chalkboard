SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

DROP SCHEMA IF EXISTS `chalkboard` ;
CREATE SCHEMA IF NOT EXISTS `chalkboard` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci ;
USE `chalkboard` ;

-- -----------------------------------------------------
-- Table `chalkboard`.`chalkboard_equipe`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `chalkboard`.`chalkboard_equipe` ;

CREATE  TABLE IF NOT EXISTS `chalkboard`.`chalkboard_equipe` (
  `idequipe` INT NOT NULL AUTO_INCREMENT ,
  `equipenom` VARCHAR(45) NOT NULL ,
  `equipeage` VARCHAR(6) NOT NULL ,
  `equipesexe` VARCHAR(1) NOT NULL ,
  `equipecat` VARCHAR(3) NOT NULL ,
  PRIMARY KEY (`idequipe`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `chalkboard`.`chalkboard_joueur`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `chalkboard`.`chalkboard_joueur` ;

CREATE  TABLE IF NOT EXISTS `chalkboard`.`chalkboard_joueur` (
  `idjoueur` INT NOT NULL ,
  `joueurnom` VARCHAR(45) NOT NULL ,
  `equipe` INT NOT NULL ,
  `joueurno` INT NULL ,
  PRIMARY KEY (`idjoueur`) ,
  INDEX `fk_joueur_equipe_idx` (`equipe` ASC) ,
  CONSTRAINT `fk_joueur_equipe`
    FOREIGN KEY (`equipe` )
    REFERENCES `chalkboard`.`chalkboard_equipe` (`idequipe` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `chalkboard`.`chalkboard_partie`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `chalkboard`.`chalkboard_partie` ;

CREATE  TABLE IF NOT EXISTS `chalkboard`.`chalkboard_partie` (
  `idpartie` INT NOT NULL AUTO_INCREMENT ,
  `partiedate` DATE NOT NULL ,
  `partieadv` VARCHAR(45) NOT NULL ,
  `equipe` INT NOT NULL ,
  PRIMARY KEY (`idpartie`) ,
  INDEX `fk_partie_equipe1_idx` (`equipe` ASC) ,
  CONSTRAINT `fk_partie_equipe1`
    FOREIGN KEY (`equipe` )
    REFERENCES `chalkboard`.`chalkboard_equipe` (`idequipe` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `chalkboard`.`chalkboard_alignement`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `chalkboard`.`chalkboard_alignement` ;

CREATE  TABLE IF NOT EXISTS `chalkboard`.`chalkboard_alignement` (
  `joueur` INT NOT NULL ,
  `partie` INT NOT NULL ,
  `joueurNo` INT NOT NULL ,
  PRIMARY KEY (`joueur`, `partie`) ,
  INDEX `fk_joueur_has_partie_partie1_idx` (`partie` ASC) ,
  INDEX `fk_joueur_has_partie_joueur1_idx` (`joueur` ASC) ,
  CONSTRAINT `fk_joueur_has_partie_joueur1`
    FOREIGN KEY (`joueur` )
    REFERENCES `chalkboard`.`chalkboard_joueur` (`idjoueur` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_joueur_has_partie_partie1`
    FOREIGN KEY (`partie` )
    REFERENCES `chalkboard`.`chalkboard_partie` (`idpartie` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `chalkboard`.`chalkboard_action`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `chalkboard`.`chalkboard_action` ;

CREATE  TABLE IF NOT EXISTS `chalkboard`.`chalkboard_action` (
  `idaction` INT NOT NULL ,
  `actionnom` VARCHAR(45) NOT NULL ,
  `actionacquisition` INT(1) NOT NULL ,
  `actionperte` INT(1) NOT NULL ,
  PRIMARY KEY (`idaction`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `chalkboard`.`chalkboard_event`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `chalkboard`.`chalkboard_event` ;

CREATE  TABLE IF NOT EXISTS `chalkboard`.`chalkboard_event` (
  `idevent` INT NOT NULL AUTO_INCREMENT ,
  `joueur` INT NOT NULL ,
  `action` INT NOT NULL ,
  `partie` INT NOT NULL ,
  `temps` TIME NOT NULL ,
  `debutx` FLOAT NOT NULL ,
  `debuty` FLOAT NOT NULL ,
  `finx` FLOAT NULL ,
  `finy` FLOAT NULL ,
  `cible` INT NULL ,
  `demie` TINYINT(1) NOT NULL ,
  PRIMARY KEY (`idevent`) ,
  INDEX `fk_event_joueur1_idx` (`joueur` ASC) ,
  INDEX `fk_event_action1_idx` (`action` ASC) ,
  INDEX `fk_event_partie1_idx` (`partie` ASC) ,
  INDEX `fk_event_joueur2_idx` (`cible` ASC) ,
  CONSTRAINT `fk_event_joueur1`
    FOREIGN KEY (`joueur` )
    REFERENCES `chalkboard`.`chalkboard_joueur` (`idjoueur` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_event_action1`
    FOREIGN KEY (`action` )
    REFERENCES `chalkboard`.`chalkboard_action` (`idaction` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_event_partie1`
    FOREIGN KEY (`partie` )
    REFERENCES `chalkboard`.`chalkboard_partie` (`idpartie` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_event_joueur2`
    FOREIGN KEY (`cible` )
    REFERENCES `chalkboard`.`chalkboard_joueur` (`idjoueur` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `chalkboard`.`chalkboard_shift`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `chalkboard`.`chalkboard_shift` ;

CREATE  TABLE IF NOT EXISTS `chalkboard`.`chalkboard_shift` (
  `idshift` INT NOT NULL AUTO_INCREMENT ,
  `joueur` INT NOT NULL ,
  `partie` INT NOT NULL ,
  `tempsdeb` TIME NOT NULL ,
  `tempsfin` TIME NOT NULL ,
  PRIMARY KEY (`idshift`) ,
  INDEX `fk_shift_chalkboard_alignement1_idx` (`joueur` ASC, `partie` ASC) ,
  CONSTRAINT `fk_shift_chalkboard_alignement1`
    FOREIGN KEY (`joueur` , `partie` )
    REFERENCES `chalkboard`.`chalkboard_alignement` (`joueur` , `partie` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `chalkboard`.`chalkboard_action`
-- -----------------------------------------------------
START TRANSACTION;
USE `chalkboard`;
INSERT INTO `chalkboard`.`chalkboard_action` (`idaction`, `actionnom`, `actionacquisition`, `actionperte`) VALUES (1, 'Ballon récupéré', 1, 0);
INSERT INTO `chalkboard`.`chalkboard_action` (`idaction`, `actionnom`, `actionacquisition`, `actionperte`) VALUES (2, 'Ballon conquis', 1, 0);
INSERT INTO `chalkboard`.`chalkboard_action` (`idaction`, `actionnom`, `actionacquisition`, `actionperte`) VALUES (3, 'Remise en jeu', 1, 0);
INSERT INTO `chalkboard`.`chalkboard_action` (`idaction`, `actionnom`, `actionacquisition`, `actionperte`) VALUES (4, 'Neutre', 0, 0);
INSERT INTO `chalkboard`.`chalkboard_action` (`idaction`, `actionnom`, `actionacquisition`, `actionperte`) VALUES (5, 'Dégagement', 0, 0);
INSERT INTO `chalkboard`.`chalkboard_action` (`idaction`, `actionnom`, `actionacquisition`, `actionperte`) VALUES (6, 'Perte sur passe', 0, 1);
INSERT INTO `chalkboard`.`chalkboard_action` (`idaction`, `actionnom`, `actionacquisition`, `actionperte`) VALUES (7, 'Perte technique', 0, 1);
INSERT INTO `chalkboard`.`chalkboard_action` (`idaction`, `actionnom`, `actionacquisition`, `actionperte`) VALUES (8, 'Perte sur duel', 0, 1);
INSERT INTO `chalkboard`.`chalkboard_action` (`idaction`, `actionnom`, `actionacquisition`, `actionperte`) VALUES (9, 'Perte sur remise en jeu', 0, 1);
INSERT INTO `chalkboard`.`chalkboard_action` (`idaction`, `actionnom`, `actionacquisition`, `actionperte`) VALUES (10, 'Passe', 0, 0);
INSERT INTO `chalkboard`.`chalkboard_action` (`idaction`, `actionnom`, `actionacquisition`, `actionperte`) VALUES (11, 'Passe clé', 0, 0);
INSERT INTO `chalkboard`.`chalkboard_action` (`idaction`, `actionnom`, `actionacquisition`, `actionperte`) VALUES (12, 'Passe décisive', 0, 0);
INSERT INTO `chalkboard`.`chalkboard_action` (`idaction`, `actionnom`, `actionacquisition`, `actionperte`) VALUES (13, 'Tir non-cadré', 0, 0);
INSERT INTO `chalkboard`.`chalkboard_action` (`idaction`, `actionnom`, `actionacquisition`, `actionperte`) VALUES (14, 'Tir cadré', 0, 0);
INSERT INTO `chalkboard`.`chalkboard_action` (`idaction`, `actionnom`, `actionacquisition`, `actionperte`) VALUES (15, 'But', 0, 0);
INSERT INTO `chalkboard`.`chalkboard_action` (`idaction`, `actionnom`, `actionacquisition`, `actionperte`) VALUES (16, 'Ballon reçu', 1, 0);

COMMIT;
