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
                int x = 1;
            foreach (WebPage i in webPages) {                
                Console.WriteLine(x+". "+i.GetKennung());
                x++;
            }
        }
        public WebPage SearchPage(String kennung) {
            WebPage ergebnis = null;
            foreach (WebPage i in webPages) {
                if (i.GetKennung() == kennung) {
                    ergebnis = i;
                    break;
                }
                else {                   
                    ergebnis = new("Fehler 404", "Seite nicht gefunden...", new List<String>());
                }
            }
            return ergebnis;
        }
    }
}
