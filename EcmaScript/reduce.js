const numeros= [10,12,20]

const somatorio = numeros.reduce((total , n) => {
    return total + n
},0);

// console.log(somatorio);

const produtos = [
    {
        produto :"camiseta" , preco : 129.90,
        produto :"jaqueta de couro" , preco : 500.00,
        produto :"tênis" , preco : 200.90

    }
]

let toProduto = produtos.reduce((vclinica , oP) => {
    return vclinica + oP.preco;
},0)

console.log(`o total de vendas foi : R$${toProduto}`);
