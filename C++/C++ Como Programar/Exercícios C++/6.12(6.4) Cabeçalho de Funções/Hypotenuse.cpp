#include <iostream>
using std::cout;
using std:: cin;
using std::endl;

double hypotenuse(double, double);

int main(){
    double cateto1, cateto2;
    
    cout << "Cateto b: ";
    cin >> cateto1;
    cout << "Cateto c: ";
    cin >> cateto2;

    cout << "Hypotenuse: " << hypotenuse(cateto1, cateto2);
}

double hypotenuse(double side1, double side2){
    return side1 * side1 + side2 * side2;
}