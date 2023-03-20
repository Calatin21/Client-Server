namespace Client_Server {
    internal class Program {
        static void Main(string[] args) {
            Client browser = new Client();
            Server internet = new Server();
            WebPage google = new WebPage("google.de", "Suche...", new List<String>());
            WebPage yahoo = new WebPage("yahoo.de", "Suche...", new List<String>());
            WebPage bitlc = new WebPage("BITLC.de", "Umschulung...", new List<String>());
            internet.AddPage(google);
            internet.AddPage(yahoo);
            internet.AddPage(bitlc);
            browser.LoadPage(internet.Start());
            browser.ShowMePage();
            browser.ChangePage("google.de", internet);
            browser.ShowMePage();
            browser.ChangePage("yahoo.de", internet);
            browser.ShowMePage();

        }
    }
}