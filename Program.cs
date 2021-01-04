using System;

namespace Ödev 
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.Write("Basit seviye için 1,orta seviye için 2,Zor seviye için 3'ü Tuşlayınız : ");
            int secim1=Convert.ToInt32(Console.ReadLine());

            if (secim1==1){    
                int rastgele1=new Random().Next(1,10);
                int i=3;
                Console.WriteLine("3 Hakkın var. ");
                Console.WriteLine("1-10 arasındakiyi sayıyı bul !!! ");
                Console.WriteLine("Başlayabilirsin");
                bölüm1: i=i-1;
                int secim2=Convert.ToInt32(Console.ReadLine());

                if (rastgele1==secim2)
                {  
                    Console.Write("Doğru Tahmin Tebrikler!!!");
                    
                }
                
                else if(i==0) {
                    Console.WriteLine("Malesef hakkınız bitmiştir.Kaybettiniz :(");
                     }

                else
                {
                   Console.WriteLine($"Yanlış.[Kalan hak {i}]"); goto bölüm1;
                }
            }
       
       if (secim1==2){    
                int rastgele8=new Random().Next(1,25);
                int i=7;
                Console.WriteLine("7 Hakkın var. ");
                Console.WriteLine("1-25 arasındakiyi sayıyı bul !!! ");
                Console.WriteLine("Başlayabilirsin");
                bölüm2: i=i-1;
                int secim3=Convert.ToInt32(Console.ReadLine());

                if (rastgele8==secim3)
                {  
                    Console.Write("Doğru Tahmin Tebrikler!!!");
                    
                }
                
                else if(i==0) {
                    Console.WriteLine("Malesef hakkınız bitmiştir.Kaybettiniz :(");
                     }

                else
                {
                   Console.WriteLine($"Yanlış.[Kalan hak {i}]"); goto bölüm2;
                }
            }
       
        if (secim1==3){    
                int rastgele5=new Random().Next(1,50);
                int i=10;
                Console.WriteLine("10 Hakkın var. ");
                Console.WriteLine("1-50 arasındakiyi sayıyı bul !!! ");
                Console.WriteLine("Başlayabilirsin");
                bölüm1: i=i-1;
                int secim4=Convert.ToInt32(Console.ReadLine());

                if (rastgele5==secim4)
                {  
                    Console.Write("Doğru Tahmin Tebrikler!!!");
                    
                }
                
                else if(i==0) {
                    Console.WriteLine("Malesef hakkınız bitmiştir.Kaybettiniz :(");
                     }

                else
                {
                   Console.WriteLine($"Yanlış.[Kalan hak {i}]"); goto bölüm1;
                }
            }



       
       
        }
    }
}
