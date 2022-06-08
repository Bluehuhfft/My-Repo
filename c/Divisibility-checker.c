
#include <stdio.h>


int main() {
    
    int x, y, r;
    

    printf("Enter the dividend: "); scanf("%d", &x);
    printf("Enter the divisor: "); scanf("%d", &y);

    if (x == 0 && y == 0) {
        printf("\nThis question does not make sense.\n");
    } else if (x == 0) {
        printf("\nThe answer is 0.\n");
    } else if (y == 0) {
        printf("The problem is non-divisible.\n");
    } 

    r = x % y;

    if (r == 0) {
        printf("\nResult: %d is divisible by %d because they leave no remainder, when divided.\n", x, y, r);
    } else {
        printf("\nResult: %d is not divisible %d because it leaves %d as remainder, when divided.\n", x, y, r);
    }
}