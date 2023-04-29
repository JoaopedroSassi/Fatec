import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        Scanner sc = new Scanner(System.in);
		System.out.println("Digite o nome:");
		String nome = sc.nextLine();

		System.out.println("Digite a idade:");
		int idade = Integer.parseInt(sc.nextLine());

		System.out.println("Digite a altura:");
		double altura = Double.parseDouble(sc.nextLine());

		System.out.println("Digite o sexo:");
		String sexo = sc.nextLine();

		System.out.println("Digite o salário:");
		double salario = Double.parseDouble(sc.nextLine());

		Empregado emp = new Empregado(nome, idade, altura, sexo, salario);

		System.out.println("------------------------");
		System.out.println("Empregado " + emp.getNome());
		System.out.println("Idade: " + emp.getIdade() + " anos");
		System.out.println("Altura: " + emp.getAltura());
		System.out.println("Sexo: " + emp.getSexo());
		System.out.println("Lucros: " + emp.obterLucros());

		sc.close();
    }
}
