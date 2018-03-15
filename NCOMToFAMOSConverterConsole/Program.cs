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
            FAMOSConverter famos_converter = new FAMOSConverter(@"C:\Users\hhaider\Desktop\wup_data\_data_snippets\moving_off_from_stationary.ncom", 
                                                                @"C: \Users\hhaider\Desktop\output.dat");
            famos_converter.PrintFile();
        }
    }
}
