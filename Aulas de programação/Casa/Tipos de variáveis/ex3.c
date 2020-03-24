#include <stdio.h>
#include <stdlib.h>

int main()
{
    int va, i, n;
    printf("Digite um numero: ");
    scanf ("%i", &n);
    va = n;
    if (n < 0)
    {
        va = n *-1;
    }
    printf ("O valor absoluto dele eh %i", va);
    return 0;
}
