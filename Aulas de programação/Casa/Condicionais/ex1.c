#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n1, n2;
    printf("Digite dois numeros separados por virgula: ");
    scanf ("%i, %i", &n1, &n2);
    if (n1 == n2)
    {
        printf ("Esses numeros sao iguais!");
    }
    else
    {
        printf ("Esses numeros sao diferentes!");
    }
    return 0;
}
