/* Exercício 3.17.
 *
 * Programa tipo piano.
 *
 * Jonathan B. Mendes.
 */

 #include <stdio.h>
 #include <windows.h>
 
 int main(void)
 {
     while(1)
     {
         switch(getch())
         {
             case 'a': Beep(262, 250); break;
             case 's': Beep(294, 250); break;
             case 'd': Beep(230, 250); break;
             case 'f': Beep(349, 250); break;
             case 'j': Beep(392, 250); break;
             case 'k': Beep(440, 250); break;
             case 'l': Beep(494, 250); break;
             case ' ': exit(1);
         }
     }
 }