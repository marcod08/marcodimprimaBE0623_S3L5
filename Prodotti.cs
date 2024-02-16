using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace S3L5.Models
{
    public class Prodotti
    {
        
        public static List<Articolo> GetProdotti()
        {
            return new List<Articolo>
            {
                new Articolo { Id = 1, Nome = "iPhone 13 Pro Max", Descrizione = "Ultimo modello di smartphone di Apple con un potente chip A15 Bionic, un sistema di telecamere Pro e un bellissimo display Super Retina XDR.", Prezzo = 1199.99, UrlImmagine = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/refurb-iphone-13-pro-max-silver-2023?wid=1144&hei=1144&fmt=jpeg&qlt=90&.v=1679072987085" },
                new Articolo { Id = 2, Nome = "Samsung Galaxy S22 Ultra", Descrizione = "Top di gamma di Samsung con una fotocamera eccezionale, uno stilo S Pen integrato e un grande display AMOLED da 6.8 pollici.", Prezzo = 1279.99, UrlImmagine = "https://ae01.alicdn.com/kf/Sba6dd4cd1ddf4d00a0906b0c5ff7cfc7M/Samsung-Galaxy-S22-Ultra-5G-S908E-DS-Dual-Sim-RAM-8-12GB-128-256-512GB-ROM.jpg" },
                new Articolo { Id = 3, Nome = "Google Pixel 6 Pro", Descrizione = "Smartphone con un design unico e una potente intelligenza artificiale. Offre una fotocamera eccellente e una batteria di lunga durata.", Prezzo = 899.99, UrlImmagine = "https://www.zdnet.com/a/img/resize/d67d91282bde4701e874a1f8eccfc513b4c3fb3a/2021/10/19/6ba6c306-d808-45c2-936f-5662b42b1305/google-pixel-6-and-6-pro-1.jpg?auto=webp&fit=crop&height=1200&width=1200" },
                new Articolo { Id = 4, Nome = "OnePlus 10 Pro", Descrizione = "Smartphone performante con un design elegante e un sistema di ricarica rapida. Offre un ottimo rapporto qualità-prezzo.", Prezzo = 919.99, UrlImmagine = "https://oasis.opstatics.com/content/dam/oasis/page/2022/operation/mar/0317/EU-IN_Green.png" },
                new Articolo { Id = 5, Nome = "Xiaomi 12S Ultra", Descrizione = "Smartphone con una fotocamera co-sviluppata con Leica e un potente chip Snapdragon 8+ Gen 1. Offre un'esperienza di imaging eccezionale.", Prezzo = 1199.99, UrlImmagine = "https://i.ebayimg.com/images/g/pCcAAOSw8xFizC~O/s-l1200.jpg" },
                new Articolo { Id = 6, Nome = "OPPO Find X5 Pro", Descrizione = "Smartphone con un design ceramico premium e un sistema di fotocamere Hasselblad. Offre un'esperienza di imaging di alta qualità.", Prezzo = 1299.99, UrlImmagine = "https://m.media-amazon.com/images/I/71cYNFfq88L.jpg" },
               };
        }

        public static Articolo GetProdottoById(int id)
        {
            List<Articolo> prodotti = GetProdotti();
            return prodotti.FirstOrDefault(p => p.Id == id);
        }
    }
    public class Articolo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public string UrlImmagine { get; set; }
    }

}
