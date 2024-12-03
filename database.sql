
USE master

DROP DATABASE DECORACIONES_AMBAR

CREATE DATABASE DECORACIONES_AMBAR

USE DECORACIONES_AMBAR

CREATE TABLE CIUDAD(
CIUDAD_ID INT CONSTRAINT PK_CIUDAD_ID PRIMARY KEY (CIUDAD_ID) IDENTITY (1,1),
NOMBRE VARCHAR (50) NOT NULL
)

CREATE TABLE CATEGORIA(
ID_CATEGORIA INT CONSTRAINT PK_ID_CATEGORIA PRIMARY KEY (ID_CATEGORIA) IDENTITY (1,1),
NOMBRE_CATEGORIA VARCHAR (50) NOT NULL
)

CREATE TABLE PROVEEDOR(
ID_PROVEEDOR INT CONSTRAINT PK_ID_PROVEEDOR PRIMARY KEY (ID_PROVEEDOR) IDENTITY (1,1),
NOMBRE VARCHAR (50) NOT NULL,
DIRECCION VARCHAR (50),
RNC INT NOT NULL,
TELEFONO CHAR (11) NOT NULL,
ID_CIUDAD INT CONSTRAINT FK_CIUDAD FOREIGN KEY (ID_CIUDAD) REFERENCES CIUDAD (CIUDAD_ID) 
)


CREATE TABLE EMPLEADO(
ID_EMPLEADO INT CONSTRAINT PK_ID_EMPLEADO PRIMARY KEY (ID_EMPLEADO) IDENTITY (1,1),
NOMBRE VARCHAR (50) NOT NULL,
TELEFONO CHAR (11) NOT NULL,
DIRECCION VARCHAR (50),
CEDULA CHAR(11) CONSTRAINT UQ_CEDULA_EMPLEADO UNIQUE (CEDULA) NOT NULL
)


CREATE TABLE CLIENTE(
ID_CLIENTE INT CONSTRAINT PK_ID_CLIENTE PRIMARY KEY (ID_CLIENTE) IDENTITY (1,1),
NOMBRE VARCHAR (50) NOT NULL,
CEDULA CHAR(11) CONSTRAINT UQ_CEDULA_CLIENTE UNIQUE (CEDULA) NOT NULL,
DIRECCION VARCHAR (50),
TELEFONO VARCHAR (50)
)

CREATE TABLE FACTURA(
ID_FACTURA INT CONSTRAINT PK_ID_FACTURA PRIMARY KEY (ID_FACTURA) IDENTITY (1,1),
FECHA DATETIME,
TIPO_DE_PAGO VARCHAR (30),
ID_CLIENTE INT CONSTRAINT FK_CLIENTE FOREIGN KEY (ID_CLIENTE) REFERENCES CLIENTE (ID_CLIENTE),
ID_EMPLEADO INT CONSTRAINT FK_EMPLEADO FOREIGN KEY (ID_EMPLEADO) REFERENCES EMPLEADO (ID_EMPLEADO)
)

CREATE TABLE PRODUCTO(
ID_PRODUCTO INT CONSTRAINT PK_ID_PRODUCTO PRIMARY KEY (ID_PRODUCTO) IDENTITY (1,1),
NOMBRE_PRODUCTO VARCHAR (50) NOT NULL,
PRECIO DECIMAL (10,2),
CANTIDAD INT,
ID_CATEGORIA INT CONSTRAINT FK_CATEGORIA_PRODUCTO FOREIGN KEY (ID_CATEGORIA) REFERENCES CATEGORIA(ID_CATEGORIA),
ID_PROVEEDOR INT CONSTRAINT FK_PROVEEDOR_PRODUCTO FOREIGN KEY (ID_PROVEEDOR) REFERENCES PROVEEDOR (ID_PROVEEDOR)
)

CREATE TABLE INVENTARIO (
ID_INVENTARIO INT CONSTRAINT PK_ID_INVENTARIO PRIMARY KEY (ID_INVENTARIO) IDENTITY (1,1),
ID_CATEGORIA INT CONSTRAINT FK_CATEGORIA FOREIGN KEY (ID_CATEGORIA) REFERENCES CATEGORIA (ID_CATEGORIA),
CANTIDAD INT,
ID_PRODUCTO INT CONSTRAINT FK_PRODUCTO FOREIGN KEY (ID_PRODUCTO) REFERENCES PRODUCTO(ID_PRODUCTO),
)


