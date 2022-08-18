<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Sevkiyat.aspx.cs" Inherits="WebApplication2.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style15 {
            margin-left: 220px;
            margin-top: -300px;
            width: 1144px;
            height: 0px;
        }
        .auto-style16 {
            height: 62px;
        }
        .auto-style17 {
            height: 69px;
        }
        .auto-style18 {
            height: 60px;
        }
        .auto-style19 {
            height: 69px;
            width: 465px;
        }
        .auto-style20 {
            height: 62px;
            width: 465px;
        }
        .auto-style22 {
            height: 60px;
            width: 465px;
        }
        .auto-style23 {
            height: 56px;
            width: 465px;
        }
        .auto-style24 {
            height: 56px;
        }
        .auto-style25 {
            height: 69px;
            width: 252px;
        }
        .auto-style26 {
            height: 62px;
            width: 252px;
        }
        .auto-style27 {
            height: 56px;
            width: 252px;
        }
        .auto-style28 {
            height: 60px;
            width: 252px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Sevkiyat.css" rel="stylesheet" />
    <table class="auto-style15">
        <tr>
            <td class="auto-style19">
                <asp:Label ID="Label3" runat="server" Text="Ankara Gönderilecek Hayvanlar:" Font-Size="20pt"></asp:Label>
            </td>
            <td class="auto-style25">
                <asp:RadioButtonList ID="RadioButtonList2" runat="server" Height="117px" Width="195px" Font-Size="15pt">
                    <asp:ListItem>Büyük Baş</asp:ListItem>
                    <asp:ListItem>Küçük Baş</asp:ListItem>
                    <asp:ListItem>Kanatlı</asp:ListItem>
                </asp:RadioButtonList>
                <br />
            </td>
            <td class="auto-style17">
                <asp:Label ID="Label7" runat="server" Font-Size="15pt" Text="Adet:"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style16" Height="43px" Width="86px" placeholder="Adet" TextMode="Number" BackColor="AntiqueWhite"></asp:TextBox>
                <br />
                <br />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label9" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style20">
                <asp:Label ID="Label4" runat="server" Text="Sevkiyat İçin Gereken Araç:" Font-Size="14pt"></asp:Label>
            &nbsp;

                <asp:TextBox ID="TextBox5" runat="server" Height="41px" Width="86px" placeholder="Araç.." TextMode="Number" BackColor="#FFCC66"></asp:TextBox>

            </td>
            <td class="auto-style26">&nbsp;</td>
            <td class="auto-style16">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button9" runat="server" BackColor="#66FF33" Height="55px" Text="Gönder" Width="160px" Font-Size="15pt" OnClick="Button9_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style23">
                <asp:Label ID="Label5" runat="server" Text="Erzincana Gönderilecek Hayvanlar:" Font-Size="20pt"></asp:Label>
            </td>
            <td class="auto-style27">
                <asp:RadioButtonList ID="RadioButtonList3" runat="server" Height="117px" Width="195px" Font-Size="15pt">
                    <asp:ListItem>Büyük Baş</asp:ListItem>
                    <asp:ListItem>Küçük Baş</asp:ListItem>
                    <asp:ListItem>Kanatlı</asp:ListItem>
                </asp:RadioButtonList>
                <br />
            </td>
            <td class="auto-style24">
                <asp:Label ID="Label8" runat="server" Font-Size="15pt" Text="Adet:"></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server" CssClass="auto-style16" Height="43px" Width="86px" placeholder="Adet" TextMode="Number" BackColor="AntiqueWhite"></asp:TextBox>
                <br />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label10" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style22">
                <asp:Label ID="Label6" runat="server" Text="Sevkiyat İçin Gereken Araç:" Font-Size="14pt"></asp:Label>
            &nbsp;

                <asp:TextBox ID="TextBox7" runat="server" CssClass="auto-style16" Height="43px" Width="86px" placeholder="Araç.." TextMode="Number" BackColor="#FFCC66"></asp:TextBox>

            </td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style18">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button10" runat="server" BackColor="#66FF33" Font-Size="15pt" Height="55px" OnClick="Button10_Click" Text="Gönder" Width="160px" />
            </td>
        </tr>
    </table>
    <link href="Sevkiyat.css" rel="stylesheet" />

</asp:Content>
