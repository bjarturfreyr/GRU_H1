<?php
include 'dbconnections/mydbconnection.inc';
try {
    $sql = "SELECT *FROM medlimur";
    $result = $pdo->query($sql);
} catch (ErrorException $e) {
    echo $e;
}
foreach ($result as $user) {
    echo $user['fornafn'] . " " . $user['eftirnafn'] . " " . $user['netfang'] . " " . $user['heimilisfang'] . "<br/>";
}
?>