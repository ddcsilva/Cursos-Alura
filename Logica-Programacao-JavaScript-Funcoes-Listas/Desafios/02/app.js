function exibeMensagem() {
    console.log("Olá, mundo!");
}

function exibeMensagemComNome(nome) {
    console.log("Olá, " + nome + "!");
}

function calculaDobro(numero) {
    return numero * 2;
}

function calculaMedia(nota1, nota2, nota3) {
    return (nota1 + nota2 + nota3) / 3;
}

function verificaNumeroMaior(numero1, numero2) {
    if (numero1 > numero2) {
        return numero1;
    } else {
        return numero2;
    }
}

function numeroMultiplicadoPorEleMesmo(numero) {
    return numero * numero;
}