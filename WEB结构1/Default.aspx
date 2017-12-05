<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="System.IO" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <%
        Response.Write("hello world");

        File.WriteAllText(@"D:\Repo\TrainingSolution\WEB结构1\\index.html", "hello world " + Guid.NewGuid().ToString());
    %>
</body>
</html>
