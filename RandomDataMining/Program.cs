using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataMining
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] DiaSemana = new string[] { "Segunda", "Terca", "Quarta", "Quinta", "Sexta", "Sabado", "Domingo" };
            string[] RedesSocias = new string[] { "FaceBook", "WhatsApp", "Instagram", "Snap", "Skype", "Hangouts" };
            string[] Stream = new string[] { "NetFlix", "YouTube", "Jornal Online" };
            string[] Web = new string[] { "Noticias", "Humor", "Assuntos Aleatorios" };
            string[] Localizacao = new string[] { "Bairro Feliz", "Vila Nova", "Negrao de Lima", "Samambaia", "Bueno", "Marista", "Central" };
            string[] QualidadeDoSinal = new string[] { "Otimo", "Bom", "Satisfatorio", "Ruim", "Pessimo", "Inexistente"};
            string[] Bateria = new string[] { "0-10", "10-20", "20-30", "30-40", "40-50", "50-60", "60-70", "70-80", "80-90", "90-100", };
            string[] Horario = new string[] { "7:00-8:00", "8:00-9:00", "9:00-10:00", "10:00-11:00", "11:00-12:00", "12:00-13:00", "13:00-14:00", "14:00-15:00", "15:00-16:00", "16:00-17:00", "17:00-18:00", "18:00-19:00", "19:00-20:00", "20:00-21:00", "21:00-22:00", "22:00-23:00", "23:00-00:00", };

            string[] transacao = new string[1000] ;
            for (int i = 0; i < 1000; i++)
            {
                string newTransacao = string.Empty;

                int rnd = random.Next(0, DiaSemana.Length);
                newTransacao += DiaSemana[rnd];

                newTransacao += ",";

                rnd = random.Next(0, Horario.Length);
                newTransacao += Horario[rnd];

                newTransacao += ",";

                rnd = random.Next(0, Localizacao.Length);
                newTransacao += Localizacao[rnd];

                newTransacao += ",";


                rnd = random.Next(0, QualidadeDoSinal.Length);
                newTransacao += QualidadeDoSinal[rnd];

                newTransacao += ",";

                rnd = random.Next(0, Bateria.Length);
                newTransacao += Bateria[rnd];

                newTransacao += ",";

                
                for (int n = 0; n < 3; n++)
                {
                    int rede = random.Next(0, RedesSocias.Length);
                    string s = RedesSocias[rede];
                    newTransacao += s;
                    newTransacao += ",";
                }

                for (int n = 0; n < 3; n++)
                {
                    int rede = random.Next(0, Stream.Length);
                    string s = Stream[rede];
                    newTransacao += s;
                    newTransacao += ",";
                }

                for (int n = 0; n < 3; n++)
                {
                    int rede = random.Next(0, Web.Length);
                    string s = Web[rede];
                    newTransacao += s;
                    newTransacao += ",";
                }

                transacao[i] = newTransacao;
            }
            
            Console.ReadKey();
        }
    }
}
