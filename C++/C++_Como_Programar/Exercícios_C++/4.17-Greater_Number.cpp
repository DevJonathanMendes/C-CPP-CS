#include <iostream>
using std::cin;
using std::cout;
using std::endl;

int main(){
    int counter = 0, number = 0, largest1 = 0, largest2 = 0;
    while(counter < 3){
        counter++;
        cout << "Number: ";
        cin >> number;
        if(number > largest2){
            if(number > largest1){
                largest2 = largest1;
                largest1 = number;
            }
            else if(number < largest1)
                largest2 = number;
        }
    }
    cout << "\nFirst highest number: " << largest1 << endl;
    cout << "Second highest number: " << largest2 << endl;
    return 0;
}