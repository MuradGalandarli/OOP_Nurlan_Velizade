/*using System;

public class Person
{
    int _age;
    public int Age
    {
        get
        {
            return _age;
        }

        set
        {
            if (value > 0)
            {
                _age = value;
            }
        }
        
    }
}

class Program
{
    static void Main()
    {

        Person person = new Person
        {
            Age = 25

        };
        Person person1 = new Person
        {
            Age = -25
            
        };

        Console.WriteLine(person.Age);
        Console.WriteLine(person1.Age);
    }
}
*/


/*
using System;

public class Program
{
   
    static void Main()
    {

        Console.WriteLine( Toplama.Sum(4, 8));
    }

}

public static class Toplama
{
    public static int Sum(int num1, int num2)
    {
        return num1 + num2;
    } }*/

/*

public class Program
{

    static void Main()
    {
       var result = Day.Birinci;
        Console.WriteLine(result);  
    }

      enum Day
    {
        Birinci, ikinci
    }
   
}
*/


/*
public class Program
{

    static void Main()
    {*/
/*
        int number = 41;
        Console.WriteLine(number);
        Console.WriteLine(change(number));
        int change(int num)
        {
            return num = 100;
        }
        Console.WriteLine(number);

        Console.WriteLine("///////////////////////////////////////////");
        int number1 = 41;
        Console.WriteLine(number1);
        Console.WriteLine(change1(ref number1));
        int change1(ref int num)
        {
            return num = 100;
        }
        Console.WriteLine(number1);

*/

/*  Console.WriteLine("///////////////////////////////////////////");
  int number1;
 // Console.WriteLine(number1);
  Console.WriteLine(change1(out number1));
  int change1(out int num)
  {
      return num = 100;
  }
  Console.WriteLine(number1);

*/
/*}



}
*/
/*
using System.Data;

public class Program
{

    static void Main()
    {
        *//*  int a = 10;
          int b = 20;
          int c;

          c = a;
          a = b;
          b = c;
          Console.WriteLine(a);
          Console.WriteLine(b);

  */

/*(int,string) tuple=(25,"Murad");
 Console.WriteLine(tuple.Item1);
 Console.WriteLine(tuple.Item2);*//*

//  List<int> ints = new List<int>();






}

}*/




/*namespace OOP
{

    class Program
    {

        delegate void testDelegate(int a, int b);
        static testDelegate test;
        static void Main()
        {
            test += Toplama;
            test += Cixma;
            test += Bolme;
            test += Vurma;

            Delegate[] arr = test.GetInvocationList();

            for (int i = 0; i < arr.Length;i++)
            {
               ((testDelegate)arr[i]).Invoke(3, 5);
            }


        }



        public static void Toplama (int q, int w)
            {
            Console.WriteLine( q + w);
            }
        public static void Cixma(int q, int w)
        {
            Console.WriteLine(q - w);
        }
        public static void Vurma(int q, int w)
        {
            Console.WriteLine(q * w);
        }
        public static void Bolme(int q, int w)
        {
            Console.WriteLine(q / w);
        }



    }
}*/





/*

using Microsoft.VisualBasic;

namespace OOP
{

    class Program
    {
        private static EventArgs e;

        public static event EventHandler Myevent;
       
        static void Main()
        {
            Myevent += Toplama;

            Myevent?.Invoke(null, e);



        }

        private static void Toplama(object? sender, EventArgs e)
        {
            Console.WriteLine("Salam,tanidin mi?");
        }

        *//* public EventHandler Myevent(EventArgs,e)
         {

         }
 */
/*public static void Toplama(int q, int w)
{
    Console.WriteLine(q + w);
}
public static void Cixma(int q, int w)
{
    Console.WriteLine(q - w);
}
public static void Vurma(int q, int w)
{
    Console.WriteLine(q * w);
}
public static void Bolme(int q, int w)
{
    Console.WriteLine(q / w);
}





    }
}
*/




/*using System;

namespace OOP
{
    class Program
    {
        public static event EventHandler MyEvent;

        public delegate void TestDelegate(int q, int w);
        public static TestDelegate TestEvent;

        static void Main()
        {
            TestEvent += Cikarma; // TestEvent delegesine Cikarma metodunu ekliyoruz
            MyEvent += TestEvent; // MyEvent olayına TestEvent delegesini ekliyoruz

            // Olayı tetikleme örneği
            OnMyEvent(EventArgs.Empty);

            // Programın kapanmadan önce bir tuşa basılmasını bekliyoruz
            Console.ReadKey();
        }

        public static void Cikarma(int q, int w)
        {
            Console.WriteLine($"{q} - {w} = {q - w}");
        }

        protected static void OnMyEvent(EventArgs e)
        {
            MyEvent?.Invoke(null, e);
        }
    }
}
*/
/*
using System.ComponentModel;

namespace OOP
{
    class Program
    {
        delegate void Testdelegate(int a, int b);
        static Testdelegate test;
        static event Testdelegate testEvent
        {
            add { Console.WriteLine("elave olundu"); }
            remove { Console.WriteLine("Silindi"); }
        }


        static void Main()
        {
            testEvent += Bolme;
            testEvent -= Bolme;
          
          
        }

        private static void Ad(int a, int b)
        {
            throw new NotImplementedException();
        }

        private static void Vurma(int a, int b)
        {
            throw new NotImplementedException();
        }

        public static void Bolme(int q, int w)
        {
            Console.WriteLine(q * w);
        }

    }
}*/


/*
using System.ComponentModel;

namespace OOP
{
    class Program
    {
        static event EventHandler Myevent;


        static void Main()
        {
            btnClick btnCil = new btnClick()
            {
                Click = "Girildi", Uzunlugu = 45, Eni = 78
            };

            btnInfo info = new btnInfo();
            info.Year = DateTime.Now.Year;
            Myevent += Mymetod;
            
           Myevent.Invoke(btnCil, info);
           //MyEvent?.Invoke(null, EventArgs.Empty);
        }

        public static void Mymetod(object sender, EventArgs e)
            {
            Console.WriteLine(((btnClick )sender).Click);
            Console.WriteLine(((btnInfo)e).Year);
        }
       
    }

    public class btnClick
    {
        public string Click { get; set; }
        public int Uzunlugu { get; set; }
        public int Eni { get; set; }
    }
   public class btnInfo:EventArgs
    {
        public int Year { get; set; }
    }


}*/

/*namespace OOP
{
    class Program
    {
        public delegate int MyDelegate(int a, int b);
        public static event MyDelegate Myevent;

        static MyDelegate myDelegate;
        static void Main()
        {
            myDelegate += Toplama;
            myDelegate += Cixma;
            myDelegate += Vurma;
            Myevent += myDelegate;
           // Console.WriteLine(Myevent.Invoke(3, 5));

            Delegate[] arr = Myevent.GetInvocationList();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(((MyDelegate)arr[i]).Invoke(4, 5));
            }


        }
        public static int Toplama(int s,int d)
        {
            return s + d;
        }
        public static  int Cixma(int s, int d)
        {
            return s - d;
        }
        public static int Vurma(int s, int d)
        {
            return s * d;
        }

    }
}*/
/*using System.Net.Http.Headers;

namespace OOP
{
    class Program
    {
       public static event EventHandler Myevent;

        static void Main()
        {
            Myevent += Mymetod;
            BtnClick btnClick = new BtnClick
            {
                Click = "Salam,tanidin mi?",
                uzunluq = 12,
                eni = 78
            };
            BtnInfo info = new BtnInfo();
            info.Year = DateTime.Now.Year;

            Myevent.Invoke(btnClick, info);

        }

        private static void Mymetod(object? sender, EventArgs e)
        {
            Console.WriteLine(((BtnClick)sender).eni);
            Console.WriteLine(((BtnInfo)e).Year);
        }

        public class BtnClick
        {
            public string Click { get; set; }
            public int eni { get; set; }
            public int uzunluq { get; set; }
        }
        public class BtnInfo:EventArgs
        {
            public int Year { get; set; }
        }

    }
}
  
*//*



using System.Net.Http.Headers;

namespace OOP
{
   public  class Program
    {
        static void Main()
        {

            List<Product> products = new List<Product>();
         
            Product product1 = new Product(1, "Ehmed", 10, 12, 7);
            Product product2 = new Product(2, "Mehmed", 15, 18, 9);
            Product product3 = new Product(3, "Ali", 20, 25, 14);
            Product product4 = new Product(4, "Ayşe", 8, 10, 6);
            Product product5 = new Product(5, "Fatma", 30, 35, 20);
            Product product6 = new Product(6, "Osman", 12, 15, 9);
            Product product7 = new Product(7, "Zeynep", 25, 30, 18);
            Product product8 = new Product(8, "Veli", 18, 22, 12);
            Product product9 = new Product(9, "Gizem", 22, 28, 15);
            Product product10 = new Product(10, "Kemal", 17, 20, 11);

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            products.Add(product5);
            products.Add(product6);
            products.Add(product7);
            products.Add(product8);
            products.Add(product9);
            products.Add(product10);


          

            var result = products.Where(x => x.ProductId < 5 && x.ProductSell < 200).ToList();


            if (result.Any())
            {
                Console.WriteLine("Data tapildi");
            }
            else
            {
                Console.WriteLine("Data tapilmadi");
            }
                foreach (var produ in result)
                {

                    Console.WriteLine($"ProductId: {produ.ProductId}, Name: {produ.ProductName}, Price: {produ.ProductBuy} Sell: {produ.ProductSell}");
                }
                
            
        }


        public class Product
        {
            public int ProductId { get; set; }
            
            public string ProductName { get; set; }
            
            public double ProductSell { get; set; }
           
            public double ProductBuy { get; set; }

            public int ProductCont { get; set; }

            public Product(int id, string name, double sell, double buy, int count)
            {
                ProductId = id;
                ProductName = name;
                ProductSell = sell;
                ProductBuy = buy;
                ProductCont = count;

            }

        }

    }
}



*/

/*using Humanizer.Localisation.TimeToClockNotation;
using System.Runtime.InteropServices;

namespace OOP
{
    public class Program
    {
        static void Main()
        {*//*
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(number);*/

/* Toplam toplam = new Toplam();
 Console.WriteLine(toplam.Sum(5, 5));*//*

var number = 45;
// number = "aaa";

*//*object num = 11;
Console.WriteLine(num);
num = "MURAD";
Console.WriteLine(num);*/

