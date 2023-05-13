#include <iostream>
using std::cout;
using std::cin;
using std::fixed;

#include <iomanip>
using std::setprecision;

double intToDouble(int);

int main(){
    int number;
    cout << "Number: ";
    cin >> number;
    cout << "int to double: " << fixed << setprecision(2) << intToDouble(number);
}

double intToDouble(int number){
    return number;
}