<?php
	include 'conexao.php';

	$user = $_POST['user'];
	$email = $_POST['email'];
	$password = $_POST['password'];

	$SQL = mysql_query("SELECT * FROM tb_cadastro WHERE usuario = '$user' OR email = '$email'");

	if (mysql_num_rows($SQL) > 0){
		echo "<center>";
		echo "<hr>";
		echo "<h1>Usuário já existe!</h1>";
		echo "<hr>";
		echo "</center>";
	} else {
		$result = mysql_query("INSERT INTO tb_cadastro (usuario, email, senha) VALUES ('$user', '$email', '$password')") or die(mysql_error());
        echo "<center>";
		echo "<hr>";
		echo "<h1>Conta cadastrada com sucesso!</h1>";
		echo "<hr>";
		echo "</center>";
	}
?>