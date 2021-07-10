<?php

	$db = $_POST["database"];
	$pw = $_POST["password"];
	$user = $_POST["username"];
	$server = $_POST["serverip"];

	$query = $_POST["query"];

	$con = mysqli_connect('" . $server . "', '" . $user . "', '" . $pw . "', '" . db . "');
	if(mysqli_connect_errno()){
		echo "1: Connection to DB failed."; //Errorcode 1 = connection failed.
		exit();
	}
	
	$namecheck = mysqli_query($con, $query) or die("2: query failed."); //Error 2 = namecheck failed.
	echo $namecheck;
	
?>