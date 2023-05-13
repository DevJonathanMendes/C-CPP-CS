#include <iostream>
using std::cout;
using std::endl;

class Date{
    public:
        Date(int day, int month, int year){
            setDay(day);
            setMonth(month);
            setYear(year);
        }

        void setDay(int setDay){
            if(setDay > 0)
                day = setDay;
            if(setDay > 31){
                day = 1;
                cout << "The date provided is not valid. Changing to 1." << endl;
            }
            if(setDay < 1){
                day = 1;
                cout << "The date provided is not valid. Changing to 1." << endl;
            }
        }

        void setMonth(int setMonth){
            if(setMonth > 0)
                month = setMonth;
            if(setMonth > 12){
                month = 1;
                cout << "The date provided is not valid. Changing to 1." << endl;
            }
            if(setMonth < 1){
                month = 1;
                cout << "The date provided is not valid. Changing to 1." << endl;
            }
        }

        void setYear(int setYear){
            if(setYear > 1900)
                year = setYear;
            if(setYear > 2150){
                year = 2000;
                cout << "The date provided is not valid. Changing to 2000." << endl;
            }
            if(setYear < 2000){
                year = 2000;
                cout << "The date provided is not valid. Changing to 2000." << endl;
            }
        }

        int getDay(){
            return day;
        }

        int getMonth(){
            return month;
        }

        int getYear(){
            return year;
        }

        void displayDate(){
            cout << getDay() << "/" << getMonth() << "/" << getYear() << endl;
        }

    private:
        int day, month, year;
};