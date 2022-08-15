Console.WriteLine("Seçiminizi tuşlayınız.\n Daire için :1\n Dikdörtgen için :2\n kare için :3\n Üçgen için :4\n");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
{
    Console.WriteLine("yarıçap giriniz");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Neyi hesaplamak istiyorsunuz?\n Alan için :1\n Çevre için :2");
    int c = Convert.ToInt32(Console.ReadLine());
    if (c == 1)
    {
        Console.WriteLine(b^2*3);
    }
    if (c == 2)
    {
        Console.WriteLine(2*3*b);
    }

}
if (a == 2)
{
    Console.WriteLine("1.kenarı girin");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("2.kenarı girin");
    int d = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Neyi hesaplamak istiyorsunuz?\n Alan için :1\n Çevre için :2");
    int c = Convert.ToInt32(Console.ReadLine());
    if (c == 1)
    {
        Console.WriteLine(b*d);
    }
    if (c == 2)
    {
        Console.WriteLine((2*b)+(2*d));
    }


}
if (a == 3)
{
    Console.WriteLine("Kenar girin");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Neyi hesaplamak istiyorsunuz?\n Alan için :1\n Çevre için :2");
    int c = Convert.ToInt32(Console.ReadLine());
    if (c == 1)
    {
        Console.WriteLine(b ^ 2);
    }
    if (c == 2)
    {
        Console.WriteLine(b * 4);
    }

}
if (a == 4)
{
    Console.WriteLine("taban girin");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("kenar1 girin");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("kenar2 girin");
    int j = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("yükseklik girin");
    int d = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Neyi hesaplamak istiyorsunuz?\n Alan için :1\n Çevre için :2");
    int c = Convert.ToInt32(Console.ReadLine());
    if (c == 1)
    {
        Console.WriteLine(b*d/2);
    }
    if (c == 2)
    {
        Console.WriteLine(b+i+j);
    }

}