// Instanciando múltiplos objetos da classe GradeBook e utilizando
// O construtor GradeBook para especificar o nome do curso
// quando cada objeto GradeBook é criado.

#include <iostream>
using std::cout;
using std::endl;

#include <string>
using std::string;

class GradeBook{
    public:
        // Construtor inicializa courseName com a string fornecida como argumento.
        GradeBook(string name){
            setCourseName(name); // Chama a função set para inicializar courseName.
        }

        void setCourseName(string name){
            courseName = name;
        }

        string getCourseName(){
            return courseName;
        }

        void displayMessage(){
            cout << "\nWelcome to the Grade Book for\n" << getCourseName() << "!" << endl;
        }
		
    private:
        string courseName;
};

int main(){
    // Cria dois objetos GradeBook.
    GradeBook gradeBook1 ("Nascar");
    GradeBook gradeBook2 ("Formula One");

    // Exibe valor inicial de courseName para cada GradeBook.
    cout << "gradeBook1 created for course: " << gradeBook1.getCourseName() << endl;
    cout << "gradeBook2 created for course: " << gradeBook2.getCourseName();
    return 0;
}