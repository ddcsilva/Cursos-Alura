// let é uma palavra chave do JavaScript que declara uma variável
// if é uma palavra chave do JavaScript que declara uma estrutura condicional
// == é um operador de comparação que verifica se os valores à esquerda e à direita são iguais
// alert() é uma função que exibe uma mensagem na tela do usuário
// prompt() é uma função que exibe uma mensagem na tela do usuário e coleta a resposta do usuário
// console.log() é uma função que exibe uma mensagem no console do navegador

alert('Boas vindas ao jogo do número secreto!');
let numeroSecreto = 5;
let chute = prompt('Escolha um número entre 1 e 10:');

if (numeroSecreto == chute) {
    console.log('Isso ai! Você descobriu o número secreto (5)!');
}