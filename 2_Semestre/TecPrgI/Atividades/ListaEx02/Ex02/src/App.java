import java.util.ArrayList;
import java.util.List;

import javax.swing.JOptionPane;

public class App {
    public static void main(String[] args) throws Exception {
		List<Integer> list = new ArrayList<Integer>();

		for (int i = 0; i < 3; i++) {
			list.add(Integer.parseInt(JOptionPane.showInputDialog(null, "Digite o " + i+1 + "° valor:", "Ordenando valores", JOptionPane.QUESTION_MESSAGE)));
		}

		list.sort(null);
   
		JOptionPane.showMessageDialog(null, list);
    }
}
