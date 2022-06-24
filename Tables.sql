

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
	foreign key (ID_Editora) references Editora(Identificador),
	foreign key (ID_Autor) references Autor(Identificador)
);



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
	Ref_Item BIGINT not null, --FK
	Price numeric not null,
	Desconto int,
	Quantity int not null,
	Primary key (n_linha, ID_Fac),

	foreign key (ID_Fac) references Documento(Identificador),
	foreign key (Ref_Item) references Produto(Ref)
);



drop table Historico_vendas
create table Historico_vendas
(
	Ref_Produto BIGINT,
	Qt INT,
	Desconto INT,
	Data_Venda DATETIME,
	foreign key (Ref_Produto) references Produto(Ref)
	
);
