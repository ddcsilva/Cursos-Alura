// Variável var (Escopo Global)
console.log('Usando var');
var altura = 5;
var comprimento = 7;

area = altura * comprimento;
console.log(`A área é do quadrado é de ${area}m²`);

var area;

console.log('------------------------------------');

// Variável let (Escopo Local)
console.log('Usando let');
let forma = 'retângulo';
let altura2 = 5;
let comprimento2 = 7;
let area2;

if (forma === 'retângulo') {
    area2 = altura2 * comprimento2;
} else {
    area2 = (altura2 * comprimento2) / 2;
}

console.log(`A área é do quadrado é de ${area2}m²`);

console.log('------------------------------------');

// Variável const (Constante)
console.log('Usando const');

const forma3 = 'triângulo';
const altura3 = 5;
const comprimento3 = 7;
let area3;

if (forma3 === 'quadrado') {
    area3 = altura3 * comprimento3;
} else {
    area3 = (altura3 * comprimento3) / 2;
}

console.log(`A área é do triângulo é de ${area3}m²`);