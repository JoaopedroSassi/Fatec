import javax.swing.JOptionPane;

public class App {
	public static void main(String[] args) throws Exception {
		int numAccount = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite o número da sua conta: ",
				"Banco MF", JOptionPane.INFORMATION_MESSAGE));

		double balance = Double.parseDouble(
				JOptionPane.showInputDialog(null, "Digite o seu saldo: ", "Banco MF", JOptionPane.INFORMATION_MESSAGE));

		double debt = Double.parseDouble(
				JOptionPane.showInputDialog(null, "Digite o débito: ", "Banco MF", JOptionPane.INFORMATION_MESSAGE));

		double credit = Double.parseDouble(
				JOptionPane.showInputDialog(null, "Digite o crédito: ", "Banco MF", JOptionPane.INFORMATION_MESSAGE));

		double actualBalance = calcActualBalance(balance, debt, credit);

		String msg = "";
		if (actualBalance > 0) {
			msg = "Positivo";
		} else {
			msg = "Negativo";
		}

		JOptionPane.showMessageDialog(null, "Conta: " + numAccount + " - Saldo =  " + actualBalance + " | Saldo " + msg,
				"Banco MF", JOptionPane.INFORMATION_MESSAGE);
	}

	public static double calcActualBalance(double balance, double debt, double credit) {
		return balance - debt + credit;
	}
}
