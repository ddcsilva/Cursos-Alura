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