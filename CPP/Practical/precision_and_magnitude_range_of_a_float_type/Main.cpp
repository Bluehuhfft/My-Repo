#include <iostream>
#include <cfloat> // Defines the FLT constants
using namespace std;

int main() {

    // Prints the storage size of the fundamental types:
    int fbits = 8 * sizeof(float); // Each byte contains 8 bits

    cout << "\nFloat uses " << fbits << " bits: \n\t "
    << FLT_MANT_DIG - 1 << " bits for its mantissa. \n\t "
    << fbits - FLT_MANT_DIG << " bits for its exponent. \n\t "
    << 1 << " bit for its sign\n\t"
    << " to obtain: " << FLT_DIG << " sig. digits\n" 
    << " with minimum value: " << FLT_MIN << endl
    << " and maximum value: " << FLT_MAX << endl;
    return 0;
}