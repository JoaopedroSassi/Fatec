#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <math.h>

int raiz_int(int x){
    
    int maior_num;
    for (int i = 0; i*i <= x; i++){
        maior_num = i;
    }
    return maior_num;
}
     
void main(){
    setlocale(LC_ALL,"Portuguese");
    
    int seq = 0;
    printf("Digite o tamanho da sequencia:");
    scanf("%d", &seq);

    int tot_raiz = 0;
    for (int i = 1; i <= seq; i++){
        int num = 0;
        printf("Digite o %do numero:", i);
        scanf("%d", &num);
        tot_raiz = tot_raiz + raiz_int(num);
    }
    
    
    printf("O somatorio das raizes inteiras e igual a %d", tot_raiz);

}