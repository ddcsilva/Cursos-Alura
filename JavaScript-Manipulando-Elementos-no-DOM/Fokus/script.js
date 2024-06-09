const html = document.querySelector('html');
const botaoFoco = document.querySelector('.app__card-button--foco');
const botaoDescansoCurto = document.querySelector('.app__card-button--curto');
const botaoDescansoLongo = document.querySelector('.app__card-button--longo');
const imagem = document.querySelector('.app__image');
const titulo = document.querySelector('.app__title');
const botoes = document.querySelectorAll('.app__card-button');

botaoFoco.addEventListener('click', () => {
    alterarContexto('foco');
    botaoFoco.classList.add('active');
});

botaoDescansoCurto.addEventListener('click', () => {
    alterarContexto('descanso-curto');
    botaoDescansoCurto.classList.add('active');
});

botaoDescansoLongo.addEventListener('click', () => {
    alterarContexto('descanso-longo');
    botaoDescansoLongo.classList.add('active');
});

function alterarContexto(contexto) {
    botoes.forEach(botao => botao.classList.remove('active'));
    html.setAttribute('data-contexto', contexto);
    imagem.setAttribute('src', `imagens/${contexto}.png`);

    switch (contexto) {
        case 'foco':
            titulo.innerHTML = `Otimizar a produtividade, <strong class="app__title-strong">mergulhe no que importa.</strong>`;
            break;
        case 'descanso-curto':
            titulo.innerHTML = `Que tal dar uma respirada? <strong class="app__title-strong">Faça uma pausa curta!</strong>`;
            break;
        case 'descanso-longo':
            titulo.innerHTML = `Hora de voltar à superfície. <strong class="app__title-strong">Faça uma pausa longa.</strong>`;
            break;
        default:
            break;
    }
}