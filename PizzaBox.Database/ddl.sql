-- data definition language

use PizzaStoreDb;
go

create schema Pizza; -- namespace
go

create schema Orders; -- namespace
go

create schema Users; -- namespace
go

create schema Store; -- namespace
go

-- CREATE 

create table Pizza.Crust
(
    CrustId int identity (1,1) not null,
    [Name] nvarchar(100) not null,
    Price money not null,
    constraint PK_Crust primary key (CrustId)
);

create table Pizza.Size
(
    SizeId int identity (1,1) not null,
    [Name] nvarchar(100) not null,
    Price money not null,
    constraint PK_Size primary key (SizeId)
);

create table Pizza.Topping
(
    ToppingId int identity (1,1) not null,
    [Name] nvarchar(100) not null,
    Price money not null,
    constraint PK_Topping primary key (ToppingId)
);

create table Pizza.Pizza
(
    PizzaId int identity (1,1) not null,
    CrustId int not null,
    SizeId int not null,
    [Name] nvarchar(250) not null,  
    Price money not null,
    DateModified datetime2(0) not null,
    constraint PK_Pizza primary key (PizzaId), 
    constraint FK_Crust foreign key (CrustId) references Pizza.Crust(CrustId),
    constraint FK_Size foreign key (SizeId) references Pizza.Size(SizeId)
);

create table Pizza.PizzaTopping
(
    PizzaToppingId int identity (1,1) not null,
    PizzaId int not null,
    ToppingId int not null,
    constraint PK_PizzaTopping primary key (PizzaToppingId),
    constraint FK_Topping foreign key (ToppingId) references Pizza.Topping(ToppingId),
    constraint FK_PizzaToppping foreign key (PizzaId) references Pizza.Pizza(PizzaId)

);

create table Users.Users
(
    UserId int not null identity (1,1),
    [Name] nvarchar(50) not null,
    constraint PK_User primary key (UserId)
);

create table Store.Store
(
    StoreId int not null identity (1,1),
    [Name] nvarchar(50) not null,
    constraint PK_Store primary key (StoreId)
);

create table Orders.Orders
(
    OrderId int not null identity (1,1),
    UserId int not null,
    StoreId int not null,
    Price money not null,
    OrderDate datetime2(0) not null default getdate(),
    constraint PK_Order primary key (OrderId),
    constraint FK_User foreign key (UserId) references Users.Users(UserId),
    constraint FK_Store foreign key (StoreId) references Store.Store(StoreId)
);

create table Orders.PizzaOrder
(
    PizzaOrderId int not null identity (1,1),
    PizzaId int not null,
    OrderId int not null,
    constraint PK_PizzaOrder primary key (PizzaOrderId),
    constraint FK_Pizza foreign key (PizzaId) references Pizza.Pizza(PizzaId),
    constraint FK_Order foreign key (OrderId) references Orders.Orders(OrderId)
);
go

-- END CREATE

-- ALTER

-- alter table Pizza.Pizza
-- drop FK_Crust;
-- alter table Pizza.Pizza
-- drop FK_Size;
-- alter table Pizza.PizzaTopping
-- drop FK_PizzaTopping;
-- alter table Orders.PizzaOrder
-- drop FK_Pizza;
-- alter table Orders.PizzaOrder
-- drop FK_Order;
-- alter table Orders.Orders
-- drop FK_User;
-- alter table Orders.Orders
-- drop FK_Store;

-- END ALTER

-- DROP

-- drop table Pizza.Pizza; -- tables are typically archived rather than dropped
-- drop table Pizza.Crust;
-- drop table Pizza.Size;
-- drop table Pizza.Topping;
-- drop table Pizza.PizzaTopping;
-- drop table Users.Users;
-- drop table Store.Store;
-- drop table Orders.Orders;
-- drop table Orders.PizzaOrder;
-- drop schema Pizza; -- schema are typically archived rather than dropped
-- drop database PizzaStoreDb; -- occurs in development

-- END DROP

-- TRUNCATE
    
-- truncate table Pizza.Crust;
-- truncate table Pizza.Toppings;

-- END TRUNCATE