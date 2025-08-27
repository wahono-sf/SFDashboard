
USE [Macnels]
GO
DROP PROCEDURE IF EXISTS [dbo].[sp_GraphConsolExport]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_GraphConsolExport]    Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
SET NOCOUNT ON   
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a Graph ConsolExport row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_GraphConsolExport]
@BusinessPartyCode NVARCHAR(20),       
@c_CityCode   NVARCHAR(6)
AS
BEGIN
SELECT *
FROM (SELECT YEAR(JobDate) [Year], 
       left(DATENAME(MONTH, JobDate),3) [Month], 
       COUNT(1) [ConsolsExport]
      FROM jmjm1 (nolock)
	  where ModuleCode='SE' and ShipmentType IN ('M','D')
	   AND CustomerCode LIKE
		  CASE 
			WHEN @BusinessPartyCode <> 'ALL' THEN  @BusinessPartyCode
			ELSE  '%'
		  END
		  AND DestCode LIKE
		  CASE 
			WHEN @c_CityCode <> 'ALL' THEN @c_CityCode
			ELSE '%'
		  END
		    AND YEAR(JobDate) > YEAR(DATEADD(year,-3,GETDATE()))
		  AND YEAR(JobDate) <= YEAR(GETDATE())
      GROUP BY YEAR(JobDate), 
      DATENAME(MONTH, JobDate)) AS MontlySalesData
PIVOT( SUM([ConsolsExport])   
    FOR Month IN ([Jan],[Feb],[Mar],[Apr],[May],
    [Jun],[Jul],[Aug],[Sep],[Oct],[Nov],[Dec])) AS MNamePivot


END

GO
DROP PROCEDURE IF EXISTS [dbo].[sp_GraphConsolImport]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_GraphConsolImport]    Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
SET NOCOUNT ON   
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a Graph ConsolImport row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_GraphConsolImport]
@BusinessPartyCode NVARCHAR(20),       
@c_CityCode   NVARCHAR(6)
AS
BEGIN
SELECT *
FROM (SELECT YEAR(JobDate) [Year], 
       left(DATENAME(MONTH, JobDate),3) [Month], 
       COUNT(1) [ConsolsImport]
      FROM jmjm1 (nolock)
	  where ModuleCode='SI' and ShipmentType IN ('M','D')
	   AND CustomerCode LIKE
		  CASE 
			WHEN @BusinessPartyCode <> 'ALL' THEN  @BusinessPartyCode
			ELSE  '%'
		  END
		  AND DestCode LIKE
		  CASE 
			WHEN @c_CityCode <> 'ALL' THEN @c_CityCode
			ELSE '%'
		  END
		    AND YEAR(JobDate) > YEAR(DATEADD(year,-3,GETDATE()))
		  AND YEAR(JobDate) <= YEAR(GETDATE())
      GROUP BY YEAR(JobDate), 
      DATENAME(MONTH, JobDate)) AS MontlySalesData
PIVOT( SUM([ConsolsImport])   
    FOR Month IN ([Jan],[Feb],[Mar],[Apr],[May],
    [Jun],[Jul],[Aug],[Sep],[Oct],[Nov],[Dec])) AS MNamePivot
END


GO
DROP PROCEDURE IF EXISTS [dbo].[sp_GraphShipmentExport]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_GraphShipmentExport]  Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
SET NOCOUNT ON   
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a Graph Shipment Export row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_GraphShipmentExport]
@BusinessPartyCode NVARCHAR(20),       
@c_CityCode   NVARCHAR(6)
AS
BEGIN
SELECT *
FROM (SELECT YEAR(JobDate) [Year], 
       left(DATENAME(MONTH, JobDate),3) [Month], 
       COUNT(1) [ShipmentExport]
      FROM jmjm1 (nolock)
	  where ModuleCode='SE' and ShipmentType = 'H'
	   AND CustomerCode LIKE
		  CASE 
			WHEN @BusinessPartyCode <> 'ALL' THEN  @BusinessPartyCode
			ELSE  '%'
		  END
		  AND DestCode LIKE
		  CASE 
			WHEN @c_CityCode <> 'ALL' THEN @c_CityCode
			ELSE '%'
		  END
		    AND YEAR(JobDate) > YEAR(DATEADD(year,-3,GETDATE()))
		  AND YEAR(JobDate) <= YEAR(GETDATE())
      GROUP BY YEAR(JobDate), 
      DATENAME(MONTH, JobDate)) AS MontlySalesData
