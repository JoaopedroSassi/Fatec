import javax.swing.JOptionPane;

public class App {
	public static void main(String[] args) throws Exception {
		String name = JOptionPane.showInputDialog(null, "Digite seu nome: ", "Plano de saúde - SUS",
				JOptionPane.INFORMATION_MESSAGE);
		int age = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite sua idade: ", "Plano de saúde - SUS",
				JOptionPane.INFORMATION_MESSAGE));

		double value = 0;
		if (age < 10) {
			value = 30.00;
		} else if (age >= 10 && age < 29) {
			value = 60.00;
		} else if (age >= 29 && age < 45) {
			value = 120.00;
		} else if (age >= 45 && age < 59) {
			value = 150.00;
		} else if (age >= 59 && age < 65) {
			value = 250.00;
		} else if (age >= 65) {
			value = 400.00;
		}

		JOptionPane.showMessageDialog(null, "Seu nome é " + name + " e você irá pagar R$" + value);
	}
}
