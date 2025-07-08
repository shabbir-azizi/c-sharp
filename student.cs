
//     studentCount++;
//     printf("Student added successfully!\n");
// }
// / Structure to store student details
// typedef struct {
//     int id;
//     char name[50];
//     float marks;
// } Student;

// Student students[MAX_STUDENTS];
// int studentCount = 0;

// // Function to add a student
// void addStudent() {
//     if (studentCount >= MAX_STUDENTS) {
//         printf("Student limit reached!\n");
//         return;
//     }


}

   for (int i = 0; i < studentCount; i++) {
        if (students[i].id == id) {
            printf("\nStudent Found!\n");
            printf("ID: %d\nName: %s\nMarks: %.2f\n", students[i].id, students[i].name, students[i].marks);
            return;
        }
    }
    printf("Student not found!\n");
}