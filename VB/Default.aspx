<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
	<title></title>

	<style type="text/css">
		html, body, form {  
			height: 100%;  
			margin: 0;  
			padding: 0;  
			overflow: hidden;  
		}
	</style>
</head>
<body>
	<form id="form1" runat="server">
		<dx:ASPxDashboard ID="ASPxWebDashboard1" runat="server" Height="100%"
			IncludeDashboardIdToUrl="True"
			IncludeDashboardStateToUrl="True" 
			UseDashboardConfigurator="True">
		</dx:ASPxDashboard>
	</form>
</body>
</html>