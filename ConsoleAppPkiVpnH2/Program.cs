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
            string newKey = ursKey;

            for (int i = 0; i < ursText.Length; i++)
            {
                newKey += newKey;
            }

            char[] charArrayText = ursText.ToCharArray();
            char[] charArrayKey = newKey.ToCharArray();

            int[] buildArray = new int[charArrayText.Length];

            Queue<int> text = new Queue<int>();
            Queue<int> key = new Queue<int>();

            convert.ConvertTextToNumbs(charArrayKey, key);
            convert.ConvertTextToNumbs(charArrayText, text);

            int[] arrText = text.ToArray();
            int[] arrKey = key.ToArray();

            Console.WriteLine("\nEncryption:");
            Console.WriteLine ("==================== ");

            for (int i = 0; i < buildArray.Length; i++)
            {
                Console.Write(encryption.VCTable()[arrKey[i],arrText[i]]);
            }

            Console.WriteLine("\n====================");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nDecryption:");
            Console.WriteLine("==================== ");

            for (int i = 0; i < buildArray.Length; i++)
            {
                Console.Write(encryption.VCTable()[arrText[i], 0]);
            }

            Console.WriteLine("\n====================");


            #region test code 
            //Console.WriteLine("The numbers for the encryption:");
            //Console.WriteLine ("==================== ");
            //Console.Write("Text) ");
            //foreach (var item in text)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.Write("\nKey) ");
            //foreach (var item in key)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("\n====================");




            //foreach (int itemRow in key)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("key loop");
            //    foreach (var itemColumn in text)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Blue;
            //        Console.WriteLine("print = " + itemRow + " || " + itemColumn);
            //        Console.WriteLine("this is from the big table) " + encryption.VCTable()[itemRow, itemColumn]);
            //    }
            //}


            //for (int i = 0; i < buildArray.Length; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        buildArray[i, j] = encryption.VCTable()[,];
            //    }

            //}

            //for (int i = 0; i <= test2.Length; i++)
            //{
            //    foreach (var itemKey in charArrayKey)
            //    {
            //        if (itemKey == 'a' && i < test2.Length)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine("A:");
            //            Console.WriteLine("this is from the big table) " + encryption.VCTable()[0, test2[i]]);
            //        }
            //        else if (i < test2.Length)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("B:");
            //            Console.WriteLine("this is from the big table) " + encryption.VCTable()[1, test2[i]]);
            //        }


            //        Console.WriteLine("nothing");
            //    }
            //}
            //Console.WriteLine("hjeee");
            //Console.ResetColor();
            #endregion

            Console.ReadKey();
        }
    }
}
