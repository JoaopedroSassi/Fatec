import javax.swing.JOptionPane;

public class App {
	public static void main(String[] args) throws Exception {
		double value = Double.parseDouble(JOptionPane.showInputDialog(null, "Insira o valor da venda: "));

		if (value < 20.0) {
			value = value + (value * 0.45);
		} else {
			value = value + (value * 0.30);
		}

		JOptionPane.showMessageDialog(null, "Valor final da venda: " + value);
	}
}
