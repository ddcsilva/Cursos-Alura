// Tipo String
const texto1 = "Olá, mundo!"; // Aspas duplas são mais utilizadas
console.log(`texto1: ${texto1}`);

const texto2 = 'Olá, mundo!'; // Aspas simples também são utilizadas
console.log(`texto2: ${texto2}`);

const senha = "senhaSuperSegura456!"; // A string pode conter números e caracteres especiais
console.log(`senha: ${senha}`);

const stringDeNumeros = "34567"; // Não é um número, é uma string
console.log(`stringDeNumeros: ${stringDeNumeros}`);

const citacao = 'O Leo disse "Oi!"'; // Aspas duplas dentro de aspas simples
console.log(`citacao: ${citacao}`);

// Concatenação (+)
const frase = "Meu nome é ";
const meuNome = "Danilo";
console.log(frase + meuNome);

// Template String ou Template Literal (crase)
const templateString = `Meu nome é ${meuNome}`;
console.log(`templateString: ${templateString}`);

console.log('--------------------------------------');

// Tipo String: Caracteres especiais

const cifrao = '\u0024';
console.log(`cifrao: ${cifrao}`);

const aMaiusculo = '\u0041';
console.log(`aMaiusculo: ${aMaiusculo}`);

const tique = '\u2705';
console.log(`tique: ${tique}`);

const hiragana = '\u3042';
console.log(`hiragana: ${hiragana}`);