// Boolean
const usuarioLogado = true;
const contaPaga = false;

// Truthy ou Falsy

// 0 => false
// 1 => true

console.log(`0 == false: ${0 == false}`);
console.log(`"" == false: ${"" == false}`);
console.log(`1 == true: ${1 == true}`);

// null => vazio ou nada

let minhaVar;
let varNull = null;

console.log(`minhaVar: ${minhaVar}`);
console.log(`varNull: ${varNull}`);

// undefined => indefinido

let numero = 3;
let texto = "Alura";

console.log(`typeof numero: ${typeof numero}`);
console.log(`typeof texto: ${typeof texto}`);

console.log(`typeof minhaVar: ${typeof minhaVar}`);
console.log(`typeof varNull: ${typeof varNull}`); // null é um objeto, mas é um bug do JS.