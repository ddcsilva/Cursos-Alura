// Por convenção, o arquivo principal de um projeto é chamado de main.js

// querySelector() => Retorna o primeiro elemento que corresponde a um grupo de seletores CSS.
// querySelectorAll() => Retorna todos os elementos que correspondem a um grupo de seletores CSS em um objeto NodeList.
// play() => Inicia ou retoma a reprodução do áudio ou vídeo.
// const => Declara uma constante local ou global somente de leitura. Isso não significa que o valor é imutável, apenas que a variável constante não pode ser alterada ou reatribuída.
// while => Cria um laço que executa uma rotina especifica enquanto a condição de teste for verdadeira. A condição é avaliada antes da execução da rotina.
// for => Cria um laço que consiste em três expressões opcionais, dentro de parênteses e separadas por ponto e vírgula, seguidas por uma declaração ou uma sequência de declarações executadas em sequência.

// É possível atribuir uma função a um evento de um elemento HTML através do atributo onclick.
// A diferença entre tocarSomTeclaPom e tocarSomTeclaPom() é que a primeira é uma referência à função, enquanto a segunda é a chamada da função.
// Uma função anônima é uma função sem nome. Ela é definida usando uma expressão de função ou uma expressão de função arrow.

// Template Strings são strings que permitem expressões embutidas. Você pode utilizar string multi-linhas e interpolação de string com elas.

function tocarSom(idElemento) {
    document.querySelector(idElemento).play();
}

const listaDeTeclas = document.querySelectorAll('.tecla');
let contador = 0;

for (let contador = 0; contador < listaDeTeclas.length; contador++) {
    const tecla = listaDeTeclas[contador];
    const instrumento = tecla.classList[1];
    const idAudio = `#som_${instrumento}`;

    tecla.onclick = () => {
        tocarSom(idAudio);
    }
}