<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579957/20.1.10%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T386418)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

#  Dashboard for Web Forms - How to load and save dashboards from/to a database

This example shows how to create a custom dashboard storage that allows storing dashboards in a database. It uses the [System.Data.SqlClient](https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient?redirectedfrom=MSDN&view=net-5.0) members to connect and operate an MS SQL server database. <br><br>A custom dashboard storage should implement one of the following interfaces: **IDashboardStorage** or **IEditableDashboardStorage**.

**IDashboardStorage** provides functionality to open and edit dashboards available in the storage. 

- **XDocument LoadDashboard(string dashboardID)** - returns a dashboard by its ID in the XDocument format, which describes an object model of the dashboard.
- **IEnumerable<DashboardInfo> GetAvailableDashboardsInfo()** - returns a list of IDs and Captions of dashboards available in the data storage.
- **SaveDashboard(string dashboardID, XDocument dashboard)** - updates the dashboard with new settings by its id.
  
**IEditableDashboardStorage** inherits the IDashboardStorage interface and contains one additional method that allows adding new dashboards to the storage:
  
- **AddDashboard(XDocument dashboard, string dashboardName)** - takes a dashboard definition with its caption, saves it to the data storage, and returns the ID of a new saved dashboard.
  
Additionally, this example contains an SQL file ([SavedDashboards.sql](./CS/SavedDashboards.sql)), which can be used to recreate a database used in this example on your side. Do no forget to update the connection string in the **Web.config** file to make it valid in your environment.

  
<!-- default file list -->
## Files to Look At

* [DataBaseEditaleDashboardStorage.cs](./CS/DataBaseEditaleDashboardStorage.cs) (VB: [DataBaseEditaleDashboardStorage.vb](./VB/DataBaseEditaleDashboardStorage.vb))
* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
* [Global.asax](./CS/Global.asax) (VB: [Global.asax](./VB/Global.asax))
* [Global.asax.cs](./CS/Global.asax.cs) (VB: [Global.asax.vb](./VB/Global.asax.vb))
<!-- default file list end -->

## Documentation
  
* [Prepare Dashboard Storage](https://docs.devexpress.com/Dashboard/16979/web-dashboard/dashboard-backend/prepare-dashboard-storage)
* [IDashboardStorage Interface](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.IDashboardStorage)
* [Manage Multi-Tenancy](https://docs.devexpress.com/Dashboard/402924/web-dashboard/dashboard-backend/manage-multi-tenancy)

## More Examples
  
- <a href="https://www.devexpress.com/Support/Center/p/T392813">Dashboard for Web Forms - How to save dashboards created in ASPxDashboard to a DataSet</a>
- <a href="https://www.devexpress.com/Support/Center/p/T400693">Dashboard for MVC - How to load and save dashboards from/to a database</a>
- <a href="https://www.devexpress.com/Support/Center/p/T954359">Dashboard for MVC - How to implement multi-tenant Dashboard architecture</a>
