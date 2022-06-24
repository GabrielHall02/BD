drop procedure insert_editora;
go

Create procedure insert_editora @Name varchar(25)
as

Insert into Editora (Nome) Values (@Name)

go



drop procedure delete_editora
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


drop procedure delete_autor
go

Create procedure delete_autor @Name varchar(25)
as 
Declare @ID INT
SELECT @ID = Identificador From Autor WHERE Nome = @Name
Delete from Autor where Nome = @Name

go