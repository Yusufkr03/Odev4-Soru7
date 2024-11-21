// See https://aka.ms/new-console-template for more information
class program
{
    public static void Main()
    {
        
        Console.WriteLine(metod.YasHesap());
        Console.WriteLine(metod.YasHesap(20));
        Console.WriteLine(metod.YasHesap(52));
        Console.WriteLine(metod.YasHesap(15));
    }
}



class metod
{
    public static int YasHesap(int y = 18)
    {
        if (y > 18)
        {
            int sonuc = y - 18;
            return sonuc;
        }
        else return 0;
        
        
        
    }

}
