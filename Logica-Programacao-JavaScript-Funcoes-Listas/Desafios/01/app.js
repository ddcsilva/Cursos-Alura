cabecalho = document.querySelector('h1');
cabecalho.innerHTML = 'Hora do Desafio!';

function cliqueConsole() {
    console.log('O botão foi clicado!');
}

function cliqueAlert() {
    alert('Eu amo JavaScript!');
}

function cliquePrompt() {
    var cidade = prompt('Digite o nome de uma cidade do Brasil:');
    alert(`Estive em ${cidade} e lembrei de você!`);
}

function cliqueSoma() {
    var numero1 = parseInt(prompt('Digite um número:'));
    var numero2 = parseInt(prompt('Digite outro número:'));
    alert(`A soma dos números é ${numero1 + numero2}`);
}