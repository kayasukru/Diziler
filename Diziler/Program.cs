
//----------------------------------------------------
DiziVeDegeriForeachIndexYapisiCSharp8VeSonrasi();

DiziIndisVeDegeriForeachIle();

DiziIndisVeDegeriForIle();

TekBoyutluDizi();

Matris();
//----------------------------------------------------

static void TekBoyutluDizi()
{
    Console.WriteLine("Tek boyutlu dizi");
    Console.Write("Dizi boyutunu girin: ");
    int boyut = 6;// Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[] sayilar = new int[boyut];

    //belirlenen boyuta göre dizi elemanları tespit ediliyor
    var r = new Random();
    for (int i = 0; i < sayilar.Length; i++)
        sayilar[i] = r.Next(1, 10);

    Console.WriteLine($"{"Eleman",5} {"Karesi",10}");

    foreach (var s in sayilar)
    {
        Console.WriteLine($"{s,5} {s * s,10}");
    }

    Console.WriteLine("------------------------------");
    Console.WriteLine();
}

static void Matris()
{
    Console.WriteLine("Matris");
    Console.WriteLine();

    double[,] matris = new double[,]
    {
                { 1, 2, 3, 4 },
                {2, 3, 4, 4},
                { 4, 5, 6, 7 },
                { 5, 6, 7, 8 }
    };

    double toplam = 0;

    for (int i = 0; i < matris.GetLength(0); i++)
    {
        for (int j = 0; j < matris.GetLength(1); j++)
        {
            Console.Write($"{matris[i, j],5}");

            toplam = toplam + matris[i, j];
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Matristeki sayıları toplamı : " + toplam);
    Console.WriteLine();
    Console.WriteLine("-------------------------------------------");
}

static void DiziIndisVeDegeriForIle()
{
    Console.WriteLine("for döngüsü kullanarak  indisler ve değerleri");
    Console.WriteLine();

    int[] numbers = { 10, 20, 30, 40, 50 };

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine($"Indis: {i}, Değer: {numbers[i]}");
    }
    Console.WriteLine();
    Console.WriteLine("---------------------------------------");
    Console.WriteLine();
}

static void DiziIndisVeDegeriForeachIle()
{
    Console.WriteLine();
    Console.WriteLine("foreach döngüsü ile birlikte Enumerable.Select metodu kullanılarak indisler ve değerleri");
    Console.WriteLine();

    int[] numbers = { 10, 20, 30, 40, 50 };

    foreach (var (value, index) in numbers.Select((value, index) => (value, index)))
    {
        Console.WriteLine($"Indis: {index}, Değer: {value}");
    }
    Console.WriteLine();
    Console.WriteLine("------------------------------------------");
    Console.WriteLine();
}

static void DiziVeDegeriForeachIndexYapisiCSharp8VeSonrasi()
{
    Console.WriteLine();
    Console.WriteLine("foreach ve Index Yapısı Kullanarak (C# 8.0 ve Üzeri)");
    Console.WriteLine();

    int[] numbers = { 10, 20, 30, 40, 50 };
    int index = 0;

    foreach (var value in numbers)
    {
        Console.WriteLine($"Indis: {index}, Değer: {value}");
        index++;
    }
    Console.WriteLine();
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine();
}