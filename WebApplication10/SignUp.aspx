<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WebApplication10.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">

function Validate () {
    if (!isNaN(parseInt(document.getElementById("ID").value * 1)) && isNaN(document.getElementById("fname").value) && isNan(document.getElementById("lname").value) && !isNaN(parseInt(document.getElementById("age").value)))
{
    document.getElementById("hid").value = "V";

}
else {
    document.getElementById("hid").value = "IV";
    alert("ID and age must be numeric, and full name should only be letters");
    
}
}
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="titleOne" runat="server">
תעודה זהות: <input name="ID" id="ID" type="text" value="<%=id %>" />
<br />
שם פרטי: <input name="first_name" id="fname" type="text"  />
<br />
שם משפחה: <input name="last_name" id="lname" type="text" />
<br />
גיל: <input name="age" type="text" id="age"/>
<br />
סיסמא: <input name="Password1" type="password" />
<br />
    <input type="submit" name="sub" value="הירשם!" onclick="Validate()"/>
    <input type="hidden" name="hid" id="hid" value="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentOne" runat="server">
</asp:Content>
