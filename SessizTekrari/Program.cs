System.Console.Write("Aralarında boşluk olacak şekilde kelimeleri giriniz");
string kelimeler = Console.ReadLine();
string[] liste = kelimeler.Split(" ");
bool[] trueFalse = new bool[liste.Length];
string unluler = "aeoöuüıi";
int sıra = 0;
foreach (var item in liste)
{
    int counter = 0;
    foreach (var harf in item)
    {

        if (unluler.Contains(harf))
        {
            counter = 0;
        }
        else
        {
            counter++;
            if (counter == 2)
            {
                trueFalse[sıra] = true;
                break;
            }
        }
    }
    sıra++;
}
foreach (var item in trueFalse)
{
    Console.Write(item+" ");
}