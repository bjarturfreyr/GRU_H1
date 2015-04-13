<?php
try {
    $pdo = new PDO('mysql:host=tsuts.tskoli.is;dbname=person', 'password12345',
                    '');
    $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    $pdo->exec('SET NAMES "utf8"');
} catch (PDOException $e) {
    $output = 'Villa gat ekki tengst gagnagrunni Villan er : ' . $e->getMessage();
    echo $output;
    exit();
}
?>
