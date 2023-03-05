import javax.swing.JOptionPane;

public class App {
    public static void main(String[] args) throws Exception {
        int carYear = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite o ano do seu carro: ", "Transferência Detrânica - TD", JOptionPane.INFORMATION_MESSAGE));

		double carValue = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite o valor do seu carro: ", "Transferência Detrânica - TD", JOptionPane.INFORMATION_MESSAGE));

		JOptionPane.showMessageDialog(null, "Você irá pagar R$" + String.format("%.2f", calcCarTransfer(carYear, carValue)) + " para transferir!", "Transferência Detrânica - TD", JOptionPane.INFORMATION_MESSAGE);
    }

	public static double calcCarTransfer(int carYear, double carValue){
		if (carYear < 1990) {
			return carValue * 0.010;
		} else {
			return carValue * 0.015;
		}
	}
}
