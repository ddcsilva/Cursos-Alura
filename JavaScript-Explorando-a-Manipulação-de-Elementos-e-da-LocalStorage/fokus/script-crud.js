const botaoAdicionarTarefa = document.querySelector('.app__button--add-task');
const caixaDeTexto = document.querySelector('.app__form-textarea');
const formularioAdicionarTarefa = document.querySelector('.app__form-add-task');

const tarefas = [];

botaoAdicionarTarefa.addEventListener('click', function () {
    formularioAdicionarTarefa.classList.toggle('hidden');
});

formularioAdicionarTarefa.addEventListener('submit', function (evento) {
    evento.preventDefault();

    const tarefa = {
        descricao: caixaDeTexto.value,
    }

    tarefas.push(tarefa);
    localStorage.setItem('tarefas', JSON.stringify(tarefas));
});