/*string a = "Murad";
Console.WriteLine(a);
a = "Rusdem";
Console.WriteLine(a);*/


/* dynamic a = "Salam";
 Console.WriteLine(a);

 a = 45;
 Console.WriteLine(a);
*/
/*int a = 23;
int b = 30;
Console.WriteLine(a<b?"Bura isleyecek":"Bura islemiyecek");*/
/*
            (int, string, int) tuple;
            tuple.Item1 = 45;
            tuple.Item2 = "Eli";
            tuple.Item3 = 78;
            Console.WriteLine(tuple.Item1);*/

/*  int a = 34;
  int b = 0;


  try
  {
      int result = a / b;
      Console.WriteLine(result);
  }
  catch (Exception ex)
  {
      Console.WriteLine(ex.ToString());
  }*//*


  //  Console.WriteLine(number > 10 ? "Girdiyiniz eded 10 dan boyukdur" : "10-dan balacadir");

}
}
}*/

//using System.Net.Http.Headers;

/*namespace OOP
{
    public class Program
    {
        static void Main()
        {
            GenericClass<int> srt = new GenericClass<int>();


            Console.WriteLine(srt.Sum(2, 4));

        }
    }

    public class GenericClass<T>
    {
        public T Sum(T t, T a)
        {
            dynamic? dyt = t;
            dynamic dya = a;
            return dyt+dya;
        }
    }
*/

/*  public class Number
  {
      public int Num1 { get; set; }
      public int Num2 { get; set; }
  }*/






/*namespace OOP
{
    public class Program
    {
        static void Main()
        {



        }
        public class Toplama<T, A>
        { 
        public 


        }

    }
}
*/
/*namespace OOP
{
    public class Program
    {
        static void Main()
        {
            GenericTest<int> Test = new GenericTest<int>();
            var result = Test.Sum(3, 5);
            Console.WriteLine(result);
        }
    }
    public class GenericTest<T>
    {
        public T Sum(T a,T b)
        {
            dynamic Ta = a;
            dynamic Tb = b;

            return Ta+ Tb; 
        }
    }


}*/


/*namespace OOP
{
    public class Program
    {
        static void Main()
        {
*/
/*  
  Class2 class2 = new Class2(4,"Murad","Qelenderli");


  *//* List<Class1> cll = new List<Class1>();
   foreach (var i in cll)
   {
       Console.WriteLine(i);
   }
*//*
           class2.ALLList();*/

/*  Class2 cl = new Class2("Murad");
  Console.WriteLine(cl.Name);*/

/* Dictionary<int,string> Dic = new Dictionary<int,string>();
 Dic.Add(90, "Baki");
 Dic.Add(20, "Gence");
 var input = int.Parse(Console.ReadLine());

 foreach (var item in Dic) {
 if(input == item.Key)
     {
         Console.WriteLine($"{item.Key} {item.Value}");
     }
 }*/

/*
            Program program = new Program();
            int res=0;
            while(res < 1000){
                int input = int.Parse(Console.ReadLine());
                res = program.Sum(input);

                Console.WriteLine(res);
            }
            }
        int num = 0;
        public int Sum(params int[] input)
        {
            var result = 0;
            foreach (int i in input)
            {

                result = num += i;
            }
            return result;

        }
  /* public int sum(int a, int c, params int[] r)
        {
            return a + c + r[0]; 
        }*/
/* string text = "Bu gun hava buludlu idi";

      bool result = text.Contains("hava");

       Console.WriteLine(result);*/

/*
                        object a = "Murad";
                        bool b = a is string;
                        Console.WriteLine(b);*/

/*object a = "Murad";
string c = a as string;
Console.WriteLine(c);*/


/* var person = new { Name = "Ilkin", LastName = "Rufullayev" };

            Console.WriteLine( person.Name);*/


/*
namespace OOP
{
    public class Program
    {
        delegate int TestDelegate(int a, int b);
        static TestDelegate test;
        static void Main()
        {
            test += Sum;
            test += Cixma;

            Delegate[] arr = test.GetInvocationList();

            for (int a = 0; a < arr.Length; a++)
            {
                TestDelegate cast = (TestDelegate)arr[a];
                Console.WriteLine(cast.Invoke(8,9));
            }


        }

        public static int Sum(int a,int b)
        {
            return a + b;
        }
        public static int Cixma(int a, int b)
        {
            return a - b;
        }

    } 
}*/



/*namespace OOP
{
    public class Program
    {
        delegate string TestDelegate(string a);
        static TestDelegate test;
       static event TestDelegate testEvent;


        static void Main()
        {
            test += Name;
            test += SureName;
            testEvent = test;
            Delegate[] arr = testEvent.GetInvocationList();
            foreach (Delegate a in arr)
            {
                TestDelegate cast = (TestDelegate)a;
                Console.WriteLine(((TestDelegate)a).Invoke("Murad"));   
            }

        }

        public static string Name(string name)
            {
            return name;
            }
        public static string SureName(string sureName)
        {
            return sureName;
        }

    }
}*/


/*namespace OOP
{
    public class Program
    {

        static void Main()
        {
           *//* int input = int.Parse(Console.ReadLine());
            int num = 20;
            Console.WriteLine(num<input ? "Girilen eded boyukdur": "Girilen eded balacadir");
*//*
           A a=new A();
            a.sum(3);
            Console.WriteLine(a.sum(4));

        }
    }
    public class A 
    {
    public new int sum (int a)
        {
            return a;
        }
    }

    public class B:A
    {
        public  int sum(int a)
        {
            return a;
        }
    }

} */

/*(int, string) tuple;
tuple.Item1 = 1;
tuple.Item2 = "Murad";
Console.WriteLine(tuple.Item1);
Console.WriteLine(tuple.Item2);
*/
/*
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace OOP
{
    public class Program
    {

        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
          
            try
            {
                int c = b / a;
                Console.WriteLine(c);
            }
            catch(DivideByZeroException e) 
            {
                Console.WriteLine("0-a bolunmur");
            }
            finally { Console.WriteLine("Salam"); }
        }
    }

}*/
/*
Dictionary<int, string> Dic = new Dictionary<int, string>();
Dic.Add(90, "Baki");
Dic.Add(20, "Gence");
int input = int.Parse(Console.ReadLine());
foreach (var item in Dic)
{
    if (item.Key == input)
    {
        Console.WriteLine(item.Value);
    }
}*/

/*string text = "Bu hava pis idi";
            bool result = text.Contains("pis");
            Console.WriteLine(result);*/


/*int result = 0;
            while (true)
            {
               
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine(Sum(input));
               
               
                int Sum(params int[] a)
                {
                   
                    foreach (int i in a)
                    {
                        result += i;
                    }
                    return result;
                }
            }*/




/*using System.Security.Cryptography.X509Certificates;

namespace OOP
{
    public class Program
    {
         
       
        static void Main()
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Program.Bolme(input1, input2));
        }

        static int Bolme(int a,int b)
        {
            try
            {
                int c = a / b;
                return c;
            }
            catch (Exception w)
            {
                Console.WriteLine(w.Message);
                Console.WriteLine("Sifira bolunmur");
            }
            return default;

        }



    }
}*/
/*
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace OOP
{
    public class Program
    {
        delegate int TestDelegate(int a,int b);
        static TestDelegate testDelegate;
        static event TestDelegate testEvent;    
      
        static void Main()
        {
            testDelegate += Sum;
            testDelegate += Cixma;
            
            testEvent += testDelegate;

            EventHandler handler = new();

         
        Delegate[] arr = testEvent.GetInvocationList();
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(((TestDelegate)arr[i]).Invoke(4,6));
            }
        }
        static int Sum(int a,int b)
        {
            return a + b;
        }

        static int Cixma(int a, int b)
        {
            return a - b;
        }

    }
}

*/

/*using System.Threading.Channels;

namespace OOP
{
    public class Program
    {
        static EventHandler eventHandlers;

        static void Main()
        {
            eventHandlers += Eve;
           

            Click cl = new Click { OnClick = "Click olundu" };

            Size Size = new Size
            {
                Eni = 20,
                Uzunu = 30
            };

            eventHandlers(cl, Size);



            static void Eve(object sender, EventArgs e)
            {
                Console.WriteLine(((Size)e).Uzunu);
               
            }
        }
    }
    public class Click
    {
        public string OnClick { get; set; }
    }
    public class Size:EventArgs
    {
        public int Eni  { get; set; }
        public int Uzunu { get; set; }
    }
*/




/*  
  for (int a = 0; a < 3; a++)
  {
      char c = char.Parse(Console.ReadLine());

      char[] chars = { c };

     e = chars.Reverse().ToArray();

  }
  foreach (var item in arr)
  {
      Console.WriteLine(arr);
  }*/

/*   char c=' ';
   for (int a = 0; a < 3; a++)
   {
       c = char.Parse(Console.ReadLine());

   }*/

/* char a = char.Parse(Console.ReadLine());
 char b = char.Parse(Console.ReadLine());
 char c = char.Parse(Console.ReadLine());

  char[] chars = { a,b,c };
  Array.Reverse(chars);   

 // string a =string.Join("", chars).Reverse();  

  foreach (char q in chars)
  {
      Console.WriteLine(q);
  }*/
/*
            string name = Console.ReadLine();
            string sureName = Console.ReadLine();
            Console.WriteLine($"{name.ToUpper()} {sureName.ToUpper()}");
*/

/*int a = 15;
byte b = (byte)a;*/

/* bool IsOkey = int.TryParse(Console.ReadLine(), out int result);

 if(IsOkey )
 {
     Console.WriteLine("Salam");
 }
*/
/*int.TryParse(Console.ReadLine(), out int result1);
int.TryParse(Console.ReadLine(), out int result2);

bool IsOkey1 = result1 % 2 == 0;
bool IsOkey2 = result2 % 2 == 0;
Console.WriteLine((IsOkey1 == IsOkey2 ) ? "true" : "false");
*/
/* string text = "Azerbaycan";
 bool result = text.Contains("cann");
 Console.WriteLine(result==true?"Var":"Yoxdur");*/

/*  int[,] arr = new int [2 , 3 ];
  arr[0, 0] = 4;
  arr[0, 1] = 4;
  arr[0, 2] = 4;
  arr[1, 0] = 4;
  arr[1, 1] = 4;
  arr[1, 2] = 4;

  int Sum=0;
  for(int i=0;i<arr.GetLength(0);i++)
  {
      for(int j =0;j<arr.GetLength(1);j++)
      {
           Sum += arr[i,j];
      }
  }
  Console.WriteLine(Sum);*/



