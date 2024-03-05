let contador = 1;

while (contador <= 10) {
    console.log(contador);
    contador++;
}

contador = 10;

while (contador >= 0) {
    console.log(contador);
    contador--;
}

contador = prompt('Digite um número');

while (contador >= 0) {
    console.log('Contagem regressiva: ' + contador);
    contador--;
}

contador = prompt('Digite um número');

while (contador <= 10) {
    console.log('Contagem progressiva: ' + contador);
    contador++;
}