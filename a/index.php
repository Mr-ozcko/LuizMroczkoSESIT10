<form action="" method="POST">

        <label for="number1">Numero 1:</label>
        <input type="number" id="number1" name="number1" required><br>

        <label for="number2">Numero 2:</label>
        <input type="number" id="number2" name="number2" required><br>

        <label for="operator">Operador:</label>
        <select id="operator" name="operator">
            <option value="+">Adição</option>
            <option value="-">Subtração</option>
            <option value="/">Divisão</option>
            <option value="*">Multiplicação</option>
        </select>

        <input type="submit" value="Submit">
    </form>

<?php
    if ($_SERVER["REQUEST_METHOD"] == "POST") {

        $number1 = $_POST['number1'];
        $number2 = $_POST['number2'];
        $operator = $_POST['operator'];

        setcookie("num1", $number1);
        setcookie("num2", $number2);
        setcookie("op", $operator);

    } else {

        echo "Invalid request.";

    }
?>
