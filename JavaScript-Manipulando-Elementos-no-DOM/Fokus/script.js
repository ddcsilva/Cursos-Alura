const html = document.querySelector('html');
const botaoFoco = document.querySelector('.app__card-button--foco');
const botaoDescansoCurto = document.querySelector('.app__card-button--curto');
const botaoDescansoLongo = document.querySelector('.app__card-button--longo');
const imagem = document.querySelector('.app__image');
const titulo = document.querySelector('.app__title');
const botoes = document.querySelectorAll('.app__card-button');
const inputMusica = document.querySelector('#alternar-musica');
const botaoIniciarOuPausar = document.querySelector('#start-pause');
const spanBotaoIniciarOuPausar = document.querySelector('#start-pause span');
const iconeBotaoIniciarOuPausar = document.querySelector('.app__card-primary-butto-icon');
const tempoNaTela = document.querySelector('#timer');

const musica = new Audio('sons/luna-rise-part-one.mp3').loop = true;
const somIniciar = new Audio('sons/play.wav');
const somPausar = new Audio('sons/pause.mp3');
const somTerminar = new Audio('sons/beep.mp3');

let tempoDecorridoEmSegundos = 1500;
let temporizadorIntervalo = null;

botaoFoco.addEventListener('click', () => {
    tempoDecorridoEmSegundos = 1500;
    alterarContexto('foco');
    botaoFoco.classList.add('active');
});

botaoDescansoCurto.addEventListener('click', () => {
    tempoDecorridoEmSegundos = 300;
    alterarContexto('descanso-curto');
    botaoDescansoCurto.classList.add('active');
});

botaoDescansoLongo.addEventListener('click', () => {
    tempoDecorridoEmSegundos = 900;
    alterarContexto('descanso-longo');
    botaoDescansoLongo.classList.add('active');
});

inputMusica.addEventListener('change', () => {
    if (musica.paused) {
        musica.play();
    } else {
        musica.pause();
    }
});

function alterarContexto(contexto) {
    mostrarTempo();
    botoes.forEach(botao => botao.classList.remove('active'));
    html.setAttribute('data-contexto', contexto);
    imagem.setAttribute('src', `imagens/${contexto}.png`);

    switch (contexto) {
        case 'foco':
            titulo.innerHTML = `
                Otimizar a produtividade, <strong class="app__title-strong">mergulhe no que importa.</strong>
            `;
            break;
        case 'descanso-curto':
            titulo.innerHTML = `
                Que tal dar uma respirada? <strong class="app__title-strong">Faça uma pausa curta!</strong>
            `;
            break;
        case 'descanso-longo':
            titulo.innerHTML = `
                Hora de voltar à superfície. <strong class="app__title-strong">Faça uma pausa longa.</strong>
            `;
            break;
        default:
            break;
    }
}

const contagemRegressiva = () => {
    if (tempoDecorridoEmSegundos <= 0) {
        somTerminar.play();
        alert('Tempo esgotado!');
        zerarTempo();
        return;
    }
    tempoDecorridoEmSegundos -= 1;
    mostrarTempo();
}

botaoIniciarOuPausar.addEventListener('click', iniciarOuPausar);

function iniciarOuPausar() {
    if (temporizadorIntervalo) {
        somPausar.play();
        zerarTempo();
        return;
    }
    somIniciar.play();
    temporizadorIntervalo = setInterval(contagemRegressiva, 1000);
    spanBotaoIniciarOuPausar.textContent = 'Pausar';
    iconeBotaoIniciarOuPausar.setAttribute('src', 'imagens/pause.png');
}

function zerarTempo() {
    clearInterval(temporizadorIntervalo);
    spanBotaoIniciarOuPausar.textContent = 'Começar';
    iconeBotaoIniciarOuPausar.setAttribute('src', 'imagens/play_arrow.png');
    temporizadorIntervalo = null;
}

function mostrarTempo() {
    const tempo = new Date(tempoDecorridoEmSegundos * 1000);
    const tempoFormatado = tempo.toLocaleTimeString('pt-BR', {
        minute: '2-digit',
        second: '2-digit'
    });
    tempoNaTela.innerHTML = `${tempoFormatado}`
}

mostrarTempo();