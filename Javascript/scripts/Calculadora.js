function Calcular(){ 

    event.preventDefault()//parar o submit do formúlario.

    let n1 = parseFloat(document.getElementById('n1').value);               
    let n2 =parseFloat( document.getElementById('n2').value);
    let op = document.getElementById('Operacao').value;
    let resultado;

    if(isNaN(n1) || isNaN(n2))
    {
        alert("a operação não pode ser vazia");
        return;
    }

    if(op == '+')
    {
    resultado= somar(n1,n2)
    
    }else if(op == '-'){
    resultado= subtrair(n1,n2)
    
    }else if(op == '/'){
    resultado= Dividir(n1,n2)
   
    }else if(op == '*'){
    resultado= Multiplicar(n1,n2)
    
    }else(op == "selecione")
    {
        resultado= "Selecione uma Operação"
    }
    document.getElementById("resultado").textContent=resultado;
}

 function somar(x,y){

     return x + y;
 }

function subtrair (x,y) {
    return x - y;
}

function Dividir (x,y) {
    if(y == 0)
    {
        return "não existe divisão por 0";
    }

    return x / y;
}

function Multiplicar (x,y) {
    return x * y;
}
