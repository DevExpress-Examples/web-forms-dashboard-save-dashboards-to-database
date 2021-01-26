Imports System
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports System.Configuration
Imports T386418

Partial Public Class [Global]
	Inherits System.Web.HttpApplication

	Protected Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
		Dim dataBaseDashboardStorage = New DataBaseEditaleDashboardStorage(ConfigurationManager.ConnectionStrings("DashboardStorageConnection").ConnectionString)

		DashboardConfigurator.Default.SetDashboardStorage(dataBaseDashboardStorage)

		Dim dataSourceStorage As New DataSourceInMemoryStorage()
		Dim objDataSource As New DashboardObjectDataSource("Object Data Source", GetType(SalesPersonData))

		objDataSource.DataMember = "GetSalesData"

		dataSourceStorage.RegisterDataSource("objectDataSource", objDataSource.SaveToXml())

		DashboardConfigurator.Default.SetDataSourceStorage(dataSourceStorage)
	End Sub
	Protected Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
End Class