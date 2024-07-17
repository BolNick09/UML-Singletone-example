using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Singletone_example
{
    internal class Program
    {

        class Singletone
        {
            private Singletone() { }
            private static Singletone single = null;

            public static Singletone getInstance()
            {
                if (single == null)
                    single = new Singletone();
                return single;
            }
        }
        static void Main(string[] args)
        {
            Singletone s1 = Singletone.getInstance();
            Singletone s2 = Singletone.getInstance();

            Console.WriteLine(s1.GetHashCode()); 
            Console.WriteLine(s2.GetHashCode()); //выводятся одинаковые хэш коды, s1 и s2 - одна и та же сущность

            //Singletone s3(s1); -- невозможно

        }
    }
}
