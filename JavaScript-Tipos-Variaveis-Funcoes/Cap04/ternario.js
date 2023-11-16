const idadeMinima = 18;
const idadeCliente = 16;

// Utilizando if/else
if (idadeCliente >= idadeMinima) {
    console.log('Cerveja');
} else {
    console.log('Suco');
}

// Utilizando operador ternário
// condição ? true : false
console.log(idadeCliente >= idadeMinima ? 'Cerveja' : 'Suco');