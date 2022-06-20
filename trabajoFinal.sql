Create database LPFinal
use LPFinal
create table Producto(
id			int not null primary key identity,
Nombre		varchar(20),
Material	int,
Personal	int,
Impuestos	int,
Transporte	int,
Suspendido	bit
)

select * from Producto

create table Costos(
id				int not null primary key identity,
material		int,
personal		int,
impuestos		int,
transporte		int,
Suspendido		bit
)

select * from Costos

create table Pedidos(
idPedido			int not null primary key identity,
NombrePedido		varchar(30) not null,
Fecha				date,
Total				money,
idcostos			int,
)
create table DetallePedidos(
idPedido			int not null,
idProducto			int not null,
PrecioUnidad		money,
Cantidad			int,
Importe				money
)

drop table Producto
drop table Costos
drop table Pedidos
drop table DetallePedidos

select * from Pedidos

alter table DetallePedidos
add constraint fk_pedido
FOREIGN KEY(idPedido) REFERENCES Pedidos (idPedido)

alter table DetallePedidos
add constraint fk_producto
FOREIGN KEY(idProducto) REFERENCES Producto (id)

alter table Pedidos
add constraint fk_costos 
FOREIGN KEY(idcostos) REFERENCES Costos (id)


select * from Producto
select * from Costos
select * from Pedidos
select * from DetallePedidos
select * from DetallePedidos where idPedido = 1

--- Productos ---
Insert into Producto (Nombre,Material,Personal,Impuestos,Transporte,Suspendido) values('Sedan','7','10','5','2','0')
Insert into Producto (Nombre,Material,Personal,Impuestos,Transporte,Suspendido) values('Camioneta','8','9','3','3','0')
Insert into Producto (Nombre,Material,Personal,Impuestos,Transporte,Suspendido) values('Economico','5','7','2','1','0')

--- Costos ---
Insert into Costos (material,personal,impuestos,transporte,Suspendido) values('5','15','7','2','0')
Insert into Costos (material,personal,impuestos,transporte,Suspendido) values('8','12','3','5','0')
