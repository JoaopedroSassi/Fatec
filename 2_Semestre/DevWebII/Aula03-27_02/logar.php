<?php
    include 'conexao.php';

    $user = $_POST['user'];
    $password = $_POST['password'];
    
    try {
        $sql = mysql_query("SELECT * FROM tb_cadastro WHERE ('$user' = usuario OR '$user' = email) AND ('$password' = senha)");

        if (mysql_num_rows($sql) > 0) {
            echo "<center>";
            echo "<hr>";
            echo "<h1>Logado</h1>";
            echo "<hr>";
            echo "</center>";
            echo "<a href=\"listagem.php\"> Lista de contas </a>";
        } else {
            echo "<center>";
            echo "<hr>";
            echo "<h1>Usuario invalido!</h1>";
            echo "<hr>";
            echo "</center>";
            echo "<a href=\"login.php\"> Voltar</a>";
        }
    } catch (\Throwable $th) {
        echo "Exception: ". $th->getMessage();
    }
?>