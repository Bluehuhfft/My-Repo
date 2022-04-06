#ifndef Function
#define Function

#include <iostream>

using namespace std;

bool isLeap(int y) {

    // Returns true if it is a leap year. False otherwise

    return ((y % 4 == 0) && ((y % 100 != 0) || (y % 400 == 0)));
}
#endif

