#include <iostream>
using std::cin;
using std::cout;
using std::endl;

int main(){
    double sales;
    while(1){
        cout << "Enter dollar sales: ";
        cin >> sales;
        if(sales == -1)
            return 1;
        cout << "Wage: " << 0.09 * sales + 200 << endl;
    }
    return 0;
}