<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
$query = $_GET['q'];

if ($query == 1) {
    $handle = fopen("./docs/nyfrett.txt", "r");
    $output = fread($handle, filesize("./docs/nyfrett.txt"));
    echo $output;
}
if ($query == 2) {
    $handle = fopen("./docs/mot.txt", "r");
    $output = fread($handle, filesize("./docs/mot.txt"));
    echo $output;
}
if ($query == 3) {
    $handle = fopen("./docs/urslit.txt", "r");
    $output = fread($handle, filesize("./docs/urslit.txt"));
    echo $output;
}
?>
