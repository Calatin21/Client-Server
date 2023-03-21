namespace Client_Server {
    internal class Client {
        WebPage wp = new();
        public Client(Server serv) {
            this.LoadPage(serv.SearchPage("Start.de"));
            this.ShowMePage();
        }
        public Client(Server serv, String str) {
            this.LoadPage(serv.SearchPage(str));
            this.ShowMePage();
        }
        public void LoadPage(WebPage wp) {
            this.wp = wp;
        }
        public void ShowMePage() {
            Console.WriteLine("URL: " + wp.GetKennung());
            Console.WriteLine("Inhalt: " + wp.GetPage());
            Console.WriteLine("Bilder: " + wp.GetBilder());
        }
        public void ChangePage(String str, Server srv) {
            this.LoadPage(srv.SearchPage(str));
        }
    }
}
