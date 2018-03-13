using NCOMToFAMOSConverterCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCOMToFAMOSConverterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            FAMOSConverter famos_converter = new FAMOSConverter(@"C: \Users\hhaider\Desktop\output.dat");
            famos_converter.PrintFile();
        }
    }
}
