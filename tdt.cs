using system;
using system.Collections.Generic;
using system.linq;
using system.Text;
using system.Threading.Tasks;

namespace Hello
// {
//   {
    {
// {

//     class program
//     {
//         static void great(string name)
//         {
//           console.WriteLine("good morning" + name);
//         }
//         static int average(int a, int b, int c)
//         {
//           float sum = a + b + c;
//           return sun /3;      





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

            // console.WriteLine("enter your name");
            // string name = console .readline();
            // console.WriteLine("hey hello "+ name);
            
            // console.WriteLine("how many books do you want?");
            // string can = console .readline();
            // console.WriteLine(" you will get 4 more books" + 
            //              (convert.toint32can (can)+ 4));
            // operators in c#
            // 1. arithmetic operators
            // 2. assignment operators
            // 3. logical operators 
            // 4. comparison operators

            // int a = 4
            // int b = 2
            // consolw.WriteLine("the volue of a + b is:" +(a + b ));
            // consolw.WriteLine("the volue of a - b is:" +(a - b ));
            // consolw.WriteLine("the volue of a * b is:" +(a * b ));
            // consolw.WriteLine("the volue of a / b is:" +(a / b ));


            // assignment operators
            // int a = 4 ;
            // int b = a;
            // b += 4;
            // b -= 4;
            // b *= 4;
            // b /= 4;
            // console.WriteLine (b);

            // // logical operators 
            // console.WriteLine(true && false);
            // console.WriteLine(true && true);
            // console.WriteLine(false && false);

            // console.WriteLine(true || false);
            // console.WriteLine(true || true);
            // console.WriteLine(false || false);
            // console.WriteLine(!false);
            // console.WriteLine(!true);

            // // comparison operators
            // console.WriteLine(324>556);
            // console.WriteLine(324<=556);
            // console.WriteLine(324>=556);
            // console.WriteLine(324!=556);
            // console.WriteLine(55==55);
            // console.WriteLine(324_>556);

            // int a = math.min(34,345);
            // double a = math.sqrt(39);
            // // double a = math.abs(39);
            // int a = math.abs(-39);
            // console. WriteLine(a);

            // string hello = "hello world thise is shabbir";
            // console.WriteLine(hello.lenght);
            // console.WriteLine(hello.toupper());
            // console.WriteLine(hello.tolower);
            // console.WriteLine(hello + "you are nice");
            // console.WriteLine(string.concat(hello + "you are nice"));
            // string name = console.readline();
            // string candis = console.readline();
            // console.WriteLine($"your name is{name}.you will get {candis} candis")



            // string hello = "hello world thise is shabbir";
            
            // console.WriteLine(hello[0]);
            // console.WriteLine(hello[1]);
            // console.WriteLine(hello[2]);
            // console.WriteLine(hello[3]);
            // console.WriteLine(hello[7]);

            // console.WriteLine(helle.indexof("hello"))
            // console.WriteLine(helle.indexof("thise"))
            // console.WriteLine(helle.indexof("shabbir"))

            // console.WriteLine(hello.substring(1));
            // console.WriteLine(hello.substring(5));

            // console.WriteLine(hello);


            // int age = 56;
            // console.WriteLine("enter your name");
            // string agestr  = console.readline();
            // int age = 16;
            // // if(age > 18)
            // if(age < 2)
            // {
            //   console.WriteLine("you can drive");
            //   console.WriteLine("you are just born");
            
            // // }
            // else if (age <10)

            // {
            //   // console.WriteLine("you can not drive");
            //   console.WriteLine("finish your school");
            // }

            // else if age (age < 18)
            // {
            //   console.WriteLine("you are below 18");
            // }
            // else if(age < 75) 
            // {
            //   console .WriteLine("you can drive");
            // }
            // else
            // {
            //   console.WriteLine("you can not drive");
            // }


            // int age = 78;

            // switch(age)
            // {
            //   case 18 ;
            //      console.WriteLine("please wain for an year");
            //      break;

            //   case 20 ;
            //      console.WriteLine("you are 20");
            //      break;

            //   default ;
            //      console.WriteLine("enjoy!")
            //      break;
            // }


            // loops in c sharp
            // console.WriteLine(1);
            // console.WriteLine(2);
            // console.WriteLine(3);
            // console.WriteLine(4);
            // console.WriteLine(5);
            // console.WriteLine(6);
            // console.WriteLine(7);

            // better alternative = loops
            // while loops
            // int i = 0;
            // while (i < 5)
            // {
            //   console.WriteLine(i+1);
            //   i++;
            // }




            //     int i = 0;
            
            // do {
            //   console.WriteLine(i+1);;
            //   i++;
            // }
            // while (i < 5);

            // for (int i=0; i<5; i++)
            // {
            //   if ( i==0 )
            //   {
            //     continue;
            //   }
              
            //   console.WriteLine(i + 1);'
            //   // break;
            // }

                      // break and continue'
            // break - leave this loop forever;
            // continue:leave this particular interation of the loop;








        switch (choice) {
            case 1:
                addStudent();
                break;
            case 2:
                displayStudents();
                break;
            case 3:
                searchStudent();
                break;
            case 4:
                deleteStudent();
                break;
            case 5:
                printf("Exiting...\n");
                exit(0);
            default:
                printf("Invalid choice! Please try again.\n");
        }
    }

    return 0;
}


#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX_STUDENTS 100
typedef struct {
    int id;
    char name[50];
    float marks;
} Student;

Student students[MAX_STUDENTS];
int studentCount = 0
int main() {
    int choice;


   while (1) {
        printf("\nStudent Management System\n");
        printf("1. Add Student\n");
        printf("2. Display Students\n");
        printf("3. Search Student\n");
        printf("4. Delete Student\n");
        printf("5. Exit\n");
        printf("Enter your choice: ");
        scanf("%d", &choice);


class DigitalClock
{
    static void Main()
    {
        while (true)
        {
            Console.Clear(); // Clear the console to update the clock display
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss")); // Display current time
            Thread.Sleep(1000); // Wait for 1 second before updating
        }
    }
}
     {    
            single line comment example - Thise is importent for debugging. do note remove

            multi line comment example 
            thise is a multi-line comment 
            spanning multiple lines


            int shabbir = 19;//integer variable 
            
            string inp = console .readline  ();
            console.WriteLine(inp);
            Console.WriteLine( "hellow world ");
            Console.Write( "hellow shabbir ");
            Console.WriteLine( "i like programing ");
            Console.WriteLine( "i like programing and code" + harry);
   