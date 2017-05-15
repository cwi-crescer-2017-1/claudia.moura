
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

console.log(seriesInvalidas(series)) //deve retornar Mr Robot, Band of Brothers, Narcos


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

console.log(filtrarSeriesPorAno(series, 2012)) //deve retornar array vazio
console.log(filtrarSeriesPorAno(series, 2010)) // deve retornar Walking Dead, 10 Days Why


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



