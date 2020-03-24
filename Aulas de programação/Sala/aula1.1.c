#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main()
{
    float lado1, lado2, a, p, d, delta, ad, bd, cd;
    printf("Por favor, indique os valores do lado1: ");
    scanf("%f", &lado1);
    printf("Por favor, indique os valores do lado2: ");
    scanf ("%f", &lado2);
    a = lado1*lado2;
    p = 2*(lado1 +lado2);
    printf("O valor da area eh: %f \n" , a);
    printf("O valor do perimetro eh: %f \n", p);
    printf("Esta fazendo bhaskara? Indique os valores abaixo para saber o valor do delta. \n");
    printf ("B:");
    scanf ("%f", &bd);
    printf ("A:");
    scanf("%f", &ad);
    printf ("C:");
    scanf("%f",&cd);
    delta = bd*bd - 4*ad*cd;
    printf ("O valor do delta eh: %f", delta);
    return 0;
}
