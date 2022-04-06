#include <iostream>
#include <cmath>

using namespace std;

int main() {
    int user, x, y; // x, y are the two thingies we need later
    cout << "Here is what you can do: \n\n1. Additon\n2. Subtraction\n3. Multiplication\n4. Division\n5. Square Root\n";
    cout << "\nAlso, please read the README.md before using this to avoid confusion (Maybe? Probably?)\n";
    cout << "\nChoices: 1/2/3/4/5 | Choose one: "; cin >> user;

    if (user == 1 or user == 2 or user == 3 or user == 4 or user == 5) {
        system("clear"); // Config. this based on your OS' terminal command for clearing the screen, for windows, use 'cls' instead of 'clear'     
    }
   
    else {
        system("clear"); // Config. this based on your OS' terminal command for clearing the screen, for windows, use 'cls' instead of 'clear'
        cout << "\nError: Could not find choice '" << user << "'. Program Terminated.\n"; 

        
        char n;
        cout << "\nEnter anything to exit: "; cin >> n;
	return 0;
    }

    cout << "\nEnter a number: "; cin >> x;
    cout << "Enter another number (Enter a garbage value here if you are using Square root!): "; cin >> y; 


    switch (user) {
        case 1:
        {int r = x + y;
        cout << "\nResult: " << r << endl;}
        break;

        case 2:
        {int r = x - y;
        cout << "\nResult: " << r << endl;}
        break;

        case 3:
        {int r = x * y;
        cout << "\nResult: " << r << endl;}
        break;

        case 4:
        {int r = x / y;
        cout << "\nResult: " << r << endl;}
        break;

        case 5:
        {int r = sqrt(x);
        cout << "\nResult: " << r << endl;}
        break;
    }
    return 0;
}