CREATE TABLE DETALLE_FACTURA(
ID_DETALLE_FACTURA INT CONSTRAINT PK_ID_DETALLE_FACTURA PRIMARY KEY (ID_DETALLE_FACTURA) IDENTITY (1,1),
ID_FACTURA INT CONSTRAINT FK_FACTURA_DETALLE FOREIGN KEY (ID_FACTURA) REFERENCES FACTURA(ID_FACTURA),
ID_PRODUCTO INT CONSTRAINT FK_PRODUCTO_DETALLE_FACTURA FOREIGN KEY (ID_PRODUCTO) REFERENCES PRODUCTO(ID_PRODUCTO),
CANTIDAD INT,
PRECIO_TOTAL DECIMAL(10,2),
PRECIO DECIMAL(10,2),
DESCUENTO DECIMAL(10,2)
)

CREATE TYPE DetalleFacturaType AS TABLE
(
    ID_PRODUCTO INT,
    CANTIDAD INT,
    PRECIO_TOTAL DECIMAL(10, 2),
    DESCUENTO DECIMAL(10, 2),
	PRECIO DECIMAL(10,2)
);


ALTER PROCEDURE InsertarFactura
(
@IdFactura INT,
@Id_Cliente INT,
@Tipo_De_Pago VARCHAR (30),
@Fecha DATETIME,
@Id_Empleado INT,
@Detalles AS DetalleFacturaType READONLY
)
AS
BEGIN

SET IDENTITY_INSERT FACTURA ON;

--Insertar en la factura
INSERT INTO FACTURA(ID_FACTURA,FECHA,TIPO_DE_PAGO,ID_CLIENTE,ID_EMPLEADO)
VALUES(@IdFactura,@Fecha,@Tipo_De_Pago,@Id_Cliente,@Id_Empleado);

--Insertar los detalles
DECLARE @TotalFactura DECIMAL(10, 2) = 0;

SELECT @TotalFactura = SUM(Cantidad * PRECIO)
        FROM @Detalles;

INSERT INTO DETALLE_FACTURA(ID_FACTURA,ID_PRODUCTO,CANTIDAD,PRECIO_TOTAL,DESCUENTO,PRECIO)
 SELECT @IdFactura, ID_PRODUCTO,CANTIDAD,@TotalFactura,DESCUENTO,PRECIO
	FROM @Detalles;

	SET IDENTITY_INSERT FACTURA OFF;

END;




-- Clientes 
CREATE PROCEDURE LeerClientes
AS 
BEGIN
SELECT * FROM CLIENTE
END

CREATE PROCEDURE EliminarCliente(@IdCliente INT)
AS 
BEGIN
DELETE FROM CLIENTE 
        WHERE ID_CLIENTE = @IdCliente;
END

--Categoria
INSERT INTO CATEGORIA(Nombre_Categoria)
        VALUES ('Cocina');

--Ciudad 

INSERT INTO CIUDAD(NOMBRE)
        VALUES ('Santo Domingo');

SELECT * FROM CIUDAD

--Proveedor
INSERT INTO PROVEEDOR(NOMBRE,DIRECCION,RNC,TELEFONO,ID_CIUDAD)
        VALUES ('La Nacional','27 de Febrero', 12231, '32-12312-12',1);


--Productos
CREATE PROCEDURE LeerProdcuctos
AS 
BEGIN
SELECT * FROM PRODUCTO
END

CREATE PROCEDURE EliminarProducto(@IdProducto INT)
AS 
BEGIN
DELETE FROM PRODUCTO 
        WHERE ID_PRODUCTO = @IdProducto;
END

--Ciudad
CREATE PROCEDURE LeerCiudad
AS 
BEGIN
SELECT * FROM CIUDAD
END

--Categoria
CREATE PROCEDURE LeerCategoria
AS 
BEGIN
SELECT * FROM CATEGORIA
END

