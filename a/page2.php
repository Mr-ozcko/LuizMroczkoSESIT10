<?php

    $num1 = $_COOKIE["num1"];
    $num2 = $_COOKIE["num2"];
    $op = $_COOKIE["op"];

    $res = eval('return '.$num1.$op.$num2.';');

    setcookie("num1", 0, time()-3600);
    setcookie("num2", 0, time()-3600);
    setcookie("op", 0, time()-3600);
    setcookie("res", $res);
    

?>