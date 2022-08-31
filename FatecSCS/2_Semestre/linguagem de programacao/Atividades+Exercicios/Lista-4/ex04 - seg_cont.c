#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int comprimento(int *b, int *e, int s){
    int *proximo = b; ++b;
    int cont = 0; int soma = 0;
    while (b != e && soma <= s && *proximo <= *b) {
        cont++; b++;
        soma += *proximo;
    }
    return cont;
}

int maior_indice(int *b, int *e, int s){
    if ((s <= 0) && (b - e == 0)) {
        return -1;
    }
    int maior = 0;
    for (int *indice = b; indice < e; ++indice) {
        int contador = comprimento(indice, e, s);
        if (contador > maior) {
            maior = contador;
        }
    }
    return maior;
}

void main(){
    int vetor[] = {4, 3, 1, 1, 2, 2, 2, 9, -2, 1};
    int n = sizeof(vetor) / sizeof(int);
    int s = 8;
    int indice = maior_indice(vetor, vetor + n, s);
    printf("O maior segmento: %d", indice);
}