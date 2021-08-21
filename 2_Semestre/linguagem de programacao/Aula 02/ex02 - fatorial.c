#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

     
void main(){
    
    int n = 0;
    puts("Digite um numero para ver o fatorial dele:");
    scanf("%d", &n);

    int resul = 1; 
    while (n > 0){
        resul = resul * n;
        n = n - 1;
    }
    
    
    printf("%d", resul);
    


    printf("\n");
}