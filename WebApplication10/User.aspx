<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="WebApplication10.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="titleOne" runat="server">
<form id="form1" method="post" action="">

שם פרטי<input type="text" name="first_name" value="<%=f_name%>"/>
<br />
שם משפחה <input type="text" name="last_name" value="<%=l_name%> "/>
<br />
גיל <input type="text" name="age" value="<%=agep%>" />
<br />
משתתף בתחרות:
<br />
לא משתתף<input name="Radio1" type="radio" value="0" /> גלישת גלים <input name="Radio1" type="radio" value="1" /> גלישת רוח <input name="Radio1" type="radio" value="2"/> 
<br />
סיסמא: <input name="Password" type="password" />
<br />
<input type="submit" name="sub" />
  </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentOne" runat="server">
</asp:Content>
