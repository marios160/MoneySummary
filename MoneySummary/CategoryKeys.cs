using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySummary
{
    public class CategoryKeys
    {
        public Category Category { get; set; }
        public List<string> Keys { get; set; }

        public CategoryKeys(Category category, List<string> keys)
        {
            Category = category;
            Keys = keys;
        }

        static public List<CategoryKeys> InitKeys()
        {
            return
            [
                new(Category.OPLATY_STALE, new() { "Spłata kredytu", "OPŁATA EKSPLOATACYJNA", "SKŁADKA ZA UBEZPIECZENIE", "ebok.gkpge", "PGE OBRÓT", "ORANGE POLSKA", "CZYNSZ" }),
                new(Category.ZAKUPY_SPOZYWCZE, new() { "BIEDRONKA", "STOKROTKA", "AUCHAN", "LIDL", "ALDI" }),
                new(Category.PAYPO, new() { "paypo", "envoyservices" }),
                new(Category.PAPIEROSY, new() { "CHIC" }),
                new(Category.PALIWO, new() { "ORLEN", " BP ", "CIRCLE", "BLISKA DOFO", "BP-KOZIOLEK" }),
                new(Category.ZAKUPY_INTERNETOWE, new() { "allegro", "Allegro", "PAYPAL" }),
                new(Category.APLIKACJE_MOBILNE_APPLE, new() { "APPLE.COM" }),
                new(Category.APLIKACJE_MOBILNE, new() { "SPOTIFY", "Netflix.com" }),
                new(Category.SZYBKIE_ZAKUPY_ZABKA, new() { "ZABKA" }),
                new(Category.FASTFOOD, new() { "SLIMAK-BIS", "glovoapp" }),
                new(Category.TRANSPORT, new() { "WALECKI KRZYSZTOF95762", "TOMASZ LIMEK", "ZAROBKOWY PRZEWOZ95488", "BEDNARCZYK EUGENI95760", "ANTONIUK JANUSZ", "SumUp", "TAXI", "TAKSOWKA", "PAWEL CHMIELEWSKI", "TAKSOWKA OSOBOWA", "KNAP GRZEGORZ", "CPG Services Miasto", "LESZEK DUDA" }),
                new(Category.ZDROWIE_HIGIENA, new() { "ROSSMANN", "STYLIZACJA", "SNARSKA MAGDALENA" }),
                new(Category.UBRANIA, new() { " HM ", "SMYK", "vinted", "sinsay", "hm.com" }),
                new(Category.PREZENTY, new() { "PREZENT" }),
                new(Category.SAMOCHOD, new() { "WIERZCHO GARAGE O.S.K.P", "CARRARA", "DACIA" }),
                new(Category.LEKARZ, new() { "ZIKO", "gemini.pl", "receptomat", "SAME DOBRE APTEKI ESKUL", "APTEKA", "phdoctorlab", "pharm" }),
                new(Category.DOM, new() { "Leroy Merlin", "IKEA", "winkhaus", "HOMLA", "JYSK", "blanda", "cleangang", "klaudiaorganizuje" }),
                new(Category.PRZYJEMNOSCI, new() { "www.cinema-city.pl", "CINEMA CITY" }),
                new(Category.ZABAWKI, new() { "bajkisklep", "EU.LOVEVERY.COM", "rozwojowymaluch", "babystuff", "sklep.lecibocian", "inwiktoria" }),
                new(Category.BANKOMAT, new() { "bankomat"}),
                new(Category.LOKATY, new() { "OTWARCIE LOKATY"}),
                new(Category.INNE, new()),

            ];


        }




    }
}
