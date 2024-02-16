<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dettaglio.aspx.cs" Inherits="S3L5.Dettaglio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-3">
            <h2 class="fw-bold">Dettagli Prodotto</h2>
            <asp:Image ID="imgProdotto" runat="server" CssClass="img-fluid rounded my-3" style="width: 13em; height: auto;" />
            <div class="row">
                <div class="col-md-6">
                    <table class="table">
                        <tbody>
                            <tr>
                                <th scope="row">Nome Prodotto</th>
                                <td>
                                    <asp:Label ID="lblNomeProdotto" runat="server" /></td>
                            </tr>
                            <tr>
                                <th scope="row">Descrizione</th>
                                <td>
                                    <asp:Label ID="lblDescrizione" runat="server" /></td>
                            </tr>
                            <tr>
                                <th scope="row">Prezzo</th>
                                <td>
                                    <asp:Label ID="lblPrezzo" runat="server" /></td>
                            </tr>
                        </tbody>
                    </table>
                    <asp:Button ID="btnTornaHomePage" runat="server" class="btn btn-primary mt-2" Text="Torna alla Home Page" OnClick="btnTornaHomePage_Click" />
                    <asp:Button ID="btnAggiungiAlCarrello" runat="server" class="btn btn-success mt-2" Text="Aggiungi al Carrello" OnClick="btnAggiungiAlCarrello_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
