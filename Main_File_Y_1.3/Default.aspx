<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#ccccff">
    <form id="form1" runat="server">
    <h4 style="color: #800080"> Employee Search Directory Created by Vithal wadje for C# corner</h4>
     <div>
        <table class="style1">
            <tr>
                <td class="style3" style="color: #800000; font-size: large;">
                Search</td>
                <td class="style2">
                 <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                 </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Go" onclick="Button1_Click" />
                </td>
            </tr>
           
        </table>
    <p> 
        <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="Maroon"></asp:Label></p>
    </div>
    <div>
     <asp:GridView ID="GridView1" runat="server"  BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" CellSpacing="2" Height="90px" Width="260px" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
         <Columns>
             <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
             <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
             <asp:BoundField DataField="psw" HeaderText="psw" SortExpression="psw" />
             <asp:BoundField DataField="file_id" HeaderText="file_id" SortExpression="file_id" />
         </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
      <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" /> 

        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:webConnectionString %>" ProviderName="<%$ ConnectionStrings:webConnectionString.ProviderName %>" SelectCommand="SELECT kullanici.* FROM kullanici"></asp:SqlDataSource>

    </div>
    </form>
</body>
</html>
