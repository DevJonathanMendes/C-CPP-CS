#include <iostream>
using std::cin;
using std::cout;
using std::endl;

int main(){
    double hours, value;
    while(1){
        cout << "Enter with hours worked: ";
        cin >> hours;
        if(hours == -1)
            return 1;
        cout << "Enter the value per hour worked: ";
        cin >> value;
        cout << "Wage: R$" << (hours > 40 ? hours * value + 0.50 * value : hours * value) << endl;
    }
    return 0;
}