// Null e Undefined

let input = null;

if (input === null) {
    console.log('não há informação');
} else {
    console.log(input);
}

input = null; // Nulo intencionalmente
let input2;

console.log(input); // null
console.log(input2); // undefined

// O que é undefined?
// É o valor atribuído a uma variável que foi declarada, mas não inicializada.

// O que é null?
// É o valor atribuído a uma variável que foi declarada e inicializada com o valor null.

console.log(null == undefined); // true
console.log(null === undefined); // false