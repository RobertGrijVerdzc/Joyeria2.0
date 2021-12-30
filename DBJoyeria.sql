create database joyeria

use joyeria

--------------
create table config
(
IDconfig bigint identity (1,1) not null primary key,
IDempresaconfig bigint not null,
ivaconfig decimal(10,2) null,
descuentoconfig bigint not null,
pagosconfig bigint not null,
);
GO

insert into config (IDempresaconfig, ivaconfig, descuentoconfig, pagosconfig)
values(1,0.6,16.5,30)

----------
create table Empresa
(
IDempresa bigint identity (1,1) not null primary key,
Nombreempre varchar (20) not null,
Direccionempre varchar (100) not null,
Telefonoempre bigint not null,
Correoempre varchar (60) not null,
RFCempre varchar (50) not null,
IDempresaconfigem bigint not null,
constraint jy_config foreign key (IDempresaconfigem) references config (IDconfig),
);
GO


insert into Empresa(Nombreempre, Direccionempre, Telefonoempre, Correoempre, RFCempre,IDempresaconfigem)
values ('Joyeria Nog', 'Moll Nogales Sonora', '631303480', 'joyer@gmail.com', 'd54ds549751', 1)


-------------
create table puesto
(
IDpuesto bigint identity (1,1) not null primary key,
Nombrepuesto varchar(30) not null,
pagopuesto money not null
);
GO

INsert into puesto (Nombrepuesto, pagopuesto)
values ('Gerente', 3500)
INsert into puesto (Nombrepuesto, pagopuesto)
values ('Ventas', 1500)
INsert into puesto (Nombrepuesto, pagopuesto)
values ('Limpieza', 1200)


----------------------
create table Empleados
(
IDempleado bigint identity (1,1) not null primary key,
IDempleadoram bigint not null,
Nombreempl varchar(200) not null,
Contrasenaemple varchar(40) null,
Tipoemple bigint null,
Apellidoemple varchar(200) not null,
Direccionemple varchar(100) not null,
Telefonoemple bigint not null,
Correoemple varchar(30) not null unique,
RFCemple varchar(13) not null,
curpemple varchar(21) not null,
sexoemple varchar(10) not null,
Municipio varchar(50) not null,
Estadoemple varchar (50) not null,
Nacimientoemple date not null,
puestoemple bigint not null,
IDempresaemple bigint not null,
constraint jy_Emplepuesto foreign key (puestoemple) references puesto (IDpuesto),
constraint jy_Empreempl foreign key (IDempresaemple) references Empresa (IDempresa)
);
GO

----------------------
create table registrologins
(
IDregistrologin bigint identity (1,1) not null primary key,
idempleadoregistro bigint not null,
fechahora datetime not null,
constraint jy_regilogin foreign key (idempleadoregistro) references Empleados (IDempleado)
);
GO

---------
Create Table Materialesart
(
IDmaterial bigint identity(1,1) not null primary key,
NombreMaterial Varchar(100) not null,
);
GO
insert into Materialesart(NombreMaterial)
values ('Oro')
insert into Materialesart(NombreMaterial)
values ('Plata')


-----------
create table categorias
(
IDcat bigint identity (1,1) not null primary key,
Nombrecat varchar(100) not null,
);
GO

insert into categorias(Nombrecat)
values ('Aniño')
insert into categorias(Nombrecat)
values ('Cadena')
insert into categorias(Nombrecat)
values ('Collares')
insert into categorias(Nombrecat)
values ('Pulseras')
insert into categorias(Nombrecat)
values ('Aros')


---------------------------------
create table Articulos
(
IDarticulos bigint not null primary key,
NombreArt varchar(100) not null,
CategoriaArt bigint not null,
cantidadArt bigint null,
ColorArt varchar(100) null,
marcaArt varchar(100) null,
grosorArt varchar (100) null,
largoArt varchar(100) null,
PrecioArt varchar (100) null,
idmaterial bigint not null,
constraint jy_cat foreign key (CategoriaArt) references categorias (IDcat),
constraint jy_mater foreign key (idmaterial) references Materialesart (IDmaterial)
);
GO

------------------------
create table pago
(
IDpado bigint identity(1,1) not null primary key,
Subtotalpago money not null,
ivapag money not null,
totalpago money not null,
cambio money not null
);
GO

---------------------
create table Clientes
(
IDcliente bigint identity(1,1) not null primary key,
Nombreclie varchar(50) not null,
Apellidoclie varchar(50) not null,
Domicilioclien varchar(100) not null,
Numeroclie bigint not null,
Correoclie varchar(30) unique not null
);
GO

insert into Clientes(Nombreclie, Apellidoclie, Domicilioclien, Numeroclie, Correoclie)
values('Publico', 'General', 'Empresa', 6313034805, 'publico@gmail.com')

