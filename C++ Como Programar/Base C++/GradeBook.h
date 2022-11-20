#include <iostream>
using std::cout;
using std::endl;

#include <string>
using std::string;

#include "GradeBook.cpp"

class GradeBook{
public:
    GradeBook(string courseName, string courseInstructor){
        setCourseName(courseName);
        setInstructorName(courseInstructor);
    }

    void setCourseName(string name){
        if (name.length() <= 25)
            courseName = name;
        else{
            courseName = name.substr(0, 25);
            cout << "Name \"" << name << "\" exceeds maximum length (25).\n"
                 << "Limiting courseName to first 25 characters.\n" << endl;
        }
    }

    string getCourseName(){
        return courseName;
    }

    void setInstructorName(string name){
        if (name.length() <= 25)
            courseInstructor = name;
        else{
            courseInstructor = name.substr(0, 25);
            cout << "Name \"" << name << "\" exceeds maximum length (25).\n"
                 << "Limiting courseInstructor to first 25 characters.\n" << endl;
        }
    }

    string getCourseInstructor(){
        return courseInstructor;
    }

    void displayMessage(){
        cout << "Welcome to the Grade Book for " << getCourseName() << "!" << endl;
        cout << "This course is presented by: " << getCourseInstructor() << "!" << endl;
    }

private:
    string courseName, courseInstructor;
};