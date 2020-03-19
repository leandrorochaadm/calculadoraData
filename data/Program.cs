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
            DateTime dataResultado = dataAtual.AddDays(int.Parse(args[0]));
            String dataString = dataResultado.ToString("dd/MM/yyyy");
            //Console.WriteLine("Numero digitado foi: " + args[0]);
            Console.WriteLine("Data atual: " + dataAtual.ToString("dd/MM/yyyy"));
            Clipboard.SetText(dataString);
            Console.WriteLine("Data resultado: " + dataString);
            Console.ReadLine();
        }
    }
}
