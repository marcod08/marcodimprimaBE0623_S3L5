using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S3L5.Models;

namespace S3L5
{
    public partial class Dettaglio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int idProdotto = Convert.ToInt32(Request.QueryString["id"]);
                    Articolo prodotto = Prodotti.GetProdottoById(idProdotto);
                    MostraDettagliProdotto(prodotto);
                }
                else
                {
                    Response.Redirect("HomePage.aspx");
                }
            }
        }
        private void MostraDettagliProdotto(Articolo prodotto)
        {
            lblNomeProdotto.Text = prodotto.Nome;
            lblDescrizione.Text = prodotto.Descrizione;
            lblPrezzo.Text = $"{prodotto.Prezzo.ToString("0.00")}€";

            imgProdotto.ImageUrl = prodotto.UrlImmagine;
        }

        protected void btnTornaHomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void btnAggiungiAlCarrello_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                int idProdotto = Convert.ToInt32(Request.QueryString["id"]);
                Articolo prodotto = Prodotti.GetProdottoById(idProdotto);
                AggiungiAlCarrello(prodotto);
            }
        }
        private void AggiungiAlCarrello(Articolo prodotto)
        {
            List<Articolo> carrello = Session["Carrello"] as List<Articolo>;
            if (carrello == null)
            {
                carrello = new List<Articolo>();
            }
            carrello.Add(prodotto);
            Session["Carrello"] = carrello;
        }

    }
}
