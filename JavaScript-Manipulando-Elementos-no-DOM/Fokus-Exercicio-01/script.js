const html = document.querySelector('html');
const temporizador = document.querySelector('#timer');
const imagemContexto = document.querySelector('.app__image');
const fraseContexto = document.querySelector('.app__title');

const botaoIniciarEPausar = document.querySelector('.app__card-primary-button');
const botaoFoco = document.querySelector('.app__card-button--foco');
const botaoDescansoCurto = document.querySelector('.app__card-button--curto');
const botaoDescansoLongo = document.querySelector('.app__card-button--longo');

const duracaoFoco = 1500;
const duracaDescansoCurto = 300;
const duracaoDescansoLongo = 900;