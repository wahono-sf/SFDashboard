
USE [MCLfreight_Test]
GO
DROP PROCEDURE IF EXISTS [dbo].[sp_GetCityDashboard]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_GetCityDashboard]    Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a Get City Dashboard row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_GetCityDashboard]  
AS
BEGIN
	select CityCode,CityName from rcct1 (nolock)
END

GO
DROP PROCEDURE IF EXISTS [dbo].[sp_GetCustomerDashboard]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_GetCustomerDashboard]   Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a sp_GetCustomerDashboard row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_GetCustomerDashboard]  
AS
BEGIN
	select bp1.BusinessPartyCode,bp1.BusinessPartyName 
                                        from rcbp1  bp1 (nolock)
                                        join rcbp5 bp5 (nolock) on bp1.BusinessPartyCode = bp5.BusinessPartyCode
                                        where partycode = 'CL'
END


GO
DROP PROCEDURE IF EXISTS [dbo].[sp_GetCustomerSlcu]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_GetCustomerSlcu]   Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a sp_GetCustomerDashboard row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_GetCustomerSlcu]  
AS
BEGIN
	select CustomerCode,CustomerName from slcu1 (nolock)
END




GO
DROP PROCEDURE IF EXISTS [dbo].[sp_GetVendorPlvn]  
GO  
/****** Object:  StoredProcedure [dbo].[sp_GetVendorPlvn]   Script Date: 6/22/2023 3:09:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Wahono
-- Create date: Agust 22, 2023
-- Description:	get a sp_GetVendorPlvn row/rows
-- =============================================

CREATE PROCEDURE [dbo].[sp_GetVendorPlvn]  
AS
BEGIN
	select VendorCode,VendorName from plvn1 (nolock)
END

