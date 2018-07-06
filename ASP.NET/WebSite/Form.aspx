<%@ Page Title="Form Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Form.aspx.cs" Inherits="Form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>this is my form page. It'll have some info about me</p>
    <table style="border:4px solid black; width: 100%; height: 100%">
    <tr>
        <th colspan="3" style="background-color:antiquewhite"></th>
    </tr>

    <tr>
        <td style="width: 80%">This is the left hand side.</td>
        <td style="width: 10%">This is the body.</td>
        <td style="width: 10%">This is the right side.</td>
    </tr>
    <tr>
        <td colspan="3">The footer</td>
    </tr>
</table>
</asp:Content>