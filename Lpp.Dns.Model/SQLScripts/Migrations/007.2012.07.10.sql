IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspSearchLookupListValues]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspSearchLookupListValues]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspSearchLookupListValues]
	@ListId INT,
	@SearchText VARCHAR(500)
AS 
BEGIN
	DECLARE @index int
	DECLARE @ParseText VARCHAR(500)
	
	SET @ParseText = REPLACE(RTRIM(LTRIM(@SearchText)), '*', '%') -- Replacing * with %
	
	SET @SearchText = REPLACE(RTRIM(LTRIM(@SearchText)), '%', '') -- Removing % sign from original search string
	
	SET @index = PatIndex('%[0-9]%', @SearchText) -- Check if its ItemCode or ItemName
	
	IF (@SearchText = '') GOTO Search_NoSearchText

	--ELSE IF (@ListId = 7 AND (@index = 1 OR @index = 2 OR @index = 3)) GOTO Search_ItemCode
	
	ELSE IF (@index = 1 OR @index = 2) GOTO Search_ItemCode

	ELSE GOTO Search_ItemName

Search_ItemCode:
	IF(@ParseText = '%') -- Find All for that ListId
		BEGIN
			SELECT ItemName, CASE WHEN (ItemCode Is Null Or ItemCode = '') THEN ItemName ELSE ItemCode END As ItemCode, ItemCodeWithNoPeriod
			FROM LookupListValues
			WHERE listid = @ListId
			ORDER BY ItemCode, ItemName
		END
		
	ELSE IF (CHARINDEX('%', @ParseText)>0 AND LEN(@ParseText)>1)	-- e.g. A1010* or *A1010 or *A10*10*
		BEGIN
			SELECT ItemName, CASE WHEN (ItemCode Is Null Or ItemCode = '') THEN ItemName ELSE ItemCode END As ItemCode, ItemCodeWithNoPeriod
			FROM LookupListValues
			WHERE listid = @ListId AND ItemCode LIKE @ParseText 
			ORDER BY ItemCode, ItemName
		END
			
	ELSE IF (CHARINDEX(',', @SearchText)>0) -- e.g. G0328,G0260
		BEGIN
			DECLARE @Cnt int
			DECLARE @SearchValue VARCHAR(250)
			DECLARE @tblResult TABLE(ItemName VARCHAR(500), ItemCode varchar(500), ItemCodeWithNoPeriod varchar(50))
			DECLARE @SplitTable TABLE(ROWID INT, value VARCHAR(500))
			
			INSERT INTO @SplitTable SELECT * FROM dbo.Split( ',', @SearchText ) AS s 

			SELECT @Cnt = Count(*) from @SplitTable

			WHILE @Cnt > 0 
			BEGIN 
				SELECT @SearchValue = [value] from  @SplitTable where ROWID = @Cnt
				
				INSERT INTO @tblResult 
				SELECT ItemName, ItemCode, ItemCodeWithNoPeriod
				FROM LookupListValues
				WHERE listid = @ListId AND ItemCode Like @SearchValue
				ORDER BY ItemCode
				SET @Cnt = @Cnt - 1	
			END

			SELECT ItemName, CASE WHEN (ItemCode Is Null Or ItemCode = '') THEN ItemName ELSE ItemCode END As ItemCode, ItemCodeWithNoPeriod FROM @tblResult ORDER BY ItemCode, ItemName
		END
			
	ELSE IF (CHARINDEX('-', @SearchText)>0) -- e.g. G0328-G0260
		BEGIN
			DECLARE @From VARCHAR(50)
			DECLARE @To VARCHAR(50)
		
			SET @From = SUBSTRING(@SearchText, 1, CAST(CHARINDEX('-', @SearchText) AS INT)-1)
			SET @To = SUBSTRING(@SearchText, CAST(CHARINDEX('-', @SearchText) AS INT)+1, len(@SearchText))
			
			SELECT ItemName, CASE WHEN (ItemCode Is Null Or ItemCode = '') THEN ItemName ELSE ItemCode END As ItemCode, ItemCodeWithNoPeriod
			FROM LookupListValues
			WHERE listid = @ListId AND ItemCode >= @From AND ItemCode <= @To
			ORDER BY ItemCode, ItemName
			
		END
	ELSE								-- e.g. G0328
		BEGIN
			SELECT ItemName, CASE WHEN (ItemCode Is Null Or ItemCode = '') THEN ItemName ELSE ItemCode END As ItemCode, ItemCodeWithNoPeriod
			FROM LookupListValues
			WHERE listid = @ListId AND ItemCode = @SearchText
			ORDER BY ItemCode, ItemName
		END
	RETURN
	
Search_ItemName:
	BEGIN
		IF (CHARINDEX('%', @ParseText) = 0) 
			BEGIN
				SET @SearchText = REPLACE(@ParseText, '%', '')
				
				SELECT ItemName, CASE WHEN (ItemCode Is Null Or ItemCode = '') THEN ItemName ELSE ItemCode END As ItemCode, ItemCodeWithNoPeriod FROM LookupListValues  
				WHERE listid = @ListId AND FREETEXT (ItemName, @SearchText )
				GROUP BY ItemName, CASE WHEN (ItemCode Is Null Or ItemCode = '') THEN ItemName ELSE ItemCode END, ItemCodeWithNoPeriod
				ORDER BY ItemCode, ItemName
			END
		ELSE		
			BEGIN
				SELECT ItemName, CASE WHEN (ItemCode Is Null Or ItemCode = '') THEN ItemName ELSE ItemCode END As ItemCode, ItemCodeWithNoPeriod FROM LookupListValues  
				WHERE listid = @ListId AND ItemName LIKE @ParseText 
				GROUP BY ItemName, CASE WHEN (ItemCode Is Null Or ItemCode = '') THEN ItemName ELSE ItemCode END, ItemCodeWithNoPeriod
				ORDER BY ItemCode, ItemName
			END
	END
	RETURN
Search_NoSearchText:	
	BEGIN
		SELECT ItemName, CASE WHEN (ItemCode Is Null Or ItemCode = '') THEN ItemName ELSE ItemCode END, ItemCodeWithNoPeriod FROM LookupListValues
		WHERE 0 = 1;
	END
	RETURN	
END
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspGetLookupListCategoryValues]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspGetLookupListCategoryValues]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[uspGetLookupListCategoryValues]
	@ListId INT,
	@CategoryId INT
AS 

BEGIN
	SELECT ListId, CategoryId, ItemName, CASE WHEN (ItemCode Is Null Or ItemCode = '') THEN ItemName ELSE ItemCode END As ItemCode, ItemCodeWithNoPeriod, ID FROM LookupListValues  
	WHERE listid = @ListId AND CategoryId = @CategoryId
	ORDER by ItemCode, ItemName
END
GO
