
USE [MCLfreight_Test]
GO
DROP PROCEDURE IF EXISTS [dbo].[sp_SumConsolExport]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_SumConsolExport]    Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a SumConsolExport row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_SumConsolExport]  
@BusinessPartyCode NVARCHAR(20),       
@c_CityCode   NVARCHAR(6)
AS
BEGIN
	select ConsolsExport=count(*) 
	from jmjm1 (nolock)
	where ModuleCode='SE' 
	and ShipmentType IN ('M','D')
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
END

GO
DROP PROCEDURE IF EXISTS [dbo].[sp_SumConsolImport]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_SumConsolImport]   Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a SumConsolImport row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_SumConsolImport]  
@BusinessPartyCode NVARCHAR(20),       
@c_CityCode   NVARCHAR(6)
AS
BEGIN
	select ConsolsImport=count(*) 
	from jmjm1 (nolock)
	where ModuleCode='SI' 
	and ShipmentType IN ('M','D')
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
END



GO
DROP PROCEDURE IF EXISTS [dbo].[sp_SumShipmentExport]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_SumShipmentExport]  Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a SumShipmentExport row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_SumShipmentExport]  
@BusinessPartyCode NVARCHAR(20),       
@c_CityCode   NVARCHAR(6)
AS
BEGIN
	select ShipmentExport=count(*) 
	from jmjm1 (nolock)
	where ModuleCode='SE' 
	and ShipmentType = 'H'
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
END



GO
DROP PROCEDURE IF EXISTS [dbo].[sp_SumShipmentImport]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_SumShipmentImport]  Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a SumShipmentImport row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_SumShipmentImport]  
@BusinessPartyCode NVARCHAR(20),       
@c_CityCode   NVARCHAR(6)
AS
BEGIN
	select ShipmentImport=count(*) 
	from jmjm1 (nolock)
	where ModuleCode='SI' 
	and ShipmentType = 'H'
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

END




GO
DROP PROCEDURE IF EXISTS [dbo].[sp_SumWeightExport]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_SumWeightExport]  Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a SumWeightExport row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_SumWeightExport]  
@BusinessPartyCode NVARCHAR(20),       
@c_CityCode   NVARCHAR(6)
AS
BEGIN
	select TotWeightExport=sum(GrossWeight) 
	from jmjm1 (nolock)
	where ModuleCode='SE' 
	and ShipmentType = 'H'
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
END



GO
DROP PROCEDURE IF EXISTS [dbo].[sp_SumWeightImport]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_SumWeightImport]  Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a SumWeightImport row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_SumWeightImport]  
@BusinessPartyCode NVARCHAR(20),       
@c_CityCode   NVARCHAR(6)
AS
BEGIN
	select TotWeightImport=sum(GrossWeight) 
	from jmjm1 (nolock)
	where ModuleCode='SI' 
	and ShipmentType = 'H'
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
END



GO
DROP PROCEDURE IF EXISTS [dbo].[sp_SumVolumeExport]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_SumVolumeExport] Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a SumVolumeExport row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_SumVolumeExport]  
@BusinessPartyCode NVARCHAR(20),       
@c_CityCode   NVARCHAR(6)
AS
BEGIN
	select TotExportVOL=sum(Volume) 
	from jmjm1 (nolock)
	where ModuleCode='SE' 
	and ShipmentType = 'H'
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
END



GO
DROP PROCEDURE IF EXISTS [dbo].[sp_SumVolumeImport]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_SumVolumetImport]  Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a SumWeightImport row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_SumVolumeImport]  
@BusinessPartyCode NVARCHAR(20),       
@c_CityCode   NVARCHAR(6)
AS
BEGIN
	select TotImportVOL=sum(Volume) 
	from jmjm1 (nolock)
	where ModuleCode='SI' 
	and ShipmentType = 'H'
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
END