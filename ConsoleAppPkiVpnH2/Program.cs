using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPkiVpnH2
{
    class Program
    {
        static void Main(string[] args)
        {
            VigenCipherEncryption encryption = new VigenCipherEncryption();
            ConvertingTool convert = new ConvertingTool();


            Console.Write("enter you´re text: ");
            string ursText = Console.ReadLine();
            Console.Write("enter you´re Key: ");
            string ursKey = Console.ReadLine();


            char[] charArrayText = ursText.ToCharArray();
            char[] charArrayKey = ursKey.ToCharArray();

            Queue<int> text = new Queue<int>();
            Queue<int> key = new Queue<int>();

            convert.ConvertTextToNumbs(charArrayKey, key);
            convert.ConvertTextToNumbs(charArrayText, text);


            foreach (int itemRow in key)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("test");
                foreach (var itemColumn in text)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("prit =" + itemRow + " || " + itemColumn);
                    Console.WriteLine("this is from the big table) " + encryption.VCTable()[itemRow, itemColumn]);
                }
            }
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
