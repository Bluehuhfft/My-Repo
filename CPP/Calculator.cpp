// #L: 30:: Enter your choice as the corresponding number for your choice.
// #Overall:: The second number (n1) is your dividend or subtrahend.

#include <iostream>

using namespace std;

void add(float a, float b) {
    cout << "Res: " << a + b << endl;
}

void sub(float mi, float su) {
    cout << "Res: " << mi - su << endl;
}

void Mul(float a, float b) {
    cout << "Res: " << a * b << endl;
}

void div(float divd, float div) {
    cout << "Res: " << divd / div << endl;
}


int main() {
    int user;
    float n, n1;
    cout << "Enter a number: "; cin >> n; cout << "Enter another number: "; cin >> n1;
    system("cls");
    cout << "Choose: [Addition / Subtraction / Multiplication / Division]\n";
    cout << "Enter: "; cin >> user;

    switch (user) {
        case 1:
        add(n, n1);
        break;

        case 2:
        sub(n, n1);
        break;

        case 3:
        Mul(n, n1);
        break;

        case 4:
        div(n, n1);
        break;

        default:
        cout << "Error: Choice not found\n";
        break;
    }

    return 0;
}