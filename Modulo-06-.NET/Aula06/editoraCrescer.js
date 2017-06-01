angular.module('app', ['ui.bootstrap']);
function CarouselDemoCtrl($scope){
  $scope.myInterval = 3000;
  
  $scope.lancamentos = [
    {
      nome: 'LivroA',
      foto: 'http://www.qparts.com/media/catalog/product/cache/1/image/650x650/9df78eab33525d08d6e5fb8d27136e95/i/m/image_not_available_12.jpg',
      genero: 'Terror',
      autor: 'eu mesma'
    }, {
      nome: 'LivroB',
      foto: 'http://www.qparts.com/media/catalog/product/cache/1/image/650x650/9df78eab33525d08d6e5fb8d27136e95/i/m/image_not_available_12.jpg',
      genero: 'Drama',
      autor: 'Alguém'
    }, {
      nome: 'LivroA',
      foto: 'http://www.qparts.com/media/catalog/product/cache/1/image/650x650/9df78eab33525d08d6e5fb8d27136e95/i/m/image_not_available_12.jpg',
      genero: 'Suspense',
      autor: 'Paulo Coelho'
    },{
      nome: 'LivroA',
      foto: 'http://www.qparts.com/media/catalog/product/cache/1/image/650x650/9df78eab33525d08d6e5fb8d27136e95/i/m/image_not_available_12.jpg',
      genero: 'Terror',
      autor: 'eu mesma'
    }, {
      nome: 'LivroB',
      foto: 'http://www.qparts.com/media/catalog/product/cache/1/image/650x650/9df78eab33525d08d6e5fb8d27136e95/i/m/image_not_available_12.jpg',
      genero: 'Drama',
      autor: 'Alguém'
    }, {
      nome: 'LivroA',
      foto: 'http://www.qparts.com/media/catalog/product/cache/1/image/650x650/9df78eab33525d08d6e5fb8d27136e95/i/m/image_not_available_12.jpg',
      genero: 'Suspense',
      autor: 'Paulo Coelho'
    },
  ];
}


/*var editoraCrescer = angular.module('angularjs', ['ui.bootstrap']);

editoraCrescer.controller('controller', function CarouselDemoCtrl($scope){
  $scope.myInterval = 3000;
  $scope.slides = [
    {
      image: 'http://lorempixel.com/400/200/'
    },
    {
      image: 'http://lorempixel.com/400/200/food'
    },
    {
      image: 'http://lorempixel.com/400/200/sports'
    },
    {
      image: 'http://lorempixel.com/400/200/people'
    }
  ];
}


function CarouselDemoCtrl($scope){
  $scope.myInterval = 3000;
  $scope.slides = [
    {
      image: 'http://lorempixel.com/400/200/'
    },
    {
      image: 'http://lorempixel.com/400/200/food'
    },
    {
      image: 'http://lorempixel.com/400/200/sports'
    },
    {
      image: 'http://lorempixel.com/400/200/people'
    }
  ];
}





// Define the `PhoneListController` controller on the `phonecatApp` module
editoraCrescer.controller('controller', function LancamentosController($scope) {
  $scope.lancamentos = [
    {
      nome: 'LivroA',
      foto: 'http://www.qparts.com/media/catalog/product/cache/1/image/650x650/9df78eab33525d08d6e5fb8d27136e95/i/m/image_not_available_12.jpg',
      genero: 'Terror',
      autor: 'eu mesma'
    }, {
      nome: 'LivroB',
      foto: 'http://www.qparts.com/media/catalog/product/cache/1/image/650x650/9df78eab33525d08d6e5fb8d27136e95/i/m/image_not_available_12.jpg',
      genero: 'Drama',
      autor: 'Alguém'
    }, {
      nome: 'LivroA',
      foto: 'http://www.qparts.com/media/catalog/product/cache/1/image/650x650/9df78eab33525d08d6e5fb8d27136e95/i/m/image_not_available_12.jpg',
      genero: 'Suspense',
      autor: 'Paulo Coelho'
    },{
      nome: 'LivroA',
      foto: 'http://www.qparts.com/media/catalog/product/cache/1/image/650x650/9df78eab33525d08d6e5fb8d27136e95/i/m/image_not_available_12.jpg',
      genero: 'Terror',
      autor: 'eu mesma'
    }, {
      nome: 'LivroB',
      foto: 'http://www.qparts.com/media/catalog/product/cache/1/image/650x650/9df78eab33525d08d6e5fb8d27136e95/i/m/image_not_available_12.jpg',
      genero: 'Drama',
      autor: 'Alguém'
    }, {
      nome: 'LivroA',
      foto: 'http://www.qparts.com/media/catalog/product/cache/1/image/650x650/9df78eab33525d08d6e5fb8d27136e95/i/m/image_not_available_12.jpg',
      genero: 'Suspense',
      autor: 'Paulo Coelho'
    },
  ];
});*/
