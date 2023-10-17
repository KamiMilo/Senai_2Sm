const numeros = [1 ,2,200, 7,10,15 ,8]

// console.log(numeros);

const nMenor10 = numeros.filter((n)=> {
  return n < 10;
});

console.log(nMenor10);


const comentarios = [
    {comentario :"bla bla bla", exibe : true},
    {comentario :"Evento é uma merda", exibe : false},
    {comentario :"ótimo evento!", exibe : true}

];

const comentariosoK = comentarios.filter((C) => {
    return C.exibe == true;
});

console.log(comentariosoK);

