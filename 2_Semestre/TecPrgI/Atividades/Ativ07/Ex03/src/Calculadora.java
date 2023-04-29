public class Calculadora {
	public double numUm;
	public double numDois;
	public char operacao;

	public Calculadora() {
	}

	public Calculadora(double numUm, double numDois, char operacao) {
		this.numUm = numUm;
		this.numDois = numDois;
		this.operacao = operacao;
	}

	public void calcValores(){
		try {
			if (this.operacao == '/'){
				if (numDois == 0)
					throw new Exception();

				System.out.println("Divisão: " + (this.numUm / this.numDois));
			} else if (this.operacao == '*'){
				System.out.println("Multiplicação: " + (this.numUm * this.numDois));
			} else if (this.operacao == '+'){
				System.out.println("Soma: " + (this.numUm + this.numDois));
			} else if (this.operacao == '-'){
				System.out.println("Subtração: " + (this.numUm - this.numDois));
			} else {
				System.out.println("Erro | Operação errada");
			}
		} catch (Exception e) {
			System.out.println("ERRO | Divisão por 0");
		}
	}

	public double getNumUm() {
		return numUm;
	}
	public void setNumUm(double numUm) {
		this.numUm = numUm;
	}
	public double getNumDois() {
		return numDois;
	}
	public void setNumDois(double numDois) {
		this.numDois = numDois;
	}
	public char getOperacao() {
		return operacao;
	}
	public void setOperacao(char operacao) {
		this.operacao = operacao;
	}
}
