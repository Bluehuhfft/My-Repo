#include <iostream>

using namespace std;

int main() {

    // Before you start complaining: This kinda isn't guessing, but with only 3 clues, it can find your the number you just thought! The algorithm used in this program is called 'binary search'.

    char ans;
    cout << "\nThink of any number between 1-8.";
    cout << "\nGuessing Process: Please Answer these questions below, as instructed.\n";
    // Guessing Process Begins:
    cout << "\nIs the number you thought: \n";
    cout << "\nLess than 5? (Y/N): "; cin >> ans;
    if (ans == 'Y' or ans == 'y')  { // 1 <= n <= 4
    cout << "Less than 3? (Y/N): "; cin >> ans;
    if (ans == 'Y' or ans == 'y') { // 1 <= n <= 2
    cout << "Less than 2? (Y/N): "; cin >> ans;
    if (ans == 'Y' or ans == 'y') cout << "\nMy Guess: Your number is 1\n";
    else cout << "\nMy Guess: Your number is 2\n";}    
    else { // 3 <= n <= 4
    cout << "Less than 4? (Y/N): "; cin >> ans;
    if (ans == 'Y' or ans == 'y') cout << "\nMy Guess: Your number is 3\n";
    else cout << "\nMy Guess: Your number is 4\n";}}
    else { // 5 <= n <= 8
    cout << "Less than 7? (Y/N): "; cin >> ans;
    if (ans == 'Y' or ans == 'y') { // 5 <= n <= 6
    cout << "Less than 6? (Y/N): "; cin >> ans;
    if (ans == 'Y' or ans == 'y') cout << "\nMy Guess: Your number is 5\n";
    else cout << "\nMy Guess: Your number is 6";}
    else { // 7 <= n <= 8
    cout << "Less than 8? (Y/N): "; cin >> ans;
    if (ans == 'Y' or ans == 'y') cout << "\nMy Guess: Your number is 7\n";
    else cout << "\nMy Guess: Your number is 8\n";}}
    return 0;}