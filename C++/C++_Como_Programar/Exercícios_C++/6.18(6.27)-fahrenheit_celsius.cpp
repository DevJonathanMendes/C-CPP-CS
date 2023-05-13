#include <iostream>
#include <iomanip>
using namespace std;


int celsius(int);
int fahrenheit(int);

int main(){
    cout << "102 Fahrenheit to celsius: " << fixed << setprecision(2) << celsius(102) << endl;
    cout << " 38 Celsius to fahrenheit: " << fixed << setprecision(2) << fahrenheit(38) << endl;
}

int celsius(int temperature){
    return (temperature - 32.0) * (5.0 / 9.0);
}

int fahrenheit(int temperature){
    return temperature * 1.8 + 32;
}