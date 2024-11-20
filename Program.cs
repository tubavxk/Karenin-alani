int kenar1, kenar2;

Console.WriteLine("1.kenarı giriniz");
kenar1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2.kenarı giriniz");
kenar2 = Convert.ToInt32(Console.ReadLine());


int alan = kenar1 * kenar2;

Console.WriteLine("Karenin alanı: " + alan);

Console.ReadKey();