#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n;
    printf("Digite um numero: ");
    scanf ("%i", &n);
    if (n != 0)
    {
        if (n < 0)
        {
            printf ("Este numero eh negativo!");
        }
        else
        {
            printf ("Este numero eh positivo!");
        }
    }
    else
    {
        printf ("Este numero eh o zero!");
    }
    return 0;
}
