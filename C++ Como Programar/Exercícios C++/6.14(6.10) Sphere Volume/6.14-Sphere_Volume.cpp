#include <iostream>
using std::cout;
using std::cin;

#include <cmath>
using std::pow;

const double PI = 3.14159;
inline double sphereVolume(double);

int main(){
    double radius;
    cout << "Radius: ";
    cin >> radius;
    cout << sphereVolume(radius);
    return 0;
}

inline double sphereVolume(double radius){
    return 4.0 / 3.0 * PI * pow(radius, 3);
}