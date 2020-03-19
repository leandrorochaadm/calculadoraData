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
            DateTime dataAtual;

            if (args.Length > 1)
            {
                dataAtual = DateTime.Parse(args[1]);
            }
            else
            {
                dataAtual = DateTime.Now;
            }
            
            DateTime dataResultado = dataAtual.AddDays(int.Parse(args[0]));
            String dataString = dataResultado.ToString("dd/MM/yyyy");
            //Console.WriteLine("Numero digitado foi: " + args[0]);
            Console.WriteLine("Data inicial: " + dataAtual.ToString("dd/MM/yyyy")+" somando "+args[0]+" dias");
            Clipboard.SetText(dataString);
            Console.WriteLine("Data resultado: " + dataString);
            Console.ReadLine();
            
        }
    }
}
