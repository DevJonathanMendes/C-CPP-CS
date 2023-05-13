#include <stdio.h>

int main(void)
{
    int stairHeight = 0;

    while (stairHeight < 1 || stairHeight > 8)
    {
        printf("What height of ladder do you want? (Between 1 and 8): ");
        scanf("%d", &stairHeight);
    }

    for (int height = 0; height <= stairHeight; height++)
    {
        for (int spaceDistance = stairHeight - height; spaceDistance > 0; spaceDistance--)
            printf(" ");

        for (int length = height; length > 0; length--)
            printf("#");

        printf("\n");
    }
    return 0;
}