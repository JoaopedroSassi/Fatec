package Entities;

public class Conta {
    public double saldo;

    public Conta(double saldo) {
        this.saldo = saldo;
    }

    public double getSaldo() {
        return saldo;
    }

    public void deposita(double value){
        this.saldo += value;
    }

    public void saca(double value){
        this.saldo -= value;
    }

    public void attByTaxa(double taxa){
        this.saldo += ((taxa / 100) * this.saldo);
    }
}
