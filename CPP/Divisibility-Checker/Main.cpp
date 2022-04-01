#include <iostream>

int main() {

    int n1, n2, r2;
    double r;

    std :: cout << "\n------------------------------- Divisibility Checker (CPP) -------------------------------\n";

    std :: cout << "Enter the dividend: "; std :: cin >> n1;
    std :: cout << "Enter the divisor: "; std :: cin >> n2; 

    if (n1 == 0 and n2 == 0){
        std ::  cout << "\nThat is completely and utterly silly, please don't ask such silly questions.\n";
        
        char i;
        std :: cout << "Press <anykey> and then <enter> to exit: "; std :: cin >> i;
        return 0;}
        
    else if (n1 == 0) {
        std :: cout << "\nHow are you going to do that? How are you going to divide 0 bananas among " << n2 << " monkeys? The answer is 0.\n";

        char i;
        std :: cout << "Press <anykey> and then <enter> to exit: "; std :: cin >> i;
        return 0; }

    else if (n2 == 0) {
        std :: cout << "\nHow are you going to do that? How are you going to divide " << n1 << " bananas among 0 monkeys? The answer is non-divisible.\n";

        char i;
        std :: cout << "Press <anykey> and then <enter> to exit: "; std :: cin >> i;
        return 0;}
    
    r2 = n1 % n2;


    if (r2 == 0) {
        std :: cout << "\nDividend = " << n1 << "\nDivisor = " << n2 << "\n\nLet's check if its divisible: " << n1 << " & " << n2 << " == 0\n";
        std :: cout << "\nTherefore: Are they divisible? Yes, they are divisible because they leave no remainder, when divided.\n";
    } 
    else {
        std :: cout << "\nDividend = " << n1 << "\nDivisor = " << n2 << "\n\nLet's check if its divisible: " << n1 << " & " << n2 << " != 0\n";
        std :: cout << "\nTherefore: Are they divisible? No, they are not divisible because they leave " << r2 << " as remainder, when divided.\n";
    }

    char i;
    std :: cout << "Press <anykey> and then <enter> to exit: "; std :: cin >> i;
    return 0;}