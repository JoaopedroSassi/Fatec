import java.util.ArrayList;
import java.util.List;

import javax.swing.JOptionPane;

public class App {
    public static void main(String[] args) throws Exception {
		List<Integer> list = new ArrayList<>();
		try {
			int beg = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite o início do intervalo: ", "Numeros pares", JOptionPane.INFORMATION_MESSAGE));
			int end = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite o final do intervalo: ", "Numeros pares", JOptionPane.INFORMATION_MESSAGE));

			for (; beg <= end; beg++) {
				if (beg % 2 == 0) {
					list.add(beg);
				}
			}

			JOptionPane.showMessageDialog(null, list, "Numeros pares", JOptionPane.INFORMATION_MESSAGE);
		} catch (NumberFormatException e) {
			JOptionPane.showMessageDialog(null, "Exceção: " + e);
		}
    }
}
