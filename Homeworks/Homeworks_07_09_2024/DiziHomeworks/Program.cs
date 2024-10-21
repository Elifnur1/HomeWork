using System.Data;

namespace Homeworks_07_09_2024;

class Program
{
    static void Main(string[] args)
    {
        #region soru1
        // Random random = new Random();
        // int[] dizi = new int[10];
        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     dizi[i] = random.Next(1, 101);
        // }

        // Console.WriteLine("Dizi elemanları: ");
        // foreach (int eleman in dizi)
        // {
        //     Console.Write(eleman + " ");
        // }
        // Console.WriteLine();


        // for (int i = 1; i < dizi.Length - 1; i++)
        // {
        //     if (dizi[i] > dizi[i - 1] && dizi[i] > dizi[i + 1])
        //     {
        //         Console.WriteLine("Eleman: " + dizi[i] + " (Index: " + i + ")");
        //     }
    }


    #endregion

    #region soru2
    // int[] dizi = new int[10];
    // int ciftSayisi = 0;
    // System.Console.WriteLine("10 tane sayı girin: ");
    // for (int i = 0; i < dizi.Length; i++)
    // {
    //     System.Console.Write($"{i + 1}.sayınız: ");
    //     dizi[i] = int.Parse(Console.ReadLine());
    //     if (dizi[i] % 2 == 0)
    //         ciftSayisi++;
    // }
    // int[] ciftSayilar = new int[ciftSayiSayisi];
    // int index = 0;
    // for (int i = 0; i < dizi.Length; i++)
    // {
    //     if (dizi[i] % 2 == 0)
    //     {
    //         ciftSayilar[index] = dizi[i];
    //         index++;
    //     }
    // }
    // Array.Sort(ciftSayilar);
    // Console.WriteLine("Çift sayılar (büyüğe doğru sıralandı):");
    // foreach (int sayi in ciftSayilar)
    // {
    //     Console.Write(sayi + " ");
    // }

    #endregion

    #region soru3
    //     Random rnd = new Random();
    //     int[] dizi = new int[10];
    //     for (int i = 0; i < dizi.Length; i++)
    //     {
    //         dizi[i] = random.Next(-30, 31);
    //     }
    //     int[] pozitifler = new int[10];
    //     int[] negatifler = new int[10];
    //     int PIndex = 0;
    //     int NIndex = 0;
    //     int index = 0;
    //     while (index < dizi.Length)
    //     {
    //         if (dizi[index] > 0)
    //         {
    //             pozitifler[PIndexIndex] = dizi[index];
    //             PIndex++;
    //         }
    //         else if (dizi[index] < 0)
    //         {
    //             negatifler[NIndexIndex] = dizi[index];
    //             NIndexIndex++;
    //         }
    //         index++;
    //     }
    //     System.Console.WriteLine("pozitif değerler: ");
    //     for (int i = 0; i < PIndex; i++)
    //     {
    //         System.Console.WriteLine(pozitifler[i]);
    //     }
    //     System.Console.WriteLine();
    //     System.Console.WriteLine("negatif değerler: ");
    //     for (int i = 0; i < NIndex; i++)
    //     {
    //         System.Console.WriteLine(negatifler[i]);
    //     }
    // }

    #endregion

    #region soru4
    //bu kodu tekrar incelicem
    // Random random = new Random();
    // int[] dizi = new int[100];

    //     for (int i = 0; i<dizi.Length; i++)
    //     {
    //         dizi[i] = random.Next(-50, 51);
    //     }
    //    Console.WriteLine("FOR döngüsü ile tekrar eden elemanlar:");

    //     for (int i = 0; i<dizi.Length; i++)
    //     {
    //     for (int j = i + 1; j<dizi.Length; j++) // 
    //      {
    //      if (dizi[i] == dizi[j])
    //      {
    //        Console.WriteLine($"{dizi[i]} değeri {i} ve {j}. indekslerde tekrar ediyor.");
    //      }
    //  }
    //  }
    //    List<int> kontrolEdilenler = new List<int>();

    //    Console.WriteLine("FOREACH döngüsü ile tekrar eden elemanlar:");

    //    foreach (int sayi in dizi)
    //       {
    //     if (!kontrolEdilenler.Contains(sayi))
    //     {
    //      kontrolEdilenler.Add(sayi);

    //      for (int i = 0; i < dizi.Length; i++)
    //         {
    //             if (dizi[i] == sayi)
    //          {
    // Console.WriteLine($"{sayi} değeri {i}. indekste bulunuyor.");
    //             }
    //         }
    //     }
    // }

    #endregion

