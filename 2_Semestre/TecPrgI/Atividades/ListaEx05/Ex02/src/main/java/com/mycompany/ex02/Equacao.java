package com.mycompany.ex02;
public class Equacao {
    private double A; 
    private double B; 
    private double C;

    public Equacao(double A, double B, double C) {
        this.A = A;
        this.B = B;
        this.C = C;
    }

    public double getA() {
        return A;
    }

    public void setA(int A) {
        this.A = A;
    }

    public double getB() {
        return B;
    }

    public void setB(int B) {
        this.B = B;
    }

    public double getC() {
        return C;
    }

    public void setC(int C) {
        this.C = C;
    }
    
    public double calcRaiz(String tipo){
        if(tipo.equals("r1")){
            return ((((this.B * -1) + Math.sqrt(calcDelta())) / (2 *this.A)));
        }
        else if(tipo.equals("r2")){
            return ((((this.B * -1) - Math.sqrt(calcDelta())) / (2 *this.A)));
        }
        else{
            return -1;
        }
    }
    
    public double calcDelta(){
        return this.B * this.B -4 * this.A * this.C;
    } 
    
}