/* DateTime time = new DateTime ( 1998,07,12 );         

 Console.WriteLine(time.DayOfWeek);*/
/*
            DateTime time = DateTime.Now;
            DateTime.TryParse(Console.ReadLine(), out DateTime result) ;

            *//* 7 / 11 / 1998 12:00:00 AM*//*


            Console.WriteLine(time-result);
*/


/* DateTime time = DateTime.Now;
 var a = time.AddDays(40);
 Console.WriteLine(a.DayOfWeek);*/

/*DateTime time = DateTime.Now;
Console.WriteLine(time);
DateTime.TryParse(Console.ReadLine(), out DateTime result);

if (time.ToShortDateString()== result.ToShortDateString())
{
    Console.WriteLine("Guncell tarixdir");
}
else Console.WriteLine("Guncell deyil");*/


/*  DateTime time = new DateTime(1998, 07, 9);


      time.AddDays(1);

      var a = 7 - (int)time.DayOfWeek;
          var result = time.AddDays(a);

      if(result.DayOfWeek.ToString()=="Sunday")
      {
          Console.WriteLine(result.DayOfWeek);
      }*/

/* DateTime time = new DateTime(1998, 04, 19);
 var day = 31 - time.Day;
 var result2 = time.Day+day;
 var man = 12 - time.Month;
 var result1 = time.Month+man;


 Console.WriteLine($"{result2},{result1},{time.Year}");*/

/*int[] arr = { 45, 78, 5 };
int max = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[0] < arr[i])
    {
       max = arr[i];
    }

}
Console.WriteLine(max);*/


/*   var input = Console.ReadLine();
   switch (input)
   {
       case "1":
           Console.WriteLine("Monday");
           break;
           case "2":
           Console.WriteLine("Tuestday");
           break;
           case "3":
           Console.WriteLine("Wenhday");
           break;
           case "4":
           Console.WriteLine("Thuseday");
           break;
           case "5":
           Console.WriteLine("Frayday");
           break;
           case "6":
           Console.WriteLine("Saturday");
           break;
       case "7":
           Console.WriteLine("Sunday");
           break;
           default: Console.WriteLine("Sef girdiniz");
           break; 
   }
*/


/*  int.TryParse(Console.ReadLine(), out int result1 );   
  int.TryParse(Console.ReadLine(), out int result2 );
  string input = Console.ReadLine();

  switch (input)
  {
      case "+":
          Console.WriteLine(Toplama(result1,result2));
          break;
      case "-":
          Console.WriteLine(Cixma(result1,result2));
          break;
      case "*":
          Console.WriteLine(Vurma(result1,result2));
          break;
          case "/":
          Console.WriteLine(Bolme(result1,result2));
          break;
      case "":
          break;

      default:
          Console.WriteLine("Eded girin");
          break;


  }
  int Toplama(int a,int b)
  {
      return a+ b;
  }

  int Cixma(int a, int b)
  {
      return a - b;
  }

  int Vurma(int a, int b)
  {
      return a * b;
  }

  int Bolme(int a, int b)
  {
      return a / b;
  }
*/
/*int Sum = 0;
  for(int i =0;i<=20;i++)
  {
      if(i%2==1)
      {
          Sum += i;
          Console.WriteLine(i);
      }
  }
  Console.WriteLine(Sum);
*/
/* int.TryParse(Console.ReadLine(), out int result1);

 for(int i=1;i<=result1;i++)
 {
     Console.WriteLine($"1*{i}={i}");
 }
 for (int i = result1; i >= 0; i
)
 {
     Console.WriteLine($"{i}*10={10*i}");
 }*/


/* for (int i = 1; i <= 5; i++)
 {
     for (int j = 1; i >= j; j++)
     {
         Console.Write("*");
     }
     Console.WriteLine();
 }*/


/*  for(int i=0;i<=10;i++)
  {
      for(int j=1;j<=i;j++)
      {
          Console.Write(j);
      }
      Console.WriteLine();
  }
*/

/*  int.TryParse(Console.ReadLine(), out int result);
  int sum = 0;
  for(int i=1;i<=result;i++)
  {
      for(int j=0;j<i;j++)
      {
          sum+=9;
          Console.Write("9");
      }
      Console.WriteLine();
  }
  Console.WriteLine(sum);
*/

/*  int.TryParse(Console.ReadLine(), out int result);
  Console.WriteLine(result <= 5? "2\n3\n5":"2\n3\n5\n7");

  for (int i=0;i<=result;i++)
  {

      for (int j = 2; j < i; j++)
      {
          if (i % j == 0 || i % 3==0 ||i%5==0 || i % 7 == 0)
          {
              break;
          }
        else { Console.WriteLine(i);
              break;
          }

      }*/


/*   int.TryParse(Console.ReadLine(), out int result);

   for (int i = 0; i <= result; i++)
   {
       int saygac = 0;
       for (int j = 1; j <= i; j++)
       {
           if (i % j == 0)
           {
               saygac++;
           }
       }
       if(saygac==2)
       {
           Console.WriteLine(i);

       }

   }*/


/*   bool IsOkey = int.TryParse(Console.ReadLine(), out int result);
  List<int> Arr= new List<int>();
   if(IsOkey)
   {
       for(int i=2;i<result;i++)
       {
           int saygac=0;
           for(int j=1;j<=i;j++)
           {
               if(i % j ==0)
               {
                   saygac++;
               }
           }
           if(saygac==2)
           {
               Console.WriteLine(i);
               Arr.Add(i);
           }

       }
   }
   Console.WriteLine("-------------------------------------------");
   foreach(int i in Arr)
   {
       Console.WriteLine(i);
   }
   Console.WriteLine("Bir eded girin");
   bool IsOkey1 = int.TryParse(Console.ReadLine(), out int result1);
   for(int i=0;i<Arr.Count;i++)
   {
       for (int j = 0; j < i; j++)
       {
           if (Arr[i] + Arr[j]==result1)
           {
               Console.WriteLine($"{Arr[i]}+{Arr[j]}={Arr[i]+Arr[j]}");
           }
       }
   }

*/
/* int.TryParse(Console.ReadLine(), out int result);
 List<int>list1 = new List<int>();
 List<int>list2 = new List<int>();
 char[] ch = result.ToString().ToCharArray();
 Console.WriteLine("Duz");
 for (int i = 0; i < ch.Length; i++)
 {
     list1.Add(ch[i]);
     Console.WriteLine(ch[i]);
 }
 Console.WriteLine("Ters");
 for (int j=ch.Length-1;j>=0;j--)
 {
     list2.Add(ch[j]);
     Console.WriteLine(ch[j]);
 }
 int saygac = 0;
 for (int a = 0; a < list1.Count; a++)
 {
     if (list1[a] == list2[a])
     {
         saygac++;
     }
 }

 if (saygac==list2.Count)
 {
     Console.WriteLine("Palindromdur");
 }
 else { Console.WriteLine("Palindrom deyil"); }
*/

/*   C# sıralama dizisinde hem azalan hem de artan düzende bir program yazın
Dizinin 3.maksimum elemanını bulan bir C# programı yazın.
İlk 4 maksimum elemanı bulan C# dilinde bir program yazın.
*/
/*
            int.TryParse(Console.ReadLine(), out int input);
            Random ran = new Random();
            List<int> list = new List<int>();
            for (int i = 10; i <= input; i++)
            {
                var number = ran.Next(10, 100);
                list.Add(number);
            }
            Console.WriteLine("Artan sira il");
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (list[i] < list[j])
                    {
                        int temp;
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
             foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Min 3 eded");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(list[i]);
            }


            Console.WriteLine("Azalan sira ile");

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (list[i] > list[j])
                    {
                        int temp;
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Max 3 eded");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(list[i]);
            }
*/

/* int first = 10;
 int secund = 20;
 first = first + secund;
 secund = first - secund;
 Console.WriteLine(secund);
 first = first - secund;
 Console.WriteLine(first);
*/
/*
            N sayıdaki Fibonacci dizisini görüntüleyecek bir 
                fonksiyon oluşturmak için C# dilinde bir program yazın. Test Verileri 
                : Fibonacci Serisinin Giriş Sayısı :
                5 Beklenen Çıktı : 5 sayıdan oluşan Fibonacci Serisi : 0 1 1 2 3 5 8*/


/* int a = 0;
 int b = 1;
 int c = 0;
 int.TryParse(Console.ReadLine(), out int result);
 for (int i = 2; i < result; i++)
 {

     c = a + b;
     Console.WriteLine(c);
     b = a;
     a = c;
 }*/

/*int.TryParse(Console.ReadLine(), out int input);
int Sum = 0;
*/


/* char[] arr = input.ToString().ToCharArray();
 int Sum = 0;
 foreach (char c in arr)
 {
     Sum += ord(c);
     Sum +=  Convert.ToInt32(new string(c,arr.Length));
 }
 Console.WriteLine(Sum);*/

/*  int.TryParse(Console.ReadLine(), out int input);
  int a = 0;
  int b = 1;
  int temp = 0;
  for(int i=0;i<input;i++)
  {
      temp = a + b;
      b = a;
      a = temp;
      Console.WriteLine(temp);

  }*/
/*
            string text = "Bu gun hava pisdir";
            char[] chars = text.ToCharArray();  
            int temp = 0 ;
            for (int i = 0; i < chars.Count(); i++)
            {
                if (chars[i].ToString() == " ")
                { temp++; }

            }
            Console.WriteLine(temp);
*/


/*
            int.TryParse(Console.ReadLine(), out int input);

            int c = 0;
            while(input>0)
             {
               c += input % 10;
                input /= 10;
            }
            Console.WriteLine(c);
*/

/*   List<int> ar = new List<int>(); 
   ar.Add(-4);
   ar.Add(3);
   ar.Add(-9);
   ar.Add(0);
   ar.Add(4);
   ar.Add(1);
 // -4 3 - 9 0 4 1
   plusMinus(ar);





}*/
/* public static void plusMinus(List<int> arr)
  {


      for (int i = 0; i < arr.Count; i++)
      {
          if (arr[i] > 0)
          {

             var result = (float)arr[i] / (float)arr.Count;
              Console.WriteLine(string.Format("{0:F6}", Math.Round(result, 6)));

          }
      }

  }
*/
/* staircase(8);

 static void staircase(int n)
 {
     for (int i = 0; i < n; i++)
     {
         int a = n;
         for (int j = 0; j < n-i-1; j++)
         {
             Console.Write(" ");
         }
         for (int q = 0; q <= i; q++)
         {
             Console.Write("#");
         }
         Console.WriteLine();
     }

 }*/


