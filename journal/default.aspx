<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="journal._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            width: 90px;
            height: 26px;
        }
        .auto-style6 {
            width: 90px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">Id</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtId" runat="server" Width="169px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Title</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtTitle" runat="server" Width="164px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Description</td>
                <td>
                    <asp:TextBox ID="txtDes" runat="server" Width="162px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">File path</td>
                <td>
                    <asp:FileUpload ID="FileUpload" runat="server" />
&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">Status</td>
                <td id="txtstatus">
                    <asp:TextBox ID="txtSt" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Is active?</td>
                <td>
                    <asp:RadioButton ID="rbtnYes" runat="server" GroupName="G" Text="YES" />
&nbsp;
                    <asp:RadioButton ID="rbtnNo" runat="server" GroupName="G" Text="NO" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="SUBMIT" Width="64px" />
                </td>
            </tr>
        </table>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
