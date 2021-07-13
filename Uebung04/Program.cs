using System;

namespace Uebung04
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer mainComputer = new Computer();

            //1)
            mainComputer.switchUser("Baldur");

            //2)
            /*
            int i = 0;
            do
            {
                try
                {
                    mainComputer.saveFile($"file{i++}.txt");
                }
                catch (System.InvalidOperationException)
                {
                    mainComputer.reboot();
                }
            }
            while(true);
            */

            //3)
            /*
            Console.WriteLine(IPTools.IPToString(IPTools.Localhost));
            Console.WriteLine(IPTools.IPToString(IPTools.IPToArray("192.168.0.1")));
            Console.WriteLine(IPTools.IPToString(IPTools.IPToArray("ffee:ddcc:bbaa:9988:7766:5544:3322:1100")));
            */

            //4)
            /*
            Blu_Ray br1, br2;
            mainComputer.burn("Absatz von Smartphones", 
                "173.5, 304.7, 494.5, 725.3, 1019.4, 1301.7, 1437.6, 1469, 1465.5, 1402.6, 1372.6, 1280", out br1);
            mainComputer.burn("Impfbereitschaft", "7, 6, 11, 75", out br2);
            Console.WriteLine($"ID: {br1.id}\nName: {br1.name}\nContent: {br1.content}");
            Console.WriteLine($"ID: {br2.id}\nName: {br2.name}\nContent: {br2.content}");
            */

            //5)
            mainComputer.print();
        }
    }
}
