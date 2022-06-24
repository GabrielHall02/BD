-- CREATE DATABASE Livraria;
 

drop table Produto
CREATE TABLE Produto (
	Ref BIGINT Not null,
	Tipo INT,
	Tipo_Nome VARCHAR(7) NOT NULL

	primary key (Ref),
	foreign key (Ref) references Livro(Ref)
);



drop table Editora
CREATE TABLE Editora(
	Identificador INT PRIMARY KEY,
	Nome VARCHAR(25) NOT NULL,
);


-- INSERT INTO Editora
-- VALUES (1, 'Bruaa'),(2,'Planeta Tangerina'),(3,'Leya'),(4,'Orfeu Negro')

Drop table autor
CREATE TABLE Autor(
	Identificador INT PRIMARY KEY,
	Nome VARCHAR(25) NOT NULL,
);


/*
alter table Livro
drop constraint FK__Livro__ID_Editor__4222D4EF

alter table Documento
drop PK__Document__F2374EB18B4E1980

alter table Documento
drop column Identificador

alter table Documento
add Identificador int identity(1,1) primary key;

alter table Livro
add foreign key (ID_Editora)
references Editora(Identificador)

*/


--INSERT INTO Autor
--VALUES (1, 'Ines Machado'),(2,'Miguel Gouveia'),(3,'Joao Fazeda'),(4,'Henrique Moreria'),(5,'Ana Pessoa'),
--(6,'Madalena Matoso'),(7,'Joana Estrela'),(8,'Joaquim Agil'),(9,'Manuel Afonso')


Drop table Cliente
CREATE TABLE Cliente(
	NIF INT PRIMARY KEY,
	Nome VARCHAR(15) NOT NULL,
	Endereco VARCHAR(25),
);


--INSERT INTO Cliente
--VALUES

Drop table Utilizador
CREATE TABLE Utilizador(
	NIF INT PRIMARY KEY,
	Nome VARCHAR(15) NOT NULL,
	Endereco VARCHAR(25),
	Tipo INT NOt NULL, -- 1 -> Cliente; 2 -> Fornecedor
);


INSERT INTO Utilizador
VALUES (84920494, 'Gigoes', 'Rua Leitao 30',2 ),(151333450,'Anantes','Rua Dr. Nascimento 10',2),
(185917583,'Manuela Silva',Null,1),(24206944,'Joao Feliz','Rua Lebre 20',1),(102947563,'Jose Alberto',Null,1);


Drop table Documento


CREATE TABLE Documento(
	Identificador INT PRIMARY KEY Identity(1,1),
	Tipo INT NOT NULL, -- 1 -> Venda; -- 2 -> Compra 
	Data Date Not null,
	NIF INT, -- FK
);


select * from Documento

INSERT into Documento (Tipo, Data, NIF)
Values(2,'2022/06/01',84920494),(1,'2022/06/07',185917583),(1,'2022/06/07',102947563),
(2,'2022/06/02',151333450)

Drop table Livro
CREATE TABLE Livro(
	Ref BIGINT primary key,
	Titulo varchar(30),
	Price numeric Not Null,
	Iva INT NOt null default 6,
	ID_Editora INT Not Null, --FK
	ID_Autor INT, --FK
	Tipo_Produto INT not null,
	Stock INT Not null default 0,
);




truncate table Produto
truncate table Pacote
truncate table livro

insert into Livro (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo_Produto)
values(978923658,'Urso Castanho',10.50,6,1,3,1)
insert into Livro (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo_Produto)
VALUES(935718148,'Joaninha Resmungona',15,6,2,1,1)
insert into Livro (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo_Produto)
VALUES(973258628,'P de Pai',12.5,6,3,9,1)
insert into Livro (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo_Produto)
VALUES(986203811,'Capitao Rosalie',9.90,6,4,2,1)
insert into Livro (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo_Produto)
VALUES (978936481,'Polo Norte',18.5,6,1,4,1)
insert into Livro (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo_Produto)
VALUES(978483761,'A Toupeira',11.50,6,4,5,1)
insert into Livro (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo_Produto)
VALUES(978483987,'Mundo no Chao',6.5,6,2,6,1)
insert into Livro (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo_Produto)
VALUES(978930031,'A Vinganca do Galo',6.5,6,2,7,1)
insert into Livro (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo_Produto)
VALUES(978907285,'Homem da Lua',6.5,6,2,8,1)

select * from Livro

Drop table Pacote
Create table Pacote(
	Ref INT NOT NULL,
	Nome varchar(30) Not null,
	Ref_livro BIGINT Not null, --FK
	Tipo_Produto INT NOT NULL DEFAULT 2,

	Constraint ID PRIMARY KEY (Ref, Ref_Livro)

);


