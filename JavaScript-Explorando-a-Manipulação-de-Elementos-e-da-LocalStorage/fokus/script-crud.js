const botaoAdicionarTarefa = document.querySelector('.app__button--add-task');
const caixaDeTexto = document.querySelector('.app__form-textarea');
const formularioAdicionarTarefa = document.querySelector('.app__form-add-task');
const ulTarefas = document.querySelector('.app__section-task-list')

const tarefas = JSON.parse(localStorage.getItem('tarefas')) || [];

function criarElementoTarefa(tarefa) {
    const li = document.createElement('li');
    li.classList.add('app__section-task-list-item');

    const svg = document.createElement('svg');
    svg.innerHTML = `
        <svg>
            <svg class="app__section-task-icon-status" width="24" height="24" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
                <circle cx="12" cy="12" r="12" fill="#FFF"></circle>
                <path d="M9 16.1719L19.5938 5.57812L21 6.98438L9 18.9844L3.42188 13.4062L4.82812 12L9 16.1719Z" fill="#01080E"></path>
            </svg>
        </svg>
    `;

    const p = document.createElement('p');
    p.textContent = tarefa.descricao;

    const button = document.createElement('button');
    const img = document.createElement('img');
    img.setAttribute('src', './imagens/edit.png');
    button.append(img);

    li.append(svg);
    li.append(p);
    li.append(button);

    return li;
};

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

tarefas.forEach(tarefa => {
    const elementoTarefa = criarElementoTarefa(tarefa);
    ulTarefas.append(elementoTarefa);
});