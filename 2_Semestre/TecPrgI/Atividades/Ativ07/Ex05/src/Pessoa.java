public class Pessoa {
	public String nome;
	public int idade;
	public double altura;
	public String sexo;

	public Pessoa() {
	}

	public Pessoa(String nome, int idade, double altura, String sexo) {
		this.nome = nome;
		this.idade = idade;
		this.altura = altura;
		this.sexo = sexo;
	}

	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public int getIdade() {
		return idade;
	}
	public void setIdade(int idade) {
		this.idade = idade;
	}
	public double getAltura() {
		return altura;
	}
	public void setAltura(double altura) {
		this.altura = altura;
	}
	public String getSexo() {
		return sexo;
	}
	public void setSexo(String sexo) {
		this.sexo = sexo;
	}
}
