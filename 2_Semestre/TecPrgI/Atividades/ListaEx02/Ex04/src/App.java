import javax.swing.JOptionPane;

public class App {
    public static void main(String[] args) throws Exception {
        int age = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite sua idade: ", "Plano de saúde - SUS",
				JOptionPane.INFORMATION_MESSAGE));

		if (age < 16) {
            JOptionPane.showMessageDialog(null, "Você não pode votar!");
		} else if (age >= 18 && age < 65) {
			JOptionPane.showMessageDialog(null, "Você é obrigado a votar!");
		} else if (age >= 65 || (age >= 16 && age < 18)) {
			JOptionPane.showMessageDialog(null, "Você tem voto facultativo!");
		}
    }
}
