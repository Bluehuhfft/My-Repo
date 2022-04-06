#include <cstdlib>  // Defines the rand() function and RAND_MAX constant
#include <iostream>

using namespace std;

int main() {
    // Prints pseudo-random-numbers:
    for (int i = 0; i < 8; i++) {
        cout << "Random number: " << rand() << endl;
    }

    cout << "\nRAND_MAX = " << RAND_MAX << endl; // Basically, the pseudo-number cannot be higher than this
    return 0;
}



