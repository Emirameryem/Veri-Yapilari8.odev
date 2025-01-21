using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan m ve n değerlerini al
            Console.WriteLine("Ackermann Fonksiyonu Hesaplama");

            Console.Write("Birinci argümanı (m) girin: ");
            int m = int.Parse(Console.ReadLine());  // m değerini al

            Console.Write("İkinci argümanı (n) girin: ");
            int n = int.Parse(Console.ReadLine());  // n değerini al

            // Ackermann fonksiyonunu hesapla
            int result = Ackermann(m, n);

            // Sonucu ekrana yazdır
            Console.WriteLine($"A({m}, {n}) = {result}");
            Console.ReadLine();

        }


        // Ackermann fonksiyonunu tanımlayan recursive (özyinelemeli) fonksiyon
        static int Ackermann(int m, int n)
        {
            // Temel durum: Eğer m sıfırsa, n + 1 döndür
            if (m == 0)
            {
                return n + 1;
            }
            // Recursive durum: Eğer m > 0 ve n = 0, A(m, 0) = A(m-1, 1)
            else if (m > 0 && n == 0)
            {
                return Ackermann(m - 1, 1);
            }
            // Recursive durum: Eğer m > 0 ve n > 0, A(m, n) = A(m-1, A(m, n-1))
            else if (m > 0 && n > 0)
            {
                // A(m, n) hesaplamak için iç içe recursive çağrı yapılır
                return Ackermann(m - 1, Ackermann(m, n - 1));
            }
            else
            {
                Console.WriteLine("hatalı giriş");
                return 0;
            }

           
        }
    }
}
