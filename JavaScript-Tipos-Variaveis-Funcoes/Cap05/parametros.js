// Parâmetros de Função

function soma(numero1, numero2) {
    return numero1 + numero2;
}

console.log(soma(2, 2));
console.log(soma(245, 20));
console.log(soma(-500, 60));

// Parâmetros x Argumentos
// Parâmetros são variáveis que existem apenas dentro da função
// Argumentos são os valores passados para a função

function nomeIdade(nome, idade) {
    return `Meu nome é ${nome} e minha idade é ${idade}`;
}

console.log(nomeIdade("Danilo", 33));

function multiplica(numero1 = 1, numero2 = 1) {
    return numero1 * numero2;
}

console.log(multiplica(soma(4, 5), soma(3, 3)));