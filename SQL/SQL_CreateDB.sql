--create database Shop
--go

use Shop
go

create table [Products](
	[Id] int not null identity(1, 1) primary key,
	[Name] nvarchar(100) not null check ([Name] <> N''),
	[Quantity] int not null check ([Quantity] >= 0),
	[Price] money not null check ([Price] > 0)
);
go

create table [Categories](
	[Id] int not null identity(1, 1) primary key,
	[Name] nvarchar(100) not null check ([Name] <> N'')
);
go

create table [ProductsCategories](
	[Id] int not null identity(1, 1) primary key,
	[ProductId] int not null,
	[CategotyId] int not null
);

alter table [ProductsCategories]
add foreign key ([ProductId]) references [Products]([Id]);
go

alter table [ProductsCategories]
add foreign key ([CategotyId]) references [Categories]([Id]);
go