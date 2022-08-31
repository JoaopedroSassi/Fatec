#include <stdio.h>
#include <stdlib.h>

struct arv
{
   int codigo;
   float preco;
   struct arv *esq;
   struct arv *dir;
};
typedef struct arv Arv;

Arv *abb_cria()
{
   return NULL;
}

int abb_vazia(Arv *a)
{
   return a == NULL;
}

Arv *abb_insere(Arv *a, int c, float pr)
{
   Arv *p, *q, *r;
   p = (Arv *)malloc(sizeof(Arv));
   p->codigo = c;
   p->preco = pr;
   p->esq = p->dir = NULL;

   if (abb_vazia(a)) // primeiro elemento da árvore
      a = p;
   else
   {
      q = a;
      while (q != NULL)
      {
         r = q;
         if (c < q->codigo)
            q = q->esq;
         else
            q = q->dir;
      }
      if (c < r->codigo)
         r->esq = p;
      else
         r->dir = p;
   }
   return a;
}

Arv *abb_retira(Arv *r, int v)
{
   if (r == NULL)
      return NULL;
   if (r->codigo > v)
      r->esq = abb_retira(r->esq, v);
   else if (r->codigo < v)
      r->dir = abb_retira(r->dir, v);
   else
   {
      // achou o elemento
      if (r->esq == NULL && r->dir == NULL)
      { // no sem filhos
         free(r);
         r = NULL;
      }
      else if (r->esq == NULL)
      { // filho a direita
         Arv *t = r;
         r = r->dir;
         free(t);
      }
      else if (r->dir == NULL)
      { // filho a esquerda
         Arv *t = r;
         r = r->esq;
         free(t);
      }
      else
      { // tem 2 filhos
         Arv *f = r->esq;
         while (f->dir != NULL)
            f = f->dir;
         r->codigo = f->codigo;
         f->codigo = v;
         r->esq = abb_retira(r->esq, v);
      }
   }
   return r;
}

void abb_pre(Arv *a)
{
   if (a != NULL)
   {
      printf("%d ", a->codigo); // visita a raiz-esq-dir
      abb_pre(a->esq);
      abb_pre(a->dir);
   }
}

void abb_ordem(Arv *a)
{
   if (a != NULL)
   {
      abb_ordem(a->esq);
      printf("%d ", a->codigo); // visita esq-raiz-dir
      abb_ordem(a->dir);
   }
}

void abb_pos(Arv *a)
{
   if (a != NULL)
   {
      abb_pos(a->esq);
      abb_pos(a->dir);
      printf("%d ", a->codigo); // visita a esq-dir-raiz
   }
}

Arv *abb_busca(Arv *a, int v)
{
   if (abb_vazia(a))
      return NULL;
   if (a->codigo > v)
      return abb_busca(a->esq, v);
   if (a->codigo < v)
      return abb_busca(a->dir, v);
   return a;
}

int max2(int a, int b)
{
   return (a > b) ? a : b;
}

int abb_altura(Arv *a)
{
   if (abb_vazia(a))
      return -1;
   return 1 + max2(abb_altura(a->esq), abb_altura(a->dir));
}

int contadorPares(Arv *a)
{
	int countPar = 0;
	if(a != NULL)
	{
		if(a->codigo % 2 ==0)
			countPar++;
			
		countPar += contadorPares(a->esq);
		countPar += contadorPares(a->dir);
	}
	return countPar;
}

void mostraMenor(Arv *a, float valor)
{
	if(a != NULL)
	{
		if(a->preco < valor)
		{
			printf("Codigo %d | Preco %.2f\n", a->codigo, a->preco);
		}
		mostraMenor(a->esq, valor);
		mostraMenor(a->dir, valor);
	}
}

int contaProdutos(Arv *a, float v1, float v2)
{
	int contProdutos = 0; //Contador de produtos
	if(a != NULL)
	{
		if(a->preco >= v1 && a->preco <= v2) //Se estiver de acordo
			contProdutos += + 1; //Add 1
		
		contProdutos += contaProdutos(a->esq, v1, v2); //Recursando
		contProdutos += contaProdutos(a->dir, v1, v2); //Recursando
	}
}

void filhos(Arv *a)
{
	if(a->esq != NULL)
		printf("\nFilho a esquerda: %d", a->esq->codigo);
	else
		printf("\nNao tem filho a esquerda");
	
	if(a->dir != NULL)
		printf("\nFilho a direita: %d", a->dir->codigo);
	else
		printf("\nNao tem filho a direita");
}

int contaNos(Arv *a)
{ // usando o percurso pre-ordem
   int conta = 0;
   if (a != NULL)
   {
      // printf("%d ", a->codigo); //visita a raiz-esq-dir
      conta = conta + 1;         // raiz
      conta += contaNos(a->esq); // esq
      conta += contaNos(a->dir); // dir
   }
   return conta;
}

void menu()
{
   system("CLS");
   printf("**Escolha uma opcao**\n");
   printf("1- Inserir\n");
   printf("2- Retirar\n");
   printf("3- Mostrar todos os percursos\n");
   printf("4- Busca No:\n"); 
   printf("5- Altura da arvore\n");
   printf("6- Contar\n");//int contaNos(Arv *a)
   printf("7- Somar\n");//int somaNos(Arv *a)
   printf("9- Sair\n");
   printf("==> ");
}

int main()
{
   int num;
   float pr;
   Arv *a = abb_cria();
   Arv *aux; // ponteiro auxiliar
   int resp;
   do
   {
      menu();
      scanf("%d", &resp);
      switch (resp)
      {
      case 1: // insere
         printf("\nEntre com o valor de codigo ser inserido: ");
         scanf("%d", &num);
         printf("\nEntre com o valor de preco ser inserido: ");
         scanf("%f", &pr);
         a = abb_insere(a, num, pr);
         break;

      case 2: // retira
         printf("\nEntre com o valor a ser retirado: ");
         scanf("%d", &num);
         a = abb_retira(a, num);
         break;

      case 3: // mostra os percursos
         printf("Percurso em pre-ordem\n");
         abb_pre(a);
         printf("\n\nPercurso em ordem\n");
         abb_ordem(a);
         printf("\n\nPercurso em pos-ordem\n");
         abb_pos(a);
         printf("\n\n");
         break;

      case 4: // busca no
         printf("Digite o elemento a ser procurado: ");
         scanf("%d", &num);
         aux = abb_busca(a, num);
         if (aux == NULL)
            printf("Elemento NAO localizado!\n");
         else
         {
            printf("Elemento %d localizado!\n", aux->codigo);
         }
         break;

      }

      system("pause");
   } while (resp != 9);

   printf("\n***FIM***\n\n");
   
   return 0;
}
