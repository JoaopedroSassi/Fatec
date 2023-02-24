import java.util.ArrayList;
import java.util.List;

import javax.swing.JOptionPane;

public class App {
    public static void main(String[] args) throws Exception {
		List<Integer> list = new ArrayList<>();
		try {
			int sup = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite o limite superior: ", "Incrementando", JOptionPane.INFORMATION_MESSAGE));
			int incr = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite o incremento: ", "Incrementando", JOptionPane.INFORMATION_MESSAGE));

			for (int i = 0; i <= sup; i = i + incr) {
				list.add(i);
			}

			JOptionPane.showMessageDialog(null, list, "Incrementando", JOptionPane.INFORMATION_MESSAGE);
		} catch (NumberFormatException e) {
			JOptionPane.showMessageDialog(null, "Exceção: " + e);
		}
    }
}
