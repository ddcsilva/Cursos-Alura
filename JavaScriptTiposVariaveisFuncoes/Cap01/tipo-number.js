// Tipo Number
const meuNumero = 3;

const primeiroNumero = 1;
const segundoNumero = 2;

console.log(`Primeiro número: ${primeiroNumero} | Segundo número: ${segundoNumero}`);
console.log('--------------------------------------');

const operacaoSoma = primeiroNumero + segundoNumero;
console.log(`Operação de soma: ${operacaoSoma}`);

const operacaoSubtracao = primeiroNumero - segundoNumero;
console.log(`Operação de subtração: ${operacaoSubtracao}`);

const operacaoMultiplicacao = primeiroNumero * segundoNumero;
console.log(`Operação de multiplicação: ${operacaoMultiplicacao}`);

const operacaoDivisao = primeiroNumero / segundoNumero;
console.log(`Operação de divisão: ${operacaoDivisao}`);

console.log('--------------------------------------');

// Ponto flutuante

const numeroPontoFlutuante = 3.3;
const pontoFlutuanteSemZero = .5; // No JavaScript, o ponto flutuante pode ser representado sem o zero antes do ponto, porém não é recomendado.

const novaOperacao = primeiroNumero / numeroPontoFlutuante;
console.log(`Nova operação com ponto flutuante: ${novaOperacao}`);

console.log('--------------------------------------');

// NaN -> Not a Number (Não é um número)

const alura = "Alura";
console.log(`Tipo da variável alura: ${typeof alura}`);
console.log(`Tipo da variável primeiroNumero: ${typeof primeiroNumero}`);
console.log(`Operaçao de multiplicação entre alura e primeiroNumero: ${alura * primeiroNumero}`);