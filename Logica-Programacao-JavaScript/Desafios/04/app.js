console.log('Boas vindas!');

let nome = 'Danilo';
console.log(`Olá, ${nome}!`);
alert(`Olá, ${nome}!`);

let linguagemProgramacao = prompt('Qual a linguagem de programação que você mais gosta?');
console.log(`A linguagem de programação que você mais gosta é ${linguagemProgramacao}.`);

let valor1 = 10;
let valor2 = 20;
let resultado = valor1 + valor2;
console.log(`A soma de ${valor1} e ${valor2} é igual a ${resultado}.`);

valor1 = 5;
valor2 = 2;
resultado = valor1 - valor2;
console.log(`A diferença entre ${valor1} e ${valor2} é igual a ${resultado}.`);

let idade = prompt('Qual a sua idade?');
if (idade >= 18) {
    alert('Você é maior de idade.');
} else {
    alert('Você é menor de idade.');
}

let numero = prompt('Digite um número:');
if (numero == 0) {
    alert('O número é igual a zero.');
} else if (numero > 0) {
    alert('O número é positivo.');
} else {
    alert('O número é negativo.');
}

let contador = 1;
while (contador <= 10) {
    console.log(contador);
    contador++;
}

let nota = 6;
if (nota >= 6) {
    console.log('Aprovado');
} else {
    console.log('Reprovado');
}

let numeroAleatorio = Math.random();
console.log(numeroAleatorio);

let numeroAleatorioEntre1e10 = Math.floor(Math.random() * 10) + 1;
console.log(numeroAleatorioEntre1e10);

let numeroAleatorioEntre1e1000 = Math.floor(Math.random() * 1000) + 1;
console.log(numeroAleatorioEntre1e1000); 