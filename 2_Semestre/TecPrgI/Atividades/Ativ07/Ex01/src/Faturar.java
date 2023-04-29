public class Faturar {
	public int id;
	public String descricao;
	public int qtdeComprada;
	public double precoUnitario;

	public Faturar(int id, String descricao, int qtdeComprada, double precoUnitario) {
		this.id = id;
		this.descricao = descricao;
		this.qtdeComprada = qtdeComprada > 0 ? qtdeComprada : 0;
		this.precoUnitario = precoUnitario > 0 ? precoUnitario : 0;
	}

	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getDescricao() {
		return descricao;
	}
	public void setDescricao(String descricao) {
		this.descricao = descricao;
	}
	public int getQtdeComprada() {
		return qtdeComprada;
	}
	public void setQtdeComprada(int qtdeComprada) {
		this.qtdeComprada = qtdeComprada;
	}
	public double getPrecoUnitario() {
		return precoUnitario;
	}
	public void setPrecoUnitario(double precoUnitario) {
		this.precoUnitario = precoUnitario;
	}

	public double getFaturaTotal(){
		return this.qtdeComprada * this.precoUnitario;
	}
	
}
