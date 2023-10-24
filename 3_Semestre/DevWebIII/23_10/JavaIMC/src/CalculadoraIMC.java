public class CalculadoraIMC {
	public double calcIMC(double altura, double peso) {
		return (peso / (altura * altura));
	}

	public String verificaBiotipo(double imc) {
		if (imc <= 18.5){
			return "Abaixo do peso normal";
		} else if (imc < 24.9) {
			return "Peso normal";
		} else if (imc <= 29.9) {
			return "Excesso de peso";
		} else if (imc <= 34.9) {
			return "Obesidade classe I";
		} else if (imc <= 39.9) {
			return "Obesidade classe II";
		} else {
			return "Obesidade classe III";
		}
	}
}
