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
            // burası hazırda verilecek bilgi
            List<int> array = new List<int>(); 
            List<int> leftList = new List<int>();
            array.Add(1);
            array.Add(5);
            array.Add(-3);
            array.Add(7);
            array.Add(-1);
            
            int result = -1; // sonuç değeri
            int listTotalValue = array.Sum(); // liste toplam değeri

            // Sol liste 0 elemanlı olacağından 1'den başlatıyoruz.
            for (int i = 1; i < array.Count; i++)
            {
                // Sol listeye ekleniyor.
                leftList.Add(array[i - 1]);

                // Ara index değerinden liste toplamı çıkarılıyor.
                int comparisonValue = listTotalValue - array[i];

                // Eğer ara değer ikiye bölünemiyorsa zaten eşit olamaz.
                if (comparisonValue % 2 == 0) {
                    // Sol liste toplamı bulunuyor.
                    int leftListTotalValue = leftList.Sum();

                    // Ara index değerinden çıkarılmış toplamdan, sol liste toplamı çıkarılıyor.
                    int remainingValue = comparisonValue - leftListTotalValue;

                    // Eğer sol liste toplamıyla, 
                    // index ve sol liste toplamından çıkarılmış değer
                    // bize sağ liste toplamını verir.
                    if (leftListTotalValue == remainingValue)
                    {
                        result = i;
                        break;
                    }
                }
            }

            //Sonuç burada dönüyor.
            Console.WriteLine("Cevap = " + result);
        }
    }
}
