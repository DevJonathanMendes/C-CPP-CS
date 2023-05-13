#include <iostream>
using std::cout;
using std::cin;
using std::endl;

int smallest(int, int, int);

int main(){
    int x, y, z;

    cout << "Number 1: ";
    cin >> x;
    cout << "Number 2: ";
    cin >> y;
    cout << "Number 3: ";
    cin >> z;

    cout << "Small number: " << smallest(x, y, z) << endl;
}

int smallest(int x, int y, int z){
    int small = x;

    if(y < small)
        small = y;
    if(z < small)
        small = z;

    return small;
}