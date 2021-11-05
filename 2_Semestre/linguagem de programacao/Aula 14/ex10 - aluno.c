#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

struct aluno {
   int id;
   int notas[2];
};

void escreve_aluno(struct aluno *ex){
   printf("id = %d | N1 = %d - N2 = %d", ex->id, ex->notas[0], ex->notas[1]);
}

double media (struct aluno *ex){
   return ((ex->notas[0] + ex->notas[1]) / 2.0);
}

struct aluno *aluno_media_max(struct aluno *beg, struct aluno *end){
   struct aluno *big = beg;

   beg++;

   while (beg != end){
      if (media(beg) > media(big)){
         big = beg;
      }
      ++beg;
   }

   return big;
}

double med_nota_espec(struct aluno *beg, struct aluno *end, int nx){
   int med_nx = 0;
   
   while (beg != end){
      med_nx += beg->notas[nx];
      ++beg;
   }

   return med_nx;
}
  
void main(){
   setlocale(LC_ALL,"Portuguese");

   struct aluno joao = {1, {9, 6}};
   escreve_aluno(&joao);
   printf("\nA média do aluno foi de %f", media(&joao));

   struct aluno alunos[] = {{1, {9, 6}}, {2, {9, 2}}, {3, {1, 4}}};
   int tam = sizeof(alunos)/sizeof(struct aluno);
   printf("\n---------------------------------------");
   printf("\nAluno de maior média:\n");
   escreve_aluno(aluno_media_max(alunos, alunos + tam));
   printf("\nDigite a média que você quer saber:");
   int op = 0;
   scanf("%d", &op);
   printf("\nA média da N%d é %f", op, med_nota_espec(alunos, alunos + tam, op) / tam);
}