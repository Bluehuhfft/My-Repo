// Note: If your compiler does not recognise the <ctime> header, then use pre-standard <time.h> header instead.

#include <iostream>
#include <ctime> // defines the time() function
#include <cstdlib>

using namespace std;

int main() {

    // Prints pseudo-random-numbers:
    unsigned seed = time(NULL);

    cout << "Seed = " << seed << endl;
    srand(seed);
    for (int i = 0; i < 8; i++) {
        cout << "Random number: " << rand() << endl;
    }

    char a;
    cout << "\nEnter anything to exit: "; cin >> a; // Exit mechanism
    return 0;
}
