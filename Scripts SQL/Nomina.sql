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
  id_usuario INT,
  Nombre VARCHAR(255),
  Apellido VARCHAR(255),
  Sexo VARCHAR (100),
  Telefono VARCHAR(255),
  Direccion VARCHAR(255),
  Email VARCHAR(255),
  Departamento VARCHAR(255),
  Fecha_ingreso VARCHAR(255),
  Salario VARCHAR(50),
  Puesto_trabajo VARCHAR(255),
  FOREIGN KEY (id_usuario) REFERENCES usuarios(id)
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

CREATE TABLE Permisos (
		ID_permiso INT AUTO_INCREMENT PRIMARY KEY,
		ID_usuario INT,
        Nom_usuario VARCHAR(50) NOT NULL,
        Descripcion VARCHAR(100) NOT NULL,
        FOREIGN KEY (ID_usuario) REFERENCES usuario(id)
);

CREATE TABLE Deducciones (
	ID_deduccion INT AUTO_INCREMENT PRIMARY KEY,
    IDHrs INT ,
    Total_devengado DECIMAL(10,2) NOT NULL,
    IGSS DECIMAL(10,2) NOT NULL,
    Anticipos DECIMAL(10,2) NOT NULL,
    ISR DECIMAL(10,2) NOT NULL,
    Total_deducciones DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (IDHrs) REFERENCES Hrs_trabajadas(IDHrs)
);
CREATE TABLE Planilla (
		ID_planilla INT AUTO_INCREMENT PRIMARY KEY,
        Fecha VARCHAR(50) NOT NULL,
        ID_empleado INT,
        Nombre_emp VARCHAR(50) NOT NULL,
        Apellido_emp VARCHAR(50) NOT NULL,
        Puesto_emp VARCHAR(50) NOT NULL,
        IDHrs INT, 
        DiasLab DECIMAL(10,2) NOT NULL,
        SlrioMensual DECIMAL(10,2) NOT NULL,
		SlrioExtra DECIMAL(10,2) NOT NULL,
        TtlDvngdo DECIMAL(10,2) NOT NULL, 
        Id_deduccion INT,
        TtlDeduccion DECIMAL(10,2) NOT NULL, 
		Bonificacion DECIMAL(10,2) NOT NULL,
        SlrioLiquido DECIMAL(10,2) NOT NULL, 
        FOREIGN KEY (ID_empleado) REFERENCES empleados(ID_empleado),
        FOREIGN KEY (IDHrs) REFERENCES Hrs_trabajadas(IDHrs),
		FOREIGN KEY (ID_deduccion) REFERENCES Deducciones(Id_deduccion)
);
CREATE TABLE Recibo (
		ID_recibo INT AUTO_INCREMENT PRIMARY KEY,
        Fecha VARCHAR(50) NOT NULL,
        ID_planilla INT,
        Nombre_emp VARCHAR(50) NOT NULL,
        Apellido_emp VARCHAR(50) NOT NULL,
        SlrioMensual DECIMAL(10,2) NOT NULL,
		SlrioExtra DECIMAL(10,2) NOT NULL,
        TtlDvngdo DECIMAL(10,2) NOT NULL, 
        TtlDeduccion DECIMAL(10,2) NOT NULL, 
        SlrioLiquido DECIMAL(10,2) NOT NULL, 
		FOREIGN KEY (ID_planilla) REFERENCES Planilla(ID_planilla)
);
CREATE TABLE Roles (
	ID_rol INT AUTO_INCREMENT PRIMARY KEY,
    Id_permiso INT ,
    ID_usuario INT,
	nombre VARCHAR(50) NOT NULL,
	Descripcion VARCHAR(150) NOT NULL,
    FOREIGN KEY (ID_usuario) REFERENCES usuarios(id),
    FOREIGN KEY (ID_permiso) REFERENCES Permisos(ID_permiso)
);


DROP table Roles;
select * from roles