CREATE DATABASE nomina;
USE nomina;
SET FOREIGN_KEY_CHECKS=0;
SET GLOBAL FOREIGN_KEY_CHECKS=0;

CREATE TABLE tipo_usuario (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL
);

CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    id_tipo INT,
    FOREIGN KEY (id_tipo) REFERENCES tipo_usuario(id)
);

CREATE TABLE empleados (
  ID_empleado INT AUTO_INCREMENT PRIMARY KEY,
  Nombre VARCHAR(255),
  Apellido VARCHAR(255),
  Sexo VARCHAR (100),
  Telefono VARCHAR(255),
  Direccion VARCHAR(255),
  Email VARCHAR(255),
  Departamento VARCHAR(255),
  Fecha_ingreso VARCHAR(255),
  Salario VARCHAR(50),
  Puesto_trabajo VARCHAR(255)
);

CREATE TABLE Hrs_trabajadas (
    IDHrs INT AUTO_INCREMENT PRIMARY KEY,
    IDEmpls INT ,
    NombreEmpl VARCHAR(255),
    Fecha VARCHAR(50) NOT NULL,
    HrsDiarias INT(2) NOT NULL,
    DiasLbrds INT(3) NOT NULL,
    SlrioMensual DECIMAL(10,2) NOT NULL,
	SlrioDiario DECIMAL(10,2) NOT NULL,
    HrsExtra INT(2) NOT NULL,
    SlrioExtra DECIMAL(10,2) NOT NULL,
    TtlDvngdo DECIMAL(10,2) NOT NULL,    
    FOREIGN KEY (IDEmpls) REFERENCES empleados(ID_empleado)
);

 
DROP table Hrs_trabajadas;
select * from hrs_trabajadas;