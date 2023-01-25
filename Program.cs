using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es._22
{
    internal class Program
    {
        static int [] Caricamento(ref int n,ref int x,ref int y)
        {
            Random r = new Random();

            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = r.Next(x, y);
            }
            return v;
        }
        static void Stampa(ref int n,int[]v)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("L'elemento in posizione " + i + " " + v[i]);
            }
        }
        static int [] Troncamento(ref int z,ref int[]v)
        {
            Array.Resize(ref v, z);
            return v;
        }
        static void Main(string[] args)
        {
            int n, x, y, z;
            int scelta;
            //menù
            Console.WriteLine("1 - caricamento array di N elementi compresi tra X e Y");
            Console.WriteLine("2 - troncamento array data una dimensione Z");
            Console.WriteLine("3 - inserimento in posizione");
            //scelta opzione
            Console.WriteLine("Inserisci la scelta");
            scelta = int.Parse(Console.ReadLine());
            






            Console.WriteLine("Inserisci la dimensione dell'array");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci l'intervallo dei numeri random");
            Console.WriteLine("Tra");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("e");
            y = int.Parse(Console.ReadLine());
            int[]array = new int[n];
            array = Caricamento(ref n,ref x,ref y);
            Stampa(ref n,array);
            Console.WriteLine("Inserisci la dimensione da troncare dell'array");
            z = int.Parse(Console.ReadLine());
            Troncamento(ref z,ref array);
            Stampa(ref n,array);
            Console.ReadLine();

            
        }
    }
}
