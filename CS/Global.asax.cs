using System;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using System.Configuration;
using T386418;

public partial class Global : System.Web.HttpApplication {
    protected void Application_Start(object sender, EventArgs e) {
        var dataBaseDashboardStorage = new DatabaseEditableDashboardStorage(
            ConfigurationManager.ConnectionStrings["DashboardStorageConnection"].ConnectionString);
        DashboardConfigurator.Default.SetDashboardStorage(dataBaseDashboardStorage);
        DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();
        DashboardObjectDataSource objDataSource = new DashboardObjectDataSource("Object Data Source", typeof(SalesPersonData));
        objDataSource.DataMember = "GetSalesData";
        dataSourceStorage.RegisterDataSource("objectDataSource", objDataSource.SaveToXml());
        DashboardConfigurator.Default.SetDataSourceStorage(dataSourceStorage);
    }
    protected void Session_Start(object sender, EventArgs e) { }
    protected void Application_BeginRequest(object sender, EventArgs e) { }
    protected void Application_AuthenticateRequest(object sender, EventArgs e) { }
    protected void Application_Error(object sender, EventArgs e) { }
    protected void Session_End(object sender, EventArgs e) { }
    protected void Application_End(object sender, EventArgs e) { }
}