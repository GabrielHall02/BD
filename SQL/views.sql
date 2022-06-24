
drop view inventario
go
create view inventario
as
SELECT Ref, Titulo, Price, Editora.Nome AS Editora, Autor.Nome AS Autor, Stock
FROM Produto JOIN Editora ON ID_Editora = Editora.Identificador JOIN Autor ON ID_Autor = Autor.Identificador
