// document é um objeto que representa a página web
// querySelector é um método que retorna o primeiro elemento que combina com o seletor especificado
// innerHTML é uma propriedade que define ou retorna o conteúdo HTML de um elemento
// function é uma palavra-chave que define uma função.

let numeroSecreto = gerarNumeroAleatorio();

exibirTextoNaTela('h1', 'Jogo do Número Secreto');
exibirTextoNaTela('p', 'Escolha um número entre 1 e 10');

function exibirTextoNaTela(tag, texto) {
    let campo = document.querySelector(tag);
    campo.innerHTML = texto;
}

function verificarChute() {
    let chute = document.querySelector('input').value;
    console.log(chute == numeroSecreto);
}

function gerarNumeroAleatorio() {
    return parseInt(Math.random() * 10 + 1);
}