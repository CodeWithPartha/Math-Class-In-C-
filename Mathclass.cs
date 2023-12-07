using System;
class Program{
    static void Main(String[] args) {
        
        double a=3;
        double b=Math.Pow(a,2);// power fuction
        Console.WriteLine("The value of b is: " + b);
        
        double a1=3;
        double b1=Math.Pow(a1,3);// power fuction
        Console.WriteLine("The value of b1 is: " + b1);
        
        double a2=3;
        double b2=Math.Sqrt(a2);// Square root fuction
        Console.WriteLine("The value of b2 is: " + b2);
        
         double a3=-3;
        double b3=Math.Abs(a3);// absoulute value fuction
        Console.WriteLine("The value of b3 is: " + b3);
        
         double a4=3.143;
        double b4=Math.Round(a4);// Round of fuction
        Console.WriteLine("The value of b4 is: " + b4);
        
         double a5=3.143;
        double b5=Math.Ceiling(a5);// Ceiling fuction
        Console.WriteLine("The value of b5 is: " + b5);
        
         double a6=3.143;
        double b6=Math.Floor(a6);// Floor fuction
        Console.WriteLine("The value of b6 is: " + b6);
        
        double x=3.143;
        double y = 5;
        double z=Math.Max(x,y);// Max fuction
        double z1=Math.Min(x,y); // Min Function
        Console.WriteLine("The value of z is: " + z);
        Console.WriteLine("The value of z1 is: " + z1);
    }
}