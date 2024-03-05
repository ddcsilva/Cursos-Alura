// let é uma palavra chave do JavaScript que declara uma variável
// if é uma palavra chave do JavaScript que declara uma estrutura condicional. Se a condição for verdadeira, o código dentro do bloco será executado
// else é uma palavra chave do JavaScript que declara uma estrutura condicional. Se a condição do if for falsa, o código dentro do bloco else será executado
// == é um operador de comparação que verifica se os valores à esquerda e à direita são iguais
// alert() é uma função que exibe uma mensagem na tela do usuário
// prompt() é uma função que exibe uma mensagem na tela do usuário e coleta a resposta do usuário
// console.log() é uma função que exibe uma mensagem no console do navegador

alert('Bem-vindo ao jogo de adivinhação!');
let numeroSecreto = 5;
console.log('Número Secreto: ', numeroSecreto);
let chute = prompt('Digite um número entre 0 e 10:');

if (numeroSecreto == chute) {
    alert(`Parabéns, você acertou! O número secreto é ${numeroSecreto}!`);
} else {
    alert('Que pena, você errou! O número secreto é 5!');
}