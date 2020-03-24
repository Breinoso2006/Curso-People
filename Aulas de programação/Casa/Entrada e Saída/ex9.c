#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a1,a2,a3; // definir suas variáveis
    printf("Digite os dois angulos conhecidos: "); // mostrar mensagem na tela
    scanf ("%i, %i", &a1, &a2); // recolher dados
    a3 = 180 - (a1 + a2); // calcular o terceiro angulo
    printf ("O terceiro angulo eh de %i graus", a3); // mostrar o resultado
    return 0;
}
