namespace Client_Server {
    internal class WebPage {
        String kennung;
        String page;
        List<String> graphicFiles = new();
        public WebPage() {

        }
        public WebPage(String kennung, String page, List<String> graphicFiles) {
            this.kennung = kennung;
            this.page = page;
            this.graphicFiles = graphicFiles;
        }
        public String GetKennung() {
            return kennung;
        }
        public void SetKennung(String s) {
            kennung = s;
        }
        public String GetPage() {
            return page;
        }
        public void SetPage(String s) {
            page = s;
        }
        public String GetBilder() {
            String s = "";
            foreach (String i in graphicFiles) {
                s += i;
            }
            return s;
        }
        public void AddBild(String s) {
            graphicFiles.Add(s);
        }
    }
}
