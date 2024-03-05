function calcularIMC(altura, peso) {
    return peso / (altura * altura);
}

console.log(calcularIMC(1.75, 70)); // 22.86

function calcularFatorial(numero) {
    let resultado = 1;

    for (let i = 1; i <= numero; i++) {
        resultado *= i;
    }

    return resultado;
}

console.log(calcularFatorial(5)); // 120

// Dolar: 4,80
function converterRealParaDolar(valor) {
    return valor / 4.80;
}

console.log(converterRealParaDolar(100)); // 20.83

function mostrarAreaEPerimetroRetangulo(altura, largura) {
    const area = altura * largura;
    const perimetro = 2 * (altura + largura);

    return `Área: ${area}, Perímetro: ${perimetro}`;
}

console.log(mostrarAreaEPerimetroRetangulo(5, 10)); // Área: 50, Perímetro: 30

function calcularTabuada(numero) {
    let resultado = '';

    for (let i = 1; i <= 10; i++) {
        resultado += `${numero} x ${i} = ${numero * i}\n`;
    }

    return resultado;
}

console.log(calcularTabuada(5));