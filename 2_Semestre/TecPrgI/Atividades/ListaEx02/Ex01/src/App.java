import javax.swing.JOptionPane;

public class App {
    public static void main(String[] args) throws Exception {
		int value = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite o valor:", "Aviso", JOptionPane.QUESTION_MESSAGE));

		boolean isdDvisible = false;
		if (value % 3 == 0){
            isdDvisible = true;
        }

		if (isdDvisible){
            JOptionPane.showMessageDialog(null, "O valor é divisível por 3");
        } else {
            JOptionPane.showMessageDialog(null, "O valor não é divisível por 3");
        }
    }
}
