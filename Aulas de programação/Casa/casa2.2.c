#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{   int n, i;
    int mult = 1;
    printf("\Digite um n\243mero:\n");
    scanf ("%i", &n);
    if (n <= 0)
    {
        if ( n < 0 )
        {
            printf ("-1");
        }
        else
        {
            printf ("0");
        }
    }
    else
    {
        for (i = n; i > 1; i--)
        {
            mult *= i * (i - 1);
        }
        printf ("%i", &mult);
    }
    return 0;
}
