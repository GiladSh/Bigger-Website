<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="AdminUp.AdminUpdateV2 " %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<script type ="text/javascript">
function Validate ()
{
    if (!isNaN(parseInt(document.getElementById("ID").value * 1))) 
{
    document.getElementById("hid").value = "V";
    

}
else {
    document.getElementById("hid").value = "IV";
    alert("ID must be numeric");

}
}


</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="titleOne" runat="server">
 <asp:Label id="Label1" runat="server"></asp:Label><br />
    User change: the id you want to change: <input name="ID" id="ID"/>
    <input type="hidden" value="" name="hid" id="hid" />
    <input type="submit" name="sub" value="Update User" onclick="Validate ()"/>
    <button name="delete" onclick="Validate ()">Delete User</button><br />
    <asp:Label id="pagebody" runat="server"></asp:Label><br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentOne" runat="server">
     
</asp:Content>