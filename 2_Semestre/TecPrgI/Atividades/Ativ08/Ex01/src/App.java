import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class App {
    private JFrame janela;
    private JPanel painelPrincipal;
    private Label label1, lblr, lbl3;
    private TextField t1, t2;

    public static void main(String[] args) throws Exception {
        new App().montaTela();
    }

    private void montaTela() {
        preparaJanela();
        preparaPainelPrincipal();
        preparaLabel();
        preparaText();
        preparaBotaoCarregar();
        preparaBotaoSubtrair();
        preparaBotaoMultiplicar();
        preparaBotaoDividir();
        preparaBotaoSair();
        mostraJanela();
    }

    private void mostraJanela() {
        janela.pack();
        janela.setSize(1200, 300);
        janela.setVisible(true);
    }

    private void preparaBotaoSair() {
        JButton botaoSair = new JButton("Sair");
        botaoSair.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                System.exit(0);
            }
        });
        painelPrincipal.add(botaoSair);
    }

    private void preparaBotaoCarregar() {
        JButton botaoCarregar = new JButton("SOMA");
        botaoCarregar.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                int soma = Integer.parseInt(t1.getText()) + Integer.parseInt(t2.getText());
                lbl3.setText(Integer.toString(soma));
            }
        });

        painelPrincipal.setLocation(50, 100);
        painelPrincipal.add(botaoCarregar);
    }

    private void preparaBotaoSubtrair(){
        JButton botaoSub = new JButton("Subtrair");
        botaoSub.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                int sub = Integer.parseInt(t1.getText()) - Integer.parseInt(t2.getText());
                lbl3.setText(Integer.toString(sub));
            }
        });

        painelPrincipal.setLocation(70, 20);
        painelPrincipal.add(botaoSub);
    }

    private void preparaBotaoMultiplicar(){
        JButton botaoMult = new JButton("Multiplicar");
        botaoMult.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                int mult = Integer.parseInt(t1.getText()) * Integer.parseInt(t2.getText());
                lbl3.setText(Integer.toString(mult));
            }
        });

        painelPrincipal.setLocation(80, 20);
        painelPrincipal.add(botaoMult);
    }

    private void preparaBotaoDividir(){
        JButton botaoDiv = new JButton("Dividir");
        botaoDiv.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (Integer.parseInt(t2.getText()) == 0)
                    lbl3.setText("NAO EXISTE DIVISÃO POR 0");
                
                int div = Integer.parseInt(t1.getText()) / Integer.parseInt(t2.getText());
                lbl3.setText(Integer.toString(div));
            }
        });

        painelPrincipal.setLocation(80, 20);
        painelPrincipal.add(botaoDiv);
    }

    private void preparaText() {
        t1 = new TextField("");
        t2 = new TextField("");
        lbl3 = new Label(" ");
        lblr = new Label("Resultado=");
        painelPrincipal.add(t1);
        painelPrincipal.add(t2);
        painelPrincipal.add(lblr);
        painelPrincipal.add(lbl3);
    }

    private void preparaLabel() {
        label1 = new Label("Calculando a Soma de 2 números");
        painelPrincipal.add(label1);
    }

    private void preparaPainelPrincipal() {
        painelPrincipal = new JPanel();
        //painelPrincipal.setLayout(new FlowLayout(painelPrincipal, BoxLayout.PAGE_AXIS));
        FlowLayout f = (FlowLayout)painelPrincipal.getLayout();
        janela.add(painelPrincipal);
        //painelPrincipal.setLayout(new GridLayout(3,2));
    }

    private void preparaJanela() {
        janela = new JFrame("Exemplo");
        janela.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
}
