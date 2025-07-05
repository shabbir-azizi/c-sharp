// typedef struct {
//     int id;
//     char name[50];
//     float marks;
// } Student;
// Student students[MAX_STUDENTS];
// int studentCount = 0;
// int main() {
//     printf("Hello, World!\n");
//     return 0;
// }


// #include <stdio.h>
// #include <stdlib.h>
// #include <string.h>

// #define MAX_STUDENTS 100
// typedef struct {
//     int id;
//     char name[50];
//     float marks;
// } Student;

// Student students[MAX_STUDENTS];
// int studentCount = 0
// int main() {
//     int choice;

    // while (1) {
    //     printf("\nStudent Management System\n");
    //     printf("1. Add Student\n");
    //     printf("2. Display Students\n");
    //     printf("3. Search Student\n");
    //     printf("4. Delete Student\n");
    //     printf("5. Exit\n");
    //     printf("Enter your choice: ");
    //     scanf("%d", &choice);

        // switch (choice) {
        //     case 1:
        //         addStudent();
        //         break;
        //     case 2:
        //         displayStudents();
        //         break;
        //     case 3:
        //         searchStudent();
        //         break;
        //     case 4:
        //         deleteStudent();
        //         break;
        //     case 5:
        //         printf("Exiting...\n");
        //         exit(0);
    //         default:
    //             printf("Invalid choice! Please try again.\n");
    //     }
    // }

//     return 0;
// }


// namepace hello
// {
//     o references
//     class Program
    {
        // o references
//         static void main ( straing[]args)
//         {
//             console.WriteLine("Hellow world");
//             console.readline();
//         }

//     }
// }

//    return 0;
}


// namepace hello
// {
//     o references
//     class Program
//     {
 //       o references
//         static void main ( straing[]args)
//         {
//             console.WriteLine("Hellow world");
//             console.readline();
//         }

//     }
// }

// using System;
// using System.Threading;

// class DigitalClock
// {
//     static void Main()
//     {
//         while (true)
//         {
//             Console.Clear(); // Clear the console to update the clock display
//             Console.WriteLine(DateTime.Now.ToString("HH:mm:ss")); // Display current time
//             Thread.Sleep(1000); // Wait for 1 second before updating
//         }
//     }
// }


// void addStudent() {
//     if (studentCount >= MAX_STUDENTS) {
//         printf("Student limit reached!\n");
//         return;
//     }

//     printf("Enter Student ID: ");
//     scanf("%d", &students[studentCount].id);
//     printf("Enter Student Name: ");
//     scanf(" %[^\n]", students[studentCount].name);
//     printf("Enter Student Marks: ");
//     scanf("%f", &students[studentCount].marks);
// void addStudent() {
    if (studentCount >= MAX_STUDENTS) {
        printf("Student limit reached!\n");
        return;
    }

    printf("Enter Student ID: ");
    scanf("%d", &students[studentCount].id);
    printf("Enter Student Name: ");
    scanf(" %[^\n]", students[studentCount].name);
    printf("Enter Student Marks: ");
    scanf("%f", &students[studentCount].marks);
