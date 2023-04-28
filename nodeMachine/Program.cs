using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nodeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] outMatrix = new char[8][];
            outMatrix[0] = new char[] { 'A', 'B', 'C', 'D', 'G' };
            outMatrix[1] = new char[] { 'B', 'C', 'G', 'H'};
            outMatrix[2] = new char[] { 'C', 'D', 'E', 'F'};
            outMatrix[3] = new char[] { 'D', 'G', 'H'};
            outMatrix[4] = new char[] { 'E', 'H'};
            outMatrix[5] = new char[] { 'F' };
            outMatrix[6] = new char[] { 'G' };
            outMatrix[7] = new char[] { 'H'};

            Console.WriteLine("  A  B  C  D  E  F  G  H");
            Console.Write("A ");
            if(outMatrix[0][0] == 'A')
            {
                Console.Write("1  ");
            }
            else
            {
                Console.Write("0");
            }
            if (outMatrix[0][1] == 'B')
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
            Console.WriteLine("");
            Console.WriteLine("B ");
            Console.WriteLine("");
            Console.WriteLine("C ");
            Console.WriteLine("");
            Console.WriteLine("D ");
            Console.WriteLine("");
            Console.WriteLine("E ");
            Console.WriteLine("");
            Console.WriteLine("F ");
            Console.WriteLine("");
            Console.WriteLine("G ");
            Console.WriteLine("");
            Console.WriteLine("H ");



            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(outMatrix[i]);
            }
            Console.ReadLine();

        }
    }
}
