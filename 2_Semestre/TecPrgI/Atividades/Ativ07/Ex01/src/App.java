import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        Scanner sc = new Scanner(System.in);
		System.out.println("Digite o ID da fatura:");
		int id = Integer.parseInt(sc.nextLine());

		System.out.println("Digite a descrição da fatura:");
		String desc = sc.nextLine();

		System.out.println("Digite a quantidade comprada da fatura:");
		int qtde = Integer.parseInt(sc.nextLine());

		System.out.println("Digite o preço unitário da fatura:");
		double precoUnit = Double.parseDouble(sc.nextLine());

		Faturar fatura = new Faturar(id, desc, qtde, precoUnit);
		System.out.println("---------------------");
		System.out.println("Fatura " + fatura.getId() + "°");
		System.out.println("Descrição: " + fatura.getDescricao());
		System.out.println("Quantidade: " + fatura.getQtdeComprada());
		System.out.println("Preço unitário: " + fatura.getPrecoUnitario());
		System.out.println("---------------------");
		System.out.println("Fatura total: " + fatura.getFaturaTotal());

		sc.close();
    }
}
