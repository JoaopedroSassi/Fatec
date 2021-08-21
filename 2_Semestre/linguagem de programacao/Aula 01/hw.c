#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

     
void main(){
    setlocale(LC_ALL,"Portuguese");
    
    printf("Entre com um valor: ");
    int x;
    scanf("%d", &x);

    printf("Entre com outro valor: ");
    int y;
    scanf("%d", &y);

    printf("A soma de %d e %d vale %d\n", x, y, x + y);

    bool logico = true;
    printf("%s", logico);

    system("pause");
}