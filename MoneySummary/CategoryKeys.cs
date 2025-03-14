using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MoneySummary
{
    public class CategoryKeys
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Category Category { get; set; }
        public List<string> Keys { get; set; }

        public CategoryKeys(Category category, List<string> keys)
        {
            Category = category;
            Keys = keys;
        }

        static public List<CategoryKeys> InitKeys()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "keys.json");

            // Sprawdź, czy plik istnieje
            if (File.Exists(filePath))
            {
                try
                {

                // Odczytaj zawartość pliku
                    string fileContents = File.ReadAllText(filePath);
                    return JsonSerializer.Deserialize<List<CategoryKeys>>(fileContents);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Plik keys.json nie istnieje.");
            }
            return new();
            //[
            //    new(Category.OPLATY_STALE, new() {"NR 1027170010019615", "OPŁATA ZA TELEFON", "RATA PODATKU OD NIERUCHOMOŚCI", "Spłata kredytu", "OPŁATA EKSPLOATACYJNA", "SKŁADKA ZA UBEZPIECZENIE", "ebok.gkpge", "PGE OBRÓT", "ORANGE POLSKA", "CZYNSZ", "PKO TOWARZYSTWO UBEZPIECZEŃ" }),
            //    new(Category.ZAKUPY_SPOZYWCZE, new() { "BIEDRONKA", "STOKROTKA", "AUCHAN", "LIDL", "ALDI", "CUKIERNIA WILLIAMS" }),
            //    new(Category.PAYPO, new() { "paypo", "envoyservices" }),
            //    new(Category.PAPIEROSY, new() { "CHIC", "inspirationclub.pl" }),
            //    new(Category.PALIWO, new() { "BP-SAFARI", "ORLEN", " BP ", "CIRCLE", "BLISKA DOFO", "BP-KOZIOLEK" }),
            //    new(Category.ZAKUPY_INTERNETOWE, new() { "allegro", "Allegro", "PAYPAL", "agataimedia.pl", "www.temu.com", "seohost.pl", "www.aliexpress.com", "botland.com.pl", "olx.pl" }),
            //    new(Category.APLIKACJE_MOBILNE_APPLE, new() { "APPLE.COM", "Adobe.com", "VIRALFINDR", "MANYCHAT.COM", "Adobe" }),
            //    new(Category.APLIKACJE_MOBILNE, new() { "SPOTIFY", "Netflix.com", "lotto.pl", "Google Payment" }),
            //    new(Category.SZYBKIE_ZAKUPY_ZABKA, new() { "ZABKA" }),
            //    new(Category.FASTFOOD, new() { "SLIMAK-BIS", "glovoapp", "McDonalds", "dominospizza.pl", "SUENO", "JEDZENIE", "Phuc", "pyszne.pl" }),
            //    new(Category.TRANSPORT, new() { "ZAKUP BILETU KOMUNIKACYJNEGO", "MPK LUBLIN", "WIERCINSKI DARIUS95286", "WALECKI KRZYSZTOF95762", "TOMASZ LIMEK", "ZAROBKOWY PRZEWOZ95488", "BEDNARCZYK EUGENI95760", "ANTONIUK JANUSZ", "SumUp", "TAXI", "TAKSOWKA", "PAWEL CHMIELEWSKI", "TAKSOWKA OSOBOWA", "KNAP GRZEGORZ", "CPG Services Miasto", "LESZEK DUDA" }),
            //    new(Category.ZDROWIE_HIGIENA, new() { "starsfromthestars.pl", "aromama.pl", "ROSSMANN", "STYLIZACJA", "SNARSKA MAGDALENA", "DAY SPA NATALIA WYSZYNSKA", "mk.marykayintouch.pl", "KOSMETYKI","sklepanwen.pl", "myhairtip.com", "J. R. MANICURE&PEDICURE", "www.hebe.pl" }),
            //    new(Category.UBRANIA, new() { " HM ", "SMYK", "vinted", "sinsay", "hm.com", "ZARA" }),
            //    new(Category.PREZENTY, new() { "PREZENT", "EMPIK" }),
            //    new(Category.SAMOCHOD, new() { "WIERZCHO GARAGE O.S.K.P", "CARRARA", "DACIA", "MYJNIA SAMOLUB", "Policja" }),
            //    new(Category.LEKARZ, new() { "ZIKO", "gemini.pl", "receptomat", "SAME DOBRE APTEKI ESKUL", "APTEKA", "phdoctorlab", "pharm", "znanarecepta.pl" }),
            //    new(Category.DOM, new() { "Leroy Merlin", "IKEA", "winkhaus", "HOMLA", "JYSK", "blanda", "cleangang", "klaudiaorganizuje", "raypath", "DPD", "euro.com.pl", "123drukuj.pl", "RTVEUROAGD" }),
            //    new(Category.PRZYJEMNOSCI, new() {"JASKINIA SOLNA", "www.cinema-city.pl", "CINEMA CITY" }),
            //    new(Category.ZABAWKI, new() { "bajkisklep", "EU.LOVEVERY.COM", "rozwojowymaluch", "babystuff", "sklep.lecibocian", "inwiktoria", "kidsinspirations.pl" }),
            //    new(Category.BANKOMAT, new() { "bankomat", "Wypłata w bankomacie"}),
            //    new(Category.LOKATY, new() { "OTWARCIE LOKATY"}),
            //    new(Category.PRZELEW_WEW, new() { "MATEUSZ BŁASZCZAK", "MAGDALENA BŁASZCZAK", "Z Z Z" }),
            //    new(Category.ROZWOJ, new() { "agataimedia.pl", "perfect-plann.shoplo.com", "ekspertkiwbiznesie.pl", "PHU DAMEX" }),
            //    new(Category.DZIALALNOSC, new() { "SKLADKA ZDROWOTNA", "FAKTURA NR", "FAKTURA F"}),
            //    new(Category.INNE, new()),
            //];
        }




    }
}
