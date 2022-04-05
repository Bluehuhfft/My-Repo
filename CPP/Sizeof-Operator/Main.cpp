#include <iostream>


using namespace std;

int main() {

    // Prints the storage sizes of the fundamental types.
    cout << "\nNumber of bytes used: \n\n";
    cout << "Char: " << sizeof(char) << endl;
    cout << "Short: " << sizeof(short) << endl;
    cout << "Long: " << sizeof(long) << endl; 
    cout << "Int: " << sizeof(int) << endl;
    cout << "Unsigned Char: " << sizeof(unsigned char) << endl;
    cout << "Unsigned Short: " << sizeof(unsigned short) << endl;
    cout << "Unsigned Int: " << sizeof(unsigned int) << endl;
    cout << "Unsigned Long: " << sizeof(unsigned long) << endl;
    cout << "Signed Char: " << sizeof(signed char) << endl;
    cout << "Float: " << sizeof(float) << endl;
    cout << "Double: " << sizeof(double) << endl;
    cout << "Long Double: " << sizeof(long double) << endl;

    return 0;
}