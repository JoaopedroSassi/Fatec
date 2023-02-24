import javax.swing.JOptionPane;

public class App {
	public static void main(String[] args) throws Exception {
		try {
			double p1 = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite a nota da P1: ",
					"Notas - FATEC Mauá", JOptionPane.INFORMATION_MESSAGE));
			double p2 = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite a nota da P2: ",
					"Notas - FATEC Mauá", JOptionPane.INFORMATION_MESSAGE));
			double trb = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite a nota de trabalhos: ",
					"Notas - FATEC Mauá", JOptionPane.INFORMATION_MESSAGE));

			double media = ((p1 * 0.35) + (p2 * 0.35) + (trb * 0.30));
			JOptionPane.showMessageDialog(null, "Sua média é: " + media);
		} catch (NumberFormatException e) {
			JOptionPane.showMessageDialog(null, "Exceção: " + e);
		}
	}
}
