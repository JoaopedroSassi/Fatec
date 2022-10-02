function register() {
	let firstName = document.getElementById("ifirstName");
	let lastName = document.getElementById("ilastName");
	let email = document.getElementById("iemail");
	let birthDate = document.getElementById("ibirthDate");
	let password = document.getElementById("ipassword");

	if (firstName.value !== '' || lastName.value !== '' || email.value !== '' || birthDate.value !== '' || password.value !== '') {
		window.alert("Registro concluído com sucesso!");
		window.location.assign("index.html");
		return true;
	}
}

function login() {
	let email = document.getElementById("iemail");
	let password = document.getElementById("ipassword");

	debugger;

	if (email.value === "admin" && password.value === "admin") {
		window.alert("Login efetuado com sucesso!");
		window.location.assign("success.html");
		return true;
	} else {
		window.alert("Login incorreto");
		email.focus();
	}
}