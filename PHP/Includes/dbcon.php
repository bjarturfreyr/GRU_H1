<?php
ob_start();
session_start();
//database login info
define('DBHOST', 'tsuts.tskoli.is');
define('DBUSER', 'GRU_H1');
define('DBPASS', 'gaben');
define('DBNAME', 'gru_h1_database');

try{
$db = new PDO("mysql:host=".DBHOST.";port=3306;dbname=".DBNAME, DBUSER, DBPASS);
$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
}
 catch(PDOException $e) {
    //show error
    echo '<p class="bg-danger">'.$e->getMessage().'</p>';
    exit;
}
//set timezone
date_default_timezone_set('Europe/London');
?>
<!--phpfunction __autoload($class) {
   
   $class = strtolower($class);

   $classpath = 'classes/class.'.$class . '.php';
   if ( file_exists($classpath)) {
      require_once $classpath;
    }     

   $classpath = '../classes/class.'.$class . '.php';
   if ( file_exists($classpath)) {
      require_once $classpath;
    }
        
     
}

$user = new User($db);-->

