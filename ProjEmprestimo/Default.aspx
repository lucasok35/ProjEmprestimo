<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjEmprestimo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Emprestimo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Cadastro de Emprestimo</h2>
        </div>
        <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
        :<br />
        <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblValor" runat="server" Text="Valor Empréstimo:"></asp:Label>
        <br />
        <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblData" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblJuros" runat="server" Text="Taxa de Juros:"></asp:Label>
        <br />
        <asp:TextBox ID="txtJuros" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblParcelas" runat="server" Text="Qtd Parcelas:"></asp:Label>
        <br />
        <asp:TextBox ID="txtParcelas" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        <br />
        <br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <br />
        <asp:GridView ID="gvEmprestimo" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="347px" OnSelectedIndexChanged="gvEmprestimo_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </form>
</body>
</html>
