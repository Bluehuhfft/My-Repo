#include <cstdlib> // defines the rand() and srand() functions
#include <iostream>

using namespace std;

int main() {
    // Prints pseudo-random-numbers:
    unsigned seed;

    cout << "Enter Seed: "; cin >> seed; 
    srand(seed); // initializes the seed
    for (int i = 0; i < 8; i++) {
        cout << "Random number: " << rand() << endl;
    }

    char a;
    cout << "\nEnter anything to exit: "; cin >> a; // Exit mechanism
    return 0;
}