<?php
    //http://localhost/phpmyadmin/addscore.php

    // Send variables for the MySQL database class.
    $database = mysql_connect('localhost', 'root', 'AOT2Rocks') or die('Could not connect: ' . mysql_error());
    mysql_select_db('aot2highscores') or die('Could not select database');
 
    $query = "SELECT * FROM `scores` ORDER by `score` DESC LIMIT 5";
    $result = mysql_query($query) or die('Query failed: ' . mysql_error());
 
    $num_results = mysql_num_rows($result);  
 
    for($i = 0; $i < $num_results; $i++)
    {
         $row = mysql_fetch_array($result);
         echo $row['name'] . "\t" . $row['score'] . "\n";
    }
?>
