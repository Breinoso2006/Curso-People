#include <stdio.h>
#include <stdlib.h>

int main()
{   char c;
    int i;
    for (i = 0; i < 256; i++)
    {
        c = i;
        printf ("%i -> %c \n", i,c);
    }
    return 0;
}
