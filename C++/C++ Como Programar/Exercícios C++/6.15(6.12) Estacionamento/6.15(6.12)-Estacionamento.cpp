#include <iostream>
using std::cout;
using std::cin;
using std::endl;
using std::fixed;

#include <iomanip>
using std::setw;
using std::setprecision;

const double minimumRate = 2.00, additionalFee = 0.50;

inline double calculateCharges(double);

int main(){
    double car1, car2, car3;
    
    cout << "Car hours 1: ";
    cin >> car1;
    cout << "Car hours 2: ";
    cin >> car2;
    cout << "Car hours 3: ";
    cin >> car3;
    cout << endl;

    cout << "Car" << setw(10) << "Hours" << setw(10) << "Charge" << endl;
    cout << "1" << setw(12) << fixed << setprecision(1) << car1 << setw(10) << setprecision(2) << calculateCharges(car1) << endl;
    cout << "2" << setw(12) << setprecision(1) << car2 << setw(10) << setprecision(2) << calculateCharges(car2) << endl;
    cout << "3" << setw(12) << setprecision(1) << car3 << setw(10) << setprecision(2) << calculateCharges(car3) << endl;
    cout << "TOTAL" << setw(8) << setprecision(1) << car1 + car2 + car3 << setw(10) << setprecision(2) << calculateCharges(car1) + calculateCharges(car2) + calculateCharges(car3);

    return 0;
}

inline double calculateCharges(double hours){
    if(hours >= 24.00)
        return 10;
    if(hours <= 3.00)
        return 2;
    if(hours > 3.00)
        return (hours - 3) * additionalFee + minimumRate;
}