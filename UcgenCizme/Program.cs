Console.WriteLine("Uzunluk girin");
int UcgenUzunlugu = Convert.ToInt32(Console.ReadLine());
        
    for (int i = 1; i <= UcgenUzunlugu; i++)
            {
    for (int j = 0; j < UcgenUzunlugu - i; j++)
    {
         Console.Write(" ");
    }

    for (int k = 0; k < 2 * i - 1; k++)
    {
      Console.Write("*");
    }
      Console.WriteLine();
    }
        
  