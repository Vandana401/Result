using System;
namespace hello
  { 
    class progarm
    {


        /*  static void Main(string[] args)  // by simple


          {
              int a = -1;
              int b = 4;
              int c = 6;
              int s = a + b * c;
              Console.WriteLine(s);
          }*/

        /*  public void App(int x, int y, int z)      // by  public method

          {
              int a =x;
              int b =y;
              int c =z;
              int d = (x + y) % z;


              Console.WriteLine(d);

               }
          static void Main(string[] args)
          {
              progarm e= new progarm();
              e.App(35,5,7);
          } */
        private void Method(int a, int b, int c, int d)     //private method
        {
            int w = a;
            int x = b;
            int y = c;
            int z = d;

            int result = a + b * 6 / d;
            Console.WriteLine(result);
        }
                public void Method1(int a, int b, int c, int d)
                {
                    Method(a,b,c,d);

                }
        static void Main(string[] args)
        {
            progarm obj=new progarm();
            obj.Method1(14, -4, 6, 11);
        }

            }
            
            

            

        }
    


