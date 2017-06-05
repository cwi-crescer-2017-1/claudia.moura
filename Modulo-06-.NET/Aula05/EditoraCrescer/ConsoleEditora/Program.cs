﻿using EditoraCrescerInfraestrutura.Entidades;
using EditoraCrescerInfraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEditora
{
    class Program
    {
        static void Main(string[] args)
        {
            var autor1 = new Autor() {  Nome = "Tolkien" };
            var autor2 = new Autor() {  Nome = "Machado de Assis" };
            var revisor1 = new Revisor() { Id = 1, Nome = "Huguinho" };
            var revisor2 = new Revisor() { Id = 1,  Nome = "Zezinho" };

            using (var contexto = new Contexto())
            {
                //Inclusão
                contexto.Autores.Add(autor1);
                contexto.Autores.Add(autor2);
                contexto.Revisores.Add(revisor1);
                contexto.Revisores.Add(revisor2);
                contexto.SaveChanges();

                var livro = new Livro()
                {
                    Autor = autor1,
                    Titulo = "O senhor dos anéis",
                    Descricao = "Um livro bem legal",
                    Genero = "Aventura",
                    DataPublicacao = DateTime.Now,
                    Revisor = revisor1,
                };

                contexto.Livros.Add(livro);
                contexto.SaveChanges();
            }

            Console.ReadKey();
        }

    }
    
}

