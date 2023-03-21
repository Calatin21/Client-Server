namespace Client_Server {
    internal class Client {
        WebPage wp;
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