    #region soru5
    //     Random random = new Random();
    //     int[] dizi = new int[100];
    //     for (int i = 0; i<dizi.Length; i++)
    //      {
    //       dizi[i] = random.Next(-50, 51);
    //      }

    //     Console.Write("Lütfen bir sayı girin: ");
    //     int girilenSayi = int.Parse(Console.ReadLine());
    //     int tekrarSayisi = 0;
    //     Console.WriteLine($"{girilenSayi} sayısının      bulunduğu indeksler:");

    //   for (int i = 0; i<dizi.Length; i++)
    //   {
    //       if (dizi[i] == girilenSayi)
    //       {
    //           Console.WriteLine($"{i}. indeks");
    //           tekrarSayisi++; 
    //       }
    //   }
    //   if (tekrarSayisi > 0)
    // {
    //     Console.WriteLine($"{girilenSayi} sayısı {tekrarSayisi} kez bulundu.");
    // }
    // else
    // {
    //     Console.WriteLine($"{girilenSayi} sayısı dizide bulunamadı.");
    // }
    // }


    #endregion

    #region soru6

    // int[] numbers=new int[100];
    // Random rnd=new Random();

    // for (int i=0; i<numbers.Length; i++ )
    // {
    //     numbers[i]=rnd.Next(1,101);
    // }
    // int enBuyuk=numbers[0];
    // int enKucuk=numbers[0];
    // for (int i=0; i<numbers.Length; i++)
    // {
    //     if(numbers[i] > enBuyuk)
    //     enBuyuk=numbers[i];
    //     if(numbers[i]< enKucuk)
    //     enKucuk=numbers[i];

    // }
    // Console.WriteLine("En büyük sayı:"+ enBuyuk);
    // Console.WriteLine("En küçük: " + enKucuk);
    // Console.WriteLine();
    #endregion

    #region soru7
    //  int[] numbers= new int[50];
    //  Random rnd= new Random();

    //  for (int i=0; i<numbers.Length; i++)
    //  {
    //     numbers[i]=rnd.Next(0,51);
    //  }
    //  int total=0;
    //  foreach (var number in numbers)
    //  {
    //     if(number%2==0)
    //     total +=number;
    //  }
    //  Console.WriteLine("Çift sayıların toplamı:" + total);

    #endregion

    #region soru8 
    //Yapamadım hocaya sorulucak

    #endregion

    #region soru9

    // int[] numbers = { -5, 8, 3, -1, 6, -7, 2, 0 };

    // Console.WriteLine("Başlangıç dizisi: " + string.Join(", ", numbers));

    // var positiveNumbers = numbers.Where(x => x > 0).ToList();

    // positiveNumbers.Reverse();


    // int[] result = new int[numbers.Length];
    // int positiveIndex = 0;

    // for (int i = 0; i < numbers.Length; i++)
    // {
    //     if (numbers[i] > 0)
    //     {
    //         result[i] = positiveNumbers   [positiveIndex];
    //         positiveIndex++;
    //     }
    //     else
    //     {
    //         result[i] = numbers[i];
    //     }
    // }

    // Console.WriteLine("Yeni dizi: " + string.Join(", ", result));


    #endregion

    #region soru10
    // int[] numbers={1,2,3,4,5,6,7,8,9,10,11};
    // Console.WriteLine("İlk dizi: " + string.Join(" ," ,numbers));
    // int[] newNumbers = new int[numbers.Length];
    // for (int i=0; i<numbers.Length; i++)
    // {
    //     newNumbers[i]= numbers[numbers.Length - i - 1];
    // }
    // Console.WriteLine("Son hali: " + string.Join(",",newNumbers));           
    #endregion

    #region soru11
    // Console.WriteLine("Bir cümle girin: ");
    // string input=Console.ReadLine();
    // string[] words=input.Split(' ');
    // int Length=words.Length;
    // int i=Length - 1;
    // while (i>=0)
    // {
    //     Console.Write(words[i] + " ");
    //     i--;
    // }

    #endregion

    #region soru12

    // 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde en sık tekrar eden elemanı bulan ve kaç defa tekrarlandığını ekrana yazdıran bir program yazın.Bu işlemi bir foreach döngüsü ile gerçekleştirin.

    // int[] dizi = new int[20];
    // Random rnd = new Random();
    // int sayaç = 1;

    // for (int i = 0; i < dizi.Length; i++)
    // {
    //     dizi[i] = rnd.Next(1, 11);

    // }
    // System.Console.WriteLine("Random dizimiz");
    // System.Console.WriteLine("---------------------------------------------------");
    // foreach (var item in dizi)
    // {
    //     System.Console.WriteLine($"{sayaç}. ==> {item}");
    //     sayaç++;
    // }

