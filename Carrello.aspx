<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="S3L5.Carrello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2 class="fw-bold">Carrello</h2>
            <table class="table">
                <thead>
                    <tr>
                        <th>Nome Prodotto</th>
                        <th>Prezzo</th>
                        <th>Elimina</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="rptCarrello" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td>
                                    <asp:HyperLink ID="lnkDettaglio" runat="server" Text='<%# Eval("Nome") %>' NavigateUrl='<%# "Dettaglio.aspx?id=" + Eval("Id") %>'></asp:HyperLink>
                                </td>
                                <td><%# Eval("Prezzo") %>€</td>
                                <td>
                                    <asp:Button ID="btnEliminaProdotto" runat="server" CssClass="btn btn-danger" Text="X" CommandName="EliminaProdotto" CommandArgument='<%# Eval("Id") %>' OnClick="btnEliminaProdotto_Click" />
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
            <div class="row">
                <div class="col">
                    <asp:Label ID="lblTotale" runat="server" Text="Totale: 0.00€" CssClass="fw-bold ms-2" />
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <asp:Button ID="btnTornaHomePage" runat="server" class="btn btn-primary mt-3" Text="Torna alla Home Page" OnClick="btnTornaHomePage_Click" />
                    <asp:Button ID="btnSvuotaCarrello" runat="server" class="btn btn-danger mt-3 me-2" Text="Svuota Carrello" OnClick="btnSvuotaCarrello_Click" />
                </div>
            </div>
        </div>

    </form>
</body>
</html>
