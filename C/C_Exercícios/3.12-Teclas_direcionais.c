/* Exercício 3.12.
 * 
 * Usar as teclas direcionais, não há como por conta de problemas no IDE.
 * 
 * Jonathan B. Mendes.
  */

#include <stdio.h>
#include <conio.h>
#include <ctype.h>
#include <stdlib.h>
#include <windows.h>

void gotoxy(int x, int y)
{
    COORD coord;
    coord.X = x;
    coord.Y = y;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
}

int main(void)
{
    int col = 40, lin = 12;
    //int s1 = getch(), s2 = getch();
    //printf("KEY = %d %d\n", s1, s2);
    system("cls");
    while(1)
    {
        gotoxy(col, lin);
        putch(219);
        switch(toupper(getch()))
        {
            case 'W': if(lin > 1 ) lin--;break;
            case 'S': if(lin < 24) lin++;break;
            case 'D': if(col < 80) col++;break;
            case 'A': if(col > 1 ) col--;break;
            case 'F': exit(1);
        }
    }
}