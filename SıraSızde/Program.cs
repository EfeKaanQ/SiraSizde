using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıraSızde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ekranIslem ei  = new ekranIslem();
            ei.EkranaYaz(0);
            
            Console.WriteLine("========================");
            ei.EkranaYaz();
        }
    }
    class ekranIslem
    {
        public void EkranaYaz(params int[] sayilar)
        {
            if (sayilar.Length == 0)
            {
                Console.WriteLine("parametre olmadığı için metotdan çıkıyor");
                return;
                
            }
            Console.WriteLine("parametreden gelen değerler");
            foreach(var s in sayilar)
            {
                if (s==0)
                {
                    return;

                }
                Console.WriteLine(s);
            }
        }
    }
    
}
