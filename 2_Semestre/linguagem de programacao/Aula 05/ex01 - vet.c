#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

     
int main(){
    setlocale(LC_ALL,"Portuguese");

    printf("Entre com o número de alunos: ");
    int n;
    scanf("%d", &n);

    int notas[n];
    double media = 0;
    for (int i = 0; i < n; i++){
      printf("Entre com a %do nota: ", i + 1);
      scanf("%d", &notas[i]);
      media = media + notas[i];
    }

    media /= n;
    int aprov = 0;
    for (int i = 0; i < n; i++){
      if (notas[i] > media){
        aprov++;
      }
    }
    
    printf("__________________________\n");
    printf("Existem %d aprovados!", aprov);
}