Imports Microsoft.VisualBasic
Imports System
Imports System.Web.Hosting
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardCommon.Native.DashboardRestfulService
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports DevExpress.Xpo.DB
Imports DevExpress.DashboardWeb
Imports System.Configuration
Imports T386418


Partial Public Class [Global]
	Inherits System.Web.HttpApplication
	Protected Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
		Dim dataBaseDashboardStorage As New DatabaseEditableDashboardStorage(ConfigurationManager. ConnectionStrings("DashboardStorageConnection").ConnectionString)

		DashboardConfigurator.Default.SetDashboardStorage(dataBaseDashboardStorage)

		Dim sqlDataSource As New DashboardSqlDataSource("SQL Data Source")
		Dim customerReportsQuery As SelectQuery = SelectQueryFluentBuilder.AddTable("CustomerReports").SelectColumn("CompanyName").SelectColumn("ProductName").SelectColumn("OrderDate").SelectColumn("ProductAmount").Build("CustomerReportsQuery")
		sqlDataSource.Queries.Add(customerReportsQuery)

		Dim dataSourceStorage As New DataSourceInMemoryStorage()
		dataSourceStorage.RegisterDataSource("sqlDataSource1", sqlDataSource.SaveToXml())
		DashboardConfigurator.Default.SetDataSourceStorage(dataSourceStorage)
		AddHandler DashboardConfigurator.Default.ConfigureDataConnection, AddressOf DataApi_ConfigureDataConnection
	End Sub

	Private Sub DataApi_ConfigureDataConnection(ByVal sender As Object, ByVal e As ConfigureDataConnectionWebEventArgs)
		If e.DataSourceName = "SQL Data Source" Then
			Dim accessParams As New Access97ConnectionParameters()
			accessParams.FileName = HostingEnvironment.MapPath("~/App_Data/nwind.mdb")
			e.ConnectionParameters = accessParams
		End If
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