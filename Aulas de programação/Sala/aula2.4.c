#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int Par (int x)
    {
        if(x%2==0)
        {
        printf ("Eh par.");
        }
        else
        {
        printf ("Eh impar.");
        }
    }
int main()
{
    printf ("%i", Par (1));
    return 0;
}
