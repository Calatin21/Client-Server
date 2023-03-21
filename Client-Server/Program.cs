namespace Client_Server {
    internal class Program {
        static void Main(string[] args) {
            Client browser = new();
            Server internet = new();
            WebPage google = new("google.de", "Suche...", new List<String>());
            WebPage yahoo = new("yahoo.de", "Suche...", new List<String>());
            WebPage bitlc = new("BITLC.de", "Umschulung...", new List<String>());
            internet.AddPage(google);
            internet.AddPage(yahoo);
            internet.AddPage(bitlc);
            browser.LoadPage(internet.Start());
            browser.ShowMePage();
            browser.ChangePage("google.de", internet);
            browser.ShowMePage();
            browser.ChangePage("yahoo.de", internet);
            browser.ShowMePage();
            bool bedingung = true;
            while (bedingung) {
                Console.Write("Auf welche Seite wollen sie surfen? (\"exit\" zum beenden) :");
                string antwort = Console.ReadLine();
                if (antwort == "exit") {
                    bedingung = false;
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