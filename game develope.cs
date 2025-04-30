


note  prject about game in c# programing language 
5 game code 



SECTION 1:
introduction to C# programing language & unity  


SECTION 2:
frist game development named obstacle avoiding game 


SECTION 3:
scond game development named rocket booster game 


SECTION 4:
third game development named jet fighter game 


SECTION 5:
fourth game development named realm rush game 


SECTION 6:


last game development named frist person shoter game 





int main() {
    printf("hellow pw");
    printf(\n)
    printf("hellow lw");
    return 0;
    float x = 5
    float c = 9
    float r = 3
    float z = 5 / 2.5;'';
    printf("%f",z);

    int r = 5;
    int v = 4 * 3.14 * r * r * r / 3;
    printf("the volume is : %f",v);
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

// public class DigitalClock : Form

