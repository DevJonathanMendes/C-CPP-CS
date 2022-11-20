#include <iostream>
#include <iomanip>
#include <ctime>
using namespace std;

static int currentRow = 4;
static int currentColumn = 1;

void board(int = currentRow, int = currentColumn);
int move(int);
int moveRow(int = currentRow);
int moveColumn(int = currentColumn);

int main(void){
    srand(time(0));
    board();
    //cout << "Row: " << currentRow << " Column " << currentColumn << endl;
    for(int i = 0, To; i < 64; i++){
        To = rand() % 8;
        if(move(To) == false){
            cout << "Invalid move!" << endl;
            i--;
        } else {
            cout << endl;
            board(moveRow(To), moveColumn(To));
        }
    }
}

int move(int move){
    int erros = 0;
    if(move < 0 || move > 7)
        erros++;
    // ROW
    if(currentRow == 0 && move <= 3)
        erros++;
    if(currentRow == 1 && (move == 1 || move == 2))
        erros++;
    if(currentRow == 7 & move >= 4)
        erros++;
    if(currentRow == 6 & (move == 5 || move == 6))
        erros++;
    // COLUMN
    if(currentColumn == 0 && (move >= 2 && move <= 5))
        erros++;
    if(currentColumn == 1 && (move == 3 || move == 4))
        erros++;
    if(currentColumn == 7 && (move == 1 || move == 0 || move == 7 || move ==6))
        erros++;
    if(currentColumn == 6 && (move == 0 || move == 7))
        erros++;

    if(erros > 0)
        return false;
    else
        return true;
}

void board(int row, int column){
    int board[8][8] = {0};
    int visited[8][8] = {0};
    for (int i = 0; i < 8; i++){
        for (int j = 0; j < 8; j++){
            if (i == row && j == column){
                visited[i][j] = 1;
                board[i][j] = 4;
            }
            cout << setw(2) << board[i][j];
        }
        cout << endl;
    }
}

int moveRow(int row){
    int vertical[8] = {-1, -2, -2, -1, 1, 2, 2, 1};
    return currentRow += vertical[row];
}

int moveColumn(int column){
    int horizontal[8] = {2, 1, -1, -2, -2, -1, 1, 2};
    return currentColumn += horizontal[column];
}