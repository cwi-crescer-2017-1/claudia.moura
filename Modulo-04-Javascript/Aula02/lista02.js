
//Exercicio01

function seriesInvalidas(series) {
    let seriesInvalidas = '';
    for (let i = 0; i < series.length; i++){
		if (series[i].anoEstreia > 2017){
		  seriesInvalidas += series[i].titulo + ', ';
		  		} else {
		    for (let campo in series[i]){
		        if ((series[i][campo] === null || typeof series[i][campo] === "undefined") && series[i].anoEstreia <= 2017){
		          seriesInvalidas += series[i].titulo + ', '
				}
			}	
		}
    }
  return seriesInvalidas.substr(0, (seriesInvalidas.length - 2));
}

console.log(seriesInvalidas(series)) //retorna Mr Robot, Band of Brothers, Narcos


//Exercicio02

function filtrarSeriesPorAno(series, ano){
	let seriesPorAno = '';
	for (let i = 0; i < series.length; i++){
		if (series[i].anoEstreia === ano){
			seriesPorAno += series[i].titulo + ", "
		}
	}
	return seriesPorAno.substr(0, (seriesPorAno.length - 2));
}

console.log(filtrarSeriesPorAno(series, 2012)) //retorna array vazio
console.log(filtrarSeriesPorAno(series, 2010)) // retorna Walking Dead, 10 Days Why


//Exercicio03

function mediaDeEpisodios(series) {
	let contador = 0;
	for (var i = 0; i < series.length; i++){
		contador += series[i].numeroEpisodios;
	}
	return contador / series.length
}

console.log(mediaDeEpisodios(series)) //deve retornar 34.1

//Exercicio04

function procurarPorNome(series, nome){
for (let i = 0; i < series.length; i++){
	for (let j = 0; j < series[i].elenco.length; j++){
		if (series[i].elenco[j].includes(nome)) {
			return true
		}
 	}
  }
  return false;
}
console.log(procurarPorNome(series, "Claudia")); //retorna true
console.log(procurarPorNome(series, "Cláudia")); //retorna false

//Exercicio05
function mascadaEmSerie(series, index){
	var totalDiretor = series[index].diretor.length * 100000;
	var totalElenco = series[index].elenco.length * 40000;
	return totalDiretor + totalElenco;
}

console.log(mascadaEmSerie(series, 4)); //retorna 1300000

//Exercicio06

function queroGenero(genero){
	var seriePorGenero = []
	for(let i = 0; i < series.length; i++){
		if (series[i].genero.includes(genero)){
			seriePorGenero.push(series[i].titulo)
		}
	}
	return seriePorGenero;
}

console.log(queroGenero("Caos")); // Retorna ["Bernardo The Master of the Wizards", "10 Days Why"]


function queroTitulo(titulo){
	let seriePorTitulo = []
	for(let i = 0; i < series.length; i++){
		if (series[i].titulo.includes(titulo)){
			seriePorTitulo.push(series[i].titulo)
		}
	}
	return seriePorTitulo;
}


console.log(queroTitulo("The")); // Retorna ["The Walking Dead", "Bernardo The Master of the Wizards"]

/*

//exercicio08

function elencoAbreviado(series){
	let contador = 0;

	for (let i = 0; i < series.length; i++){
		let variavel = '';
		for (let j = 0; j < series.length; j++){			
			variavel += series[i].elenco[j];
			if (variavel.includes(".")){
				contador += 1;
			}
			if (contador === series[i].elenco.length){
				return true;
			}
		}
	}
	return contador;
}


function abreviacao(series){
	let palavra = '';
	let index = 0;
	for (let i = 0; i < series.length; i++){
		for (let j = 0; j < series.length; j++)
		if (series[i].elenco[j].includes('.')){
			index = str.search(".");
			palavra += series[i].elenco.substr(index-2, index-1)
		}
	}
	return palavra;
}

*/