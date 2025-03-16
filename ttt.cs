






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

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}


// Global using directives (C# 10 feature)
global using System;

namespace MyApp; // File-scoped namespace (C# 10 feature)

public class Program
{
    public static void Main()
    {
        var person = new Person("Alice", 25);
        Console.WriteLine(person);

        var updatedPerson = person with { Age = 26 }; // Record struct with expression-based mutation
        Console.WriteLine(updatedPerson);
    }
}

// Record struct (C# 10 feature)
public readonly record struct Person(string Name, int Age);




#include <stdio.h>

int main() {
    printf("Hello, World!\n");
    return 0;
}


#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX_STUDENTS 100

// Structure to store student details
typedef struct {
    int id;
    char name[50];
    float marks;
} Student;

Student students[MAX_STUDENTS];
int studentCount = 0;

// Function to add a student
void addStudent() {
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

    studentCount++;
    printf("Student added successfully!\n");
}

// Function to display all students
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