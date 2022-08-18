<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Depo.aspx.cs" Inherits="WebApplication2.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style14 {
            margin-left: 310px;
            margin-top: -340px;
            width: 1069px;
        }
        .auto-style16 {
            width: 251px;
        }
        .auto-style17 {
            width: 404px;
        }
        .auto-style18 {
            width: 515px;
        }
        .auto-style19 {
            width: 251px;
            height: 28px;
        }
        .auto-style20 {
            width: 404px;
            height: 32px;
        }
        .auto-style21 {
            width: 515px;
            height: 28px;
        }
        .auto-style22 {
            height: 28px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Depo.css" rel="stylesheet" />
   
    <table class="auto-style14">
        <tr>
            <td class="auto-style19"><div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"/>
            <asp:Timer ID="Timer1" runat="server" Interval="10" OnTick="Timer1_Tick"></asp:Timer>
                 <asp:Timer ID="Timer2" runat="server" OnTick="Timer2_Tick" Interval="10">
            </asp:Timer> 
                <asp:Timer ID="Timer3" runat="server" Interval="5" OnTick="Timer3_Tick1">
                </asp:Timer>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                <Triggers>
              <asp:AsyncPostBackTrigger controlid="Timer1" eventname="Tick"/>
              <asp:AsyncPostBackTrigger controlid="Timer2" eventname="Tick"/>
              <asp:AsyncPostBackTrigger controlid="Timer3" eventname="Tick"/>
         </Triggers>
         <ContentTemplate>
              <asp:Label ID="Label6" runat="server" Text="Büyük Baş:"></asp:Label>
              <asp:Literal ID="Literal1" runat="server"></asp:Literal>
             <br />
              <asp:Label ID="Label7" runat="server" Text="Yüzde:"></asp:Label>
             <asp:Label ID="Label1" runat="server" Text="0"></asp:Label>
         
              <br />
             <br />
              <asp:Label ID="Label10" runat="server" Text="Küçük Baş:"></asp:Label>
             <asp:Literal ID="Literal2" runat="server"></asp:Literal>
             <br />
              <asp:Label ID="Label8" runat="server" Text="Yüzde:"></asp:Label>
             <asp:Label ID="Label2" runat="server" Text="0"></asp:Label>
         
              <br />
         
              <br />
              <asp:Label ID="Label11" runat="server" Text="Kanatlı"></asp:Label>
              <asp:Literal ID="Literal3" runat="server"></asp:Literal>
              <br />
              <asp:Label ID="Label9" runat="server" Text="Yüzde:"></asp:Label>
              <asp:Label ID="Label5" runat="server" Text="0"></asp:Label>
         </ContentTemplate>
            </asp:UpdatePanel>
        <br />
        </div></td>
            <td class="auto-style20">&nbsp;
                <asp:Label ID="Label19" runat="server" CssClass="label" Text="Toplam Hayvan " color="Red" Font-Size="25pt" ForeColor="#FF6600"></asp:Label>
                :<asp:Label ID="Label12" runat="server" Text="Label" Font-Size="20pt"></asp:Label>
            </td>
            <td class="auto-style21">
                 <asp:Label ID="Label20" runat="server" CssClass="label" Text="Harcanan Tutar:" Font-Size="25pt" ForeColor="#FF6600"></asp:Label>
                 <asp:Label ID="Label13" runat="server" Text="Label" Font-Size="20pt"></asp:Label>
                 </td>
            <td class="auto-style22">
            </td>
        </tr>
        <tr>
            <td class="auto-style19">
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
            <td class="auto-style20">&nbsp;<asp:Label ID="Label18" runat="server" CssClass="label" Text="Yapılan Transferler:" Font-Size="25pt" ForeColor="#FF6600"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label22" runat="server" Font-Size="21pt" Text="Büyük Baş:"></asp:Label>
&nbsp;<asp:Label ID="Label14" runat="server" Text="Label" Font-Size="20pt"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label23" runat="server" Font-Size="21pt" Text="  Küçük Baş:"></asp:Label>
&nbsp;<asp:Label ID="Label15" runat="server" Text="Label" Font-Size="20pt"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label24" runat="server" Font-Size="21pt" Text="Kanatlı:"></asp:Label>
&nbsp;<asp:Label ID="Label16" runat="server" Text="Label" Font-Size="20pt"></asp:Label>
            </td>
            <td class="auto-style21">
                <asp:Label ID="Label21" runat="server" Text="Sevkiyat İçin Kullanılan Araç :" Font-Size="23pt" ForeColor="#FF6600"></asp:Label>
                &nbsp;
                <asp:Label ID="Label17" runat="server" Text="Label" Font-Size="20pt"></asp:Label>
            &nbsp;<br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
            <td class="auto-style22"></td>
        </tr>
        <tr>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style19"></td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style21"></td>
            <td class="auto-style22">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
   
</asp:Content>