---------
create table detallarticu
(
idpagodetal bigint identity(1,1) not null primary key,
cantidadarticudetall bigint not null,
IDarticulosdetall bigint not null,
idpagodetals bigint not null
constraint jy_detallmater foreign key (IDarticulosdetall) references Articulos (IDarticulos),
constraint jt_detallpagode foreign key (idpagodetals) references pago(IDpado)
);
GO

-------------
Create table Venta
(
IDventas bigint identity (1,1) not null primary key,
IDEmpleadovent bigint not null,
IDclientevent bigint null,
IDpagoven bigint not null unique,
fecha date not null,
constraint jy_emple foreign key (IDEmpleadovent) references Empleados (IDempleado),
constraint jy_clien foreign key (IDclientevent) references Clientes (IDcliente),
constraint jy_pago foreign key (IDpagoven) references pago (IDpado),
);
GO
--------------------------------------------

create table Apartado
(
IDApartado bigint identity (1,1) not null constraint jy_Apart primary key,
IDempleadoapa bigint not null,
IDclienteapar bigint not null,
idpagoapart bigint not null,
fechainicioapart date not null,
fechafinalapart date not null,
Pago1 money not null,
Totalapart money not null,
constraint jy_empleapar foreign key (IDempleadoapa) references Empleados (IDempleado),
constraint jy_clienapar foreign key (IDclienteapar) references Clientes (IDcliente),
constraint jy_pagoapart foreign key (idpagoapart) references pago (IDpado),
);
GO
--Aqui termina
--------------------------------------------------

select * from Apartado

select IDApartado as ID, Nombreempl as Empleado, Nombreclie as Cliente,fechainicioapart as [Fecha Inicial],fechafinalapart as [Fecha a finalizar] ,Totalapart as [Saldo a Pagar], totalpago as Total from Apartado inner join detallarticu on Apartado.idpagoapart = detallarticu.idpagodetal inner join Articulos on detallarticu.IDarticulosdetall = Articulos.IDarticulos inner join pago on Apartado.idpagoapart = pago.IDpado inner join Clientes on Apartado.IDclienteapar = Clientes.IDcliente inner join Empleados on Apartado.IDempleadoapa = Empleados.IDempleado ORDER BY IDApartado asc
where fechafinalapart <= '2018-11-07'

-------------
---------
select * from Empresa
select * from config
Select * from Articulos
Select * from Empleados
Select * from Clientes
Select * from Venta
Select * from puesto
select * from Materialesart
select * from categorias
select * from Apartado
Select * from pago

update Articulos set IDarticulos = 7501055307906 where IDarticulos = 45

update Articulos set cantidadArt = cantidadArt +1 where IDarticulos = 7501055307906
 Select Nombreempl as Nombre, Contrasenaemple as Password, Nombrepuesto As Puesto, pagopuesto as CantidadPago from Empleados inner join puesto on Empleados.puestoemple = puesto.IDpuesto



 select * from config

 select * from detallarticu


 select * from Articulos where NombreArt = 'A'

select * from Empleados inner join puesto on Empleados.puestoemple = puesto.IDpuesto where Nombreempl = 'Roberto'

select IDventas as ID, Nombreempl as Empleado, Nombreclie as Cliente, totalpago as Total from Venta inner join detallarticu on Venta.IDpagoven = detallarticu.idpagodetals inner join Articulos on detallarticu.IDarticulosdetall = Articulos.IDarticulos inner join pago on Venta.IDpagoven = pago.IDpado inner join Clientes on Venta.IDclientevent = Clientes.IDcliente inner join Empleados on Venta.IDEmpleadovent = Empleados.IDempleado
 




 select * from Venta inner join pago on Venta.IDpagoven = pago.IDpado
 inner join detallarticu on pago.IDpado = detallarticu.idpagodetals where IDpado = 10


 select * from Venta inner join pago on Venta.IDpagoven = pago.IDpado inner join detallarticu on pago.IDpado = detallarticu.idpagodetals
 where IDpado = 10013

 select * from Venta

 select MAX(IDventas + 1) as ID from Venta

 select IDarticulos, NombreArt, PrecioArt from Articulos where IDarticulos = 
 1542515415151
Select PrecioArt from Articulos where IDarticulos = 1452


 select * from detallarticu where idpagodetals = 10


 select * from pago where Subtotalpago = 221 and cambio = 43.64


select IDarticulosdetall, NombreArt from detallarticu inner join pago on detallarticu.idpagodetals = pago.IDpado
inner join Articulos on detallarticu.IDarticulosdetall = Articulos.IDarticulos

select * from venta

select IDempleado, Nombreempl from Empleados

delete from registrologins

delete  from Apartado where IDApartado = 3

select *  from Venta

delete  from pago

DBCC CHECKIDENT (pago, RESEED,0)

select * from Apartado

update Apartado set fechafinalapart  = '2018-12-01' where IDApartado = 3
