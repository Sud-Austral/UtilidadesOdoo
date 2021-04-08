using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace AplicacionBlanco.Models
{
    public class Util
    {
        public static List<string> ListaObtenerTexto(string url)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string s = "Comuna,Cuposáé";
            using (WebClient client = new WebClient())
            {
                //s = client.DownloadString("https://raw.githubusercontent.com/Sud-Austral/MPG/main/Datos/10agricultura_y_ganaderia/1001agricultura/100112hortalizas/100112015calabaza/test_caracteres.csv");
                s = client.DownloadString(url);  
            }
            List<string> listaTextoP = s.Split(new[] { "\n" },
                                            StringSplitOptions.RemoveEmptyEntries).ToList();
            return listaTextoP;
        }

        public static string ObtenerTexto(string url)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string s = "Comuna,Cuposáé";
            using (WebClient client = new WebClient())
            {
                //s = client.DownloadString("https://raw.githubusercontent.com/Sud-Austral/MPG/main/Datos/10agricultura_y_ganaderia/1001agricultura/100112hortalizas/100112015calabaza/test_caracteres.csv");
                s = client.DownloadString(url);
            }
            byte[] bytes = Encoding.Default.GetBytes(s);
            s = Encoding.UTF8.GetString(bytes);
            return s;
        }


    }
}