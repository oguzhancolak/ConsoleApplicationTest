using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSepeti
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();
        }

        private void Start()
        {
            int result = -1; // sonuç değeri

            // burası hazırda verilecek bilgi
            List<int> array = new List<int>(); 
            array.Add(1);
            array.Add(5);
            array.Add(-3);
            array.Add(7);
            array.Add(-1);

            for (int i = 1; i < array.Count; i++)
            {
                //Sağ ve sol liste toplamları burada karşılaştırılıyor.
                if (leftTotal(i, array) == rightTotal(i, array))
                {
                    result = i;
                    break;
                }
            }

            //Sonuç burada dönüyor.
            Console.WriteLine("Cevap = " + result);
        }

        //Sol liste toplam fonksiyonu
        private int leftTotal(int index, List<int> array)
        {
            int t = 0;
            for (int i = index - 1; i >= 0; i--)
            {
                t += array[i];
            }
            return t;
        }

        //Sağ liste toplam fonksiyonu
        private int rightTotal(int index, List<int> array)
        {
            int t = 0;
            for (int i = index + 1; i < array.Count; i++)
            {
                t += array[i];
            }
            return t;
        }
    }
}
