#include <stdio.h>
#include <stdlib.h>

int main() {

  int i, x;
  int div = 0;
    printf("Digite um n\243mero inteiro e positivo: ");
    scanf("%d", &x);
    for (i = 1; i <= x; i++) {
    if (x % i == 0)
        {
        div++;
        }
  }
  if (div == 2)
    printf("O n\243mero %d \202 primo! (1)", x);
  else
    printf("O n\243mero %d nao \202 primo! (0)", x);

  return 0;
}
