using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ColecaoHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> setNumeros = new HashSet<string>();
            setNumeros.Add("1");
            setNumeros.Add("1");
            setNumeros.Add("2");
            setNumeros.Add("2");
            setNumeros.Add("3");
            setNumeros.Add("3");
            setNumeros.Add("4");
            setNumeros.Add("5");
            setNumeros.Add("5");
            setNumeros.Add("6");
            setNumeros.Add("6");
            setNumeros.Add("7");
            setNumeros.Add("8");
            setNumeros.Add("9");
            setNumeros.Add("10");

            foreach (string item in setNumeros)
            {
                Console.WriteLine(item);
            }



        }
    }
}