--Proveedor
CREATE PROCEDURE LeerProveedor
AS 
BEGIN
SELECT * FROM PROVEEDOR
END



-- 1 Procedimiento Productos

CREATE PROCEDURE ProductosCRUD(
    @opcion INT,
    @IdProducto INT,
    @Nombre_Producto VARCHAR(30),
    @Precio DECIMAL(10,2),
    @Cantidad INT,
    @IdCategoria INT,
    @IdProveedor INT
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Opción 1: Insertar
    IF @opcion = 1
    BEGIN
        INSERT INTO Producto (Nombre_Producto, Precio, Cantidad, ID_CATEGORIA, ID_PROVEEDOR)
        VALUES (@Nombre_Producto, @Precio, @Cantidad, @IdCategoria, @IdProveedor);
    END

    -- Opción 2: Seleccionar 
    IF @opcion = 2
    BEGIN
        SELECT 
            P.ID_PRODUCTO,
            P.Nombre_Producto,
            C.NOMBRE_CATEGORIA AS Categoria,
            Pr.Nombre AS Nombre_Proveedor,
            P.Cantidad,
            P.Precio
        FROM 
            Producto P
        INNER JOIN 
            Categoria C ON C.ID_CATEGORIA = P.ID_CATEGORIA
        INNER JOIN 
            Proveedor Pr ON Pr.ID_PROVEEDOR = P.ID_PROVEEDOR;
    END

    -- Opción 3: Actualizar
    IF @opcion = 3
    BEGIN
        UPDATE Producto 
        SET 
            Nombre_Producto = @Nombre_Producto, 
            Precio = @Precio, 
            Cantidad = @Cantidad,
            ID_CATEGORIA = @IdCategoria,
            ID_PROVEEDOR = @IdProveedor
        WHERE 
            ID_PRODUCTO = @IdProducto;
    END

    -- Opción 4: Eliminar
    IF @opcion = 4
    BEGIN
        DELETE FROM Producto 
        WHERE ID_PRODUCTO = @IdProducto;
    END

END;

----- 2 Procedimiento Ciudad



CREATE PROCEDURE CiudadCRUD(
    @opcion INT,
    @IdCiudad INT,
    @Nombre VARCHAR(30)
    
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Opción 1: Insertar
    IF @opcion = 1
    BEGIN
        INSERT INTO CIUDAD(Nombre)
        VALUES (@Nombre);
    END

    -- Opción 2: Seleccionar 
    IF @opcion = 2
    BEGIN
        SELECT 
            Ciudad_ID,
            NOMBRE
        FROM 
            CIUDAD

        
    END

    -- Opción 3: Actualizar
    IF @opcion = 3
    BEGIN
        UPDATE CIUDAD 
        SET 
            Nombre = @Nombre
        WHERE 
            CIUDAD_ID = @IdCiudad;
    END

    -- Opción 4: Eliminar
    IF @opcion = 4
    BEGIN
        DELETE FROM CIUDAD 
        WHERE CIUDAD_ID = @IdCiudad;
    END

END;




-- 3  Procedimiento Proveedor



CREATE PROCEDURE ProveedorCRUD(
    @opcion INT,
	@IdProveedor INT,
    @Nombre VARCHAR(30),
	@Direccion VARCHAR(50),
    @Rnc INT,
	@Telefono char(11),
	@IdCiudad INT
    
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Opción 1: Insertar
    IF @opcion = 1
    BEGIN
        INSERT INTO PROVEEDOR(Nombre, Direccion, RNC, TELEFONO, ID_CIUDAD)
        VALUES (@Nombre,@Direccion,@Rnc,@Telefono,@IdCiudad);
    END

    -- Opción 2: Seleccionar 
    IF @opcion = 2
    BEGIN
       SELECT 
			P.Nombre,
			P.Direccion,
			P.RNC,
			P.Telefono,
			C.CIUDAD_ID 
		FROM
			PROVEEDOR P
		INNER JOIN
			CIUDAD C ON P.ID_CIUDAD = C.CIUDAD_ID;

    END

    -- Opción 3: Actualizar
    IF @opcion = 3
    BEGIN
        UPDATE PROVEEDOR 
        SET 
            Nombre = @Nombre, DIRECCION = @Direccion, RNC = @Rnc, TELEFONO = @Telefono, ID_CIUDAD = @IdCiudad
        WHERE 
            ID_PROVEEDOR = @IdProveedor;
    END

    -- Opción 4: Eliminar
    IF @opcion = 4
    BEGIN
        DELETE FROM PROVEEDOR 
        WHERE ID_PROVEEDOR = @IdProveedor;
    END

END;





-- 4  Procedimiento Categoria


CREATE PROCEDURE CategoriaCRUD(
    @opcion INT,
	@IdCategoria INT,
    @Nombre VARCHAR(30)
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Opción 1: Insertar
    IF @opcion = 1
    BEGIN
        INSERT INTO Categoria(Nombre_Categoria)
        VALUES (@Nombre);
    END

    -- Opción 2: Seleccionar 
    IF @opcion = 2
    BEGIN
       SELECT 
			ID_CATEGORIA,
			NOMBRE_CATEGORIA
		FROM
			CATEGORIA
		
    END

    -- Opción 3: Actualizar
    IF @opcion = 3
    BEGIN
        UPDATE CATEGORIA 
        SET 
            NOMBRE_CATEGORIA = @Nombre
        WHERE 
            ID_CATEGORIA = @IdCategoria;
    END

    -- Opción 4: Eliminar
    IF @opcion = 4
    BEGIN
        DELETE FROM CATEGORIA 
        WHERE ID_CATEGORIA = @IdCategoria;
    END

END;



-- 5  Procedimiento Empleado


CREATE PROCEDURE EmpleadoCRUD(
    @opcion INT,
	@IdEmpleado INT,
    @Nombre VARCHAR(30),
	@Telefono char(11),
	@Direccion varchar(50),
	@Cedula INT
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Opción 1: Insertar
    IF @opcion = 1
    BEGIN
        INSERT INTO EMPLEADO(Nombre, TELEFONO, DIRECCION, CEDULA)
        VALUES (@Nombre,@Telefono,@Direccion,@Cedula);
    END

    -- Opción 2: Seleccionar 
    IF @opcion = 2
    BEGIN
       SELECT 
			ID_EMPLEADO,
			NOMBRE,
			TELEFONO,
			DIRECCION,
			CEDULA
		FROM
			EMPLEADO
		
    END

    -- Opción 3: Actualizar
    IF @opcion = 3
    BEGIN
        UPDATE EMPLEADO 
        SET 
            NOMBRE = @Nombre, TELEFONO = @Telefono, DIRECCION = @Direccion, CEDULA = @Cedula
        WHERE 
            ID_EMPLEADO = @IdEmpleado;
    END

    -- Opción 4: Eliminar
    IF @opcion = 4
    BEGIN
        DELETE FROM EMPLEADO 
        WHERE ID_EMPLEADO = @IdEmpleado;
    END

END;



-- 6  Procedimiento Cliente


CREATE PROCEDURE ClienteCRUD(
    @opcion INT,
	@IdCliente INT,
    @Nombre VARCHAR(30),
	@Cedula VARCHAR (50),
	@Direccion varchar(50),
	@Telefono VARCHAR (50)
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Opción 1: Insertar
    IF @opcion = 1
    BEGIN
        INSERT INTO CLIENTE(Nombre, CEDULA, DIRECCION, TELEFONO)
        VALUES (@Nombre,@Cedula,@Direccion,@Telefono);
    END

    -- Opción 2: Seleccionar 
    IF @opcion = 2
    BEGIN
       SELECT 
			*
		FROM
			CLIENTE
		
    END

    -- Opción 3: Actualizar
    IF @opcion = 3
    BEGIN
        UPDATE CLIENTE 
        SET 
            NOMBRE = @Nombre,CEDULA = @Cedula,DIRECCION = @Direccion, TELEFONO = @Telefono
        WHERE 
            ID_CLIENTE = @IdCliente;
    END

    -- Opción 4: Eliminar
    IF @opcion = 4
    BEGIN
        DELETE FROM CLIENTE 
        WHERE ID_CLIENTE = @IdCliente;
    END

END;