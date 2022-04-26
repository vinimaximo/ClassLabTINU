-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema comercialdb0191
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema comercialdb0191
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `comercialdb0191` DEFAULT CHARACTER SET utf8 ;
USE `comercialdb0191` ;

-- -----------------------------------------------------
-- Table `comercialdb0191`.`clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`clientes` (
  `idcli` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(60) NOT NULL,
  `cpf` CHAR(11) NOT NULL,
  `email` VARCHAR(60) NOT NULL,
  `datacad` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP(),
  `ativo` BIT(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`idcli`),
  UNIQUE INDEX `cpf_UNIQUE` (`cpf` ASC) ,
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) )
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`usuarios` (
  `iduser` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(60) NOT NULL,
  `email` VARCHAR(60) NOT NULL,
  `senha` VARCHAR(32) NOT NULL,
  `nivel` VARCHAR(15) NOT NULL DEFAULT 'A',
  `ativo` BIT(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`iduser`),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`pedidos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`pedidos` (
  `idped` INT(11) NOT NULL AUTO_INCREMENT,
  `data` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP(),
  `status_ped` VARCHAR(15) NOT NULL DEFAULT 'A',
  `desconto` DECIMAL(10,2) NOT NULL,
  `idcli_ped` INT(11) NOT NULL,
  `iduser_ped` INT(11) NOT NULL,
  PRIMARY KEY (`idped`),
  INDEX `fk_Pedidos_Clientes_idx` (`idcli_ped` ASC) ,
  INDEX `fk_Pedidos_Usuarios1_idx` (`iduser_ped` ASC) ,
  CONSTRAINT `fk_Pedidos_Clientes`
    FOREIGN KEY (`idcli_ped`)
    REFERENCES `comercialdb0191`.`clientes` (`idcli`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Pedidos_Usuarios1`
    FOREIGN KEY (`iduser_ped`)
    REFERENCES `comercialdb0191`.`usuarios` (`iduser`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`produtos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`produtos` (
  `idprod` INT(11) NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(100) NOT NULL,
  `unidade` VARCHAR(14) NOT NULL,
  `codbar` CHAR(13) NOT NULL,
  `valor` DECIMAL(10,2) NOT NULL,
  `desconto` DECIMAL(10,2) NOT NULL,
  PRIMARY KEY (`idprod`),
  UNIQUE INDEX `codbar_UNIQUE` (`codbar` ASC) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`itempedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`itempedido` (
  `idped_ip` INT(11) NOT NULL,
  `idprod_ip` INT(11) NOT NULL,
  `valor` DECIMAL(10,2) NOT NULL,
  `quantidade` DECIMAL(10,2) NOT NULL,
  `desconto` DECIMAL(10,2) NOT NULL,
  INDEX `fk_ItemPedido_Pedidos1_idx` (`idped_ip` ASC) ,
  INDEX `fk_ItemPedido_Produtos1_idx` (`idprod_ip` ASC) ,
  CONSTRAINT `fk_ItemPedido_Pedidos1`
    FOREIGN KEY (`idped_ip`)
    REFERENCES `comercialdb0191`.`pedidos` (`idped`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ItemPedido_Produtos1`
    FOREIGN KEY (`idprod_ip`)
    REFERENCES `comercialdb0191`.`produtos` (`idprod`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`caixas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`caixas` (
  `idcx` INT NOT NULL AUTO_INCREMENT,
  `data_abertura` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  `saldo` DECIMAL(10,2) NOT NULL,
  `status_caixa` VARCHAR(32) NOT NULL,
  `iduser_cx` INT(11) NOT NULL,
  PRIMARY KEY (`idcx`),
  INDEX `fk_caixas_usuarios1_idx` (`iduser_cx` ASC) ,
  CONSTRAINT `fk_caixas_usuarios1`
    FOREIGN KEY (`iduser_cx`)
    REFERENCES `comercialdb0191`.`usuarios` (`iduser`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`vendas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`vendas` (
  `idvnd` INT NOT NULL AUTO_INCREMENT,
  `data_vnd` TIMESTAMP NOT NULL DEFAULT current_timestamp,
  `status_vnd` VARCHAR(15) NOT NULL DEFAULT 'A',
  `desconto` DECIMAL(10,2) NOT NULL,
  `idcx_vnd` INT NOT NULL,
  `idped_vnd` INT(11) NOT NULL,
  PRIMARY KEY (`idvnd`),
  INDEX `fk_vendas_caixas1_idx` (`idcx_vnd` ASC) ,
  INDEX `fk_vendas_pedidos1_idx` (`idped_vnd` ASC) ,
  CONSTRAINT `fk_vendas_caixas1`
    FOREIGN KEY (`idcx_vnd`)
    REFERENCES `comercialdb0191`.`caixas` (`idcx`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_vendas_pedidos1`
    FOREIGN KEY (`idped_vnd`)
    REFERENCES `comercialdb0191`.`pedidos` (`idped`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`tipos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`tipos` (
  `idtipo` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(20) NOT NULL,
  `sigla` VARCHAR(10) NOT NULL,
  PRIMARY KEY (`idtipo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `comercialdb0191`.`pagamentos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `comercialdb0191`.`pagamentos` (
  `idpag` INT NOT NULL AUTO_INCREMENT,
  `valor` DECIMAL(10,2) NOT NULL,
  `idvnd_pag` INT NOT NULL,
  `idtipo_pag` INT NOT NULL,
  PRIMARY KEY (`idpag`),
  INDEX `fk_pagamentos_vendas1_idx` (`idvnd_pag` ASC) ,
  INDEX `fk_pagamentos_tipos1_idx` (`idtipo_pag` ASC) ,
  CONSTRAINT `fk_pagamentos_vendas1`
    FOREIGN KEY (`idvnd_pag`)
    REFERENCES `comercialdb0191`.`vendas` (`idvnd`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_pagamentos_tipos1`
    FOREIGN KEY (`idtipo_pag`)
    REFERENCES `comercialdb0191`.`tipos` (`idtipo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
-- Criação de Procedures


