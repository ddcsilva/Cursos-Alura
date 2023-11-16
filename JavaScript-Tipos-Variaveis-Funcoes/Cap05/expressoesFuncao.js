function minhaFuncao(param) {
    // bloco de código
}

minhaFuncao("param");

// Expressões de Função
const soma = function (num1, num2) { return num1 + num2 };
console.log(soma(1, 1));

// Qual a diferença?
console.log(apresentar());
function apresentar() {
    return "Olá";
}
// A diferença é que a função declarada "sobe" para o topo do código, então a chamada da função pode ser feita antes da declaração da mesma.