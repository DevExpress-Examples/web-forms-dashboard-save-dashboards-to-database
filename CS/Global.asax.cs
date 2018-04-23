using System;
using System.Web.Hosting;
using DevExpress.DashboardCommon;
using DevExpress.DashboardCommon.Native.DashboardRestfulService;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.Xpo.DB;
using DevExpress.DashboardWeb;
using System.Configuration;
using T386418;


public partial class Global : System.Web.HttpApplication {
    protected void Application_Start(object sender, EventArgs e) {
        DataBaseEditaleDashboardStorage dataBaseDashboardStorage = new DataBaseEditaleDashboardStorage(ConfigurationManager.
    ConnectionStrings["DashboardStorageConnection"].ConnectionString);

        DashboardConfigurator.Default.SetDashboardStorage(dataBaseDashboardStorage);

        DashboardSqlDataSource sqlDataSource = new DashboardSqlDataSource("SQL Data Source");
        SelectQuery customerReportsQuery = SelectQueryFluentBuilder
            .AddTable("CustomerReports")
            .SelectColumn("CompanyName")
            .SelectColumn("ProductName")
            .SelectColumn("OrderDate")
            .SelectColumn("ProductAmount")
            .Build("CustomerReportsQuery");
        sqlDataSource.Queries.Add(customerReportsQuery);

        DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();
        dataSourceStorage.RegisterDataSource("sqlDataSource1", sqlDataSource.SaveToXml());
        DashboardConfigurator.Default.SetDataSourceStorage(dataSourceStorage);
        DashboardConfigurator.Default.ConfigureDataConnection += DataApi_ConfigureDataConnection;
    }

    void DataApi_ConfigureDataConnection(object sender, ConfigureDataConnectionWebEventArgs e)
    {
        if (e.DataSourceName == "SQL Data Source")
        {
            Access97ConnectionParameters accessParams = new  Access97ConnectionParameters();
            accessParams.FileName = HostingEnvironment.MapPath("~/App_Data/nwind.mdb");
            e.ConnectionParameters = accessParams;
        }
    }

    protected void Session_Start(object sender, EventArgs e) {
    }
    protected void Application_BeginRequest(object sender, EventArgs e) {
    }
    protected void Application_AuthenticateRequest(object sender, EventArgs e) {
    }
    protected void Application_Error(object sender, EventArgs e) {
    }
    protected void Session_End(object sender, EventArgs e) {
    }
    protected void Application_End(object sender, EventArgs e) {
    }
}