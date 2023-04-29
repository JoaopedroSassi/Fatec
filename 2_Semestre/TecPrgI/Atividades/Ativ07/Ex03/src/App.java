import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
		Scanner sc = new Scanner(System.in);
		System.out.println("Digite o primeiro núemro da equação:");
		double num1 = Double.parseDouble(sc.nextLine());

		System.out.println("Digite o segundo núemro da equação:");
		double num2 = Double.parseDouble(sc.nextLine());

		System.out.println("Digite a operação:");
		String desc = sc.nextLine();

		Calculadora calc = new Calculadora(num1, num2, desc.toCharArray()[0]);

		calc.calcValores();

		sc.close();
    }
}
