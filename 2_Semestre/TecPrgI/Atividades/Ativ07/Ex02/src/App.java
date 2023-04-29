import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
		Scanner sc = new Scanner(System.in);
		System.out.println("Digite o primeiro nome 1:");
		String nomeUm = sc.nextLine();

		System.out.println("Digite o sobrenome nome 1:");
		String sobrenomeUm = sc.nextLine();

		System.out.println("Digite o salário mensal 1:");
		Double salMenUm = Double.parseDouble(sc.nextLine());

		System.out.println("Digite o primeiro nome 2:");
		String nomeDois = sc.nextLine();

		System.out.println("Digite o sobrenome nome 2:");
		String sobrenomeDois = sc.nextLine();

		System.out.println("Digite o salário mensal 2:");
		Double salMenDois = Double.parseDouble(sc.nextLine());

		Empregado emp1 = new Empregado(nomeUm, sobrenomeUm, salMenUm);
		Empregado emp2 = new Empregado(nomeDois, sobrenomeDois, salMenDois);

		System.out.println("-----------------------");
		exibeInfosEmp(emp1);
		exibeInfosEmp(emp2);

		System.out.println();
		System.out.println();

		aplicaReajusteDezPcnt(emp1);
		aplicaReajusteDezPcnt(emp2);

		exibeInfosEmp(emp1);
		exibeInfosEmp(emp2);

		sc.close();
    }

	public static void exibeInfosEmp(Empregado emp){
		exibeDadosEmpregado(emp);
		exibeSalarioAnual(emp.getSalarioMensal());
		System.out.println();

	}

	public static void exibeDadosEmpregado(Empregado emp){
		System.out.println("Empregado: " + emp.getPrimeiroNome() + " " + emp.getSobrenome());
	}

	public static void exibeSalarioAnual(double sal){
		System.out.println("Salário anual: " + sal * 12);
	}

	public static void aplicaReajusteDezPcnt(Empregado emp){
		emp.setSalarioMensal((emp.getSalarioMensal() * 0.10) + emp.getSalarioMensal());
	}
}