    // int fazlaTekEleman = dizi[0];
    // int tekrareleman = 0;

    // for (int i = 0; i < dizi.Length; i++)
    // {
    //     int x = dizi[i];
    //     int teksay = 0;

    //     foreach (var eleman in dizi)
    //     {
    //         if (eleman == x)
    //         {
    //             teksay++;
    //         }
    //     }

    //     if (teksay > tekrareleman)
    //     {
    //         fazlaTekEleman = x;
    //         tekrareleman = teksay;
    //     }
    // }

    // System.Console.WriteLine($"En çok tekrar eden eleman {fazlaTekEleman} = {tekrareleman} kadar tekrarlanıyor.");

    #endregion

    #region soru13
    // int[] numbers={2,4,5,8,7,8,1,3};
    // int total=numbers.Where(number => number% 2 !=0 ).Sum();
    // if(total % 2 == 0 )
    // Console.WriteLine("Toplamı çift sayı.");
    // else
    // Console.WriteLine("Toplamı tek sayı. ");

    #endregion

    #region soru14
    // int[] numbers={1,2,3,4,5,6,7,1,2,3,4,5,6,7,1,2,3,4,5};
    // int total=numbers.Where(number => number % 3 == 0).Sum();

    // int karakterSayaci = 0;
    // foreach (var number in numbers)
    // {
    //     Console.Write(number);
    //     karakterSayaci++;
    //     if (karakterSayaci % 5 == 0)
    //     {
    //         Console.Write(" ");
    //      }
    //  }
    #endregion

    #region soru15
    // int[] numbers=[2,5,8,3,11,6,7];
    // //OrderBy;belirli kriterlere göre elemanları sıralayan metot.
    // int[] oddnumbers=numbers.Where(number => number % 2 !=0 ).OrderBy(number => number).ToArray();
    // int oddnumbersIndex=0;
    // for (int i=0; i<numbers.Length; i++)
    // {
    //     if (numbers[i] % 2 != 0)
    //    {
    //         numbers[i] = oddnumbers[oddnumbersIndex]; //iki dizi arasında eleman kopyalama işlemi.
    //         oddnumbersIndex++;
    //    } 
    // }
    // Console.WriteLine(string.Join(" , " ,numbers));

    #endregion


    #region soru16 
    // int input;
    //         int sayaç=0;
    //         int[] dizi = new int[10];
    //         int top =0;

    //     do
    //     {

    //         System.Console.WriteLine("Bir sayı giriniz => ");
    //         input = int.Parse(Console.ReadLine());


    //         if( input !=0)
    //         {
    //             dizi[sayaç] = input;
    //             top +=input;

    //             sayaç++;
    //         }



    // } while (input != 0 && sayaç < dizi.Length);
    //     Array.Resize(ref dizi, dizi.Length);
    //     foreach (var item in dizi)
    //     {
    //         System.Console.WriteLine(item);
    //     }

    //   if(sayaç >0)
    //   {
    //         double ort =(double)top/sayaç;
    //         System.Console.WriteLine($"Sayılarımızın ortalaması = {ort}");
    //   }


    // int sayi;
    // List<int> sayilar = new List<int>();

    // do
    // {
    //     Console.Write("Bir sayı giriniz (çıkmak için 0): ");
    //     sayi = Convert.ToInt32(Console.ReadLine());

    //     if (sayi != 0)
    //     {
    //         sayilar.Add(sayi);
    //     }
    // } while (sayi != 0);

    // if (sayilar.Count > 0)
    // {
    //     double ortalama = sayilar.Average();
    //     Console.WriteLine("Girilen sayıların ortalaması: " + ortalama);
    // }
    // else
    // {
    //     Console.WriteLine("Hiç sayı girilmedi.");
    // }

    #endregion

    #region soru17


    // int[] sayilar = { 3, 6, 2, 9, 11, 5, 1, 8 };

    // int enBuyuk1 = int.MinValue;
    // int enBuyuk2 = int.MinValue;

    // for (int i = 0; i < sayilar.Length; i++)
    // {
    //     if (sayilar[i] > enBuyuk1)
    //     {
    //         enBuyuk2 = enBuyuk1; 
    //         enBuyuk1 = sayilar[i];
    //     }
    //     else if (sayilar[i] > enBuyuk2 && sayilar[i] != enBuyuk1)
    //     {
    //         enBuyuk2 = sayilar[i]; 
    //     }
    // }

    // Console.WriteLine("En büyük sayı: " + enBuyuk1);
    // Console.WriteLine("İkinci en büyük sayı: " + enBuyuk2);

    #endregion


}

