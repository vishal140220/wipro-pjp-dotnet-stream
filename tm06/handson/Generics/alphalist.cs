using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace myapp
{
 class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("ENTER THE STRING");
            List<Char> dig = new List<Char>();
            List<Char> alpha = new List<Char>();
            string x = Console.ReadLine();
            char[] ch = x.ToCharArray();
            for(int i =0;i<x.Length;i++)
            {
                if(Char.IsDigit(ch[i]))
                {
                    dig.Add(ch[i]);
                }
                else
                {
                    alpha.Add(ch[i]);
                }
            }
            Console.WriteLine("digit list: ");
            foreach(int i in dig)
            {
                Console.WriteLine((Char)i);
            }
            Console.WriteLine("alpha list: ");
            foreach (int i in alpha)
            {
                Console.WriteLine((Char)i);
            }
            
        }
    }
}













