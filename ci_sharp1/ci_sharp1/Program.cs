using System;

namespace ci_sharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            /*  Console.Write("Введите свое имя: ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Привет {name}");*/
            /*  int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                  { { 4, 5 }, { 6, 7 } },
                  { { 7, 8 }, { 9, 10 } },
                  { { 10, 11 }, { 12, 13 } }
                };
              int j = 0,k=0,i=0;
              Console.Write("{");
              for (i=0;i<4;i++)
              {
                  Console.Write("{");
                  for (k = 0; k < 2; k++)
                  {
                      Console.Write("{");
                      for (j=0;j<2;j++)
                      {
                          Console.Write($"{mas[i,k,j]}");
                          if(j<1)
                          {
                              Console.Write(",");
                          }
                      }
                      Console.Write("}");
                      if (k < 1)
                      {
                          Console.Write(",");
                      }
                  }
                  Console.Write("}");
                  if (i < 3)
                  {
                      Console.Write(",");
                  }
              }
             Console.Write("}");*/
            void Increment(ref int n)
            {
                n++;
                Console.WriteLine($"Число в методе Increment: {n}");
            }

            int number = 5;
            Console.WriteLine($"Число до метода Increment: {number}");
            Increment(ref number);
            Console.WriteLine($"Число после метода Increment: {number}");




        }
          
    }
}
