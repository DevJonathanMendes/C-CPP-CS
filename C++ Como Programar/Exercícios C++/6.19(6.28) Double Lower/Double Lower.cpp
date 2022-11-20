#include <iostream>
using namespace std;

double doubleLower(double, double, double);

int main(){
    double num1, num2, num3;
    cout << "Provide 3 double numbers:" << endl;
    cin >> num1 >> num2 >> num3;
    cout << "Lower: " << doubleLower(num1, num2, num3);
}

double doubleLower(double n1, double n2, double n3){
    double lower = n1;
    if(lower > n2)
        lower = n2;
    if(lower > n3)
        lower = n3;
    return lower;
}