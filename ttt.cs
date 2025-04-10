
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
/ Structure to store student details
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

    return 0;
}


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
    using System;
using System.Drawing;
using System.Windows.Forms;

public class DigitalClock : Form
{
    private Label timeLabel;
    private Timer timer;

    public DigitalClock()
    {
        this.Text = "Digital Clock";
        this.Size = new Size(300, 150);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        
        timeLabel = new Label();
        timeLabel.Font = new Font("Arial", 24, FontStyle.Bold);
        timeLabel.Dock = DockStyle.Fill;
        timeLabel.TextAlign = ContentAlignment.MiddleCenter;
        
        this.Controls.Add(timeLabel);
        


        timer = new Timer();
        timer.Interval = 1000; // Update every second
        timer.Tick += new EventHandler(UpdateClock);
        timer.Start();
        
        UpdateClock(null, null);
    }

    private void UpdateClock(object sender, EventArgs e)
    {
        timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new DigitalClock());
    }
}


// afsaf
// sfaf
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




