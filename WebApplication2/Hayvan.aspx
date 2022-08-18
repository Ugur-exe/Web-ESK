<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Hayvan.aspx.cs" Inherits="WebApplication2.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style15 {
            width: 87px;
        }
        .auto-style16 {
            background-color: bisque;
        }
        .auto-style19 {
            width: 140px;
        }
        .auto-style21 {
            width: 45px;
        }
        .auto-style22 {
            width: 92px;
        }
        .auto-style23 {
            width: 136px;
        }
    .auto-style25 {
        width: 2px;
    }
        .auto-style26 {
            margin-left: 400px;
            width: 827px;
            height: 80px;
        }
        .auto-style27 {
            width: 248px;
        }
        .auto-style28 {
            width: 174px;
        }
        .auto-style29 {
            margin-left: 400px;
            margin-top: -300px;
            width: 488px;
            height: 80px;
        }
        .auto-style30 {
            margin-left: 400px;
            width: 562px;
            height: 80px;
        }
        .auto-style31 {
            width: 91px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <link href="Hayvan.css" rel="stylesheet" />
    <table class="auto-style29">
        <tr>
            <td class="auto-style19">

                <asp:Label ID="Label2" runat="server" CssClass="all" Text="Büyükbaş Alım:" Font-Size="20pt"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style16" Height="43px" Width="86px" placeholder="Adet" TextMode="Number"></asp:TextBox>
            </td>
            <td class="auto-style31">
                <asp:TextBox ID="TextBox11" runat="server" CssClass="auto-style16" Height="43px" Width="86px" placeholder="Adet" TextMode="Number"></asp:TextBox>
            </td>
            <td class="auto-style28">
                <asp:Button ID="Button8" runat="server" CssClass="eklebuton" Height="42px" Text="Ekle" Width="68px" OnClick="Button8_Click" Font-Size="14pt" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        </table>
        &nbsp;
        &nbsp;
        &nbsp;
        <table class="auto-style26">
            <tr>
            <td class="auto-style23">

                <asp:Label ID="Label3" runat="server" CssClass="all" Text="Küçükbaş Alım:" Font-Size="20pt"></asp:Label>

            </td>
            <td class="auto-style21">

                <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style16" Height="43px" Width="86px" placeholder="Adet.." TextMode="Number"></asp:TextBox>

            </td >
            <td class="auto-style22">

                <asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style16" Height="43px" Width="86px" placeholder="Fiyat.." TextMode="Number"></asp:TextBox>

            </td>
            <td class="auto-style27">

                <asp:Button ID="Button9" runat="server" CssClass="eklebuton" Height="42px" Text="Ekle" Width="68px" OnClick="Button9_Click" Font-Size="14pt" />

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <asp:Label ID="Label6" runat="server" ForeColor="Red"></asp:Label>

            </td>
            <td>

                <asp:CheckBox ID="CheckBox1" runat="server"  Text="Ankara" Font-Size="18pt" />
                <br />
                <br />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Erzincan" Font-Size="18pt" />
                <br />
                <br />

            </td>
                </tr>
        </table>
     &nbsp;&nbsp;&nbsp;
    <table class="auto-style30">
        <tr>
            <td class="auto-style23">
                <asp:Label ID="Label4" runat="server" Text="Kanatlı Alım:" Font-Size="20pt"></asp:Label>
            </td>
            <td class="auto-style25">

                <asp:TextBox ID="TextBox9" runat="server" CssClass="auto-style16" Height="43px" Width="86px" placeholder="Adet.." TextMode="Number"></asp:TextBox>

            </td>
            <td class="auto-style22">

                <asp:TextBox ID="TextBox10" runat="server" CssClass="auto-style16" Height="43px" Width="86px" placeholder="Adet.." TextMode="Number"></asp:TextBox>

            </td>
            <td>

                <asp:Button ID="Button10" runat="server" CssClass="eklebuton" Height="42px" Text="Ekle" Width="68px" OnClick="Button10_Click" Font-Size="14pt" Font-Strikeout="False" />

                

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <asp:Label ID="Label7" runat="server" ForeColor="Red"></asp:Label>

            </td>
        </tr>
    </table>

   
</asp:Content>
