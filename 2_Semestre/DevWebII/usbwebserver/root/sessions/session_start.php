<?php

session_start();

if (empty($_SESSION['count'])) {
   $_SESSION['count'] = 1;
} 
   elseif ($_SESSION['count']=10) {
	session_destroy();
}
  else {
   $_SESSION['count']++;
}
?>

<p>
<html>
<head>
  <meta charset="utf-8">
</head>
Olá visitante, você acessou esta página <?php echo $_SESSION['count']; ?> vezes.
</p>


<p>
</p>