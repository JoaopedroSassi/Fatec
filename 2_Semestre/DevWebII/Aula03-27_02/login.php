<!DOCTYPE html>
<html lang="pt-br">
<head>
	<meta charset="UTF-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Login</title>
	<link rel="stylesheet" href="style.css">
</head>
<body>
	<div id="form-group">
		<form method="post" name="form" id="form">
			<h2 id="tituloLogin">Login</h2>
			<label for="user">Usuário ou Email</label><br />
			<input type="text" name="user" id="user">
			<br />
			<label for="password">Password</label><br />
			<input type="password" name="password" id="password">
			<br />
			<div id="btn-group">
				<input type="submit" value="Entrar" onclick="document.form.action='logar.php'">
				<input type="submit" value="Nova conta" onclick="document.form.action='cadastro.html'">
			</div>
		</form>
	</div>
</body>
</html>