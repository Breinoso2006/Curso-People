#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main()
{   setlocale(LC_ALL, "Portuguese");
    int n, i, div = 0;
    printf ("Escreva um n�mero: \n");
    scanf ("%i", &n);
    for (i=1; i <= n; i ++)
    {
        if (n % i == 0)
        {
            div++;
        }
    }
    if (div == 2)
    {
        printf ("Este n�mero � primo");
    }
    else
        {
            printf ("Este n�mero n�o � primo");
        }
    return 0;
}