/* int Total = 3;
 Person[] person = new Person[Total];
 for (int i = 0; i < Total; i++)
 {
     person[i] = new Person() {
     Name = Console.ReadLine()
     };


 }

 for(int i=0;i<Total;i++)
 {
     Console.WriteLine( person[i].ToString());

 }

 */

/*  int Total = 3;
  Person[] person = new Person[Total];
  for(int i=0;i<Total;i++)
  {
      person[i] = new Person()
      {
          Name = Console.ReadLine(),
          SureName = Console.ReadLine(),
      };
  }
  for (int i = 0; i < Total; i++)
  {
      Console.WriteLine(person[i].ToString());
  }

*/


/* Student student = new Student();   
    Professor professor = new Professor();
   bool IsOkey = int.TryParse(Console.ReadLine(), out int result);
    if(IsOkey && result==1)
    {
        Console.WriteLine(student.RiteStudent());
        Console.WriteLine(student.Age);
        Console.WriteLine(professor.ProfessorExplaining());
    }


    Console.WriteLine();
*/
/* BigPhoto bp = new BigPhoto();
     Console.WriteLine(bp.phg);
     Photo p = new Photo();  
     Console.WriteLine(p.phg);
     Photo pp = new Photo(24);
     Console.WriteLine(pp.phg);*/



/* Professor pro = new Professor("Murad");
 Student student = new Student("Rufet");
 Student student2 = new Student("Ehmed");
 Console.WriteLine(pro.Name);
 Console.WriteLine(student);
 Console.WriteLine(student2);*/

/*Student stu = new Student();
Person person = new Person();
stu.test();
person.test();*/

/*User user = new User()
{
    Name = "Murad",
    SureName = "Qelenderli",

    Person = new Person10()
    {
        Age = 26, Description = "Back-end developer"

    },
    PersonArr = new Person10[]
    {
        new Person10() { Age=26,Description = "Deli" },
        new Person10() { Age=72,Description = "sfasdfasasd"}

    }

};



var result = JsonConvert.SerializeObject(user,Formatting.Indented);
Console.WriteLine(result);



Console.WriteLine($"Name: {user.Name}");
Console.WriteLine($"Surname: {user.SureName}");
Console.WriteLine($"Person Age: {user.Person.Age}");
Console.WriteLine($"Person Description: {user.Person.Description}");

Console.WriteLine("PersonArr:");
foreach (var person in user.PersonArr)
{
    Console.WriteLine($"- Age: {person.Age}, Description: {person.Description}");
}
*/

/*using Humanizer;
using Newtonsoft.Json;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Linq;
*/
/*namespace OOP
{
    public class Program
    {
        static void Main()
        {*/

/* HttpClient client = new HttpClient();
 const string ApiUrl = "https://www.boredapi.com/api/activity";
 bool IsOkey;
 do
 {
     Console.WriteLine("Facts");
     IsOkey = Convert.ToBoolean(Console.ReadLine());
     var result =await client.GetStringAsync(ApiUrl);
     await Console.Out.WriteLineAsync(result);

     var con = JsonConvert.DeserializeObject<Car>(result);
     Console.WriteLine(con.activity);

 }

 while (IsOkey);


*/

/*   public class Car
   {
       public string? activity { get; set; }
       public string? type { get; set; }
       public string? tecreational { get; set; }
       public string? participants { get; set; }
       public string? price { get; set; }
       public string? link { get; set; }
       public string? key { get; set; }
       public string? accessibility { get; set; }
   }

}*/
/* public class User
 {
     public string Name { get; set; }

     public string SureName { get; set; }

     public Person10 Person { get; set; }

     public Person10[] PersonArr { get; set; }
 }

 public class Person10
 {
     public int Age { get; set; }

     public string Description { get; set; }
 }
}
*/
/*
using Humanizer;
using Newtonsoft.Json;
using System.IO;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace OOP
{
    public class Program
    {
        static void Main()
        {
           

            const string Search = "C:\\Users\\LENOVO\\Desktop";
            const string WriteTXT = "D:\\.TXT";
            const string WriteDLL = "D:\\.DLL";




            
                foreach (string file in GetFiles(Search))
                {
                    Console.WriteLine(file);

                string type = file.Split('.').Last().ToString();

                switch (type)
                {
                    case "txt":
                        if (File.Exists(file))
                        {
                            WriteFile(WriteTXT, file);
                        }
                        break;
                    case "dll":

                        { 
                        WriteFile(WriteDLL, file);
                        }

                        break;


                        static void WriteFile(string WriteFilePath,string context)
                        {
                            string fileName = Path.GetFileName(context);
                            string destinationPath = Path.Combine(WriteFilePath, fileName); 

                         
                            if (!Directory.Exists(WriteFilePath))
                            {
                                Directory.CreateDirectory(WriteFilePath);
                            }

                           
                            File.Copy(context, destinationPath, true);
                            Console.WriteLine("Dosya başarıyla kopyalandı.");

                        }
                }
                }
        }


            static IEnumerable<string> GetFiles(string path)
            {
                Queue<string> queue = new Queue<string>();
                queue.Enqueue(path);
                while (queue.Count > 0)
                {
                    path = queue.Dequeue();
                    try
                    {
                        foreach (string subDir in Directory.GetDirectories(path))
                        {
                            queue.Enqueue(subDir);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine(ex);
                    }
                    string[] files = null;
                    try
                    {
                        files = Directory.GetFiles(path);
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine(ex);
                    }
                    if (files != null)
                    {
                        for (int i = 0; i < files.Length; i++)
                        {
                            yield return files[i];
                        }
                    }
                }
            
*/



/* 
 StreamWriter writer = new StreamWriter(path);

 int i=0;
 while(i<3)
 {
       var input = Console.ReadLine();

     writer.Write(input);
     i++;
 }*/
/*   string name = "Murad";
   using (StreamWriter writer = new StreamWriter(path))
   {
       writer.Write(name);
       writer.WriteLine("Monica Rathbun");
       writer.WriteLine("Vidya Agarwal");
       writer.WriteLine("Mahesh Chand");
       writer.WriteLine("Vijay Anand");
       writer.WriteLine("Jignesh Trivedi");
   }
   // Read a file
   string readText = File.ReadAllText(path);
   Console.WriteLine(readText);
   Console.WriteLine("---------------");
   var a = File.ReadAllLines(path).Last();
   Console.WriteLine(a);*/


/////////////////////////////////////////

/* string path = "D:\\Task\\";
 const string Search = "C:\\Users\\LENOVO\\Desktop";

 int sum = 0;
 foreach (var result in GetFiles(path))
 {
     Console.WriteLine(result);
     sum++;
 }
 Console.WriteLine(sum);
 static IEnumerable<string> GetFiles(string path)
 {
     Queue<string> queue = new Queue<string>();
     queue.Enqueue(path);
     while (queue.Count > 0)
     {
         path = queue.Dequeue();
         try
         {
             foreach (string subDir in Directory.GetDirectories(path))
             {
                 queue.Enqueue(subDir);
             }
         }
         catch (Exception ex)
         {
             Console.Error.WriteLine(ex);
         }
         string[] files = null;
         try
         {
             files = Directory.GetFiles(path);
         }
         catch (Exception ex)
         {
             Console.Error.WriteLine(ex);
         }
         if (files != null)
         {
             for (int i = 0; i < files.Length; i++)
             {
                 yield return files[i];
             }
         }
     }
 }*/


/*     int.TryParse(Console.ReadLine(), out int result);
     List<int> list1 = new List<int>();
     List<int> list2 = new List<int>();
     char[] ch = result.ToString().ToCharArray();
     Console.WriteLine("Duz");
     for (int i = 0; i < ch.Length; i++)
     {
         list1.Add(ch[i]);
         Console.WriteLine(ch[i]);
     }
     Console.WriteLine("Ters");
     for (int j = ch.Length - 1; j >= 0; j--)
     {
         list2.Add(ch[j]);
         Console.WriteLine(ch[j]);
     }
     int saygac = 0;
     for (int a = 0; a < list1.Count; a++)
     {
         if (list1[a] == list2[a])
         {
             saygac++;
         }
     }

     if (saygac == list2.Count)
     {
         Console.WriteLine("Palindromdur");
     }
     else { Console.WriteLine("Palindrom deyil"); }

*/


/*  bool IsOkey = int.TryParse(Console.ReadLine(), out int input);

  if (input>=0)
  {
      CarAddGass addGass = new CarAddGass();
      addGass.Gass(input);
  }
  else
  {
      Car car = new Car();
      car.Gass(0);
  }
*/

//Person person = new Person();

/*using Humanizer;
using Newtonsoft.Json;
using OOP.Abstract;
using OOP.Concrete;
using System.IO;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace OOP
{
    public class Program
    {

        static async Task Main(string[] args)
        {
            *//*IPersonVisualizer visuallizer1 = new PersonVisuallizer1(); 
            IPersonVisualizer visuallizer2 = new PersonVisuallizer2(); 
            Person person = new Person(visuallizer1);
            person.Name = "Test";
            visuallizer1.Print(person);*//*


         
            HttpClient httpClient = new HttpClient();
            const string ApiUrl = "https://official-joke-api.appspot.com/random_joke";
            bool IsOkey = true;
            while (IsOkey)
                {
               var result =await httpClient.GetStringAsync(ApiUrl);
                var deseri = JsonConvert.DeserializeObject<ApiProp>(result);
                ApiProp api = new ApiProp();
             Console.WriteLine(api.punchline);
             Console.WriteLine(deseri.setup);
                
                //Console.WriteLine(deseri);
                IsOkey = Console.ReadLine().ToLower() == "yes";
                if (IsOkey != true)
                {
                    break;
                }
            }
           

        }
        public class ApiProp
        {
            

            public string type { get; set; }
            
            public string setup { get; set; }
            
            public string punchline { get; set; }

            public int id { get; set; }

        }


    }
}*/

