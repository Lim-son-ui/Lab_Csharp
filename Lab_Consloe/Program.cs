using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Form;

namespace Lab_Consloe
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFirstClass mc = new MyFirstClass();
            mc.Method05();

            Console.WriteLine("Hello C#!");
            Console.Write("請輸入姓名: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello, " + Name);
            Console.ReadKey();

            
        }
    }
}
