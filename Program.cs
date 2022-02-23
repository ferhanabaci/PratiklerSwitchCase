using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            // switch_on Expression yazıyoruz oraya kontrol etmek istediğimiz koşulu yazıyoruz
            // hangi ifade üzerinden baglanma yapıcam gelip onun üzerine yazıcam

            switch (month)
            {
                case 1:
                    Console.WriteLine("ocak ayındasınız:");
                    break;
                case 2:
                    Console.WriteLine("Subat");
                    break;
                case 4 :
                    Console.WriteLine("Nisan");
                    break;

                case 3:
                    Console.WriteLine("mart");
                    break;

                default:// hic bir case uymadıgı taktirde yapılcak olan islemi ifade ediyor
                Console.WriteLine("yanlış veri girişi:");
                break;
            }
            switch (month){
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Ayındasınız:");
                    break;
                case 3:
                case 4:
                case 5:
                Console.WriteLine("İlk Bahar Ayındasınız:");
                    break;
                case 6:
                case 7:
                case 8:
                Console.WriteLine("Yaz Ayındasınız:");
                    break;
                default:
                break;

            }
        }
    }
}
