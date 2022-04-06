#include <iostream>
#include "Function.h"

using namespace std;

int main() {
    // tests the isLeap() function:

    int n;
    cout << "\nEnter year: "; cin >> n;

    if(isLeap(n)) cout << n << " is a leap year.\n";
    else cout << n << " is not a leap year.\n";
}