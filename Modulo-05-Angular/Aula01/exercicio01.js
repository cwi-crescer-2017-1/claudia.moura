var app = angular.module('angularjs', []);

app.controller('controller', function ($scope, $locale) {

  console.log($locale);

  $scope.listaPokemon = [
    { 	nome: 'Bulbasaur',
      	tipo: ['Planta', 'Veneno']
    },
    {
      	nome: 'Venusaur',
      	tipo: 'Fogo'
    },
    {	
  	  	nome: 'Ivysaur',
	  	tipo: ['Planta', 'Veneno']
    },
    {
      	nome: 'Ivysaur',
      	tipo: 'Fantasma'
    },
    {	
  		nome: 'Charmander',
		tipo: ['Fogo']
    },
    {   
  	  	nome: 'Charmeleon',
	  	tipo: ['Fogo']
    },
    { 	nome: 'Charizard',
	  	tipo: ['Fogo']
    },
	{ 
      	nome: 'Squirtle',
	  	tipo: ['Água']},
	{   nome: 'Wartortle',
	    tipo: ['Água']
	},
    {	nome: 'Blastoise',
		tipo: ['Água']
	},	
	{	nome: 'Caterpie',
		tipo: ['Inseto']
	},	
	{	nome: 'Metapod',
		tipo: ['Inseto']
	},
	{   nome: 'Butterfree',
	    tipo: ['Inseto', 'Voador']
	},
    {   nome: 'Weedle',
	    tipo: ['Inseto', 'Veneno']
	},
	{   nome: 'Pidgey',
	    tipo: ['Normal', 'Voador']
	}

  ];
});

/*
    $scope.listaPokemon = [
    {  	nome: 'Bulbasaur',
    	tipo: ['Planta', 'Veneno']},
	{	nome: 'Venusaur',
		tipo: ['Planta', 'Veneno']},
	{	nome: 'Ivysaur',
		tipo: ['Planta', 'Veneno']},
	{	nome: 'Charmander',
		tipo: ['Fogo']},
	{   nome: 'Charmeleon',
	    tipo: ['Fogo']},
	{   nome: 'Charizard',
	    tipo: ['Fogo']},
	{   nome: 'Squirtle',
	    tipo: ['Água']},
	{   nome: 'Wartortle',
	    tipo: ['Água']},
    {	nome: 'Blastoise',
		tipo: ['Água']},	
	{	nome: 'Caterpie',
		tipo: ['Inseto']},	
	{	nome: 'Metapod',
		tipo: ['Inseto']},	
	{   nome: 'Butterfree',
	    tipo: ['Inseto', 'Voador']},
    {   nome: 'Weedle',
	    tipo: ['Inseto', 'Veneno']},
	{   nome: 'Pidgey',
	    tipo: ['Normal', ['Voador']]
	}];
}]);

*/