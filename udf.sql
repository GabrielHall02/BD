
drop function get_Price
go
Create function get_Price(@Ref BIGINT)
Returns numeric
as
begin
return
(
Select Price from Produto where Ref = @Ref 
)
end
go


drop function get_ProdType
go
Create function get_ProdType(@Ref BIGINT)
Returns INT
as
begin
return
(
Select Tipo from Produto where Ref = @Ref 
)
end
go


drop function get_LastDoc
go
Create function get_LastDoc()
Returns INT
as
begin
return
(
Select MAX(Identificador) from Documento 
)
end
go


drop function get_Faturacao
go
Create function get_Faturacao()
Returns INT
as
begin
return
(	
SELECT SUM(Price*Qt*(100-Desconto)/100) AS Total FROM Historico_vendas JOIN Produto on Historico_vendas.Ref_Produto = Produto.Ref 
)
end
go

select dbo.get_Faturacao() as Total

