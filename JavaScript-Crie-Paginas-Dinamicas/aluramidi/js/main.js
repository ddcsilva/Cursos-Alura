// Função para tocar o som correspondente ao seletor de áudio fornecido
function tocarSom(seletorAudio) {
    const elemento = document.querySelector(seletorAudio);

    if (!elemento) {
        console.warn(`Elemento com seletor ${seletorAudio} não encontrado.`);
        return;
    }

    if (elemento.localName === 'audio') {
        elemento.currentTime = 0;
        elemento.play();
    } else {
        console.warn(`Elemento com seletor ${seletorAudio} não é um áudio.`);
    }
}

// Seleciona todas as teclas
const listaDeTeclas = document.querySelectorAll('.tecla');

// Itera sobre cada tecla e adiciona os eventos necessários
listaDeTeclas.forEach((tecla) => {
    const instrumento = tecla.classList[1];
    const idAudio = `#som_${instrumento}`;

    // Evento de clique para tocar o som
    tecla.addEventListener('click', () => {
        tocarSom(idAudio);
    });

    // Evento de pressionar a tecla Enter ou Espaço para adicionar classe 'ativa'
    tecla.addEventListener('keydown', (evento) => {
        if (evento.code === 'Enter' || evento.code === 'Space') {
            tecla.classList.add('ativa');
        }
    });

    // Evento de soltar a tecla Enter ou Espaço para remover a classe 'ativa'
    tecla.addEventListener('keyup', (evento) => {
        if (evento.code === 'Enter' || evento.code === 'Space') {
            tecla.classList.remove('ativa');
        }
    });
});