/*using Humanizer;
using Humanizer.Localisation.TimeToClockNotation;
using Newtonsoft.Json;
using OOP.Abstract;
using OOP.Concrete;
using System.IO;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace OOP
{
    public class Program
    {

        static async Task Main(string[] args)
        {

            bool IsOkey = false;
            HttpClient client = new HttpClient();
            string ApiUrl = "https://catfact.ninja/fact";

            do
            {
                IsOkey = Console.ReadLine().ToLower() == "yes";
                var result =await client.GetStringAsync(ApiUrl);
              
                var deseri = JsonConvert.DeserializeObject<Cat>(result);
                await Console.Out.WriteLineAsync(deseri.fact);


            }
            while(IsOkey);





        }
    }
    public class Cat
    {
        public string fact { get; set; }
    }

}*/

/*using Humanizer;
using Humanizer.Localisation.TimeToClockNotation;
using Newtonsoft.Json;
using OOP.Abstract;
using OOP.Concrete;
using System.IO;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace OOP
{
    public class Program
    {

        static void Main(string[] args)
        {
            IVizulaizer50 viz1 = new PersonVizulaizer10();
            Person per = new Person(viz1)
            {Name="Murad" };
            per.Print(per);

        }
    }

    public class Person
    {
        private readonly IVizulaizer50 _vizulaizer;
        public Person(IVizulaizer50 _vizulaizer)
        {
            this._vizulaizer = _vizulaizer;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }

        public void Print(Person person)
            {
       _vizulaizer.Vizula(person);
        }

    }


    public interface IVizulaizer50
    {
        public void Vizula(Person person);
     
    }

    public class PersonVizulaizer10:IVizulaizer50
    {
        public void Vizula(Person person)
        {
            Console.WriteLine($"{person.Id}");
            Console.WriteLine($"{person.Name}");
            Console.WriteLine($"{person.SureName}");
        }

    }
    public class PersonVizulaizer20:IVizulaizer50
    {
        public void Vizula(Person person)
        {
            Console.WriteLine($" Person{person.Id}");
            Console.WriteLine($" Person{person.Name}");
            Console.WriteLine($" Person{person.SureName}");
        }

    }*/
/*using Humanizer;
using Humanizer.Localisation.TimeToClockNotation;
using Newtonsoft.Json;
using OOP.Abstract;
using OOP.Concrete;
using System;
using System.IO;
using System.Net.Cache;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace OOP
{
    public class Program
    {

        static void Main(string[] args)
        {
            Disc disc = new Disc();
           
            var a = DriveInfo.GetDrives();
            Console.WriteLine($"Disq sayi {a.Count()}");
            foreach (var item in a)
            {
                GetTotalFreeSpace(item.Name);             
            }
        



            string ConvertMb(long x)
            {
                string[] suffixes =
{ "Bytes", "KB", "MB", "GB", "TB", "PB" };

                int counter = 0;
                decimal number = (decimal)x;
                while (Math.Round(number / 1024) >= 1)
                {
                    number = number / 1024;
                    counter++;
                }
                return string.Format("{0:n1}{1}", number, suffixes[counter]);
            }
            Console.WriteLine(disc.Name);




            void GetTotalFreeSpace(string driveName)
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    Disc disc = new Disc();

                    if (drive.IsReady && drive.Name == driveName)
                    {


                        disc.Name = drive.Name;
                        disc.FireSize = drive.TotalFreeSpace;
                        disc.TotalSize = drive.TotalSize;
                        disc.DiscCount += 1;

                        Console.WriteLine($"Disk adi {disc.Name}");
                        Console.WriteLine($"Disqde olan bos yer{ConvertMb(disc.FireSize)}");
                        Console.WriteLine($"Disqde olan olcu{ConvertMb(disc.TotalSize)}");
                                          
                    }
                }
            }
      

        string GetDiscName()
            {
                var a = DriveInfo.GetDrives();

                foreach (var item in a)
                {
                    return item.Name;
                }
                return "-1";
            }


        }
        class Disc
        {
            public string Name { get; set; }
            public long TotalSize { get; set; }
            public long FireSize { get; set; }
            public int DiscCount { get; set; }


        }
*/

/*using Humanizer;
using Humanizer.Localisation.TimeToClockNotation;
using Newtonsoft.Json;
using OOP.Abstract;
using OOP.Concrete;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace OOP
{
    public class Program
    {

        static async Task Main(string[] args)
        {
            const string DowlandUrl = @"D:\Task\New Bitmap image.bmp";
            string ApiUrl = "https://dog.ceo/api/breeds/image/random";
            HttpClient client = new HttpClient();
            var result1 = await client.GetStringAsync(ApiUrl);
            var result2 = JsonConvert.DeserializeObject<Dog>(result1);
            await Console.Out.WriteLineAsync(result2.Message);



            var result3 = await client.GetStringAsync(result2.Message);
            SaveImage(result2.Message, DowlandUrl, System.Drawing.Imaging.ImageFormat.Bmp);

             void SaveImage(string imageUrl, string filename, ImageFormat format)
            {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead(imageUrl);
                Bitmap bitmap; bitmap = new Bitmap(stream);

                if (bitmap != null)
                {
                    bitmap.Save(filename, format);
                }

                stream.Flush();
                stream.Close();
                client.Dispose();
            }




            using (WebClient client1 = new WebClient())
            {
                //client1.DownloadFile(new Uri(result2.Message), @"C:\Foto");
                
                client1.DownloadFileAsync(new Uri(result2.Message), @"D:\Task");
            }

        }
        class Dog
        {
            public string? Message { get; set; }
            public string? Status { get; set; }
        }
    }
}*/

/*using System.Diagnostics;
using System.Net.Cache;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace OOP
{
    public class Program
    {

        static void Main(string[] args)
        {
            var gcMemoryInfo = GC.GetGCMemoryInfo();
            long installedMemory = gcMemoryInfo.TotalAvailableMemoryBytes;
           
          // it will give the size of memory in MB
            var physicalMemory = (double)installedMemory / 1048576.0;
            var a = physicalMemory / 1024;
            Console.WriteLine($"Ram {a}");
           


            var memory = 0.0;
            Process proc = Process.GetCurrentProcess();
            memory = Math.Round((double)proc.PrivateMemorySize64 / (1024 * 1024), 2);
            proc.Dispose();
            Console.WriteLine($"Istifade olunan yaddas {memory}");

        }
    }
}*/
/*using System;
using System.Diagnostics;
using System.Net.Cache;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace OOP
{
    public class Program
    {

        static void Main(string[] args)
        {


            *//* PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");


             while (true)
             {
                 float cpuUsage = cpuCounter.NextValue();
                 Console.WriteLine("CPU Kullanımı: {0}%", cpuUsage);
                 System.Threading.Thread.Sleep(1000); 
             }*/

/* var a = TimeSpan.FromSeconds(20);
System.Threading.Thread.Sleep(a);
     Process.Start("shutdown", "/s /t 0");*//*

const string FileLogPaht = "D:\\NurlanLog\\text1.txt";
try
{
    int input1 = int.Parse(Console.ReadLine());
    int input2 = int.Parse(Console.ReadLine());
    int a = 5;
    Console.WriteLine(input1 / input2);
}
catch (Exception ex)
{
    DateTime dateTime = DateTime.Now;
    Console.WriteLine(dateTime.ToString());
    File.AppendAllText(FileLogPaht, dateTime.ToString() +'\n'+ ex.ToString());

}

}
}
}*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Null_Reference_Exception
{
    class Program
    {
        static void Main(string[] args)
        {*/
/*
            string[] list = new string[5];
            list[0] = "Sunday";
            list[1] = "Monday";
            list[2] = "Tuesday";
            list[3] = "Wednesday";
            list[4] = "Thursday";
            // list[5] = "Friday";

            try
            {

                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(list[i].ToString());
                }
                Console.ReadLine();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.ToString());
            }
*/
/*  const string FileLogPaht = "D:\\NurlanLog\\text1.txt";
  int num1, num2;
      byte result;

      num1 = 30;
      num2 = 40;
  try
  {
      result = Convert.ToByte(num1 * num2);
      Console.WriteLine("{0} x {1} = {2}", num1, num2, result);

  }

  catch (OverflowException ex)
  {
      File.AppendAllText(FileLogPaht, ex.Message);
      Console.WriteLine(ex.ToString());

  }
  catch(Exception ex)
  {
      Console.WriteLine(ex.Message.ToString());
      File.AppendAllText(FileLogPaht,ex.Message);
  }

  Console.ReadLine();
*/

/* int[] arr = { 1, 2, 3, 4, 5 , 6 };
 for(int i=0;i<arr.Length;i++)
 {
     var con = Convert.ToDouble(arr[i]);

     Console.WriteLine(con);
 }*/

/* bool IsOkey = true ;


 if (IsOkey)
 {


     while(true)
     {
         try
         {
             IsOkey = int.TryParse(Console.ReadLine(), out int input);
             if (input % 2 == 0 && input != 0)
             {
                 Console.WriteLine("Cutdur");
                 continue;
             }
             else if (input % 2 == 0 && input != 0)
             {
                 Console.WriteLine("Tekdir");
                 continue;
             }
         }
         catch(Exception ex)
         {
             Console.WriteLine(ex.ToString());
         }
     }

 }
*/

/* int a = 4;
 MyClass<int> myClass = new MyClass<int>();

 myClass.AddList(1);
 myClass.AddList(45);
 myClass.AddList(24);

 myClass.RemoveList(1);

 Console.WriteLine(myClass.ContainsList(45));
 Console.WriteLine(myClass.CountList());

 foreach ( var item in myClass)
 {
     Console.WriteLine(item);
 }
*/


/*   Dictionary<string,string> person = new Dictionary<string, string>();


   Dictionary<string, bool> characters = new Dictionary<string, bool>()
{
{ "Luke", true },
{ "Han", false },
{ "Chewbacca", false }
};
characters.Remove("Han");
foreach(var item in characters)
{
   Console.WriteLine(item);

}
*/

/*Dictionary<string, int> people = new Dictionary<string, int>()
{
    { "Rauf", 28 }
};

people.Add("Murad", 26);

foreach (var item in people)
{
    Console.W2iteLine(item);
    break;
}*/


