#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main()
{
    float n1, n2, resultado;
    char comando;
    printf("Digite dois numeros separados por virgula: ");
    scanf ("%f, %f", &n1, &n2);
    printf ("Agora digite o sinal do comando desejado: ");
    scanf ("\n%c", &comando);
    switch (comando)
    {
        case '+': resultado = n1 + n2;
        break;
        case '-': resultado = n1 - n2;
        break;
        case '/': resultado = n1 / n2;
        break;
        case '*': resultado = n1 * n2;
        break;
    }
    printf ("O resultado eh: %f", resultado);

    return 0;
}
