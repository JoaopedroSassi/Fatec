import java.util.ArrayList;
import java.util.List;

import javax.swing.JOptionPane;

public class App {
    public static void main(String[] args) throws Exception {	
		List<Integer> list = new ArrayList<>();	
		try {
			int fim = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite o tamanho da sequência: ", "Fibonacci", JOptionPane.INFORMATION_MESSAGE));

			int n1 = 1;
			int n2 = 0;
			for (int i = 0; i < fim; i++) {
				int n3 = n1 + n2;
				list.add(n3);
				n1 = n2;
				n2 = n3;
			}

			JOptionPane.showMessageDialog(null, list);
		} catch (NumberFormatException e) {
			JOptionPane.showMessageDialog(null, "Exceção: " + e);
		}
    }
}
