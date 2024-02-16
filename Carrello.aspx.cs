using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using S3L5.Models;

namespace S3L5
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["add"] != null)
                {
                    int idProdotto = Convert.ToInt32(Request.QueryString["add"]);
                    Articolo prodotto = Prodotti.GetProdottoById(idProdotto);
                    AggiungiAlCarrello(prodotto);
                }
                MostraCarrello();
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
        private void MostraCarrello()
        {
            List<Articolo> carrello = Session["Carrello"] as List<Articolo>;
            rptCarrello.DataSource = carrello;
            rptCarrello.DataBind();

            double totale = 0;
            if (carrello != null)
            {
                totale = carrello.Sum(p => p.Prezzo);
            }
            lblTotale.Text = $"Totale: {totale.ToString("0.00")}€";
        }

        protected void btnEliminaProdotto_Click(object sender, EventArgs e)
        {
            Button btnEliminaProdotto = (Button)sender;
            int idProdotto = Convert.ToInt32(btnEliminaProdotto.CommandArgument);

            List<Articolo> carrello = Session["Carrello"] as List<Articolo>;
            if (carrello != null)
            {
                carrello.RemoveAll(p => p.Id == idProdotto);
                Session["Carrello"] = carrello;

                MostraCarrello();
            }
        }

        protected void btnTornaHomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void btnSvuotaCarrello_Click(object sender, EventArgs e)
        {
            Session["Carrello"] = null;
            MostraCarrello();
        }
    }
}