/*

              const int result = 100;

              Person[] person = new Person[result];

              for (int i = 0; i < result; i++)
              {Random rnd = new Random();
              var a = rnd.Next(1, 4);


  person[i] = new Person()
      { Id = i + 1, Name = "Peter"+i, SureName = "Alicanov",BirthDate = 25 , FamilyId = a};
  }

  foreach (var p in person)
  {
      Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, SureName: {p.SureName}, FamilyId: {p.FamilyId}");
  }*/




/*       const string FilePath = "D:\\Student\\Student1.txt";


   bool IsOkey = true;
   while (IsOkey)
   {if (IsOkey == true)
       {
           Console.Write("Id: ");
           var Id = int.Parse(Console.ReadLine());

           Console.Write("Ad: ");
           var Name = Console.ReadLine();

           Console.Write("Soyad: ");
           var SureName = Console.ReadLine();
           File.AppendAllText(FilePath, $"Id: {Id.ToString()}'\n'Ad: {Name}'\n'Soyad: {SureName}'\n'");
       }

       Console.WriteLine("Davam etmek isteyirsiz   yes/no");
       IsOkey = Convert.ToBoolean(Console.ReadLine().ToLower() == "yes");

   }*/

/*
            List<Person> people = new List<Person>();

            Person per1 = new Person();
            per1.Id = 1;
            per1.Name = "Murad1";
            per1.SureName = "Qelenderli1";
            per1.FamilyId = 0;
            per1.SonId = 0;
            per1.Generation1 = new List<Person>();
            people.Add(per1);
            per1.Generation1.Add(per1);


            Person per2 = new Person();
            per2.Id = 2;
            per2.Name = "Murad2";
            per2.SureName = "Qelenderli2";
            per2.FamilyId = 1;
            per2.SonId = 1;

            per2.Generation2 = new List<Person>();
            people.Add(per2);
            per2.Generation2.Add(per2);


            Person per3 = new Person();
            per3.Id = 3;
            per3.Name = "Murad2";
            per3.SureName = "Qelenderli2";
            per3.FamilyId = 1;
            per3.SonId = 1;
            per3.Generation2 = new List<Person>();
            people.Add(per3);
            per3.Generation2.Add(per3);


            Person per4 = new Person();
            per4.Id = 4;
            per4.Name = "Murad2";
            per4.SureName = "Qelenderli2";
            per4.FamilyId = 1;
            per4.SonId = 1;
            per4.Generation2 = new List<Person>();
            people.Add(per4);
            per4.Generation2.Add(per4);


            Person per5 = new Person();
            per5.Id = 5;
            per5.Name = "Murad3";
            per5.SureName = "Qelenderli3";
            per5.FamilyId = 2;
            per5.SonId = 2;
            per5.Generation3 = new List<Person>();
            people.Add(per5);
            per5.Generation3.Add(per5);


            Person per6 = new Person();
            per6.Id = 6;
            per6.Name = "Murad3";
            per6.SureName = "Qelenderli3";
            per6.FamilyId = 2;
            per5.SonId = 2;
            per6.Generation3 = new List<Person>();
            people.Add(per6);
            per6.Generation3.Add(per6);


            Person per7 = new Person();
            per7.Id = 7;
            per7.Name = "Murad3";
            per7.SureName = "Qelenderli3";
            per7.FamilyId = 2;
            per5.SonId = 5;
            per7.Generation3 = new List<Person>();
            people.Add(per7);
            per7.Generation3.Add(per7);


            Person per8 = new Person();
            per8.Id = 8;
            per8.Name = "Murad4";
            per8.SureName = "Qelenderli4";
            per5.SonId = 5;
            per8.FamilyId = 3;
            per8.Generation4 = new List<Person>();
            people.Add(per8);
            per8.Generation4.Add(per8);


            Person per9 = new Person();
            per9.Id = 9;
            per9.Name = "Murad4";
            per9.SureName = "Qelenderli4";
            per9.FamilyId = 3;
            per5.SonId = 7;
            per9.Generation4 = new List<Person>();
            people.Add(per9);
            per9.Generation4.Add(per9);


            Person per10 = new Person();
            per10.Id = 10;
            per10.Name = "Murad4";
            per10.SureName = "Qelenderli4";
            per10.FamilyId = 3;
            per5.SonId = 7;
            per10.Generation4 = new List<Person>();
            people.Add(per10);
            per10.Generation4.Add(per10);


            Person per11 = new Person();
            per11.Id = 11;
            per11.Name = "Murad4";
            per11.SureName = "Qelenderli4";
            per11.FamilyId = 3;
            per5.SonId = 7;
            per11.Generation4 = new List<Person>();
            people.Add(per11);
            per11.Generation4.Add(per11);


*/

/*   foreach (var person in per1.Generation1)
   {
       Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, SureName: {person.SureName}, FamilyId: {person.FamilyId}");
   }*/

/*  foreach (var person in per2.Generation2)
  {
      Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, SureName: {person.SureName}, FamilyId: {person.FamilyId}");
  }

  foreach (var person in per6.Generation3)
  {
      Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, SureName: {person.SureName}, FamilyId: {person.FamilyId}");
  }
  foreach (var person in per10.Generation4)
  {
      Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, SureName: {person.SureName}, FamilyId: {person.FamilyId}");
  }*/

/*bool IsOkey = int.TryParse(Console.ReadLine(), out int input);

foreach (var person in people)
{
    //  Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, SureName: {person.SureName}, FamilyId: {person.FamilyId}");

    if (person.FamilyId == 1 && person.Id == input)
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("++++++++++++++++");
        Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, SureName: {person.SureName}, FamilyId: {person.FamilyId}");
        foreach (var person1 in people)
        {
            if (person1.FamilyId == 3)
            {
                Console.WriteLine($"Id: {person1.Id}, Name: {person1.Name}, SureName: {person1.SureName}, FamilyId: {person1.FamilyId}");
            }
        }
    }

    else { Console.WriteLine("Baba deyil"); }

}*/

/*      List<int> list = new List<int>()
      {
          2,4,5,8,44,66,7,77

     };

     List<int>TenBig(List<int> t,int compen )
      {
          var a = new List<int>();
          foreach (int i in t)
          {

              if (i>compen)
              {
                a.Add(i);
              }
          }
          return new List<int>(a);
      }

      List<int> TenBig1(List<int> t, int compen)
      {
          var a = new List<int>();
          foreach (int i in t)
          {

              if (i % compen ==0)
              {
                  a.Add(i);
              }
          }
          return new List<int>(a);
      }



      var a = TenBig1(list,2);

      foreach (int i in a)
      {
          Console.WriteLine(i);
      }
*/
// List<int> list = new List<int>()
/*            {
                2,4,5,8,44,66,7,77

           };
            var result = list.Where(x => x > 10).ToList();
            foreach ( var item in result )
            {
                Console.WriteLine(item);
            }*/
//Student student = new Student();

/* Student[] student = new Student[11];

 List<Student> std = new List<Student>();

 for (int i = 1; i <= 10; i++)
 {
     student[i] = new Student();
     student[i].Id = i;
     student[i].Name ="Murad"+ i.ToString();
     student[i].Age = i+15;
     std.Add(student[i]);
 }

 var result = std.Where(x => x.Age > 22 ).ToList();
  std.RemoveAll(x => x.Age < 19 && x.Name == "Murad2");

 foreach (var item in result)
 {
         Console.WriteLine(item);
 }
 Console.WriteLine("-------------------------");
 foreach (var item in std)
 {
     Console.WriteLine(item);
 }
*/


/*
            NumericFunction f = MakeMultiplier(3.0);
                double input = 5.0;

                Console.WriteLine("factor = {0}", factor);
                Console.WriteLine("input = {0}", input);
                Console.WriteLine("f is a generated function which multiplies its input with factor");
                Console.WriteLine("f(input) = input * factor = {0}", f(input));

    }
    public delegate double NumericFunction(double d);
    static double factor = 4.0;

    public static NumericFunction MakeMultiplier(double factor)
    {
        return delegate (double input) { return input * factor; };
    }
*/

/*using OOP;
using OOP.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Person = OOP.Person;

namespace Null_Reference_Exception
{
    class Program
    {
         *//*public delegate void TestDelegate();

        static public void TestMet()
        {
            Console.WriteLine("First metod");
        }
        static public void TestMet2()
        {
            Console.WriteLine("Secund metod");
        }
*//*


        static void Main(string[] args)
        {
            *//*  // Program program = new Program();
              // public static TestDelegate test;
               TestDelegate test;
              test = TestMet;
              test = TestMet2;
              test.Invoke();

              test();
  */
/* Sum(4, 8 );
void Sum<T1,T2>(T1 a ,T2 b)
 {
     dynamic A = a;
     dynamic B = b;
     Console.WriteLine(A+B);
 }*/
/* User user = new User();
  user.Arqument();*//*

List<Person> people = new List<Person>();




testDelegate del = testDelegate1(MyWhere);

object MyWhere(object obj)
{
    foreach (object o in obj.ToString())
    {
        return o;
    }
    return obj;
}

}

private static testDelegate testDelegate1(Func<object, object> myWhere)
{
return myWhere;
}

public delegate object testDelegate();
}
}
*/

/*
using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    public delegate object TestDelegate();

    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "John", Age = 30 },
            new Person { Name = "Jane", Age = 25 },
            new Person { Name = "Mike", Age = 40 }
        };

        TestDelegate del = TestDelegate1(MyWhere);

     

        object MyWhere()
        {
            foreach (Person person in people)
            {
                if (person.Age > 30)
                {
                    return person;
                }
            }
            return null;
        }

        var result = del();
        if (result != null)
        {
            Person personResult = (Person)result;
            Console.WriteLine($"Found: {personResult.Name}, Age: {personResult.Age}");
        }
        else
        {
            Console.WriteLine("Not found.");
        }
    }

    private static TestDelegate TestDelegate1(Func<object> myWhere)
    {
        return new TestDelegate(myWhere);
    }
}
*/

/*using System.ComponentModel.DataAnnotations;
using System.Linq;*/
/*public class Guest
{
    public string Name { get; set; }
}*/

/*public class Table
{
    public Table()
    {
        Guests = new List<Guest>()
        {
            new Guest(){Name = "John"}
            , new Guest(){Name = "Charlie"}
            , new Guest() {Name = "Jill"}
            , new Guest(){Name = "Jane"}
            , new Guest(){Name = "Martin"}
            , new Guest(){Name = "Ann"}
            , new Guest(){Name = "Eve"}
        };
    }
  
    private List<Guest> Guests { get; set; }

    public int Count => Guests.Count;
*/
/* public Guest this [int index]
 {
     get => Guests[index];
     set => Guests[index] = value;
 }*/


