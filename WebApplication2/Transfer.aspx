<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Transfer.aspx.cs" Inherits="WebApplication2.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style16 {
            width: 341px;
            height: 45px;
        }
        .auto-style17 {
            height: 45px;
            width: 286px;
        }
        .auto-style18 {
            width: 341px;
            height: 56px;
        }
        .auto-style19 {
            height: 56px;
            width: 286px;
        }
        .auto-style20 {
            height: 56px;
            width: 242px;
        }
        .auto-style21 {
            height: 45px;
            width: 242px;
        }
        .auto-style22 {
            width: 341px;
            height: 19px;
        }
        .auto-style23 {
            height: 19px;
            width: 242px;
        }
        .auto-style24 {
            height: 19px;
            width: 286px;
        }
        .auto-style25 {
            margin-left: 300px;
            margin-top: -300px;
            width: 850px;
            height: 404px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <link href="Transfer.css" rel="stylesheet" />
    <table class="auto-style25">
        <tr>
            <td class="auto-style18">
                <asp:CheckBox ID="CheckBox1" runat="server" BorderStyle="Groove" Font-Size="20pt"  Text="Ankaradan&gt;Erzincana" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
            </td>
            <td class="auto-style20">
                <asp:Label ID="Label3" runat="server" Font-Size="15pt" Text="Adet:"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style16" Height="43px" Width="86px" placeholder="Adet" TextMode="Number" BackColor="AntiqueWhite"></asp:TextBox>
            </td>
            <td class="auto-style19">&nbsp;<asp:Label ID="Label5" runat="server" Font-Size="22pt" ForeColor="Red" Text="Yapılacak İşlem Türü"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:CheckBox ID="CheckBox2" runat="server" BorderStyle="Groove" Font-Size="20pt" Text="Erzincandan&gt;Ankaraya" AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged" />
            </td>
            <td class="auto-style21">
                <asp:Label ID="Label4" runat="server" Font-Size="15pt" Text="Adet:"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style16" Height="43px" Width="86px" placeholder="Adet" TextMode="Number" BackColor="AntiqueWhite"></asp:TextBox>
            </td>
            <td class="auto-style17">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" Font-Size="16pt" Height="144px" Width="189px">
                    <asp:ListItem>Büyük Baş</asp:ListItem>
                    <asp:ListItem>Küçük Baş</asp:ListItem>
                    <asp:ListItem>Kanatlı</asp:ListItem>
                </asp:RadioButtonList>
&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style22">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style23"></td>
            <td class="auto-style24">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button9" runat="server" BackColor="#29C44D" Font-Bold="True" Font-Italic="False" Font-Size="14pt" ForeColor="#003300" Height="57px" Text="Transfet Et" Width="149px" OnClick="Button9_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

