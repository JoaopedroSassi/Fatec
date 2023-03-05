import javax.swing.JOptionPane;

public class App {
    public static void main(String[] args) throws Exception {
		String productName = JOptionPane.showInputDialog(null, "Digite o nome do produto: ", "Lojinho", JOptionPane.INFORMATION_MESSAGE);

        double productPrice = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite preço de " + productName + "", "Lojinho", JOptionPane.INFORMATION_MESSAGE));

		int productQtde = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite a quantidade: ", "Lojinho", JOptionPane.INFORMATION_MESSAGE));

		JOptionPane.showMessageDialog(null, "Produto: " + productName + " - Valor: " + CalcDiscount(productName, productPrice, productQtde) + "", "Lojinho", JOptionPane.INFORMATION_MESSAGE);
    }

	public static double CalcDiscount(String productName, double productPrice, int productQtde){
		if (productQtde <= 10) {
			return productPrice * productQtde;
		} else if (productQtde <= 20) {
			return productPrice * productQtde - ((productPrice * productQtde) * 0.10);
		} else if (productQtde <= 50) {
			return productPrice * productQtde - ((productPrice * productQtde) * 0.20);
		} else {
			return productPrice * productQtde - ((productPrice * productQtde) * 0.50);
		}
	}
}
