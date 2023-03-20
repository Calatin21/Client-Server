using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Server {
    internal class Client {
        public void ShowMePage(WebPage wp) {
            Console.WriteLine("URL: "+wp.GetKennung());
            Console.WriteLine("Inhalt: "+wp.GetPage());
            Console.WriteLine("Bilder: "+wp.GetBilder());
        }
        public void ChangePage(String s) {

        }
    }
}
