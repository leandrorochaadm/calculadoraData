using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace data
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            DateTime dataAtual = DateTime.Now;
            int qtdDias = int.Parse(args[0]);
            String dataString;

            if (qtdDias == 0 & args.Length == 1){
                Clipboard.SetText(dataAtual.ToString("dd/MM/yyyy") + ", CONSULTA SPC OK");
            } else if (args.Length == 1)
            {
                dataString = dataAtual.AddDays(qtdDias).ToString("dd/MM/yyyy");
                Console.WriteLine("Data inicial: " + dataAtual.ToString("dd/MM/yyyy") + " somando " + qtdDias + " dias = "+ dataString);
                Clipboard.SetText(dataString);
                Console.ReadLine();
            } else if(args.Length > 1)
            {
                DateTime data1 = DateTime.Parse(args[1]).AddDays(qtdDias);
                DateTime data2 = DateTime.Parse(args[2]);

                dataString = (data1 - data2).ToString("ddd");
                Console.WriteLine("A diferença entre " + data1.ToString("dd/MM/yyyy") + " e " + data2.ToString("dd/MM/yyyy") + " é "+ dataString);
                Clipboard.SetText(dataString);
                Console.ReadLine();
            }                      
        }
    }
}
