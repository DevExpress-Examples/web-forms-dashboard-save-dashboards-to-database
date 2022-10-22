<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="Default" %>

<%@ Register assembly="DevExpress.Dashboard.v20.1.Web.WebForms, Version=20.1.16.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.DashboardWeb" tagprefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<dx:ASPxDashboard ID="ASPxWebDashboard1" runat="server" 
					IncludeDashboardIdToUrl = "True"
					IncludeDashboardStateToUrl = "True" Height="800px" UseDashboardConfigurator="True">
			</dx:ASPxDashboard>
	</form>
</body>
</html>