PIVOT( SUM([ShipmentExport])   
    FOR Month IN ([Jan],[Feb],[Mar],[Apr],[May],
    [Jun],[Jul],[Aug],[Sep],[Oct],[Nov],[Dec])) AS MNamePivot
END



GO
DROP PROCEDURE IF EXISTS [dbo].[sp_GraphShipmentImport]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_GraphShipmentExport]  Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
SET NOCOUNT ON   
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a Graph Shipment Import row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_GraphShipmentImport]
@BusinessPartyCode NVARCHAR(20),       
@c_CityCode   NVARCHAR(6)
AS
BEGIN
SELECT *
FROM (SELECT YEAR(JobDate) [Year], 
       left(DATENAME(MONTH, JobDate),3) [Month], 
       COUNT(1) [ShipmentExport]
      FROM jmjm1 (nolock)
	  where ModuleCode='SI' and ShipmentType = 'H'
	   AND CustomerCode LIKE
		  CASE 
			WHEN @BusinessPartyCode <> 'ALL' THEN  @BusinessPartyCode
			ELSE  '%'
		  END
		  AND DestCode LIKE
		  CASE 
			WHEN @c_CityCode <> 'ALL' THEN @c_CityCode
			ELSE '%'
		  END
		    AND YEAR(JobDate) > YEAR(DATEADD(year,-3,GETDATE()))
		  AND YEAR(JobDate) <= YEAR(GETDATE())
      GROUP BY YEAR(JobDate), 
      DATENAME(MONTH, JobDate)) AS MontlySalesData
PIVOT( SUM([ShipmentExport])   
    FOR Month IN ([Jan],[Feb],[Mar],[Apr],[May],
    [Jun],[Jul],[Aug],[Sep],[Oct],[Nov],[Dec])) AS MNamePivot
END


GO
DROP PROCEDURE IF EXISTS [dbo].[sp_GraphWeightExport]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_GraphWeightExport] Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
SET NOCOUNT ON   
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a Graph Weight Export row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_GraphWeightExport]
@BusinessPartyCode NVARCHAR(20),       
@c_CityCode   NVARCHAR(6)
AS
BEGIN
SELECT *
FROM (SELECT YEAR(JobDate) [Year], 
       left(DATENAME(MONTH, JobDate),3) [Month], 
       sum(GrossWeight) [TotWeightExport]
      FROM jmjm1 (nolock)
	  where ModuleCode='SE' and ShipmentType = 'H'
	   AND CustomerCode LIKE
		  CASE 
			WHEN @BusinessPartyCode <> 'ALL' THEN  @BusinessPartyCode
			ELSE  '%'
		  END
		  AND DestCode LIKE
		  CASE 
			WHEN @c_CityCode <> 'ALL' THEN @c_CityCode
			ELSE '%'
		  END
		    AND YEAR(JobDate) > YEAR(DATEADD(year,-3,GETDATE()))
		  AND YEAR(JobDate) <= YEAR(GETDATE())
      GROUP BY YEAR(JobDate), 
      DATENAME(MONTH, JobDate)) AS MontlySalesData
PIVOT( SUM([TotWeightExport])   
    FOR Month IN ([Jan],[Feb],[Mar],[Apr],[May],
    [Jun],[Jul],[Aug],[Sep],[Oct],[Nov],[Dec])) AS MNamePivot
END



