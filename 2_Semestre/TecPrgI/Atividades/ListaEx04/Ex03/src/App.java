import javax.swing.JOptionPane;

public class App {
    public static void main(String[] args) throws Exception {
		double x = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite o lado X do Triângulo: ", "Triangulação", JOptionPane.INFORMATION_MESSAGE));

		double y = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite o lado Y do Triângulo: ", "Triangulação", JOptionPane.INFORMATION_MESSAGE));

		double z = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite o lado Z do Triângulo: ", "Triangulação", JOptionPane.INFORMATION_MESSAGE));

		if (!validateTriangle(x, y, z)) {
			JOptionPane.showMessageDialog(null, "ERRO | Valores não formam um triângulo!", "Triangulação", JOptionPane.INFORMATION_MESSAGE);
		} else {
			JOptionPane.showMessageDialog(null, "Esses valores formam um triângulo " + typeOfTriangle(x, y, z), "Triangulação", JOptionPane.INFORMATION_MESSAGE);
		}
    }

	public static boolean validateTriangle(double x, double y, double z){
		if ((x > y + z) ||(y > x + z) || (z > x + y)){
			return false;
		} 

		return true;
	}

	public static String typeOfTriangle(double x, double y, double z) {
		if ((x == y) && (y == z)){
			return "Equilátero";
		} else if (((x == y) && (y != z)) || (y == z) && (z != x) || (x == z) && (z != y)){
			return "Isóceles";
		} else {
			return "Escaleno";
		}
	}
}
