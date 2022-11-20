#include <cmath>
#include <iostream>
using std::cout;
using std::cin;
using std::endl;

inline int roundToInteger(double);
inline double roundToTenths(double);
inline double roundToHundredths(double);
inline double roundToThousandths(double);

int main(){
    double x;
    while(1){
        cout << "Number to round to integer: ";
        cin >> x;
        cout << "Number rounded to integer: " << roundToThousandths(x) << "\n" << endl;
    }
}

// Arredonda para o inteiro mais próximo.
inline int roundToInteger(double number){
    return number = floor(number + .5);
}

// Arredonda para o décimo mais próximo.
inline double roundToTenths(double number){
    return number = floor(number * 10 + .5) / 10;
}

// Arredonda para o centésimo mais próximo.
inline double roundToHundredths(double number){
    return number = floor(number * 100 + .5) / 100;
}

// Arredonda para o milésimo mais próximo.
inline double roundToThousandths(double number){
    return number = floor(number * 1000 + .5) / 1000;
}