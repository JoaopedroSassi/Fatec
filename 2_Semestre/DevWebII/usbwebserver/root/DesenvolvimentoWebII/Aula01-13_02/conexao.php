<?php

	$user = "root";
	$pass = "usbw";
	$db = "crudphp";
	$host = "localhost";
	$conectDB = mysqli_connect($host, $user, $pass) or die(mysqli_error());

	mysql_select_db($db) or die("Erro ao conectar!");
?>