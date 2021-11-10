#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

struct task{
   int start, finish;
};

void print_task(struct task *beg, struct task *end){
   while (beg != end){
   

      ++beg;
   }
   
}
     
void main(){
   setlocale(LC_ALL,"Portuguese");

   int n = 0;
   scanf("%d", &n);
   struct task event[n];
   for (int i = 0; i < n; ++i){
      //scanf("{%d | %d}", &event.start, &event.finish);
   }
   
}