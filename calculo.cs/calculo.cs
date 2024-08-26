csharp
using System;

class Program
{
    private static void Main(string[] args)
    {
        float retangulo01 = 5.0f;
        float retangulo02 = 4.0f;

   float retangulo03 = 10.3f;
   float retangulo04 = 13.1f;

   float resuPitagora01 = 6.4f;
   float resuPitagora02 = 16.66f;

   float area01 = retangulo01 * retangulo02;

   float perimetro01 = retangulo01 + retangulo01 + retangulo01 + retangulo02;

   double diagonal01 = Math.Sqrt(retangulo01 * retangulo01 + retangulo02 * retangulo02);

   Console.WriteLine("atividade01");
   Console.WriteLine("a area é: " + area01);
   Console.WriteLine("o perimetro é: " + perimetro01);
   Console.WriteLine("a diagonal é: " + diagonal01);

   Console.WriteLine("atividade02");

   float area03 = retangulo03 * retangulo04;

   float perimetro03 = retangulo03 + retangulo03 + retangulo03 + retangulo04;

   double diagonal03 = Math.Sqrt(retangulo03 * retangulo03 + retangulo04 * retangulo04);

   Console.WriteLine("a area é: " + area03);
   Console.WriteLine("o perimetro é: " + perimetro03);
   Console.WriteLine("a diagonal é: " + diagonal03);
    }
}
