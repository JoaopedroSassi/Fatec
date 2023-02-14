<?php

	$user = "root";
	$pass = "usbw";
	$db = "crudphp";
	$host = "localhost";
	$conectDB = mysql_connect($host, $user, $pass) or die(mysql_error());

	mysql_select_db($db) or die("Erro ao conectar!");
?>