var total = 0;
var prato = 0;
var bebida = 0;
var sobremesa = 0;
var tst = 0;
var bat = 0;

function comecar(){
    var nome = document.getElementById("exampleFormControlInput1").value;
     show(nome);
}

function show(nome){
    document.getElementById("nomePrint").textContent = nome;
    var div = document.getElementById("selects-div");
    if(nome && nome.trim() !== ""){ 
        div.style.display = "flex";
        document.getElementById("exampleFormControlInput1").style.background = "none";
    }else{
        document.getElementById("error").style.display = "block"
    }
}

function fechar(){
    document.getElementById("error").style.display = "none"
    document.getElementById("exampleFormControlInput1").style.background = "lightpink";
}

function calcularTotal(){
    var selectPratos = document.getElementById("selectPrato");
    var selectBebidas = document.getElementById("selectBebida");
    var selectSobremesas = document.getElementById("selectSobremesa");
    var selectTst = document.getElementById("selectTst");
    var selectBat = document.getElementById("selectBat");
    var resultadoSpan = document.getElementById("resultado");

    switch (selectPratos.value) {
        case "Baguete":
            total += 13.80;
            prato = 13.80;
        break;
        case "Herbs & Cheese":
            total += 15.00;
            prato = 15.00;
        break;
        case "Achatado":
            total += 10.99;
            prato = 10.99;
        break;
        case "Italiano":
            total += 8.99;
            prato = 8.99;
        break;
        case "Graos":
            total += 12.75;
            prato = 12.75;
        break;
    }
    switch (selectBebidas.value) {
        case "Bife":
            total += 8.10;
            bebida = 8.10;
        break;
        case "Frango":
            total += 6.50;
            bebida = 6.50;
        break;
        case "Presunto":
            total += 9.00;
            bebida = 9.00;
        break;
        case "Tuna":
            total += 7.80;
            bebida = 7.80;
        break;
        case "Almondega":
            total += 10.99;
            bebida = 10.99;
        break;
    }
    switch (selectSobremesas.value) {
        case "Americano":
            total += 5.50;
            sobremesa = 5.50;
        break;
        case "Cheddar Ralado":
            total += 6.70;
            sobremesa = 6.70;
        break;
        case "Mozzarella":
            total += 8.90;
            sobremesa = 8.90;
        break;
        case "Pepper Jack":
            total += 7.65;
            sobremesa = 7.65;
        break;
        case "Provolone":
            total += 6.40;
            sobremesa = 6.40;
        break;
    }
    switch (selectTst.value) {
        case "Chocolate":
            total += 4.25;
            tst = 4.25;
        break;
        case "Chocolate Branco":
            total += 4.50;
            tst = 4.50;
        break;
        case "Chocolate Duplo":
            total += 5.00;
            tst = 5.00;
        break;
        case "Framboesa":
            total += 7.00;
            tst = 7.00;
        break;
        case "Aveia":
            total += 6.75;
            tst = 6.75;
        break;
    }
    switch (selectBat.value) {
        case "Coca Lata":
            total += 6.50;
            bat = 6.50;
        break;
        case "Coca 1L":
            total += 9.99;
            bat = 9.99;
        break;
        case "Fanta Lata":
            total += 6.00;
            bat = 6.00;
        break;
        case "Guarana Lata":
            total += 5.50;
            bat = 5.50;
        break;
        case "Guarana Lata Zero":
            total += 5.50;
            bat = 5.50;
        break;
    }
    document.getElementById("resultado").style.display = "block"
    document.getElementById("pedido-pronto").style.display = "block"
    document.getElementById("prato-pronto").textContent = selectPratos.value + " - R$ " + prato.toFixed(2);
    document.getElementById("bebida-pronto").textContent = selectBebidas.value + " - R$ " + bebida.toFixed(2);
    document.getElementById("sobremesa-pronto").textContent = selectSobremesas.value + " - R$ " + sobremesa.toFixed(2);
    document.getElementById("tst-pronto").textContent = selectTst.value + " - R$ " + tst.toFixed(2);
    document.getElementById("bat-pronto").textContent = selectBat.value + " - R$ " + bat.toFixed(2);
    resultadoSpan.textContent = "R$ " + total.toFixed(2);
}

function limpar(){
    document.getElementById("pedido-pronto").style.display = "none";
    document.getElementById("selects-div").style.display = "none";
    document.getElementById("resultado").style.display = "none";
    document.getElementById("exampleFormControlInput1").value = "";
    document.getElementById("resultado").value = "";
    document.getElementById("selectPrato").value = "Selecione seu pão";
    document.getElementById("selectBebida").value = "Selecione sua proteina";
    document.getElementById("selectSobremesa").value = "Selecione seu queijo";
    document.getElementById("selectTst").value = "Selecione seu cookie";
    document.getElementById("selectBat").value = "Selecione seu refri";
    total = 0;
    prato = 0;
    bebida = 0;
    sobremesa = 0;
    tst = 0;
    bat = 0;

}

function enviar() {
    const hour = new Date().getHours();
    const minute = new Date().getMinutes();
    const day = new Date().getDay();
    const month = new Date().getMonth();
    const year = new Date().getFullYear();   
    const hora = day.toString() + "/"+ month.toString() + "/" + year.toString() + " - " + hour.toString() + ":" + minute.toString();
    var numeroTelefone = "5599999999999"
    var nome = document.getElementById("exampleFormControlInput1").value;
    var selectPratos = document.getElementById("selectPrato").value;
    var selectBebidas = document.getElementById("selectBebida").value;
    var selectSobremesas = document.getElementById("selectSobremesa").value;

    var linkWhatsApp = "https://wa.me/" +
     numeroTelefone + 
     "?text=Cliente: " +  nome + "%0a" + "Prato: " + selectPratos + " - R$" + prato.toFixed(2) + "%0a" + "Bebida: " + selectBebidas + " - R$" + bebida.toFixed(2) + "%0a" + "Sobremesa: " + selectSobremesas + " - R$" + sobremesa.toFixed(2) + "%0a" + "Total: R$" + total.toFixed(2) + "%0a" + "Hora do pedido: " + hora;
    window.open(linkWhatsApp, "_blank");
}