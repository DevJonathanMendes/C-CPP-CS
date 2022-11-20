#include <iostream>
using std::cout;
using std::endl;

#include "Invoice.h"

int main(){
    Invoice JonathanCart("\nMilk (1L) (Qtd 2);\nCornflakes (1Kg) (Qtd 2).\n", "Breakfast.\n", 4, 70);
    cout << "Jonathan's cart:\n" << JonathanCart.getIdentifiedNumber() << endl;
    cout << "Description:\n" << JonathanCart.getDescription() << endl;
    cout << "Invoice:\nR$ " << JonathanCart.getInvoiceAmount() << endl;
    
    return 0;
}