/* public int Countt => Guests.Count();
 public Guest this[string index]
 {
     get
     { 
         return Guests.Where(x => x.Name == index).FirstOrDefault();
     }
    // set => Guests[index].Na = value;
 }
*/

/* static void Main()
 {*/
/*  Table table = new Table();
  Guest guest = new Guest();

  Console.WriteLine( table["Jane"].Name);*/

/*foreach (var item in table.Guests)
{
    Console.WriteLine(item.Name);

}*/
//Console.WriteLine(guest.Name);














/*
using System;

namespace DelegatesAndEvents
{
    public class Program
    {
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }
    }

    public delegate void MyDelegate(ref int intValue);

    public class DelegateExercises
    {
        void Method1(ref int intValue)
        {
            intValue = intValue + 5;
            System.Console.WriteLine("Method1 " + intValue);
        }

        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            MyDelegate myDelegate1 = new MyDelegate(Method1);
            MyDelegate myDelegate2 = myDelegate + myDelegate1;
            int intParameter = 5;
            myDelegate2(ref intParameter);
        }
    }
}
*/





















/*using System.Net.WebSockets;
///fibancci
/// string path = "D:\\Task\\text.txt";
///
namespace OOP
{
    public class Person1
    {
        public string Name { get; set; }

        //public List<Person1> Per { get; set; } 
        public List<Person1> Per { get; set; } = new List<Person1>();


        public Person1 this[int index]
        {
            get { return Per[index]; }

            set { Per[index] = value; }
        }

        public Person1 this[string index]
        {
            get { return Per.Where(x=>x.Name == index).FirstOrDefault(); }
          

        }

        public override string ToString()
        {
            return $"{Name}";
        }

    }

    class Program
    {
        static void Main()
        {
            Person1 person20 = new Person1();
            var a = person20.Name = "Cavad1";
            person20.Per.Add(person20);
           // Person1 person20 = new Person1();
            var a1 = person20.Name = "Cavad2";
            person20.Per.Add(person20);

            var b = new Person1() { Name = "Cavad2" };
            person20.Per.Add(b);
            person20.Per.Add(new Person1() { Name = "Cavad3" });
            person20.Per.Add(new Person1() { Name = "Cavad4" });
            person20.Per.Add(new Person1() { Name = "Cavad5" });
        
           Console.WriteLine(person20[3]);
           Console.WriteLine(person20["Cavad5"]);

        }
    }
}

*/


/* var currentThread = Thread.CurrentThread;
 Console.WriteLine(currentThread.Name);
 var date1 = DateTime.Now.ToString();
 Console.WriteLine(date1);
 currentThread.CurrentCulture = new CultureInfo("az");
 currentThread.CurrentUICulture = new CultureInfo("az");
 var date2 = DateTime.Now.ToString();
 Console.WriteLine(date2);*/
/*
            Thread thread = new Thread(Method2);
            thread.Start();
            Method1();
            //   Thread.Sleep(1000);
            void Method1()
            {
                for (int i = 0; i < 30; i++) {
                    Console.WriteLine($"Method1 {i}");
                    Thread.Sleep(10);
                }
            }
            void Method2()
            {
                for (int i = 0; i < 30; i++)
                {
                    Console.WriteLine($"Method2 {i}");
                    Thread.Sleep(10);
                }
            }
*/


/*
            const string ApiUrl = "https://catfact.ninja/fact";

            bool IsOkey = true;

            do
            {
             
            HttpClient client = new HttpClient();
              var result =await client.GetStringAsync(ApiUrl);
              //  Console.WriteLine(result);
                var deseriyalizeCat = JsonConvert.DeserializeObject<Cat>(result);
                await Console.Out.WriteLineAsync($"{deseriyalizeCat.fact}  {deseriyalizeCat.length}");
                IsOkey = Console.ReadLine().ToLower() == "yes";
            } 
            
            while (IsOkey);

        }
        public class Cat
        {
            public string fact { get; set; }
            public int length { get; set; }
*/



/*using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace OOP
{
    class Program
    {
        public delegate void testDelegate(int a);
        public delegate void testDelegate2(int a);
        static async Task Main()
        {
            testDelegate del;
            testDelegate2 del2;
            del2 = Method3;
            del2 += Method4;
            del = Method1;
            del += Method2;

            
            
            Thread thread = new Thread(() => del(9));
            thread.Start();
            del2(9);

            void Method1(int input)
            {
                for (int i = 0; i < input; i++)
                {
                    Console.WriteLine($"Methot1 {i}");
                    Thread.Sleep(100);
                }
               
            }
            void Method2(int input)
            {
                for (int i = 0; i < input; i++)
                {
                    Console.WriteLine($"Methot2 {i}");
                    Thread.Sleep(100);
                }
            }
                void Method3(int input)
                {
                    for (int i = 0; i < input; i++)
                    {
                        Console.WriteLine($"Methot3 {i}");
                    Thread.Sleep(100);
                }

                }
                void Method4(int input)
                {
                    for (int i = 0; i < input; i++)
                    {
                        Console.WriteLine($"Methot4 {i}");
                    Thread.Sleep(100);
                }
                }*/



/*var input = int.Parse(Console.ReadLine());

int a = 1;
int b = 0;
int c = 0;

List<int> list = new List<int>();
for (int i = 0; i < input; i++)
{
    list.Add(c);

    c = a + b;
    a = b;
    b = c;
}
foreach (int i in list)
{
    Console.WriteLine(i);
}*/
/*
            bool IsBreak = true;

            while (IsBreak)
            {

                Console.WriteLine("1-10 arasinda bir eded girin");
                bool IsOkey = int.TryParse(Console.ReadLine(), out int input);

                Random random = new Random();

                var deger = random.Next(0, 10);
                Console.WriteLine("Hille" + deger);
                if (deger == input)
                {
                    Console.WriteLine("Tapdiniz");
                    break;
                }
                else
                {
                    Console.WriteLine("Tapa bilmediniz");
                }
                Console.WriteLine("Davam etmek isteyirsiz?  yes/no");
                IsBreak = Console.ReadLine().ToLower() == "yes";

            }*/
/*

using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace OOP
{
    class Program
    {
        static void Main()
        {

            List<int> ar = new List<int> { 1, 2, 3, 4, 5, 6 };
          
           int result = divisibleSumPairs(6, 7, ar);
            Console.WriteLine(result);
        }
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int count = 0;
            n = ar.Count;


           // int.TryParse(Console.ReadLine(), out k);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (ar[i] != ar[j] && ((ar[i] + ar[j]) % k) == 0)
                    {
                        
                        Console.WriteLine("--------");
                        Console.WriteLine($"{ ar[i]}  {ar[j]}" 
);
                        count++;

                    }

                }

            }
            return count;



        }
    }
}

*//*
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    *//*
     * Complete the 'divisibleSumPairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY ar
     *//*

    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int sayi= 0 ;
        n = ar.Count;


        int.TryParse(Console.ReadLine(), out k);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (ar[i] != ar[j] && ((ar[i] + ar[j]) % k) == 0)
                {

                    sayi++;

                }

            }

        }
        return sayi;

    }

}*/


/*  public static string kangaroo(int x1, int v1, int x2, int v2)
  {
      int sayac = 0;
      int result1=x1;
      int result2 = x2; ;
      while (sayac < 1000)
      {
           result1 += v1;

           result2 += v2;

          if (result1 == result2)
          {
              return "YES";
          }
          sayac++;

      }

      return "NO";
  }*/


/* public static string kangaroo(int x1, int v1, int x2, int v2)
 {
     int sayac = 0;
     int result1 = x1;
     int result2 = x2; ;
     while (sayac < 1000)
     {
         result1 += v1;

         result2 += v2;

         if (result1 == result2)
         {
             return "YES";
         }
         sayac++;

     }

     return "NO";
}*/
/* public static int sockMerchant(int n, List<int> ar)
 {*/
/*  
  for (int i = 0; i < ar.Count; i++)
  {
      foreach (int x in ar)
      {
          if (ar[i] == x)
          {
              result++;
          }
      }
  }*/

/*            int result = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                for(int X = 0; X < i ; X++)
                {
                    if(i != X)
                    {
                        result++;
                    }
                }
            }






                return result;
        }

        public static int sockMerchant(int n, List<int> ar)
        {
            int result = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                for (int X = 0; X < i; X++)
                {
                    if (i != X)
                    {
                        result++;
                    }
                }
            }
            return result;
        }*/


/* for(int i=0;i<10000;i++)
 {
     if (list1[i] == list2[i])
     {
         return "YES";
     }
 }
 return "NO";*/

/*
            foreach (int x in list1)
            {
                foreach (int v in list2)
                {
                    if (x == v)
                    {
                        return "YES";
                    }
                }
            }
            return "NO";

        }*/


/*   public static int sockMerchant(int n, List<int> ar)
   {
       List<int> list = new List<int>();

       HashSet<int> set = new HashSet<int>(ar);
       int result = 0;
        for (int i = 0; i<set.Count;i++)
       {
           int count = 0;
           for (int j = 0; j < n; j++)
           {
               if (ar[j] == set.ToArray()[i])
               {
                   count += 1;
               }
           }

           if(count % 2 == 0)
           {
               result++;
           }
       }


       return result;*/



/*
        public static int sockMerchant(int n, List<int> ar)
        {
            List<int> list1 = new List<int>();

            HashSet<int> set = new HashSet<int>(ar);

            for (int i = 0; i < set.Count; i++)
            {
                int count = 0;
                foreach (int item in ar)
                {
                    if (item == set.ToArray()[i])
                    {
                        count++;
                    }
                }
                if (count != 1)
                {
                    list1.Add(count);
                }
            }
            int c = 0;
            foreach (int item in list1)
            {

                c += item/2;
            }
            return c ;

        }

        static void Main()
        {
            *//* List<int> list = new List<int>() {
             10 ,20 ,20, 10, 10, 30, 50, 10 ,20 };
 *//*
            List<int> list = new List<int>() {
          1 ,1, 3, 1, 2, 1, 3 ,3 ,3 ,3};

            Console.WriteLine(sockMerchant(10,list));
            //Console.WriteLine(kangaroo(0 ,3,4 ,2));
            // Console.WriteLine(kangaroo(0, 2, 5, 3));

        }
    }
}*/



