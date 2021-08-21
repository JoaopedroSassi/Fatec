#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

     
void main(){
    
    int n = 0;
    puts("Digite um numero para ver o somatorio dele:");
    scanf("%d", &n);

    int cont = 0, resul = 0; 
    while (cont <= n){
        resul = resul + cont;
        cont += 1;
    }
    
    
    printf("%d", resul);
    


    printf("\n");
}