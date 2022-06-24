

drop table Editora
CREATE TABLE Editora(
	Identificador INT PRIMARY KEY Identity(1,1),
	Nome VARCHAR(25) NOT NULL,
);



Drop table Autor
CREATE TABLE Autor(
	Identificador INT PRIMARY KEY Identity(1,1),
	Nome VARCHAR(25) NOT NULL,
);



Drop table Utilizador
CREATE TABLE Utilizador(
	NIF INT PRIMARY KEY,
	Nome VARCHAR(15) NOT NULL,
	Endereco VARCHAR(25),
	Tipo INT NOt NULL, -- 1 -> Cliente; 2 -> Fornecedor
	
);



Drop Table Cliente
Create Table Cliente (
	NIF INT PRIMARY KEY,
	Tipo varchar(7) default('Cliente'),

	foreign key (NIF) references Utilizador(NIF)
)



Drop Table Fornecedor
Create Table Fornecedor (
	NIF INT PRIMARY KEY,
	Tipo varchar(10) default('Fornecedor'),

	foreign key (NIF) references Utilizador(NIF)
)



drop table Produto
CREATE TABLE Produto (
	Ref BIGINT Not null,
	Titulo varchar(30),
	Price numeric Not Null,
	Iva INT NOt null default 6,
	ID_Editora INT, --FK
	ID_Autor INT, --FK
	Tipo INT not null,
	Stock INT Not null default 0,

	primary key (Ref),
	foreign key (ID_Editora) references Editora(Identificador) ON DELETE SET NULL,
	foreign key (ID_Autor) references Autor(Identificador) ON DELETE SET NULL
);


Drop table Livro
Create table Livro (
	Ref BIGINT Primary key,
	Tipo varchar(5) default('Livro'),

	foreign key (Ref) references Produto(Ref) ON DELETE CASCADE
);



drop table Pacote
Create Table Pacote (
	Ref BIGINT Primary key,
	Tipo varchar(6) default('Pacote'),

	foreign key (Ref) references Produto(Ref) ON DELETE CASCADE
)



Drop table Documento
CREATE TABLE Documento(
	Identificador INT PRIMARY KEY Identity(1,1),
	Tipo INT NOT NULL, -- 1 -> Venda; -- 2 -> Compra 
	Data Date Not null,
	NIF INT, -- FK

	foreign key (NIF) references Utilizador(NIF)
);



Drop table Linha_Fatura
create table Linha_Fatura(
	n_linha INT default 999,
	ID_Fac INT, --FK
	Ref_Item BIGINT, --FK
	Price numeric not null,
	Desconto int,
	Quantity int not null,

	Primary key (n_linha, ID_Fac),

	foreign key (ID_Fac) references Documento(Identificador),
	foreign key (Ref_Item) references Produto(Ref) ON DELETE SET NULL
);



drop table Historico_vendas
create table Historico_vendas
(
	Ref_Produto BIGINT,
	Qt INT,
	Desconto INT,
	Data_Venda DATETIME,
	foreign key (Ref_Produto) references Produto(Ref) ON DELETE SET NULL
	
);


