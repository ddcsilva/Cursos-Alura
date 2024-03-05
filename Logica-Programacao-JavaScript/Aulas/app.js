// let é uma palavra chave do JavaScript que declara uma variável
// if é uma palavra chave do JavaScript que declara uma estrutura condicional. Se a condição for verdadeira, o código dentro do bloco será executado
// else é uma palavra chave do JavaScript que declara uma estrutura condicional. Se a condição do if for falsa, o código dentro do bloco else será executado
// == é um operador de comparação que verifica se os valores à esquerda e à direita são iguais
// != é um operador de comparação que verifica se os valores à esquerda e à direita são diferentes
// > é um operador de comparação que verifica se o valor à esquerda é maior que o valor à direita
// < é um operador de comparação que verifica se o valor à esquerda é menor que o valor à direita
// ++ é um operador de incremento que adiciona 1 ao valor da variável
// -- é um operador de decremento que subtrai 1 do valor da variável
// += é um operador de atribuição que adiciona o valor à direita ao valor da variável e atribui o resultado à variável
// -= é um operador de atribuição que subtrai o valor à direita do valor da variável e atribui o resultado à variável
// *= é um operador de atribuição que multiplica o valor da variável pelo valor à direita e atribui o resultado à variável
// /= é um operador de atribuição que divide o valor da variável pelo valor à direita e atribui o resultado à variável
// % é um operador de módulo que retorna o resto da divisão do valor da variável pelo valor à direita
// || é um operador lógico que retorna verdadeiro se uma das condições for verdadeira
// && é um operador lógico que retorna verdadeiro se ambas as condições forem verdadeiras
// ! é um operador lógico que inverte o valor da condição
// ? : é um operador ternário que retorna o valor à esquerda se a condição for verdadeira e o valor à direita se a condição for falsa
// break é uma palavra chave do JavaScript que encerra a execução de um laço de repetição
// alert() é uma função que exibe uma mensagem na tela do usuário
// prompt() é uma função que exibe uma mensagem na tela do usuário e coleta a resposta do usuário
// console.log() é uma função que exibe uma mensagem no console do navegador
// Math.random() é uma função que retorna um número aleatório entre 0 e 1
// parseInt() é uma função que converte uma string em um número inteiro

alert('Bem-vindo ao jogo de adivinhação!');
let numeroMaximo = 5000;
let numeroSecreto = parseInt(Math.random() * numeroMaximo + 1);
console.log('Número Secreto: ', numeroSecreto);
let chute;
let tentativas = 1;

// Enquanto o chute for diferente do número secreto, solicita um novo chute ao usuário
while (chute != numeroSecreto) {
    chute = prompt('Digite um número entre 1 e ' + numeroMaximo + ':');

    // Se o chute for igual ao número secreto, exibe uma mensagem de parabéns, senão, exibe uma mensagem informando se o número secreto é maior ou menor que o chute
    if (numeroSecreto == chute) {
        break;
    } else {
        if (chute > numeroSecreto) {
            alert(`O número secreto é menor que ${chute}`);
        } else {
            alert(`O número secreto é maior que ${chute}`);
        }

        tentativas++;
    }
}

let palavraTentativa = tentativas > 1 ? 'tentativas' : 'tentativa';

alert(`Parabéns! Você acertou o número secreto ${numeroSecreto} em ${tentativas} ${palavraTentativa}.`);