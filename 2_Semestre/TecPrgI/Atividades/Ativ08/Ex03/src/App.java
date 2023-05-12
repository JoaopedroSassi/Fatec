package com.mycompany.tp_08_ex_03;

public class App {
    public static void main(String[] args) throws Exception {
        JFrame frame = new JFrame("Calculadora de Impostos");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(150, 300);
        frame.setLocationRelativeTo(null);
        frame.setResizable(false);

        JPanel panel = new JPanel();

        JLabel valorLabel = new JLabel("Valor da Venda:");
        JTextField valorField = new JTextField(10);
        JLabel icmsLabel = new JLabel("ICMS (18%):");
        JTextField icmsField = new JTextField(10);
        icmsField.setEditable(false);
        JLabel ipiLabel = new JLabel("IPI (5%):");
        JTextField ipiField = new JTextField(10);
        ipiField.setEditable(false);
        JLabel totalLabel = new JLabel("Valor Total:");
        JTextField totalField = new JTextField(10);
        totalField.setEditable(false);

        JButton calcularButton = new JButton("Calcular");
        calcularButton.addActionListener(e -> {
            try {
                double valor = Double.parseDouble(valorField.getText());
                double icms = valor * 0.18;
                double ipi = valor * 0.05;
                double total = valor + icms + ipi;

                icmsField.setText(String.format("%.2f", icms));
                ipiField.setText(String.format("%.2f", ipi));
                totalField.setText(String.format("%.2f", total));
            } catch (NumberFormatException ex) {
                JOptionPane.showMessageDialog(frame, "Valor inválido", "Erro", JOptionPane.ERROR_MESSAGE);
            }
        });

        panel.add(valorLabel);
        panel.add(valorField);
        panel.add(icmsLabel);
        panel.add(icmsField);
        panel.add(ipiLabel);
        panel.add(ipiField);
        panel.add(totalLabel);
        panel.add(totalField);
        panel.add(calcularButton);

        frame.add(panel);
        frame.setVisible(true);
    }
}
