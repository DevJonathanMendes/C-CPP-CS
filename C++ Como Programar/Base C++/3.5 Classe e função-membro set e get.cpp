// Define a classe GradeBook que contém um membro de dados courseName.
// Define funções-membro para configurar e obter seu valor.
// Cria e manipula um objeto GradeBook com essas funções.

#include <iostream>

using std::cout;
using std::cin;
using std::endl;

#include <string>
using std::string;
using std::getline;

class GradeBook{
    public:
        
        // Função que configura o nome do curso.
        void setCourseName(string name){
            courseName = name; // Armazena o nome do curso no objeto.
        }

        // Função que obtém o nome do curso.
        string getCourseName(){
            return courseName; // Retorna o courseName do objeto.
        }
        
        // Função-membro que exibe uma mensagem ao usuário do GradeBook.
        void displayMessage(){
            cout << "Welcome to the Grade Book for\n" << getCourseName() << "!" << endl;
        }

    private: // Especificador private, somente funções-membro dessa classe podem acessar.
        string courseName; // Nome do curso para esse GradeBook.
};

int main(){
    string nameOfCourse;
    GradeBook myGradeBook;
    cout << "Initial course name is: " << myGradeBook.getCourseName() << endl; // Exibe valor inicial de courseName.

    // Solicita, insere e configura o nome do curso.
    cout << "\nPlease enter the course name: " << endl;
    getline(cin, nameOfCourse);
    myGradeBook.setCourseName(nameOfCourse); // Configura o nome do curso.
    cout << endl;
    myGradeBook.displayMessage();
    return 0;
}