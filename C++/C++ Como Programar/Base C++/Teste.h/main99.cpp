// main99.cpp
#include <iostream>
using std::cout;
using std::cin;
using std::endl;
using std::fixed;

#include <iomanip>
using std::setw;
using std::setprecision;

#include <cmath>
using std::pow;

#include <cstdlib>
using std::srand;
using std::rand;

#include <ctime>
using std::time;

int main(){
    unsigned seed;
    cout << "Enter seed: ";
    cin >> seed;
    srand(seed);

    for(int counter = 1; counter <= 10; counter++){
        cout << setw(4) << (1 + rand() % 6);

        if(counter % 5 == 0)
            cout << endl;
    }
    return 0;
}