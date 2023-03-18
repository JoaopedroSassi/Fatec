package com.mycompany.ex02;

import java.util.Scanner;

public class Ex02 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        
        System.out.println("Digite o valor A: ");
        double A = sc.nextDouble();
        System.out.println("Digite o valor B: ");
        double B = sc.nextDouble();
        System.out.println("Digite o valor C: ");
        double C = sc.nextDouble();
        
        Equacao eq = new Equacao(A, B, C);
        
        if(eq.calcDelta() > 0 ){
            System.out.println("R1 igual a: " + eq.calcRaiz("r1"));
            System.out.println("R2 igual a: " + eq.calcRaiz("r2"));
        }
        else if(eq.calcDelta() < 0){
            System.out.println("Não existem raízes para uma equação com estes valores!");
        }
        else{
            System.out.println("O valor de R1 e R2 é: " + eq.calcRaiz("r1"));
        }
        
        
        sc.close();
    }
    
}
