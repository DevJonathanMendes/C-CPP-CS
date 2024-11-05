<!-- Fig. 20.4: WebTime.aspx -->
<!-- Uma página que contém dois rótulos. -->


<%@ Page language="C#" Codebehind="WebTime.aspx.cs" AutoEventWireup="false"
	Inherits="WebTime.WebTimeTest" EnableSessionState="False" enableViewState="False" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">

<HTML>
	<HEAD>
		<title>WebTime</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="WebForm1" method="post" runat="server">
			<asp:Label id="promptLabel" style="Z-INDEX: 101; LEFT: 25px; POSITION: absolute; TOP: 23px" runat="server"
				Font-Size="Medium">
				A Simple Web Form Example
			</asp:Label>
			<asp:Label id="timeLabel" style="Z-INDEX: 102; LEFT: 25px; POSITION: absolute; TOP: 55px" runat="server"
				Font-Size="XX-Large" BackColor="Black" ForeColor="LimeGreen">
			</asp:Label>
		</form>
	</body>
</HTML>
