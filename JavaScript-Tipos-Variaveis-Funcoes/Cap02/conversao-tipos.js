// Tipos de Dados Booleanos

console.log("Conversão Implícita");

// Conversão Implícita
const numero = 456;
const numeroString = "456";

// Compara o valor, não o tipo.
console.log(`numero == numeroString: ${numero == numeroString}`); // true
// Compara o valor e o tipo.
console.log(`numero === numeroString: ${numero === numeroString}`); // false

// Conversão Explícita

console.log("\nConversão Explícita");

console.log(`numero + numeroString: ${numero + numeroString}`); // 456456
console.log(`numero + Number(numeroString): ${numero + Number(numeroString)}`); // 912