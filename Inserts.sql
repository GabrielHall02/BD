INSERT INTO Editora (Nome)
VALUES ('Bruaa'),('Planeta Tangerina'),('Leya'),('Orfeu Negro')
select * from Editora


INSERT INTO Autor (Nome)
VALUES ('Ines Machado'),('Miguel Gouveia'),('Joao Fazeda'),('Henrique Moreria'),('Ana Pessoa'),
('Madalena Matoso'),('Joana Estrela'),('Joaquim Agil'),('Manuel Afonso')
select * from Autor


insert into Produto (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo)
values(978923658,'Urso Castanho',10.50,6,1,3,1)
insert into Produto (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo)
VALUES(935718148,'Joaninha Resmungona',15,6,2,1,1)
insert into Produto (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo)
VALUES(973258628,'P de Pai',12.5,6,3,9,1)
insert into Produto (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo)
VALUES(986203811,'Capitao Rosalie',9.90,6,4,2,1)
insert into Produto (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo)
VALUES (978936481,'Polo Norte',18.5,6,1,4,1)
insert into Produto (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo)
VALUES(978483761,'A Toupeira',11.50,6,4,5,1)
insert into Produto (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo)
VALUES(978483987,'Mundo no Chao',6.5,6,2,6,1)
insert into Produto (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo)
VALUES(978930031,'A Vinganca do Galo',6.5,6,2,7,1)
insert into Produto (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo)
VALUES(978907285,'Homem da Lua',6.5,6,2,8,1)
select * from Produto

INSERT INTO Utilizador
VALUES (84920494, 'Gigoes', 'Rua Leitao 30',2 ),(151333450,'Anantes','Rua Dr. Nascimento 10',2),
(185917583,'Manuela Silva',Null,1),(24206944,'Joao Feliz','Rua Lebre 20',1),(102947563,'Jose Alberto',Null,1);


INSERT into Documento (Tipo, Data, NIF)
Values(2,'2022/06/01',84920494),(1,'2022/06/07',185917583),(1,'2022/06/07',102947563),
(2,'2022/06/02',151333450)


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


