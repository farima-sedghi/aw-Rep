using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Main(string[] args)
        {

           /* System.Numerics.BigInteger number1 = System.Numerics.BigInteger.Parse("223424234234242333234343243");
            System.Numerics.BigInteger number2= System.Numerics.BigInteger.Parse("223424234234242333234343243");
           var num= System.Numerics.BigInteger.Compare(number1 , number2);
            Console.WriteLine(num);*/
            int numeric = 0;
            int chars = 0;
            int symbols = 0;
            int otherType = 0;
            Console.WriteLine("enter string to counting character's type");
            string st = Console.ReadLine();
            for(int index=0;index<st.Length;index++)
            {
                if (Char.IsDigit(st[index]))
                    numeric++;
                else if (Char.IsLetter(st[index]))
                    chars++;
                else if (Char.IsSymbol(st[index]))
                    symbols++;
                else
                    otherType++;
            }
            Console.WriteLine("numercis: {0:n} characters: {1:n} symbols: {2:n} otherType: {3:n}", numeric, chars, symbols, otherType);
            Console.ReadKey();
            return 0;
            
        }
    }
}
