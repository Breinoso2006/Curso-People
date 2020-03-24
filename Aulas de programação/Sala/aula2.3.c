#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main()
{
    int tamanho = 5,x, y = 1;
    float salario [tamanho]; // o 5 mostra quantas posições existem (0,1,2,3,4)

    for (x = 0; x < tamanho; x++)
    {
        printf ("Quanto eh o salario do funcionario %i? ", y);
        scanf ("%f", &salario [x]);
        if (salario [x] < 1000)
        {
            salario [x] = salario [x] * 1.1;
        }
        printf ("%f eh o salario final deste funcionario.\n", salario [x]);
        printf ("=============================================\n");
        y++;
    }
    return 0;
}
