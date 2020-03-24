#include <stdio.h>
#include <stdlib.h>

int maior (int a, int b)
{
    if (a > b)
        return a;
    else
        return b;
}
int main()
{
    int n1, n2, n3, resultado;
    printf("Digite um n\243mero\n");
    scanf ("%i", &n1);
    printf("Digite o segundo n\243mero\n");
    scanf ("%i", &n2);
    printf("Digite o terceiro n\243mero\n");
    scanf ("%i", &n3);
    resultado = maior (n3,maior(n1, n2));
    printf ("O maior n\243mero \202 %i", resultado);
    return 0;
}
