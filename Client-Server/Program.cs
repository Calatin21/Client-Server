namespace Client_Server {
    internal class Program {
        static void Main(string[] args) {
            Client browser = new();
            Server internet = new();
            WebPage google = new("google.de", "Suche...", new List<String>());
            WebPage yahoo = new("yahoo.de", "Suche...", new List<String>());
            WebPage bitlc = new("BITLC.de", "Umschulung...", new List<String>());
            WebPage error = new("404", "ERROR...", new List<String>());
            WebPage wiki = new("wikipedia.org", "Wissen...", new List<String>());
            internet.AddPage(wiki);
            internet.AddPage(google);
            internet.AddPage(yahoo);
            internet.AddPage(bitlc);
            internet.AddPage(error);
            browser.LoadPage(internet.Start());
            browser.ShowMePage();
            browser.ChangePage("google.de", internet);
            browser.ShowMePage();
            browser.ChangePage("yahoo.de", internet);
            browser.ShowMePage();
            bool bedingung = true;
            while (bedingung) {
                Console.Write("Auf welche Seite wollen sie surfen? (\"exit\" zum beenden & \"list\" um alle Webseiten anzuzeigen) :");
                string antwort = Console.ReadLine();
                if (antwort == "exit") {
                    bedingung = false;
                }
                else if (antwort == "list") {
                    internet.GetWebpageKennung();
                }
                else if (antwort != null) {
                    browser.ChangePage(antwort, internet);
                    browser.ShowMePage();
                }
                else {
                    Console.WriteLine("Bitte eine Antwort eingeben");
                }
            }
        }
    }
}