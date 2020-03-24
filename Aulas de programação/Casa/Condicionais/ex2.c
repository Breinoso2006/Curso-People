#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n;
    printf("Digite um numero: ");
    scanf ("%i", &n);
    if (n % 2 == 0)
    {
        printf ("Este numero eh par!");
    }
    else
    {
        printf ("Este numero eh impar!");
    }
    return 0;
}
