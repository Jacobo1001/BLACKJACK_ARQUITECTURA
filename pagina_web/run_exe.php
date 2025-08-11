<?php
$inputData = $_POST['inputData'];

$inputData = trim($inputData);
$inputData = escapeshellarg($inputData); // Escapar los datos para prevenir inyección de comandos

$output = shell_exec('C:\Users\jacob\Desktop\NUEVO PROYECTO POO\I_Juego\BlackJack\bin\Release\BlackJack.exe' . $inputData);

echo "<pre>$output</pre>";
?>
