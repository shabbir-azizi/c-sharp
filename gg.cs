



















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







