using System;

namespace UtariDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UtariDict<string, string> dict = new UtariDict<string, string>();

            dict.Add("nissan", "skyline");
            dict.Add("toyota", "trueno");
            dict.Add("honda", "civic");
            dict.Add("mazda", "miata");
            dict.Add("mitsubishi", "lancer");
            dict.Add("subaru", "impreza");
            dict.Print("toyota");
            dict.Print("subaru");
            dict.Print("honda");
            dict.Print();

        }
    }
}