/*{ "revisores": [
                {"id": 1, "Nome": "João Paulo"},
                {"id": 2, "Nome": "José Dutra"},
                {"id": 3, "Nome": "Ana dos Santos"}
              ],
"autores": [
          	{"id": 1, "Nome": "Ludwig Von Mises"},
          	{"id": 2, "Nome": "Augusto Comte"},
          	{"id": 3, "Nome": "George R. R. Martin"},
          	{"id": 4, "Nome": "Rodrigo Constantino"},
          	{"id": 5, "Nome": "Jennifer L. Armentrout"},
          	{"id": 6, "Nome": "Neil Gailman"},
          	{"id": 7, "Nome": "Sara Shepard"},
          	{"id": 8, "Nome": "Carlos Ruiz Zafón"},
          	{"id": 9, "Nome": "Marie Kondo"},
          	{"id": 10, "Nome": "Victor Hugo"},
          	{"id": 11, "Nome": "Fiona Barton"},
          	{"id": 12, "Nome": "Donna Leon"},
          	{"id": 13, "Nome": "J. R. R. Tolkien"},
          	{"id": 14, "Nome": "John Darwin"},
          	{"id": 15, "Nome": "Gayle Forman"},
            {"id": 16, "Nome": "Jean Paul Sartre"},
            {"id": 17, "Nome": "J. R. Ward"},
            {"id": 18, "Nome": "Harlan Coben"},
            {"id": 19, "Nome": "Allan Percy"},
            {"id": 20, "Nome": "Clovis Brigagão"}
          ],
"livros": [
            {
              "Titulo": "Libertarianismo",
              "Descricao": "Livro sobre economia e filosofia liberal",
              "Genero": "Economia e Filosofia",
              "DataPublicacao": "1968-10-04T00:00:00",
              "Capa": "http://cdn.mises.org.br/images/ebooks_thumbs/44.png",
              "IdAutor": 1,
              "IdRevisor": 1,
              "DataRevisao": "2010-10-10T00:00:00"
            },
            {
              "Titulo": "Os Pensadores",
              "Descricao": "Livro sobre filosofia positiva",
              "Genero": "Filosofia",
              "DataPublicacao": "1978-11-04T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2017/05/Baixar-Livro-Auguste-Comte-Os-Pensadores-em-Pdf-ePub-e-Mobi-ou-ler-online-370x470.jpg",
              "IdAutor": 2,
              "IdRevisor": 1,
              "DataRevisao": "2012-12-01T00:00:00"
            },
            {
              "Titulo": "A mão do homem morto",
              "Descricao": "Os super-heróis mais poderosos e os vilões mais bizarros estão de volta nos novos volumes da saga de ficção científica de George R.R. Martin",
              "Genero": "Ficção",
              "DataPublicacao": "2015-10-04T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2017/04/Baixar-Livro-A-Mao-do-Homem-Morto-Wild-Cards-Vol-07-George-R.-R.-Martin-em-Pdf-Epub-e-Mobi-Ou-Ler-Onine-370x509.jpg",
              "IdAutor": 3,
              "IdRevisor": 1,
              "DataRevisao": "2011-01-10T00:00:00"
            },
            {
              "Titulo": "Economia do indivíduo",
              "Descricao": "São 223 páginas que sintetizam anos e anos de estudos e análises do comportamento humano, da economia e das relações entre os indivíduos.",
              "Genero": "Economia",
              "DataPublicacao": "1975-10-04T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2014/02/Download-Economia-do-Individuo-Rodrigo-Constantino-em-epub-mobi-e-pdf-370x552.jpg",
              "IdAutor": 4,
              "IdRevisor": 1,
              "DataRevisao": "2013-07-15T00:00:00"
            },
            {
              "Titulo": "Espero por você",
              "Descricao": "Algumas coisas valem a pena esperar. Algumas coisas valem a pena experimentar. Algumas coisas não devem ser mantidas em silêncio. E, por algumas coisas, vale a pena lutar. Avery Morgansten precisa fugir. Ir para uma faculdade a centenas de quilômetros de casa foi a única forma que encontrou para esquecer o acontecimento fatídico que, cinco anos antes, mudara a sua vida para sempre. ",
              "Genero": "Romance",
              "DataPublicacao": "2010-10-04T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2017/03/Baixar-Livro-Espero-por-Voce-Jennifer-L.-Armentrout-em-PDF-ePub-e-Mobi-ou-ler-online-370x532.jpg",
              "IdAutor": 5,
              "IdRevisor": 1,
              "DataRevisao": "2014-10-05T00:00:00"
            },
            {
              "Titulo": "A roda da eternidade",
              "Descricao": "Joey Harker nunca quis ser um líder, mas o destino o levou a se tornar um. E agora é sua responsabilidade evitar o fim do Entremundos, do Multiverso e tudo mais que existe em A roda da eternidade, a eletrizante conclusão da série Entremundos, imaginada por ninguém menos que Neil Gaiman, e escrita pelo premiado autor Michael Reaves e por sua filha Mallory Reaves. Desde que descobriu ser um Andarilho, capaz de se deslocar entre as dimensões, Joey acreditava ter encontrado seu lugar como um agente do Entremundos (organização responsável por manter a paz nos vários universos e dimensões).",
              "Genero": "Ficção Filosofia",
              "DataPublicacao": "1968-10-04T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2017/04/Baixar-Livro-A-Roda-da-Eternidade-Entre-Mundos-Vol-03-Neil-Gaiman-em-Pdf-ePub-e-Mobi-ou-ler-online-370x552.jpg",
              "IdAutor": 6,
              "IdRevisor": 2,
              "DataRevisao": "2014-02-12T00:00:00"
            },
            {
              "Titulo": "Eu nunca... The lying game",
              "Descricao": "Autora da bem-sucedida série Pretty Little Liars, Sara Shepard mostra que sabe mesmo prender a atenção dos adolescentes com histórias que mostram o lado obscuro de garotas bonitas e cheias de segredos.",
              "Genero": "Adolescente",
              "DataPublicacao": "2016-10-04T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2017/03/Baixar-Livro-Eu-Nunca...-The-Lying-Game-Vol-02-Sara-Shepard-em-Pdf-ePub-e-Mobi-ou-ler-online-370x574.jpg",
              "IdAutor": 7,
              "IdRevisor": 2,
              "DataRevisao": "2010-10-19T00:00:00"
            },
            {
              "Titulo": "O Prisioneiro do Céu",
              "Descricao": "Barcelona, 1957. Daniel Sempere e seu amigo Fermín, os heróis de A sombra do vento, estão de volta à aventura para enfrentar o maior desafio de suas vidas.",
              "Genero": "Romance",
              "DataPublicacao": "1971-10-04T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2016/11/Baixar-Livro-O-Prisioneiro-do-Ceu-Carlos-Ruiz-Zafon-em-PDF-ePub-e-Mobi-ou-ler-online-370x532.jpg",
              "IdAutor": 8,
              "IdRevisor": 2,
              "DataRevisao": "2010-03-23T00:00:00"
            },
            {
              "Titulo": "A Mágica da Arrumação",
              "Descricao": "A mágica da arrumação se tornou um fenômeno mundial por apresentar uma abordagem inovadora para acabar de vez com a bagunça. ",
              "Genero": "Desenvolvimento pessoal",
              "DataPublicacao": "2005-10-04T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2016/09/Baixar-Livro-A-Magica-da-Arrumacao-Marie-Kondo-em-PDF-ePub-e-Mobi-ou-ler-online-370x556.jpg",
              "IdAutor": 9,
              "IdRevisor": 2,
              "DataRevisao": "2010-12-25T00:00:00"
            },
            {
              "Titulo": "O último dia de um condenado",
              "Descricao": "Em um romance de surpreendente modernidade, o grande escritor do romantismo se joga de corpo e alma contra a pena de morte. ",
              "Genero": "Romance",
              "DataPublicacao": "1905-10-04T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2016/09/Baixar-Livro-O-Ultimo-dia-de-um-Condenado-Victor-Hugo-em-PDF-ePub-e-Mobi-ou-ler-online-370x525.jpg",
              "IdAutor": 10,
              "IdRevisor": 2,
              "DataRevisao": "2011-08-18T00:00:00"
            },
            {
              "Titulo": "A viúva",
              "Descricao": "Ao longo dos anos, Jean Taylor deixou de contar muitas coisas sobre o terrível crime que o marido era suspeito de ter cometido.",
              "Genero": "Romance",
              "DataPublicacao": "1999-10-04T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2017/02/Baixar-Livro-A-Viuva-Fiona-Barton-em-Pdf-ePub-e-Mobi-ou-ler-online-370x549.jpg",
              "IdAutor": 11,
              "IdRevisor": 3,
              "DataRevisao": "2010-09-27T00:00:00"
            },
            {
              "Titulo": "O fardo da nobreza",
              "Descricao": "No sétimo volume da premiada série de Donna Leon",
              "Genero": "Ficção",
              "DataPublicacao": "1968-10-04T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2017/05/Baixar-Livro-O-Fardo-da-Nobreza-Donna-Leon-em-Pdf-ePub-e-Mobi-ou-ler-online-360x574.jpg",
              "IdAutor": 12,
              "IdRevisor": 3,
              "DataRevisao": "2010-08-29T00:00:00"
            },
            {
              "Titulo": "A história de kullervo",
              "Descricao": "Kullervo, filho de Kalervo, é talvez o mais sombrio e trágico de todos os personagens de J.R.R. Tolkien.",
              "Genero": "Ficção",
              "DataPublicacao": "1965-10-04T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2017/03/Baixar-Livro-A-Historia-de-Kullervo-J.R.R.-Tolkien-em-Epub-Mobi-e-Pdf-ou-ler-Online-364x574.jpg",
              "IdAutor": 13,
              "IdRevisor": 3,
              "DataRevisao": "2010-10-31T00:00:00"
            },
            {
              "Titulo": "Ascensão e Queda dos Impérios Globais.1400-2000",
              "Descricao": "Tamerlão, os Otomanos, Os Mongóis, os Manchus, os Britânicos, os Soviéticos e os nazis, todos construíram impérios concebidos para durarem para sempre",
              "Genero": "Sociologia e história",
              "DataPublicacao": "2009-10-04T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2017/05/Baixar-Livro-Ascensão-e-Queda-dos-Impérios-Globais.1400-2000-John-Darwin-em-Pdf-ePub-e-Mobi-ou-ler-online-370x542.jpg",
              "IdAutor": 14,
              "IdRevisor": 3,
              "DataRevisao": "2010-10-10T00:00:00"
            },
            {
              "Titulo": "Eu estive aqui",
              "Descricao": "Quando sua melhor amiga, Meg, toma um frasco de veneno sozinha num quarto de motel, Cody fica chocada e arrasada.",
              "Genero": "Romance",
              "DataPublicacao": "1968-10-04T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2015/06/Baixar-Livro-Eu-Estive-Aqui-Gayle-Forman-em-PDF-ePub-e-Mobi-370x532.jpg",
              "IdAutor": 15,
              "IdRevisor": 3,
              "DataRevisao": "2010-10-11T00:00:00"
            },
            {
              "Titulo": "A Náusea",
              "Descricao": "Publicado originalmente em 1938, é o primeiro romance de Sartre.",
              "Genero": "Romance",
              "DataPublicacao": "2017-06-02T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2017/05/A-Nausea-370x566.jpg",
              "IdAutor": 16,
              "IdRevisor": 1,
              "DataRevisao": "2017-06-03T00:00:00"
            },
            {
              "Titulo": "Os Reis Do Bourbon",
              "Descricao": "Por gerações, a família Bradford foi coroada como magnata da capital mundial da produção de bourbon, no Estado norte-americano de Kentucky",
              "Genero": "Romance",
              "DataPublicacao": "2017-06-01T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2017/04/Baixar-Livro-Os-Reis-Do-Bourbon-Os-Reis-do-Bourbon-Vol-01-J.-R.-Ward-em-Pdf-ePub-e-Mobi-ou-ler-online-370x543.jpg",
              "IdAutor": 17,
              "IdRevisor": 2,
              "DataRevisao": "2017-06-02T00:00:00"
            },
            {
              "Titulo": "O Medo Mais Profundo",
              "Descricao": "Na época da faculdade, Myron Bolitar teve seu primeiro relacionamento sério, que terminou de forma dolorosa quando a namorada o trocou por seu maior adversário no basquete. ",
              "Genero": "Romance",
              "DataPublicacao": "2017-06-02T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2016/09/Baixar-Livro-O-Medo-Mais-Profundo-Myron-Bolitar-Vol-07-Harlan-Coben-em-PDF-ePub-e-Mobi-ou-ler-online-370x532.jpg",
              "IdAutor": 18,
              "IdRevisor": 3,
              "DataRevisao": "2017-06-03T00:00:00"
            },
            {
              "Titulo": "Einstein Para Distraídos",
              "Descricao": "Einstein para distraídos é um livro inspirador, dedicado a todas as pessoas que buscam relativizar preocupações, resolver problemas e encontrar a fórmula mais simples e poderosa para uma vida plena.",
              "Genero": "Desenvolvimento Pessoal",
              "DataPublicacao": "2017-06-02T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2017/03/Baixar-Livro-Einstein-Para-Distra%C3%ADdos-Allan-Percy-em-Epub-Mobi-e-Pdf-ou-ler-Online-370x563.jpg",
              "IdAutor": 19,
              "IdRevisor": 1,
              "DataRevisao": "2017-06-02T00:00:00"
            },
            {
              "Titulo": "Brizola",
              "Descricao": "Quando sua melhor amiga, Meg, toma um frasco de veneno sozinha num quarto de motel, Cody fica chocada e arrasada.",
              "Genero": "História",
              "DataPublicacao": "2017-06-01T00:00:00",
              "Capa": "http://lelivros.love/wp-content/uploads/2015/07/Baixar-Livro-Brizola-Clovis-Brigagao-em-PDF-ePub-e-Mobi-370x544.jpg",
              "IdAutor": 20,
              "IdRevisor": 3,
              "DataRevisao": "2017-06-01T00:00:00"
            }
          ]
}*/
