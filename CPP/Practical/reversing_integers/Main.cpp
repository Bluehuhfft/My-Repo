#include <iostream>

using namespace std;

int main() {

	long m, d, n = 0;

	cout << "Enter a positive integer: "; cin >> m;
	while (m > 0) {


		d = m % 10; // D will be the right-most digit of m
		m /= 10; // Then remove that digit from m
		n = 10 * n + d; // and append that digit to n
	} cout << "\nThe reverse is: " << n << endl;


	return 0;
}