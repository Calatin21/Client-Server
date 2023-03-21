namespace Client_Server {
    internal class Server {
        List<WebPage> webPages = new List<WebPage>();
        public Server() {
            List<String> startGraphics = new List<String>();
            startGraphics.Add("Bild1");
            webPages.Add(new WebPage("Start.de", "Start blabla", startGraphics));
        }
        public void AddPage(WebPage wp) {
            webPages.Add(wp);
        }
        public void RemovePage(WebPage wp) {
            webPages.Remove(wp);
        }
        public WebPage Start() {
            return webPages.First();
        }
        public void GetWebpageKennung() {
            foreach (WebPage i in webPages) {
                Console.WriteLine(i.GetKennung());
            }
        }
        public WebPage SearchPage(String kennung) {
            WebPage wp = new();
            foreach (WebPage i in webPages) {
                if (i.GetKennung() == kennung) {
                    wp = i;
                }
            }
            return wp;
        }
    }
}
