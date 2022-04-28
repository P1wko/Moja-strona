<?php
$login = $_POST["login"];
$haslo = $_POST["psw"];
$email = $_POST["email"];
$polaczenie = mysqli_connect("localhost", "root", "", "contest");
$kwerenda = "INSERT INTO logowanie (id, login, psw, email) VALUES (default, ".$login.", ".$haslo.", ".$email.");";
mysqli_query($polaczenie, $kwerenda);
?>