GO
DROP PROCEDURE IF EXISTS [dbo].[sp_GraphWeightImport]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_GraphWeightImport] Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
SET NOCOUNT ON   
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a Graph Weight Import row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_GraphWeightImport]
@BusinessPartyCode NVARCHAR(20),       
@c_CityCode   NVARCHAR(6)
AS
BEGIN
SELECT *
FROM (SELECT YEAR(JobDate) [Year], 
       left(DATENAME(MONTH, JobDate),3) [Month], 
       sum(GrossWeight) [TotWeightExport]
      FROM jmjm1 (nolock)
	  where ModuleCode='SI' and ShipmentType = 'H'
	   AND CustomerCode LIKE
		  CASE 
			WHEN @BusinessPartyCode <> 'ALL' THEN  @BusinessPartyCode
			ELSE  '%'
		  END
		  AND DestCode LIKE
		  CASE 
			WHEN @c_CityCode <> 'ALL' THEN @c_CityCode
			ELSE '%'
		  END
		    AND YEAR(JobDate) > YEAR(DATEADD(year,-3,GETDATE()))
		  AND YEAR(JobDate) <= YEAR(GETDATE())
      GROUP BY YEAR(JobDate), 
      DATENAME(MONTH, JobDate)) AS MontlySalesData
PIVOT( SUM([TotWeightExport])   
    FOR Month IN ([Jan],[Feb],[Mar],[Apr],[May],
    [Jun],[Jul],[Aug],[Sep],[Oct],[Nov],[Dec])) AS MNamePivot
END


GO
DROP PROCEDURE IF EXISTS [dbo].[sp_GraphVolumeExport]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_GraphVolumeExport] Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
SET NOCOUNT ON   
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a Graph Volume Export row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_GraphVolumeExport]
@BusinessPartyCode NVARCHAR(20),       
@c_CityCode   NVARCHAR(6)
AS
BEGIN
SELECT *
FROM (SELECT YEAR(JobDate) [Year], 
       left(DATENAME(MONTH, JobDate),3) [Month], 
       sum(Volume) [TotExportVOL]
      FROM jmjm1 (nolock)
	  where ModuleCode='SI' and ShipmentType = 'H'
	   AND CustomerCode LIKE
		  CASE 
			WHEN @BusinessPartyCode <> 'ALL' THEN  @BusinessPartyCode
			ELSE  '%'
		  END
		  AND DestCode LIKE
		  CASE 
			WHEN @c_CityCode <> 'ALL' THEN @c_CityCode
			ELSE '%'
		  END
		    AND YEAR(JobDate) > YEAR(DATEADD(year,-3,GETDATE()))
		  AND YEAR(JobDate) <= YEAR(GETDATE())
      GROUP BY YEAR(JobDate), 
      DATENAME(MONTH, JobDate)) AS MontlySalesData
PIVOT( SUM([TotExportVOL])   
    FOR Month IN ([Jan],[Feb],[Mar],[Apr],[May],
    [Jun],[Jul],[Aug],[Sep],[Oct],[Nov],[Dec])) AS MNamePivot
END



GO
DROP PROCEDURE IF EXISTS [dbo].[sp_GraphVolumeImport]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_GraphVolumeImport] Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
SET NOCOUNT ON   
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a Graph Volume Import row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_GraphVolumeImport]
@BusinessPartyCode NVARCHAR(20),       
@c_CityCode   NVARCHAR(6)
AS
BEGIN
SELECT *
FROM (SELECT YEAR(JobDate) [Year], 
       left(DATENAME(MONTH, JobDate),3) [Month], 
       sum(GrossWeight) [TotWeightExport]
      FROM jmjm1 (nolock)
	  where ModuleCode='SI' and ShipmentType = 'H'
	   AND CustomerCode LIKE
		  CASE 
			WHEN @BusinessPartyCode <> 'ALL' THEN  @BusinessPartyCode
			ELSE  '%'
		  END
		  AND DestCode LIKE
		  CASE 
			WHEN @c_CityCode <> 'ALL' THEN @c_CityCode
			ELSE '%'
		  END
		    AND YEAR(JobDate) > YEAR(DATEADD(year,-3,GETDATE()))
		  AND YEAR(JobDate) <= YEAR(GETDATE())
      GROUP BY YEAR(JobDate), 
      DATENAME(MONTH, JobDate)) AS MontlySalesData
PIVOT( SUM([TotWeightExport])   
    FOR Month IN ([Jan],[Feb],[Mar],[Apr],[May],
    [Jun],[Jul],[Aug],[Sep],[Oct],[Nov],[Dec])) AS MNamePivot
END





