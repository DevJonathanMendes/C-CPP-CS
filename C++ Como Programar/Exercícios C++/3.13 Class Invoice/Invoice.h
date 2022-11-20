#include <iostream>
using std::cout;
using std::endl;

#include <string>
using std::string;

class Invoice{
    public:
        Invoice(string identifiedNumber, string description, int amount, int price){
            setIdentifiedNumber(identifiedNumber);
            setDescription(description);
            setAmount(amount);
            setPrice(price);
        }

        void setIdentifiedNumber(string setIdentifiedNumber){
            identifiedNumber = setIdentifiedNumber;
        }

        void setDescription(string setDescription){
            description = setDescription;
        }

        void setAmount(int setAmount){
            if(setAmount >= 0)
                amount = setAmount;
            if(setAmount < 0){
                amount = 0;
                cout << "The supplied quantity of items is not valid. No changes were made." << endl;
            }
        }

        void setPrice(int setPrice){
            if(setPrice > 0)
                price = setPrice;
            if(setPrice <= 0){
                price = 0;
                cout << "The price provided for the item is not valid. No changes were made." << endl;
            }
        }

        string getIdentifiedNumber(){
            return identifiedNumber;
        }

        string getDescription(){
            return description;
        }

        int getAmount(){
            return amount;
        }

        int getPrice(){
            return price;
        }

        int getInvoiceAmount(){
            return amount * price;
        }

    private:
        string identifiedNumber, description;
        int amount, price;
};