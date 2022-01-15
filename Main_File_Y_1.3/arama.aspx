<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="arama.aspx.cs" Inherits="yazlab1_3.v._1.arama" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
<asp:GridView ID="GridView1" runat="server" Caption="Excel Files " 
        CaptionAlign="Top" HorizontalAlign="Justify" onselectedindexchanged="GridView1_SelectedIndexChanged" 
        ToolTip="Excel FIle DownLoad Tool" CellPadding="4" ForeColor="#333333" 
        GridLines="None" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="351px" DataKeyNames="id">
        <RowStyle BackColor="#E3EAEB" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="Gray" Font-Bold="True" ForeColor="White" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" InsertVisible="False" ReadOnly="True" />
            <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
            <asp:BoundField DataField="psw" HeaderText="psw" SortExpression="psw" />
            <asp:BoundField DataField="file_id" HeaderText="file_id" SortExpression="file_id" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView> 
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:webConnectionString_web %>" ProviderName="<%$ ConnectionStrings:webConnectionString_web.ProviderName %>" SelectCommand="SELECT kullanici.* FROM kullanici"></asp:SqlDataSource>
    </form>
</body>
</html>
