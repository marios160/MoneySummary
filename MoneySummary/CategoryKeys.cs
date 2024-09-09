using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
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
                new(Category.OPLATY_STALE, new() {"NR 1027170010019615", "OPŁATA ZA TELEFON", "RATA PODATKU OD NIERUCHOMOŚCI", "Spłata kredytu", "OPŁATA EKSPLOATACYJNA", "SKŁADKA ZA UBEZPIECZENIE", "ebok.gkpge", "PGE OBRÓT", "ORANGE POLSKA", "CZYNSZ", "PKO TOWARZYSTWO UBEZPIECZEŃ" }),
                new(Category.ZAKUPY_SPOZYWCZE, new() { "BIEDRONKA", "STOKROTKA", "AUCHAN", "LIDL", "ALDI", "Phuc" }),
                new(Category.PAYPO, new() { "paypo", "envoyservices" }),
                new(Category.PAPIEROSY, new() { "CHIC" }),
                new(Category.PALIWO, new() { "BP-SAFARI", "ORLEN", " BP ", "CIRCLE", "BLISKA DOFO", "BP-KOZIOLEK" }),
                new(Category.ZAKUPY_INTERNETOWE, new() { "allegro", "Allegro", "PAYPAL", "agataimedia.pl", "www.temu.com", "seohost.pl" }),
                new(Category.APLIKACJE_MOBILNE_APPLE, new() { "APPLE.COM", "Adobe.com", "VIRALFINDR", "MANYCHAT.COM", "Adobe" }),
                new(Category.APLIKACJE_MOBILNE, new() { "SPOTIFY", "Netflix.com", "lotto.pl", "Google Payment" }),
                new(Category.SZYBKIE_ZAKUPY_ZABKA, new() { "ZABKA" }),
                new(Category.FASTFOOD, new() { "SLIMAK-BIS", "glovoapp", "McDonalds", "dominospizza.pl", "SUENO" }),
                new(Category.TRANSPORT, new() { "ZAKUP BILETU KOMUNIKACYJNEGO", "MPK LUBLIN", "WIERCINSKI DARIUS95286", "WALECKI KRZYSZTOF95762", "TOMASZ LIMEK", "ZAROBKOWY PRZEWOZ95488", "BEDNARCZYK EUGENI95760", "ANTONIUK JANUSZ", "SumUp", "TAXI", "TAKSOWKA", "PAWEL CHMIELEWSKI", "TAKSOWKA OSOBOWA", "KNAP GRZEGORZ", "CPG Services Miasto", "LESZEK DUDA" }),
                new(Category.ZDROWIE_HIGIENA, new() { "ROSSMANN", "STYLIZACJA", "SNARSKA MAGDALENA", "DAY SPA NATALIA WYSZYNSKA", "mk.marykayintouch.pl", "KOSMETYKI","sklepanwen.pl", "myhairtip.com", "J. R. MANICURE&PEDICURE" }),
                new(Category.UBRANIA, new() { " HM ", "SMYK", "vinted", "sinsay", "hm.com", "ZARA" }),
                new(Category.PREZENTY, new() { "PREZENT", "EMPIK" }),
                new(Category.SAMOCHOD, new() { "WIERZCHO GARAGE O.S.K.P", "CARRARA", "DACIA", "MYJNIA SAMOLUB", "Policja" }),
                new(Category.LEKARZ, new() { "ZIKO", "gemini.pl", "receptomat", "SAME DOBRE APTEKI ESKUL", "APTEKA", "phdoctorlab", "pharm", "znanarecepta.pl" }),
                new(Category.DOM, new() { "Leroy Merlin", "IKEA", "winkhaus", "HOMLA", "JYSK", "blanda", "cleangang", "klaudiaorganizuje", "raypath", "DPD", "euro.com.pl", "123drukuj.pl", "RTVEUROAGD" }),
                new(Category.PRZYJEMNOSCI, new() { "www.cinema-city.pl", "CINEMA CITY" }),
                new(Category.ZABAWKI, new() { "bajkisklep", "EU.LOVEVERY.COM", "rozwojowymaluch", "babystuff", "sklep.lecibocian", "inwiktoria", "kidsinspirations.pl" }),
                new(Category.BANKOMAT, new() { "bankomat", "Wypłata w bankomacie"}),
                new(Category.LOKATY, new() { "OTWARCIE LOKATY"}),
                new(Category.PRZELEW_WEW, new() { "MATEUSZ BŁASZCZAK", "MAGDALENA BŁASZCZAK", "Z Z Z" }),
                new(Category.ROZWOJ, new() { "agataimedia.pl", "perfect-plann.shoplo.com", "ekspertkiwbiznesie.pl", "PHU DAMEX" }),
                new(Category.DZIALALNOSC, new() { "SKLADKA ZDROWOTNA", "FAKTURA NR", }),
                new(Category.INNE, new()),
            ];
        }




    }
}
