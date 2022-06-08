#include <iostream>
#include <climits> // Defines the constants SHRT_MIN, etc.

using namespace std;

int main() {
    // This program prints some of the constants stored in the <climits> header:
    cout << "\nMinimum short: " << SHRT_MIN << endl;
    cout << "Max. short: " << SHRT_MAX << endl;
    cout << "Min. unsigned short: 0\n"; 
    cout << "Max. unsigned short: " << USHRT_MAX << endl;
    cout << "Min. integer: " << INT_MIN << endl;
    cout << "Max. integer: " << INT_MAX << endl;
    cout << "Min. unsigned integer: 0\n";
    cout << "Max. unsigned int: " << UINT_MAX << endl;
    cout << "Min. long: " << LONG_MIN << endl;
    cout << "Max. long: " << LONG_MAX << endl; 
    return 0;
}