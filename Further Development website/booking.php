<html>
<head>

<?php

$status=$_POST["status"];
$fname=$_POST["firstname"];
$lname=$_POST["lastname"];
$doctor=$_POST["doctor"];
$date=$_POST["date"];
$month=$_POST["month"];
$year=$_POST["year"];
$phone=$_POST["phone"];


if(isset($_POST["submit"]))
{
	$conn=mysqli_connect('localhost','root','','medical center');
	{
		echo "not connected";
	}
	
	$ac=mysqli_query($conn,"INSERT INTO book VALUES ('$status', '$fname', '$lname', '$doctor', '$date', '$month', '$year', '$phone') ");
	
	if($ac)
	{
		echo "Data inserted";
	}
	
	else
	{
		echo "failed";
	}
}

?>

</head>
</html>