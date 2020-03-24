#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>

int main()
{
    float n1, n2, r;
    char comando;
    printf("Ola, por favor digite os valores pedidos. \n");
    printf ("Valor 1: ");
    scanf ("%f", &n1);
    printf ("Valor 2: ");
    scanf ("%f", &n2);
    printf ("Digite o sinal da operacao desejada:");
    scanf ("\n%c", &comando);
        switch (comando)
        {
            case '+': r = n1 + n2;
            break;
            case '-': r = n1 - n2;
            break;
            case '*': r = n1 * n2;
            break;
            case '/': r = n1 / n2;
            break;
            case '^': r = pow(n1,n2);
            break;
            default: printf ("Voce eh retardado '-' \n");
            break; // gostaria de saber como faria caso parasse aqui
        }
    printf ("Resultado = %f \n", r);
    if (r != 0)
    {
        if (r < 0)
        {
            printf ("Este numero eh negativo ");
        }
        else
        {
            printf ("Este numero eh positivo ");
        }
    }
    else
    {
        printf ("Este numero eh o zero!");
    }
    if ((int)r % 2 == 0)
    {
        printf ("e par!");
    }
    else
    {
        printf("e impar!");
    }
    return 0;
}
