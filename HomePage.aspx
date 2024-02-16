<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="S3L5.HomePage" %>

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
            <h2 class="fw-bold my-3">Benvenuto!</h2>
            <div class="row">
                <asp:Repeater ID="rptProdotti" runat="server">
                    <ItemTemplate>
                        <div class="col-md-4 mb-3">
                            <div class="card">
                                <div class="card-body">
                                    <img src='<%# Eval("UrlImmagine") %>' class="card-img-top" alt='<%# Eval("Nome") %>' />
                                    <h5 class="card-title fw-bold mt-3"><%# Eval("Nome") %></h5>
                                    <p class="card-text"><%# Eval("Descrizione") %></p>
                                    <p class="card-text fw-bold">Prezzo: <%# Eval("Prezzo")%>€</p>
                                    <asp:Button ID="btnDettaglio" runat="server" class="btn btn-primary" Text="Dettagli" OnClick="btnDettaglio_Click" CommandArgument='<%# Eval("Id") %>' />
                                    <asp:Button ID="btnAggiungiAlCarrello" runat="server" class="btn btn-success" Text="Aggiungi al Carrello" OnClick="btnAggiungiAlCarrello_Click" CommandArgument='<%# Eval("Id") %>' />
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <asp:Button ID="btnVisualizzaCarrello" runat="server" CssClass="btn btn-warning mb-3 ms-3 py-2" Text="Visualizza Carrello" OnClick="btnVisualizzaCarrello_Click" />
            <div></div>
        </div>
    </form>
</body>
</html>