/*  public static void plusMinus(List<int> arr)
  {
     double Neqativ = 0;
     double Pozitiv = 0;
     double zero = 0;

      foreach(int i in arr)
      {
          if(i==0)
          {
              zero++;
              continue;
          }

          if (i > 0)
          {
              Pozitiv++;
              continue;
          }
          else
          { 
          Neqativ++;
              continue;
          }

      }
      Console.WriteLine($"{Math.Round(Pozitiv / (double)arr.Count(), 6):F6}\n" + 
          $"{Math.Round(Neqativ / (double)arr.Count(), 6):F6}\n" +
            $"{Math.Round(zero / (double)arr.Count(), 6):F6}");
          */

/*   public static string timeConversion(string s)
   {

       if (s.Contains("PM"))
       {
           var c1 = s.Split("PM");
           foreach (var x in c1)
           {
               var sub = x.Substring(0, 2);
               var convert = Convert.ToInt32(sub);
               var result = convert + 12;

               if (result == 24)
               {

                   var delete1 = x.Remove(0, 2);
                   var a1 = delete1.Insert(0, "12");
                   return a1;
               }
               var delete = x.Remove(0, 2);
               var a = delete.Insert(0, result.ToString());
               return a;
           }
       }
       else
       {
           var c2 = s.Split("AM");

           foreach (var x in c2)
           {
             var a=  x.Substring(0, 2);
               if(a=="12")
                   {
                   var delete1 = x.Remove(0, 2);
                   var a1 = delete1.Insert(0, "00");
                   return a1;
               }

               return x;
           }
       }
       return s;
   }*/





/* public static List<int> gradingStudents(List<int> grades)
     {
         List<int> result = new List<int>();

         foreach (int a in grades)
         {
             if (a % 5 == 3 && a > 33)
             {
                 result.Add(a + 2);
                 continue;
             }
             if (a % 5 == 4 && a > 38)
             {
                 result.Add(a + 1);
                 continue;
             }

             result.Add(a);

         }
         return result;
     }*/



/*
        robocopy "C:\Program Files\Microsoft SQL Server" "D:\Program Files\Microsoft SQL Server" /sec /move /e

mklink "C:\Program Files\Microsoft SQL Server" "D:\Program Files\Microsoft SQL Server" /j

*/




/*  Aşağıdakileri bilgi önem derecesi olarak kaydeden özel bir ara yazılım yazalım: İsteğin zaman damgasını
  günlüğe kaydeder URL'nin tamamını günlüğe kaydeder Http yöntemini günlüğe kaydeder (GET, POST vb.) 
      Appsettings.json dosyasında "LogBody" yapılandırması doğru olarak bildirilirse, varsa gövdeyi 
      günlüğe kaydedin Tüm isteğin yanıt süresini, uygulamanın isteğinizi hangi saniyede işlediğini 
      günlüğe kaydedin Aşağıdaki Çalışan nesnesine sahibiz İD İsim Soyadı Doğum günü Konum Maaş İş 
      Yöneticisi Aşağıdakileri yapmamız gerekiyor EmployeeController'da Çalışan için bellekte CRUD
      uygulaması oluşturun Yalnızca Kullanıcı Pozisyonunu, Maaşını ve IsManager özelliklerini değiştirmeliyiz*/






/* List<int> list = new List<int>() { 4, 73, 67, 38, 33 };

 var result = gradingStudents(list);
 foreach (int i in result)
 {
     Console.WriteLine(i);
 }*/


/* Console.WriteLine(timeConversion("11:01:00 AM"));*/

/*List<int>list = new List<int>() { -4, 3, - 9, 0, 4, 1 };
plusMinus(list);*/

/*   string time = "07:05:45";
   var sub = time.Substring(0, 2);
   var convert = Convert.ToInt32(sub);
   var result = convert + 12;
  var delete = time.Remove(0, 2);
   var a = delete.Insert(0, result.ToString());
   Console.WriteLine(a);


   Console.WriteLine(time);
   Console.WriteLine(result);*/




/*   var c = b.Split("PM");*/

/*    foreach (var x in c)
    {
        //  Console.WriteLine(x.Substring(1, 2));
        if (x == "PM") { Console.WriteLine("salam"); }
        Console.WriteLine(x);
    }
   */


/*    if (hours >= 12)
        {
            AmOrPm = "PM";
        }

        if (hours > 12)
        {
            hours -= 12;
        }

        TimeSpan timeSpanAmPm = new TimeSpan(hours, minutes, 0);

        returnValue = timeSpanAmPm.ToString(@"h\:mm") + " " + AmOrPm;
    }


    return returnValue;
*/


/*
            Semin evində bol meyvə verən alma ağacı və portağal ağacı var.Aşağıdakı
            məlumatlardan istifadə edərək, Semin evinə düşən alma və portağalların sayını təyin edin.

            Aşağıdakı diaqramda:

            Qırmızı bölgə başlanğıc nöqtəsi olan evi ifadə edir və son nöqtədir.Alma ağacı evin solunda, 
                portağal ağacı isə sağındadır.
           Ağacların alma ağacının nöqtədə və portağal ağacının nöqtədə 
                olduğu bir nöqtədə yerləşdiyini düşünək.
           Meyvə ağacından düşəndə, o, oxu boyunca mənşə ağacından məsafə vahidlərinə enir. * Mənfi dəyəri
                meyvənin vahid ağacın soluna düşdüyünü, müsbət qiyməti isə ağacın sağ tərəfinə düşdüyünü bildirir. *
          Alma və portağal(2).png*/

/*

    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Net.NetworkInformation;
    using System.Security.Cryptography.X509Certificates;
    using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string ApiUrl = "https://api.nationalize.io/?name=nathaniel";

            HttpClient client = new HttpClient();
            var js = await client.GetStringAsync(ApiUrl);
            //  Console.WriteLine(json);


            var result1 = JsonConvert.DeserializeObject<Root>(js);
            var result2 =  JsonConvert.DeserializeObject(js).ToString();

            var result =JsonConvert.DeserializeObject<Country>(js);
            await Console.Out.WriteLineAsync(result2);
            Country con = new Country();
            Root ro = new Root();
          //  await Console.Out.WriteLineAsync(con.probability.ToString());
         //   await Console.Out.WriteLineAsync(ro.name.ToString());


        }

    }
    public class Country
    {
        public string country_id { get; set; }
        public double probability { get; set; }
    }

    public class Root
    {
        public int count { get; set; }
        public string name { get; set; }
        public List<Country> country { get; set; }
*/
/*

        private static event EventHandler MyEvent;

       
     

        static void Main()
        {
            MyEvent += Top;
            Button btn = new Button() { 
            Text = "OK",
            Text2="Ok2"
            };

            Olcu olcu = new Olcu()
            {
                Left = 40,
                Rait = 45  
            };

            MyEvent(btn, olcu);
        }



        private static void Top(object? sender, EventArgs e)
        {
            Console.WriteLine(((Button)sender).Text);
            Console.WriteLine(((Olcu)e).Rait);
        }

public class Button
        {
            public string Text { get; set; }
            public string Text2 { get; set; }
        }
        public class Olcu:EventArgs
        {
            public int Left { get; set; }
            public int Rait { get; set; }
        }
    }
}*/

/*using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP
{
    class Program
    {
        static event EventHandler MyEvent;

       static public void Main()
        {
            MyEvent += Top;
            MyEvent += Test;
           

            Button btn = new Button()
            {
                Text1 = "OK",
                Text2 = "Cancel"
            };
            Button2 btn2 = new Button2()
            {
                Text3 = "Execute",

            };

            MyEvent.Invoke(btn, btn2);  

        }
        private static void Test(object? sender, EventArgs e)
        {
            Console.WriteLine(((Button)sender).Text2);
        }

        static private void Top(object? sender, EventArgs e)
        {
            Console.WriteLine(((Button)sender).Text1);
            Console.WriteLine(((Button2)e).Text3);
        }

        public class Button
        {
            public string Text1 { get; set; }
            public string Text2 { get; set; }
        }

        public class Button2:EventArgs
        {
            public string Text3 { get; set; }
        }

    }
}*/

/*
    {
       public delegate int mydel(int a, int b);
        public static event EventHandler Myevent;
      static  mydel del;

        static void Main()
        {
            Myevent += publicer;



            del = toplama;

            del += cixma;

            *//*   var arr = del.GetInvocationList();

               for (int a =0; a < arr.Length;a++)
               {
                   Console.WriteLine(((mydel)arr[a]).Invoke (4,6));
               }
   *//*
          

            Myevent(4,args.Empty    );
        }

        private static void publicer(object? sender, EventArgs e)
        {
            var arr = del.GetInvocationList();


            for (int a = 0; a < arr.Length; a++)
            {
                Console.WriteLine(((mydel)arr[a]).Invoke((int)sender, args.num));
            }

        }

        public class args:EventArgs
        {
            static public int num { get; set; } = 10;
        }


        static public int toplama(int a,int b)
        {
            return a + b;
        }

        static public int cixma(int a, int b)
        {
            return a - b;
        }*/

using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP
{
    class Program {

      

        delegate void Mydelegete(int a,int b);
     public  static event EventHandler MyHandler;

      static  Mydelegete del;
        static  public void Main()
        {
            MyHandler += myevent;
           
            
            
            
            del = toplama;
            del += cixma;


            Button1 button1 = new Button1() { Num1=45,Num2=50};
            Button2 button2 = new Button2() { Num3=145,Num4=150};

            MyHandler(button1.Num1, button2);


        }
       

        public static void myevent(object? sender, EventArgs e)
        {
            
            del((int)sender,((Button2)e).Num3);
        }

        public static void toplama(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public static void cixma(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }

    public class Button1
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
    }
    public class Button2:EventArgs
    {
        public int Num3 { get; set; }
        public int Num4 { get; set; }
    }

    class Myclass
    {
        public Myclass(string name)
        {
            this.Name = name;
        }
        public Myclass(string name, string SureN) : this(SureN)
        {
            this.SureName = SureName;
        }
        public Myclass(string name, int age):this(name)
        {
           
            Age = age;
        }

        public string Name { get; set; }
        public string SureName { get; set; }

        public Myclass(int age)
        {
            this.age = age;
        }
        int age;
        public int Age
        {
            get { return age; }
            set 
            { 
            if(0<value)
                {
                    age = value;
                }
            }
        }

    }



}