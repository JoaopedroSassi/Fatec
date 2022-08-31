#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

     
void main(){
    setlocale(LC_ALL,"Portuguese");
    
    printf("Entre com um valor: ");
    int x;
    scanf("%d", &x);

    int cont = 1;
    while (cont <= x)
    {
        printf("%d\n", cont);
        cont = cont + 1;
    }
    

    system("pause");
}