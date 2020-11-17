using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPkiVpnH2
{
    class ConvertingTool
    {
        public void ConvertTextToNumbs(char[] collection, Queue<int> queueName)
        {
            foreach (char item in collection)
            {
                switch (item)
                {
                    case 'a':
                        queueName.Enqueue(0);
                        break;
                    case 'b':
                        queueName.Enqueue(1);
                        break;
                    case 'c':
                        queueName.Enqueue(2);
                        break;
                    case 'd':
                        queueName.Enqueue(3);
                        break;
                    case 'e':
                        queueName.Enqueue(4);
                        break;
                    case 'f':
                        queueName.Enqueue(5);
                        break;
                    case 'g':
                        queueName.Enqueue(6);
                        break;
                    case 'h':
                        queueName.Enqueue(7);
                        break;
                    case 'i':
                        queueName.Enqueue(8);
                        break;
                    case 'j':
                        queueName.Enqueue(9);
                        break;
                    case 'k':
                        queueName.Enqueue(10);
                        break;
                    case 'l':
                        queueName.Enqueue(11);
                        break;
                    case 'm':
                        queueName.Enqueue(12);
                        break;
                    case 'n':
                        queueName.Enqueue(13);
                        break;
                    case 'o':
                        queueName.Enqueue(14);
                        break;
                    case 'p':
                        queueName.Enqueue(15);
                        break;
                    case 'q':
                        queueName.Enqueue(16);
                        break;
                    case 'r':
                        queueName.Enqueue(17);
                        break;
                    case 's':
                        queueName.Enqueue(18);
                        break;
                    case 't':
                        queueName.Enqueue(19);
                        break;
                    case 'u':
                        queueName.Enqueue(20);
                        break;
                    case 'v':
                        queueName.Enqueue(21);
                        break;
                    case 'w':
                        queueName.Enqueue(22);
                        break;
                    case 'x':
                        queueName.Enqueue(23);
                        break;
                    case 'y':
                        queueName.Enqueue(24);
                        break;
                    case 'z':
                        queueName.Enqueue(25);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
