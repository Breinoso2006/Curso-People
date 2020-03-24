#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main()
{
    int x, dobro; //declarando variáveis
    printf("Por favor, digite um numero: "); //printa na tela
    scanf("%i", &x); //espera um valor e capta ele
    dobro=2*x; //declara um valor para dobro
    printf ("O dobro de uma variavel do tipo inteiro eh %i", dobro);
    return 0;
}
