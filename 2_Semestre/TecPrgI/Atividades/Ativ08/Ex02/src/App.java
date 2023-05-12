import javax.swing.JFrame;

public class App {
    public static void main(String[] args) throws Exception {
        Telefone telefone = new Telefone();
        telefone.setSize(170, 225);        
        telefone.setResizable(false);
        telefone.setLocationRelativeTo(null);
        telefone.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        telefone.setVisible(true);
    }
}
