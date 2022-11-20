#include <iostream>
using std::cin;
using std::cout;
using std::endl;

#include <iomanip>
using std::setprecision;
using std::fixed;

int main(){
    double km, liters;
    while(1){
        cout << "Mileage: ";
        cin >> km;
        if(km == -1)
            //exit(1);
            return 1;

        cout << "Liters: ";
        cin >> liters;
        if(liters == -1)
            //exit(1);
            return 2;
        cout << "km/l from this tank: " << setprecision(6) << fixed << km / liters << endl;
    }
    return 0;
}