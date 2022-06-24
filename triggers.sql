drop trigger addUserTyoe
go

CREATE TRIGGER addUserTyoe
ON Utilizador
FOR INSERT
AS
BEGIN
	DECLARE @NIF BIGINT, @Tipo INT
	Select @NIF = NIF, @Tipo = Tipo from inserted
	IF (@Tipo = 1)
	Begin
	INSERT INTO Cliente (NIF, Tipo)
		VALUES (@NIF,'Cliente')
	END

	IF (@Tipo = 2)
	Begin
	INSERT INTO Fornecedor (NIF, Tipo)
		VALUES (@NIF,'Fornecedor')
	END

END
GO



drop trigger addProdType
go
CREATE TRIGGER addProdType
ON Produto
FOR INSERT
AS
BEGIN
	DECLARE @Ref BIGINT, @Tipo INT
	Select @Ref = Ref, @Tipo = Tipo from inserted
	IF (@Tipo = 1)
	Begin
		INSERT INTO Livro (Ref, Tipo)
			VALUES (@Ref,'Livro')
	End
	IF (@Tipo = 2)
	Begin
		INSERT INTO Pacote (Ref, Tipo)
		VALUES (@Ref,'Pacote')
	End
END
GO



drop trigger trg_updateStocks
go
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
			Update Produto
				SET Stock = Stock - @Qt
				where ref = @Ref

			Insert into Historico_vendas (Ref_Produto, Qt, Desconto, Data_Venda)
			VALUES (@Ref, @Qt, @Desc, @data)
		END
	END


	IF (@Doc_type = 2)
	BEGIN
		IF (@Prod_type = 1)
		BEGIN
			Update Produto
				SET Stock = Stock + @Qt
				where ref = @Ref
		END
	END

END
GO



drop trigger update_line
go
create trigger dbo.update_Line
ON dbo.Linha_Fatura
FOR INSERT 
AS 
BEGIN

	declare @ID_Fac INT

	select @ID_Fac = ID_Fac from inserted

	--check if doc exists
	--if exists(select Identificador from Documento where Identificador =  @ID_Fac)
	--Begin
		--get lines from doc

		declare @num INT
		select @num = count(n_linha) from dbo.Linha_Fatura where ID_Fac =  @ID_Fac
		update dbo.Linha_Fatura set n_linha = @num, ID_Fac = @ID_Fac where n_linha = 999
	--end
END
go





