// main.js => Por convenção, o arquivo principal de um projeto é chamado de main.js

// querySelector() => Retorna o primeiro elemento que corresponde a um grupo de seletores CSS.

function tocarSomTeclaPom() {
    // play() => Inicia ou retoma a reprodução do áudio ou vídeo.
    document.querySelector('#som_tecla_pom').play();
}

// É possível atribuir uma função a um evento de um elemento HTML através do atributo onclick.
// A diferença entre tocarSomTeclaPom e tocarSomTeclaPom() é que a primeira é uma referência à função, enquanto a segunda é a chamada da função.
document.querySelector('.tecla_pom').onclick = tocarSomTeclaPom;
