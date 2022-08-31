#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdbool.h>

bool percorre(int *b, int *e){
    if (b - e == 0) return true;
    int soma = 0; int indice = e - b;

    while (b != e){
        soma = soma + *b; b++;
    }
    if ((indice) % 2 == 0) {
        if (*e >= soma) return true;
    } else {
        if (*e <= soma) return true;
    }
    return false;

}

bool alto(int *b, int *e){
    if (b > e) return false;
    int *i = b; int cont = 0;
    while (b != e){
        bool hav = percorre(i, b);
        if (!hav) return false;
        ++b;
    }
    return true;
}

void main(){
    int vetor[] = {2, 1, 4, 2, 11, 10}; int tam = sizeof(vetor)/4;

    bool height = alto(vetor, vetor + tam);

    if (height){
        printf("O vetor e alternante");
    } else {
        printf("O vetor nao e alternante");
    }
}
