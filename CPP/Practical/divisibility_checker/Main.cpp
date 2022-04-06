#include <iostream>

using namespace std;

int main() {

    int n1, n2, r2;
    double r;

    cout << "\n------------------------------- Divisibility Checker (CPP) -------------------------------\n";

    cout << "Enter the dividend: "; std :: cin >> n1;
    cout << "Enter the divisor: "; std :: cin >> n2; 

    if (n1 == 0 and n2 == 0){
        cout << "\nThat is completely and utterly silly, please don't ask such silly questions.\n";
        return 0;}
        
    else if (n1 == 0) {
        cout << "\nHow are you going to do that? How are you going to divide 0 bananas among " << n2 << " monkeys? The answer is 0.\n";
        return 0; }

    else if (n2 == 0) {
        cout << "\nHow are you going to do that? How are you going to divide " << n1 << " bananas among 0 monkeys? The answer is non-divisible.\n";
        return 0;
    }
    
    r2 = n1 % n2;


    if (r2 == 0) {
        cout << "\nDividend = " << n1 << "\nDivisor = " << n2 << "\n\nLet's check if its divisible: " << n1 << " & " << n2 << " == 0\n";
        cout << "\nTherefore: Are they divisible? Yes, they are divisible because they leave no remainder, when divided.\n";
        return 0;
    } 
    else {
        cout << "\nDividend = " << n1 << "\nDivisor = " << n2 << "\n\nLet's check if its divisible: " << n1 << " & " << n2 << " != 0\n";
        cout << "\nTherefore: Are they divisible? No, they are not divisible because they leave " << r2 << " as remainder, when divided.\n";
        return 0;
    }

    return 0;
}