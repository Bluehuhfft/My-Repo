#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main() {
    int user;
    float x, y;

    printf("Here's what you can do:\n");
    printf("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Square Root\n");
    printf("\nAlso, please read the README.md file to avoid any confusion you might have\n");
    printf("\nChoices: 1/2/3/4/5 | Choose one: "); scanf("%d", &user);

    if ((user == 1) || (user == 2) || (user == 3) || (user == 4) || (user == 5)) {
        system("clear"); // Config. based on your OS
    }

    else {
        char a;
        system("clear"); // Config. based on your OS
        printf("\nError: %d not recognized as an programmed input, Type anything to exit: ", user); scanf("%s", &a);
    }

    printf("\nEnter a number: "); scanf("%f", &x);
    printf("Enter another number (Leave blank if you are using Square root): "); scanf("%f", &y);

    switch (user) {
        case 1: {
            float r = x + y;
            printf("\nResult: %f\n", r);
        } break;

        case 2: {
            float r = x - y;
            printf("\nResult: %f\n", r);
        } break;

        case 3: {
            float r = x * y;
            printf("\nResult: %f\n", r);
        } break;

        case 4: {
            float r = x / y;
            printf("\nResult: %f\n", r);
        } break;

        case 5: {
            float r = sqrt(x);
            printf("\nResult: %f\n", r);
        }
    }

     return 0;
}