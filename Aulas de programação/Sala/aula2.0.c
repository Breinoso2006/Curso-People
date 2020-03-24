#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main()
{   int x;
    x = 0;
    while (x <= 100)
    {
        if (x % 2 == 0)
        {
            printf ("%i --> par\n", x);
        }
         else
         {
             printf ("%i --> impar\n", x);
         }
        x++;
    }
    return 0;
}
