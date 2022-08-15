Console.WriteLine("Sayı adedi girin");
int a = Convert.ToInt32 (Console.ReadLine());
int ort = 0;
Console.WriteLine("sayıları girin");

for (int i = 0; i < a; i++)
{
    int b = Convert.ToInt32(Console.ReadLine());
    ort = ort + b;

}
ort = ort / a;
Console.WriteLine(ort);