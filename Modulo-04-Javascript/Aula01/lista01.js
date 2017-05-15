//Exercicio 01
function daisyGame(numero){
return numero % 2 !== 'Love me' : 'Love me not'
}

console.log(daisyGame(1));
console.log(daisyGame(4));

//Exercicio 02
function maiorTexto(textos){
  var maiorTamanho = textos.length > 0 ? textos[0] : "";
  for(let i = 0; i < textos.length; i++) {
    if (textos[i].length) > maiorTamanho.length) {
      maiorTamanho = textos[i];
    }
  }
  return maiorTamanho;
}

maiorTexto(['a', 'bb', 'ccc', 'dddd'])

//Exercicio 03
imprime(){

}

//Exercicio 4

function adicionar(numero1){
  return function(numero2){
    return numero1 + numero2;
  }
}

console.log(adicionar(3)(4));
console.log(adicionar(5642)(8749));

//Exercicio 5

function fibonacci(n){
  if (n === 1) || (n === 2){
    return 1;
  }
  return fibonacci(n - 1) + fibonacci(n - 2);
}

function fiboSum(n){

}

console.log(fibonacci(3))


//Exercício 06

function queroCafe(mascada, precos){
  let dentroDoOrcamento = [];
  precos.foreach(p => {
    if(p <= mascada){
      dentroDoOrcamento.push(p);
    }
  });
  return dentroDoOrcamento.sort((a, b) => a - b).join(', ')
}

queroCafe(3.14, [ 5.16, 2.12, 1.15, 3.11, 17.5 ]);
