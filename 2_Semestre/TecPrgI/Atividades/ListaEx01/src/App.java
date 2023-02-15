import java.util.Scanner;

public class App {
	public static void main(String[] args) throws Exception {
		Scanner scn = new Scanner(System.in);
		System.out.println("-----------------------");
		System.out.println("Escolha o exercício:");
		System.out.println("-----------------------");
		System.out.println("1 - Calcular desconto");
		System.out.println("2 - Quantidades salários mínimos");
		System.out.println("3 - Média entre valores");
		System.out.println("4 - Celsius pra Fahrenheit");
		System.out.println("5 - Volume da lata de óleo");

		int opt = Integer.parseInt(scn.nextLine());

		switch (opt) {
			case 1:
				System.out.print("Digite o nome do produto: ");
				String name = scn.nextLine();
				System.out.print("Digite o valor do produto: R$");
				double value = Double.parseDouble(scn.nextLine());
				Ex01(name, value);
				break;

			case 2:
				System.out.print("Digite o salário mínimo atual: R$");
				double minSalaly = Double.parseDouble(scn.nextLine());
				System.out.print("Digite o seu salário: R$");
				double salary = Double.parseDouble(scn.nextLine());
				Ex02(minSalaly, salary);
				break;

			case 3:
				System.out.print("Digite o valor de X1: ");
				float x1 = Float.parseFloat(scn.nextLine());
				System.out.print("Digite o valor de X2: ");
				float x2 = Float.parseFloat(scn.nextLine());
				Ex03(x1, x2);
				break;

			case 4:
				System.out.print("Digite os graus celsius: ");
				double celsius = Double.parseDouble(scn.nextLine());
				Ex04(celsius);
				break;

			case 5:
				System.out.print("Digite o valor do raio: ");
				double radius = Double.parseDouble(scn.nextLine());
				System.out.print("Digite o valor da altura: ");
				double height = Double.parseDouble(scn.nextLine());
				Ex05(radius, height);
				break;

			default:
				System.out.println("VALOR INVÁLIDO");
				break;
		}
		scn.close();
	}

	public static void Ex01(String name, double value) {
		value = value - (value * 0.09);
		System.out.println("O produto: " + name + " agora tem o valor " + String.format("%.2f", value));

	}

	public static void Ex02(double minSalary, double salary) {
		System.out
				.println("Você tem o equivalente a " + String.format("%.2f", salary / minSalary) + " salários mínimos");
	}

	public static void Ex03(float x1, float x2) {
		System.out.println("A média entre " + x1 + " e " + x2 + " é igual a " + String.format("%.2f", ((x1 + x2) / 2)));
	}

	public static void Ex04(double celsius) {
		double Fahrenheit = (((9 * celsius) + 160) / 5);
		System.out
				.println("A temperatura " + celsius + "°C em Fahrenheit é " + String.format("%.2f", Fahrenheit) + "°F");
	}

	public static void Ex05(double radius, double height) {
		double volume = 3.1459 * Math.pow(radius, 2) * height;
		System.out.println("O volume é igual a " + String.format("%.2f", volume));
	}
}
