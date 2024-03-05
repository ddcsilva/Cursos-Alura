// let é uma palavra chave do JavaScript que declara uma variável
// if é uma palavra chave do JavaScript que declara uma estrutura condicional. Se a condição for verdadeira, o código dentro do bloco será executado
// else é uma palavra chave do JavaScript que declara uma estrutura condicional. Se a condição do if for falsa, o código dentro do bloco else será executado
// == é um operador de comparação que verifica se os valores à esquerda e à direita são iguais
// != é um operador de comparação que verifica se os valores à esquerda e à direita são diferentes
// > é um operador de comparação que verifica se o valor à esquerda é maior que o valor à direita
// < é um operador de comparação que verifica se o valor à esquerda é menor que o valor à direita
// ++ é um operador de incremento que adiciona 1 ao valor da variável
// alert() é uma função que exibe uma mensagem na tela do usuário
// prompt() é uma função que exibe uma mensagem na tela do usuário e coleta a resposta do usuário
// console.log() é uma função que exibe uma mensagem no console do navegador

alert('Bem-vindo ao jogo de adivinhação!');
let numeroSecreto = 5;
console.log('Número Secreto: ', numeroSecreto);
let chute;
let tentativas = 1;

// Enquanto o chute for diferente do número secreto, solicita um novo chute ao usuário
while (chute != numeroSecreto) {
    chute = prompt('Digite um número entre 0 e 10:');

    // Se o chute for igual ao número secreto, exibe uma mensagem de parabéns, senão, exibe uma mensagem informando se o número secreto é maior ou menor que o chute
    if (numeroSecreto == chute) {
        alert(`Parabéns, você acertou! O número secreto é ${numeroSecreto}! Você acertou em ${tentativas} tentativas.`);
    } else {
        if (chute > numeroSecreto) {
            alert(`O número secreto é maior que ${chute}`);
        } else {
            alert(`O número secreto é menor que ${chute}`);
        }

        tentativas++;
    }
}