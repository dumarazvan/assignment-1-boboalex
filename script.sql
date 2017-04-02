CREATE TABLE `a1`.`accounts` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `idnumber` VARCHAR(45) NULL,
  `type` VARCHAR(45) NULL,
  `amount` VARCHAR(45) NULL,
  `date` VARCHAR(45) NULL,
  PRIMARY KEY (`id`));

  
  CREATE TABLE `a1`.`clients` (
  `id` INT NOT NULL,
  `name` VARCHAR(45) NULL,
  `idcard` VARCHAR(45) NULL,
  `pnc` VARCHAR(45) NULL,
  `address` VARCHAR(45) NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `pnc_UNIQUE` (`pnc` ASC),
  UNIQUE INDEX `idcard_UNIQUE` (`idcard` ASC));

  
  CREATE TABLE `a1`.`users` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(45) NULL,
  `password` VARCHAR(45) NULL,
  `fullname` VARCHAR(45) NULL,
  `isadmin` VARCHAR(45) NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC));
  
  
Insert into a1.users( username ,password,fullname, isadmin ) values('root', 'root', 'system', '1');
Insert into a1.users( username ,password,fullname, isadmin ) values('admin', 'admin', 'boss', '1');
Insert into a1.users( username ,password,fullname, isadmin ) values('user', 'user', 'worker', '0');

Insert into a1.accounts( idnumber ,type,amount, date ) values('101', 'deposit', '10000', '03.01');
Insert into a1.accounts( idnumber ,type,amount, date ) values('102', 'closed', '10', '07.02');
Insert into a1.accounts( idnumber ,type,amount, date ) values('103', 'temporary', '500', '15.03');

Insert into a1.clients( name ,idcard,pnc, address ) values('Frodo', '4492', '1001', 'Bucuresti 28');
Insert into a1.clients( name ,idcard,pnc, address ) values('Andone', '1187', '1002', 'Buftea 01');
Insert into a1.clients( name ,idcard,pnc, address ) values('Constantin', '8322', '1003', 'Unirii 14');
  
  
