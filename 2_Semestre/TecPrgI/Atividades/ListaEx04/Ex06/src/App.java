import javax.swing.JOptionPane;

public class App {
    public static void main(String[] args) throws Exception {
        int value = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite o valor: ", "To Boâdo", JOptionPane.INFORMATION_MESSAGE));

		JOptionPane.showMessageDialog(null, "A soma da tabuada de " + value + " = " + calcSumMultTable(value) + "", "To Boâdo", JOptionPane.INFORMATION_MESSAGE);
    }

	public static int calcSumMultTable(int value){
		int newValue = 0;
		for (int i = 1; i < 11; i++) {
			newValue += i * value;
		}

		return newValue;
	}
}
