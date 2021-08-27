<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579957/16.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T386418)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DataBaseEditaleDashboardStorage.cs](./CS/DataBaseEditaleDashboardStorage.cs) (VB: [DataBaseEditaleDashboardStorage.vb](./VB/DataBaseEditaleDashboardStorage.vb))
* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
* [Global.asax](./CS/Global.asax) (VB: [Global.asax](./VB/Global.asax))
* [Global.asax.cs](./CS/Global.asax.cs) (VB: [Global.asax.vb](./VB/Global.asax.vb))
<!-- default file list end -->
#  ASPxDashboard - How to load and save dashboards from/to a database


<p>This example shows how to create a custom dashboard storage that allows storing dashboards in a data base. It uses the <a href="https://msdn.microsoft.com/en-us/library/system.data.sqlclient(v=vs.110).aspx">System.Data.SqlClient</a> members to connect and operate an MS SQL server data base. <br><br>A custom dashboard storage should implement one of the following interfaces:<strong> IDashboardStorage</strong> or <strong>IEditableDashboardStorage</strong>.<br><br>IDashboardStorage provides functionality to open and edit dashboards available in the storage. <br><strong>XDocument LoadDashboard(string dashboardID) </strong>- returns a dashboard by its ID in the XDocument format, which describes an object model of the dashboard.<br><strong>IEnumerable<DashboardInfo> GetAvailableDashboardsInfo()</strong> - returns a list of IDs and Captions of dashboards available in the data storage.<br><strong>void SaveDashboard(string dashboardID, XDocument dashboard)</strong> - updates the dashboard with new settings by its id.<br><br>IEditableDashboardStorage inherits the IDashboardStorage interface and contains one additional method that allows adding new dashboards to the storage.<br><strong>string AddDashboard(XDocument dashboard, string dashboardName)</strong> - takes a dashboard definition with its caption, saves it to the data storage, and returns the ID of a new saved dashboard.<br><br>Additionally, this example contains an SQL query and data base backup file,  which can be used to recreate a data base used in this example on your side.<br><br>See also: <br><a href="https://www.devexpress.com/Support/Center/p/T392813">How to save dashboards created in ASPxDashboard to a DataSet</a><br><a href="https://www.devexpress.com/Support/Center/p/T400693">MVCxDashboard - How to save dashboards to a data base</a><br><br>This example applies to the Web Dashboard Designer starting from v2016 vol 1. To learn how to achieve this goal in previous versions, refer to the <a href="https://www.devexpress.com/Support/Center/p/T373382">OBSOLETE - ASPxDashboardDesigner - How to save dashboards to a data base</a> example.</p>

<br/>


