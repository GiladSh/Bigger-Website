<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication10.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    function Validate() {
        if (!isNaN(parseInt(document.getElementById("ID").value * 1))) {
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
<h3>הכנס תעודת זהות וסיסמא</h3>
ID: <input name="ID"  />
Pass: <input name="pass"  />
<br /><br />
    <input type="submit" name="sub"  value="התחבר" onclick="Validate()"/>
    <input type="hidden" value="" name="hid" id="hid" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentOne" runat="server">
</asp:Content>
