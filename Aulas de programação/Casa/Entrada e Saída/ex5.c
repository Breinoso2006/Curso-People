#include <stdio.h>
#include <stdlib.h>

int main()
{
    float hora, minuto, total;
    printf("Por favor, poderia me informar: \nHora: ");
    scanf ("%f", &hora);
    printf ("Minuto: \n");
    scanf ("%f", &minuto);
    hora = hora * 60;
    total = hora + minuto;
    printf ("Sera um total de: %f", total);
    return 0;
}
