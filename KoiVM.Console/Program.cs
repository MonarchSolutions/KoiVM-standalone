using dnlib.DotNet;
using KVM;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace KoiVM.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                ExceuteKoi(@args[0], @args[1], "", null);
            }
            if (args.Length == 3)
            {
                ExceuteKoi(@args[0], @args[1], args[2], null);
            }
            if (args.Length == 4)
            {
                ExceuteKoi(@args[0], @args[1], args[2], args[3]);
            }

            Process.GetCurrentProcess().Kill();
        }

       private static void ExceuteKoi(String input, string outPath, string snPath, string snPass)
        {
            try
            {
                new KVMTask().Exceute(ModuleDefMD.Load(input), outPath, snPath, snPass);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }
    }
}
