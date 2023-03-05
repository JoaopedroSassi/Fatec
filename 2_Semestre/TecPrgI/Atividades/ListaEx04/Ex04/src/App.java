import javax.swing.JOptionPane;

public class App {
    public static void main(String[] args) throws Exception {
        double height = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite a sua altura: ", "Pesage", JOptionPane.INFORMATION_MESSAGE));

		int sex = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite o seu sexo (1 - Homem | 2 - Mulher): ", "Pesage", JOptionPane.INFORMATION_MESSAGE));

		calcIdealWeight(height, sex);
    }

	public static void calcIdealWeight(double height, int sex) {
		if (sex == 1) {
			JOptionPane.showMessageDialog(null, "Homem: Peso ideal = " + String.format("%.2f", ((72.2 * height) - 58)), "Pesage", JOptionPane.INFORMATION_MESSAGE);
		} else if (sex == 2) {
			JOptionPane.showMessageDialog(null, "Mulher: Peso ideal = " + String.format("%.2f", ((62.1 * height) - 44.7)), "Pesage", JOptionPane.INFORMATION_MESSAGE);
		} else {
			JOptionPane.showMessageDialog(null, "ERRO | Valor de sexo inválido!", "Pesage", JOptionPane.INFORMATION_MESSAGE);
		}
	}
}
