Create database ASPNetADO
go
Use ASPNetADO
go 

--------Tabla habitacion 

create table Habitaciones (

Id int primary key identity (1,1) not null,
Nombre nvarchar (50) not null,
Descripcion nvarchar(100) not null
)
Insert into Habitaciones values ('Sencilla','Solo para una persona'), ('Doble','Solo para dos persona')
Select * from Habitaciones