const botaoAdicionarTarefa = document.querySelector('.app__button--add-task');
const formularioAdicionarTarefa = document.querySelector('.app__form-add-task');

botaoAdicionarTarefa.addEventListener('click', function () {
    formularioAdicionarTarefa.classList.toggle('hidden');
});