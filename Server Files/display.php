<?php
    //http://localhost/phpmyadmin/addscore.php


    //https://devcenter.heroku.com/articles/cleardb#using-cleardb-with-php
    $url = parse_url(getenv("CLEARDB_DATABASE_URL"));
    $server = $url["host"];
    $username = $url["user"];
    $password = $url["pass"];
    $db = substr($url["path"], 1);

    $conn = new mysqli($server, $username, $password, $db);

    //http://codular.com/php-mysqli
    if($conn->connect_errno > 0){
        die('Unable to connect to database [' . $db->connect_error . ']');
    }

    $query = "SELECT * FROM `scores` ORDER by `score` DESC LIMIT 5";

    //http://codular.com/php-mysqli
    if(!$result = $conn->query($query)){
    die('There was an error running the query [' . $db->error . ']');
    }

    $num_results = $result->num_rows;

    for($i = 0; $i < $num_results; $i++)
    {
         $row = $result->fetch_array(MYSQLI_BOTH);
         echo $row['name'] . "\t" . $row['score'] . "\n";
    }
?>
