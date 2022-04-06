#ifndef Function 
#define Function

#include <iostream>
#include <cmath>

int isPrime(int n) {
    // Returns true if n is prime. False otherwise

    float sqrtn = sqrt(n);
    if (n < 2) return false; // 0 and 1 are not primes
    if (n < 4) return true; // 2 and 3 are the first primes
    if (n % 2 == 0) return false; // 2 is the only even prime
    for (int d = 3; d <= sqrtn; d += 2) {
        if (n % d == 0) return false; // n has a nontrivial divisor

    return true; // n is no nontrivial divisor
    }

    return 0;
}
#endif