CREATE trigger tgiDecrementaEstoqueVenda on itensvenda
for insert
as
BEGIN 
	DECLARE @qtde	float, 
	@codigo			integer
	
	SELECT @codigo = pro_cod, @qtde = itv_qtde FROM INSERTED 
	
	update produto set pro_qtde = pro_qtde - @qtde where produto.pro_cod = @codigo 
end
go
---------------------------------------------------------------


CREATE TRIGGER DECREMENTAESTOQUEVENDA ON ITENSVENDA
FOR INSERT
AS
BEGIN 
	DECLARE @QTDE	FLOAT, 
	@CODIGO			INTEGER
	
	SELECT @CODIGO = PRO_COD, @QTDE = ITV_QTDE FROM INSERTED 
	
	UPDATE PRODUTO SET PRO_QTDE = PRO_QTDE - @QTDE WHERE PRODUTO.PRO_COD = @CODIGO 
END
GO


CREATE TRIGGER INCREMENTAESTOQUEVENDA ON ITENSCOMPRA
FOR INSERT
AS
BEGIN 
	DECLARE @QTDE	FLOAT, 
	@CODIGO			INTEGER
	
	SELECT @CODIGO = PRO_COD, @QTDE = ITC_QTDE FROM INSERTED 
	
	UPDATE PRODUTO SET PRO_QTDE = PRO_QTDE + @QTDE WHERE PRODUTO.PRO_COD = @CODIGO 
END
GO