Insert into Pacote (Ref,Nome,Ref_livro) 
Values (5681934,'Bag of Books','978483987')
Insert into Pacote (Ref,Nome,Ref_livro) 
Values(5681934,'Bag of Books','978930031')
Insert into Pacote (Ref,Nome,Ref_livro) 
Values(5681934,'Bag of Books','978907285')


delete from Pacote where Nome = 'Bag of Books'

Drop table Linha_Fatura
create table Linha_Fatura(
	n_linha INT default 999,
	ID_Fac INT, --FK
	Ref_Item INT not null, --FK
	Price numeric not null,
	Desconto int,
	Quantity int not null,
	Primary key (n_linha, ID_Fac)
);

drop table Linha_Fatura


select * from Linha_Fatura
truncate table Linha_Fatura

Insert into Linha_Fatura (ID_Fac,Ref_Item,Price,Desconto,Quantity)
Values(1,978483987,6.5, 30, 5);
Insert into Linha_Fatura (ID_Fac,Ref_Item,Price,Desconto,Quantity)
Values(1,978930031,6.5, 30, 10)
Insert into Linha_Fatura (ID_Fac,Ref_Item,Price,Desconto,Quantity)
Values(1,978907285,6.5, 30, 5)

Insert into Linha_Fatura (ID_Fac,Ref_Item,Price,Desconto,Quantity)
Values(2,978483987,6.5, 0, 1)
Insert into Linha_Fatura (ID_Fac,Ref_Item,Price,Desconto,Quantity)
Values(2,978930031,6.5, 0, 2)

Insert into Linha_Fatura (ID_Fac,Ref_Item,Price,Desconto,Quantity)
Values(3,978483987,6.5, 0, 3)
Insert into Linha_Fatura (ID_Fac,Ref_Item,Price,Desconto,Quantity)
Values(3,978930031,6.5, 0, 2)
Insert into Linha_Fatura (ID_Fac,Ref_Item,Price,Desconto,Quantity)
Values(3,978930031,6.5, 0, 4)
Insert into Linha_Fatura (ID_Fac,Ref_Item,Price,Desconto,Quantity)
Values(4,978923658,10.5, 30, 5)
Insert into Linha_Fatura (ID_Fac,Ref_Item,Price,Desconto,Quantity)
Values(4,935718148,15, 30, 5)
Insert into Linha_Fatura (ID_Fac,Ref_Item,Price,Desconto,Quantity)
Values(4,973258628,12.5, 30, 5)
Insert into Linha_Fatura (ID_Fac,Ref_Item,Price,Desconto,Quantity)
Values(4,986203811,9.90, 30, 5)

select * from Livro
select * from Produto



alter table Documento
add constraint NIF foreign key (NIF) references Utilizador(NIF);



alter table Livro
add foreign key (ID_Editora) references Editora(Identificador),
	foreign key (ID_Autor) references Autor(Identificador)



/*
alter table Pacote
	add foreign key (Ref_livro) references Livro(Ref);
*/



alter table Linha_Fatura
	add foreign key (ID_Fac) references Documento(Identificador)
alter table Linha_Fatura
	add foreign key (Ref_Item) references Produto(Ref)

drop table Historico_vendas
create table Historico_vendas
(
	Ref_Produto BIGINT,
	Qt INT,
	Desconto INT,
	Data_Venda DATETIME
)
GO

select * from Historico_vendas
truncate table Historico_vendas
drop table Historico_vendas

CREATE TRIGGER addProdOnBook
ON Livro
FOR INSERT
AS
BEGIN
	DECLARE @Ref_Book BIGINT
	Select @Ref_Book = Ref from inserted

	INSERT INTO Produto (Ref, Tipo, Tipo_Nome)
		VALUES (@Ref_Book,1,'Livro')
END
GO



create trigger addProdOnPacote
ON Pacote
FOR INSERT
AS
BEGIN
	DECLARE @Ref_Pacote BIGINT
	Select @Ref_Pacote = Ref from inserted

	IF NOT EXISTS (SELECT * from Produto where Ref = @Ref_Pacote)
	Begin
	INSERT INTO Produto (Ref, Tipo, Tipo_Nome)
		VALUES (@Ref_Pacote,2,'Pacote')
	END
END
GO

drop trigger trg_updateStocks

