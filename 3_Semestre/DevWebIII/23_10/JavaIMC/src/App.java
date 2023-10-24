import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("Hello, World!");
        Scanner sc = new Scanner(System.in);

        System.out.println("Digite a altura:");
        Double altura = Double.parseDouble(sc.nextLine());

        System.out.println("Digite o peso:");
        Double peso = Double.parseDouble(sc.nextLine());

        CalculadoraIMC calculadoraIMC = new CalculadoraIMC();
        double imc = calculadoraIMC.calcIMC(altura, peso);

        System.out.println("IMC = " + imc);
        System.out.println("Biotipo: " + calculadoraIMC.verificaBiotipo(imc));

        sc.close();
    }
}
