<?php
		//https://devcenter.heroku.com/articles/cleardb#using-cleardb-with-php
		$url = parse_url(getenv("CLEARDB_DATABASE_URL"));

		$server = $url["host"];
		$username = $url["user"];
		$password = $url["pass"];
		$db = substr($url["path"], 1);

		$conn = new mysqli($server, $username, $password, $db);

		if($conn->connect_errno > 0){
	        die('Unable to connect to database [' . $db->connect_error . ']');
	    }


        // Strings must be escaped to prevent SQL injection attack.
        $name = $conn->real_escape_string($_GET['name']);
        $score = $conn->real_escape_string($_GET['score']);
        $hash = $_GET['hash'];


        $secretKey="AOT24LYFE"; # Change this value to match the value stored in the client javascript below

        $real_hash = md5($name . $score . $secretKey);
        if($real_hash == $hash)
		{
            // Send variables for the MySQL database class.
            $query = "insert into scores values (NULL, '$name', '$score');";
			if(!$result = $conn->query($query)){
		    die('There was an error running the query [' . $db->error . ']');
		    }

			$querytwo = "DELETE FROM `scores` ORDER BY `score` LIMIT 1";
			if(!$result = $conn->query($querytwo)){
		    die('There was an error running the query [' . $db->error . ']');
		    }
        }
?>
