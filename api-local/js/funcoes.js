
const UrlViaCep = "https://viacep.com.br/ws"
function cadastrar(e) {
    e.preventDefault();
    alert("cadastrar...");

}
async function buscarEndereco(Cep) {
    //complemento do Endereço  da api
    const resource = `/${Cep}/json/`

    console.log(UrlViaCep + resource);
    try {
        const promise = await fetch(UrlViaCep + resource)
        //transforma o json retornando em um objeto ou array
        const endereco = await promise.json();
        console.log(endereco);

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
