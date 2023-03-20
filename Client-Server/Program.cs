namespace Client_Server {
    internal class Program {
        static void Main(string[] args) {
            Client browser = new Client();
            Server internet = new Server();
            browser.ShowMePage(internet.Start());
        }
    }
}