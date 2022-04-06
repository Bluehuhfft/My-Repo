#include <iostream>
#include "Function.h"

// This program is quite impractical, but hey! If you can do it using your brain, why not make a program to do it too?

using namespace std;

void printDate(int, int, int);
// Prints the given date in literal form

int main() {

    // Tests printDate() function

    int month, day, year;
    cout << "\nProvide your input (DD/MM/YYYY): "; cin >> day >> month >> year;
    printDate(month, day, year);

    return 0;
} 

