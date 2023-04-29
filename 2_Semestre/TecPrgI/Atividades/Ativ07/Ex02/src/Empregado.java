public class Empregado {
	public String primeiroNome;
	public String sobrenome;
	public double salarioMensal;

	public Empregado(String primeiroNome, String sobrenome, double salarioMensal) {
		this.primeiroNome = primeiroNome;
		this.sobrenome = sobrenome;
		this.salarioMensal = salarioMensal > 0 ? salarioMensal : 0;
	}

	public String getPrimeiroNome() {
		return primeiroNome;
	}
	public void setPrimeiroNome(String primeiroNome) {
		this.primeiroNome = primeiroNome;
	}
	public String getSobrenome() {
		return sobrenome;
	}
	public void setSobrenome(String sobrenome) {
		this.sobrenome = sobrenome;
	}
	public double getSalarioMensal() {
		return salarioMensal;
	}
	public void setSalarioMensal(double salarioMensal) {
		this.salarioMensal = salarioMensal;
	}
}
