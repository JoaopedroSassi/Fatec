import java.util.Scanner;

import Entities.Conta;

public class App {
    public static void main(String[] args) throws Exception {
        Scanner sc = new Scanner(System.in);
        
        double value = 0;
        try {
            System.out.println("Entre com o valor inicial da conta:");
            value = Double.parseDouble(sc.nextLine());
        } catch (Exception e) {
            System.out.println("ERRO - Digite um valor numérico");
        }
        
        Conta conta = new Conta(value);
        int resp = 9;
        while (resp != 0) {
            System.out.println("---------------------");
            System.out.println("BANCO DIGITAL");
            System.out.println("CONTA 1 - Saldo atual: " + conta.getSaldo());
            System.out.println("----------------------");
            System.out.println("1 - Depósito");
            System.out.println("2 - Saque");
            System.out.println("3 - Atualização por taxa");
            System.out.println("0 - Sair do programa");
            resp = Integer.parseInt(sc.nextLine());

            if (resp == 1){
                System.out.println("Digite o valor para depósito:");
                value = Double.parseDouble(sc.nextLine());
                conta.deposita(value);
            } else if (resp == 2){
                System.out.println("Digite o valor para saque:");
                value = Double.parseDouble(sc.nextLine());
                conta.saca(value);
            } else if (resp == 3){
                System.out.println("Digite o valor da porcentagem de ajuste:");
                value = Double.parseDouble(sc.nextLine());
                conta.attByTaxa(value);
            } else {
                System.out.println("OPÇÃO INVÁLIDA");
            }
        }

        System.out.println("PROGRAMA FINALIZADO");
        sc.close();
    }
}
