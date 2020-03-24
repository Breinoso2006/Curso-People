#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main()
{
    int hora, minuto, n;
    printf("Digite o total de minutos: ");
    scanf ("%i", &n);
    hora = n / 60;
    minuto = n % 60;
    printf ("Logo, \nHora; %i\nMinuto: %i", hora, minuto);
    return 0;
}
