create database parcial2;
use parcial2;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultaGenClientes` ()  BEGIN
	select idCliente as ID, nombre, apellido, telefono from cliente; 
END$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `consultaGenFactura` ()  BEGIN
	select idFactura as ID, idCliente, nombre_facturacion, fecha, descripcion, monto from factura; 
END$$



CREATE DEFINER=`root`@`localhost` PROCEDURE `ingClientes` (IN `idCliente` VARCHAR(10), IN `nombre` VARCHAR(35), IN `apellido` VARCHAR(35), IN `telefono` VARCHAR(35))  BEGIN
	insert into cliente (idCliente, nombre, apellido, telefono) values (idCliente, nombre, apellido, telefono);
END$$


CREATE DEFINER=`root`@`localhost` PROCEDURE `ingFacturas` (IN `idFactura` VARCHAR(20), IN `idCliente` VARCHAR(10), IN `nombre_facturacion` VARCHAR(45), IN `fecha` VARCHAR(45), IN `descripcion` VARCHAR(100), IN `monto` VARCHAR(100))  BEGIN
	insert into factura (idFactura, idCliente, nombre_facturacion, fecha,descripcion,monto) values (idFactura, idCliente, nombre_facturacion, fecha, descripcion,monto);
END$$

DELIMITER ;


create table cliente(
	idCliente varchar(10) not null primary key,
    nombre varchar(35) not null,
    apellido varchar (35) not null,
    telefono varchar (35)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE factura(
  idFactura varchar(20) not null primary key,
  idCliente varchar(10) not null,
  nombre_facturacion varchar(45) not null,
  fecha varchar(45),
  descripcion varchar(100) not null,
  monto  varchar(100) not null,
  foreign key (idCliente) references cliente(idCliente)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE compras(
  idCompras varchar(20) not null primary key,
  idFactura varchar(10) not null,
  fecha varchar(45),
  detalle  varchar(100) not null,
  monto float not null,
  foreign key (idFactura) references factura(idFactura)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE cuentasporcobrar(
  idCuentas varchar(20) not null primary key,
  idCompras varchar(10) not null,
  nombre_compra varchar(45) not null,
  fecha varchar(45),
  descripcion varchar(100) not null,
  monto float not null,
  foreign key (idCompras) references compras(idCompras)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;





insert into cliente values ('1','Melissa','Aldana','25456648'), ('2','Mercedes','Flores','2548748'),  ('3','Daniel','Mejia','25248791');
insert into factura values ('0','1','Melissa Aldana','2021-09-28','por compra',450.00),
('1','2','Mercedes Flores','2021-09-28','por compra',850.00),
('2','3','Daniel Mejia','2021-09-28','por compra',1050.00);

select * from factura;