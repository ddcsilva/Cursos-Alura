let diaDaSemana = prompt('Qual o dia da semana?');

if (diaDaSemana == 'Sábado' || diaDaSemana == 'Domingo') {
    alert('Bom fim de semana!');
} else {
    alert('Boa semana!');
}

let numero = prompt('Digite um número');

if (numero < 0) {
    alert('Você digitou um número negativo');
} else {
    alert('Você digitou um número positivo');
}

let pontuacao = prompt('Digite a pontuação');

if (pontuacao >= 100) {
    alert('Parabéns, você venceu!');
} else {
    alert('Tente novamente para ganhar');
}

let nome = prompt('Digite seu nome');

alert(`Bem-vindo, ${nome}!`);