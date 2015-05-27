<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserAdmin.aspx.cs" Inherits="WebApplication10.UserAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="titleOne" runat="server">

<form id="form1" method="post" action="">
ת.ז: <input type="text" name="id" value="<%=idtoupdate %>"/>
<br />

שם פרטי: <input type="text" name="first_name" value="<%=f_nametoupdate%>"/>
<br />
שם משפחה: <input type="text" name="last_name" value="<%=l_nametoupdate%> "/>
<br />
גיל: <input type="text" name="age" value="<%=agetoupdate%>" />
<br />
משתתף בתחרות:
<br />
לא משתתף<input name="Radio1" type="radio" value="0" /> גלישת גלים <input name="Radio1" type="radio" value="1" /> גלישת רוח <input name="Radio1" type="radio" value="1"/> 
<br />
סיסמא: <input name="Password" type="password" value="<%=passwordtoupdate %>" />
<br />
סוג משתמש: <input type="text" name="u_type" value="<%=user_typetoupdate%>" />
<input type="submit" name="sub" />
  </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentOne" runat="server">
</asp:Content>
