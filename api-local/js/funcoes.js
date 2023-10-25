
const UrlViaCep = "https://viacep.com.br/ws";
const UrlCepProfessor ="http://172.16.35.155:3000/myceps";

function cadastrar(e) {
    e.preventDefault();
   
    const Nome= document.getElementById('nome').value;
    const Email= document.getElementById('email').value;
    const Cep= float.parse(document.getElementById('Cep').value);
    const Endereco= document.getElementById('Endereco').value;
    const Numero= document.getElementById('numero').value;
    const Cidade= document.getElementById('Cidade').value;
    const Estado= document.getElementById('Cep').value;
}
//fazer a validaçao (dica - crie uma função que retorna um bool)

function validaForm() {
    if (Nome == undefined  
    || email == undefined || cep < 8 
    || Endereco == undefined || Numero < 3 
    || Cidade == undefined  ||Estado == undefined ) {
        
        alert('Preencha o formúlario')
        return;false
    }

    return true;
    
}


function escolheCep() {
    switch (key) {
        case value:
            
            break;
    
        default:
            break;
    }
}

async function buscarEndereco(Cep) {
    //complemento do Endereço  da api

    const resource = `/${Cep}/json/`

    console.log(UrlCepProfessor + resource);
    try {

        // const promise = await fetch(UrlViaCep + resource)
        const promise = await fetch(`${UrlCepProfessor}/${Cep}`)

        //transforma o json retornando em um objeto ou array
        const endereco = await promise.json();
        console.log(endereco);
        return;
        

        document.getElementById("not-found").innerText = "";

        //prencheer formulario
        //objeto que está sendo passado no método prencheer campos.
        preencherCampos({
            logradouro: endereco.logradouro,
            localidade: endereco.localidade,
            uf: endereco.uf
        })

    }
    catch (error) {

        console.log(error);

        document.getElementById("not-found").innerText = "cep inválido";
    }

    function preencherCampos(dadosEndereco) {
        document.getElementById("Endereco").value = endereco.logradouro;
        document.getElementById("Cidade").value = endereco.localidade;
        document.getElementById("Estado").value = endereco.uf;
    }
}
