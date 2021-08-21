#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

double square(double x){
        return x*x;
    }

double sum (double x, double y){
    return x + y;
}


int main(){
    setlocale(LC_ALL,"Portuguese");

    printf("%f %f", square(1.2), sum(1, 5));
    
}