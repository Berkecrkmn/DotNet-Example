int s1, s2, toplam;


Console.Title = "Berke Çırakman";

Console.WriteLine("1. Sayıyı girin");
s1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. Sayıyı girin");
s2 = Convert.ToInt32(Console.ReadLine());

toplam = s1 + s2;

Console.WriteLine("iki sayının toplamı" + toplam + "dir");

Console.ReadKey();