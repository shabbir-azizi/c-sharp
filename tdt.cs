using system;
using system.Collections.Generic;
using system.linq;
using system.Text;
using system.Threading.Tasks;

namespace Hello
{

    class program
    {

        static void Main (string []args)
        {    
            // single line comment example - Thise is importent for debugging. do note remove

            // multi line comment example 
            // thise is a multi-line comment 
            // spanning multiple lines


            // int shabbir = 19;//integer variable 
            
            // string inp = console .readline  ();
            // console.WriteLine(inp);
            // Console.WriteLine( "hellow world ");
            // Console.Write( "hellow shabbir ");
            // Console.WriteLine( "i like programing ");
            // Console.WriteLine( "i like programing and code" + harry);
         


            /* data type in c#:
            integer - int shabbir ; --> 4 bytes
            long - long harry; --> 8 bytes
            floating point number - float that; --> 4 bytes
            double - double  harry; --> 8 bytes

            character - char a = 'A';--> 2 bytes
            boolean -  bool is great = true;--> 1 bit
            // string - string inp = "shabbir";--> 2 bytes per character
              */


              // data types examples
            // int a = 34;
            // float b = 34.4f;
            // double  c = 34.4d;
            // bool is great = true ;
            // char d = 'r';
            // string e = "thise is a string "
            // console .WriteLine(a);
            // console .WriteLine(b);
            // console .WriteLine(c);
            // console .WriteLine(is great);
            // console .WriteLine(d);
            // console .WriteLine(e);
           

            // type casting 
            // there are to type of type casting
            // 1. implicit casting 
            // char to int to long to float to double
            // 2. explicit casting 
            // int x = (int)3.5;
            // double x1 = (double) 3.5;
            // console.WriteLine(x1);
            // int x = 3;
            // double y = x;
            // int z = 'y';
            // float varr = convert.taint32(3.55);
            // string sx ="34 is amazing ";
            // float ax1 = 34.4;
            // convert .todouble
            // convert .to string
            // string sx = "random string";

            // console.WriteLine(x);
            // console.WriteLine(y);
            // console.WriteLine(z);

            console.WriteLine("enter your name");
            string name = console .readline();
            console.WriteLine("hey hello "+ name);
            
            console.WriteLine("how many books do you want?");
            string can = console .readline();
            console.WriteLine(" you will get 4 more books" + 
                         (convert.toint32can (can)+ 4));
            console.readline();
             }
    }
}



