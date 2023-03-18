package com.mycompany.ex01;

import java.util.Scanner;

public class Ex01 {

    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        System.out.println("Digite o valor da base: ");
        double base = sc.nextDouble();
        System.out.println("Digite o valor da altura: ");
        double altura = sc.nextDouble();
        
        Triangle triangle = new Triangle(altura,base);
        
        System.out.println("O valor da área do triangulo é: " +triangle.calculateArea());
        
        sc.close();
    }
}
