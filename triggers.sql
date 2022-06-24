drop trigger addCliente
go

CREATE TRIGGER addCliente
ON Utilizador
FOR INSERT
AS
BEGIN
	DECLARE @NIF BIGINT
	Select @NIF = NIF from inserted

	INSERT INTO Cliente (NIF, Tipo)
		VALUES (@NIF,'Cliente')
END
GO


drop trigger addFornecedor
go

CREATE TRIGGER addFornecedor
ON Utilizador
FOR INSERT
AS
BEGIN
	DECLARE @NIF BIGINT
	Select @NIF = NIF from inserted

	INSERT INTO Fornecedor (NIF, Tipo)
		VALUES (@NIF,'Fornecedor')
END
GO




drop trigger addProdOnBook
go

CREATE TRIGGER addProdOnBook
ON Produto
FOR INSERT
AS
BEGIN
	DECLARE @Ref_Book BIGINT
	Select @Ref_Book = Ref from inserted

	INSERT INTO Livro (Ref, Tipo)
		VALUES (@Ref_Book,'Livro')
END
GO



drop trigger addProdOnPacote
go

create trigger addProdOnPacote
ON Produto
FOR INSERT
AS
BEGIN
	DECLARE @Ref_Pacote BIGINT
	Select @Ref_Pacote = Ref from inserted

	INSERT INTO Pacote (Ref, Tipo)
	VALUES (@Ref_Pacote,'Pacote')

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


