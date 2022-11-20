// Figura 7.16: GradeBook.h
// As funções-membro são definidas em GradeBook.cpp
// Figura 7.17: GradeBook.cpp

#include <iostream>
using std::cin;
using std::cout;
using std::endl;
using std::fixed;

#include <iomanip>
using std::setprecision;
using std::setw;

#include <string> // o programa utiliza a classe string da C++ Standard Library
using std::string;

class GradeBook{
    public:
        // Constante - Número de alunos que fizeram o teste
        const static int students = 10; // note os dados públicos

    // construtor inicializa o nome do curso e o array de notas
    GradeBook(string, const int[]);

    void setCourseName(string); // função para configurar o nome do curso
    string getCourseName();     // função para recuperar o nome do curso
    void displayMessage();      // exibe uma mensagem de boas-vindas
    void processGrades();       // realiza várias operações nos dados
    int getMinimum();           // localiza a nota mínima para o teste
    int getMaximum();           // localiza a nota máxima para o teste
    double getAverage();        // determina a nota média para o teste
    void outputBarChart();      // gera saída do gráfico de barras de distribuição de notas
    void outputGrades();        // gera a saída do conteúdo do array de notas
    
    private:
        string courseName; // nome do curso para esse livro de notas
        int grades[students]; // array de notas de aluno
};

// Construtor.
GradeBook::GradeBook(string name, const int gradesArray[]){
    setCourseName(name); // inicializa courseName

    // copia notas de gradeArray para membro de dados grades
    for (int grade = 0; grade < students; grade++)
        grades[grade] = gradesArray[grade];
}

// função para configurar o nome do curso
void GradeBook::setCourseName(string name){
    courseName = name; // armazena o nome do curso
}

// função para recuperar o nome do curso
string GradeBook::getCourseName(){
    return courseName;
}

// exibe uma mensagem de boas-vindas para o usuário de GradeBook
void GradeBook::displayMessage(){
    cout << "Welcome to the grade book for\n"
         << getCourseName() << "!" << endl;
}

// realiza várias operações nos dados
void GradeBook::processGrades(){
    // gera saída de array de notas
    outputGrades();

    // chama função getAverage para calcular a nota média
    cout << "\nClass average is " << setprecision(2) << fixed << getAverage() << endl;

    // chama funções getMinimum e getMaximum
    cout << "Lowest grade is " << getMinimum() << "\nHighest grade is "
         << getMaximum() << endl;

    // chama outputBarChart para imprimir gráfico de distribuição de notas
    outputBarChart();
}

// localiza nota mínima
int GradeBook::getMinimum(){
    int lowGrade = 100; // supõe que a nota mais baixa é 100

    // faz um loop pelo array de notas
    for (int grade = 0; grade < students; grade++)
    {
        // se nota for mais baixa que lowGrade, ela é atribuída a lowGrade
        if (grades[grade] < lowGrade)
            lowGrade = grades[grade]; // nova nota mais baixa
    }                                 // fim do for

    return lowGrade; // retorna nota mais baixa
} // fim da função getMinimum

// localiza nota máxima
int GradeBook::getMaximum(){
    int highGrade = 0; // supõe que a nota mais alta é 0

    // faz um loop pelo array de notas
    for (int grade = 0; grade < students; grade++)
    {
        // se a nota atual for mais alta que highGrade, ela é atribuída a highGrade
        if (grades[grade] > highGrade)
            highGrade = grades[grade]; // nova nota mais alta
    }                                  // fim do for

    return highGrade; // retorna nota mais alta
}

// determina média para o teste
double GradeBook::getAverage(){
    int total = 0; // inicializa o total

    // soma notas no array
    for (int grade = 0; grade < students; grade++)
        total += grades[grade];

    // retorna média de notas
    return static_cast<double>(total) / students;
}

// gera a saída do gráfico de barras exibindo distribuição de notas
void GradeBook::outputBarChart(){
    cout << "\nGrade distribution :" << endl;

    // armazena frequência de notas em cada intervalo de 10 notas
    const int frequencySize = 11;
    int frequency[frequencySize] = {0};

    // para cada nota, incrementa a frequência apropriada
    for (int grade = 0; grade < students; grade++)
        frequency[grades[grade] / 10]++;

    // para cada frequência de nota, imprime barra no gráfico
    for (int count = 0; count < frequencySize; count++){
        // gera a saída do rótulo das barras ("0-9:", ..., "90-99:", "100:" )
        if (count == 0)
            cout << " 0 - 9 : ";
        else if (count == 10)
            cout << " 100 : ";
        else
            cout << count * 10 << "-" << (count * 10) + 9 << ": ";

        // imprime a barra de asteriscos
        for (int stars = 0; stars < frequency[count]; stars++)
            cout << '*';

        cout << endl; // inicia uma nova linha de saída
    }
}

// gera a saída do conteúdo do array de notas
void GradeBook::outputGrades(){
    cout << "\nThe grades are :\n\n";

    // gera a saída da nota de cada aluno
    for (int student = 0; student < students; student++)
        cout << "Student " << setw(2) << student + 1 << ": " << setw(3)
             << grades[student]
             << endl;
}