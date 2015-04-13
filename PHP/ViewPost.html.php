<!DOCTYPE html>
<html>
<head>
<?php
include 'Includes/dbcon.php';
 ?>
	<title></title>
</head>
<body>
<?php 
$stmt = $db->prepare('SELECT BlogID, BlogTitle, BlogsCont, BlogDate FROM blogs WHERE BlogID = :BlogID');
$stmt->execute(array(':BlogID' => $_GET['id']));
$row = $stmt->fetch();
if($row['BlogID'] == ''){
    header('Location: ./');
    exit;
}
echo '<div>';
    echo '<h1>'.$row['BlogTitle'].'</h1>';
    echo '<p>Posted on '.date('jS M Y', strtotime($row['BlogDate'])).'</p>';
    echo '<p>'.$row['BlogsCont'].'</p>';                
echo '</div>';
?>
</body>
</html>