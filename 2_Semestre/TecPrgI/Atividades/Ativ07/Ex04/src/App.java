import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
		Scanner sc = new Scanner(System.in);
		System.out.println("Digite o dia:");
		int dia = Integer.parseInt(sc.nextLine());

		System.out.println("Digite o mês:");
		int mes = Integer.parseInt(sc.nextLine());

		System.out.println("Digite o ano:");
		int ano = Integer.parseInt(sc.nextLine());

		Data data = new Data(dia, mes, ano);

		data.displayData();

		sc.close();
    }
}
