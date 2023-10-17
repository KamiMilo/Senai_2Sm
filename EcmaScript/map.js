// let hobbies = ['filmes', 'livros', 'futebol', 'músicas', 'artes'];
// const hobbiesList = hobbies.map(function(hobb){
// return `<li>${hobb}</li>`
// });

// const numeros = [1, 2, 5,10,300];

// const arrdobros = numeros.map((n) => {
//     return n * 2;
// });

// console.log(numeros);
// console.log(arrdobros);

//crie 2 arrays nomes e sobrenomes
//crie um terceiro array de nomes completo
// ao final exiba os nomes completos no console com o foreach

const nomes = ["Evelyn","Allan", "Enzo"]

const sobrenome = ["Ribeiro","Rodrigues", "Aquarela"]

const nomeCompleto = nomes.map((nome,indice) => {`${nome} ${sobrenome[indice]} `});

nomeCompleto.forEach((nomesc) => {
    console.log(nomesc);
})
  





