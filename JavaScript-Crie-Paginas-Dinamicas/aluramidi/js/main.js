// Por convenção, o arquivo principal de um projeto é chamado de main.js

// querySelector() => Retorna o primeiro elemento que corresponde a um grupo de seletores CSS.
// querySelectorAll() => Retorna todos os elementos que correspondem a um grupo de seletores CSS em um objeto NodeList.
// play() => Inicia ou retoma a reprodução do áudio ou vídeo.
// const => Declara uma constante local ou global somente de leitura. Isso não significa que o valor é imutável, apenas que a variável constante não pode ser alterada ou reatribuída.

// É possível atribuir uma função a um evento de um elemento HTML através do atributo onclick.
// A diferença entre tocarSomTeclaPom e tocarSomTeclaPom() é que a primeira é uma referência à função, enquanto a segunda é a chamada da função.

function tocarSomTeclaPom() {
    document.querySelector('#som_tecla_pom').play();
}

document.querySelector('.tecla_pom').onclick = tocarSomTeclaPom;

const listaDeTeclas = document.querySelectorAll('.tecla');