create trigger trg_updateStocks
ON Linha_Fatura
FOR INSERT 
AS 
BEGIN

	DECLARE @ID_Fac INT,  @Qt INT, @Ref BIGINT, @Doc_type INT, @Prod_type INT, @data DATETIME, @Desc INT

	SELECT @ID_Fac = ID_Fac, @Qt = Quantity, @Ref = Ref_Item, @Desc = Desconto from inserted

	SELECT @data = Documento.Data, @Doc_type = AVG(Documento.Tipo) from Linha_Fatura JOIN Documento ON ID_Fac = Identificador 
	where Identificador = @ID_Fac 
	GROUP BY Documento.Data

	SELECT @Prod_type = Produto.Tipo from Linha_Fatura join Produto on Ref_Item = Ref WHERE Ref = @Ref

	IF (@Doc_type = 1)
	BEGIN
		IF (@Prod_type = 1)
		BEGIN
			Update Livro
				SET Stock = Stock - @Qt
				where ref = @Ref

			Insert into Historico_vendas (Ref_Produto, Qt, Desconto, Data_Venda)
			VALUES (@Ref, @Qt, @Desc, @data)
		END
		IF (@Prod_type = 2)
		BEGIN
			Declare @Ref_Livro BIGINT
			select @Ref_Livro = Ref_livro from Pacote Join Produto on Pacote.Ref = Produto.Ref
			Update Livro
				SET Stock = Stock - @Qt
				where ref = @Ref_Livro

			Insert into Historico_vendas (Ref_Produto, Qt, Data_Venda)
		VALUES (@Ref, @Qt, @data)

		END
	END


	IF (@Doc_type = 2)
	BEGIN
		IF (@Prod_type = 1)
		BEGIN
			Update Livro
				SET Stock = Stock + @Qt
				where ref = @Ref
		END
	END

END
GO

drop trigger update_line

create trigger update_Line
ON Linha_Fatura
FOR INSERT 
AS 
BEGIN
	--check if doc exists
	declare @ID_Fac INT

	select @ID_Fac = ID_Fac from inserted


	if exists(select Identificador from Documento where Identificador =  @ID_Fac)
	Begin
		--get lines from doc
		--if exists(select n_linha from Linha_Fatura where ID_Fac =  @ID_Fac)
		--begin
			declare @num INT
			select @num = count(n_linha) from Linha_Fatura where ID_Fac =  @ID_Fac
			update Linha_Fatura set n_linha = @num where n_linha = 999

		--end
	end
END



--UDF


Create function get_Price(@Ref BIGINT)
Returns numeric
as
begin
return
(
Select Price from Produto where Ref = @Ref 
)
end

select dbo.get_Price(978483987) as Price

Create function get_ProdType(@Ref BIGINT)
Returns INT
as
begin
return
(
Select Tipo from Produto where Ref = @Ref 
)
end

select dbo.get_ProdType(978483987) as Type

Create function get_LastDoc()
Returns INT
as
begin
return
(
Select MAX(Identificador) from Documento 
)
end


Create function get_Faturacao()
Returns INT
as
begin
return
(	
SELECT SUM(Price*Qt*(100-Desconto)/100) AS Total  FROM Historico_vendas JOIN Produto on Historico_vendas.Ref_Produto = Produto.Ref 
)
end

drop function get_Faturacao




select dbo.get_Faturacao() as Total


select * from Produto

select * from Livro

select * from Documento
select * from Linha_Fatura

SELECT Documento.Data, AVG(Documento.Tipo) AS DOC_TYPE from Linha_Fatura JOIN Documento ON ID_Fac = Identificador where Identificador = 2 group by Data
SELECT Produto.Tipo from Linha_Fatura join Produto on Ref_Item = Ref WHERE Ref = 978483987


SELECT Identificador From Autor WHERE Nome = 'abccc'
go




--PROCEDURES




drop procedure insert_editora;
go

Create procedure insert_editora @Name varchar(25)
as

Insert into Editora (Nome) Values (@Name)

go

exec insert_editora @Name = 'testing'
go

Create procedure delete_editora @Name varchar(25)
as 
Declare @ID INT
SELECT @ID = Identificador From Editora WHERE Nome = @Name
Delete from Editora where Nome = @Name

go

drop procedure insert_autor;
go

Create procedure insert_autor @Name varchar(25)
as

Insert into Autor (Nome) Values (@Name)

go

exec insert_editora @Name = 'testing'
go

Create procedure delete_autor @Name varchar(25)
as 
Declare @ID INT
SELECT @ID = Identificador From Autor WHERE Nome = @Name
Delete from Autor where Nome = @Name

go



--Views




create view inventario
as
SELECT Ref, Titulo, Price, Editora.Nome AS Editora, Autor.Nome AS Autor, Stock
FROM Livro JOIN Editora ON ID_Editora = Editora.Identificador JOIN Autor ON ID_Autor = Autor.Identificador


