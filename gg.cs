



















 Function to search for a student by ID
void searchStudent() {
    int id;
    printf("Enter Student ID to search: ");
    scanf("%d", &id);

    for (int i = 0; i < studentCount; i++) {
        if (students[i].id == id) {
            printf("\nStudent Found!\n");
            printf("ID: %d\nName: %s\nMarks: %.2f\n", students[i].id, students[i].name, students[i].marks);
            return;
        }
    }
    printf("Student not found!\n");
}

// Function to delete a student record
void deleteStudent() {
    int id, found = 0;
    printf("Enter Student ID to delete: ");
    scanf("%d", &id);

    for (int i = 0; i < studentCount; i++) {
        if (students[i].id == id) {
            found = 1;
            for (int j = i; j < studentCount - 1; j++) {
                students[j] = students[j + 1];
            }
            studentCount--;
            printf("Student record deleted successfully!\n");
            return;
        }
    }
    if (!found) {
        printf("Student not found!\n");
    }
}













/
public readonly record struct Person(string Name, int Age);




#include <stdio.h>




void displayStudents() {
    if (studentCount == 0) {
        printf("No students to display.\n");
        return;
    }

    printf("\nStudent Records:\n");
    printf("ID\tName\t\tMarks\n");
    printf("---------------------------------\n");

    for (int i = 0; i < studentCount; i++) {
        printf("%d\t%s\t%.2f\n", students[i].id, students[i].name, students[i].marks);
    }


void searchStudent() {
    int id;
    printf("Enter Student ID to search: ");
    scanf("%d", &id);

    for (int i = 0; i < studentCount; i++) {
        if (students[i].id == id) {
            printf("\nStudent Found!\n");
            printf("ID: %d\nName: %s\nMarks: %.2f\n", students[i].id, students[i].name, students[i].marks);
            return;
        }
    }
    printf("Student not found!\n");
}





typedef struct {
    int id;
    char name[50];
    float marks;
} Student;

Student students[MAX_STUDENTS];
int studentCount = 0;


int main() {
    printf("Hello, World!\n");
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
int studentCount = 0;











namepace hello
{
    o references
    class Program
    {
        o references
        static void main ( straing[]args)
        {
            console.WriteLine("Hellow world");
            console.readline();
        }

    }
}



using System;
using System.Threading;

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





using System;
using System.Threading;

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