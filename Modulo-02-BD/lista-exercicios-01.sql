/* --Lista de exercícios 1
--Exercício 01
CREATE TABLE CidadeAux SELECT * FROM Cidade;
--Exercício 02
truncate TABLE CidadeAux;
insert into CidadeAux select * FROM Cidade
WHERE UF = 'RS';
--Exercício 03
Create table Produto 
(
  IDProduto  		int         not null,
  NomeProduto		varchar(30) not null,
  DescricaoProduto  varchar(2)  not null,
  DataCriacao		datetime,
  LocalEstoque		varchar(45) not null,
  Quantidade		int,
  Preco				double,  
    constraint PK_IDProduto primary key (IDProduto)
);	
alter table Produto
modify DescricaoProduto varchar(200);
alter table Produto
modify LocalEstoque varchar(45) null,
modify Quantidade int not null;
--Exercício 04
insert into Produto 
      (IDProduto, 
  NomeProduto, 
  DescricaoProduto,
  DataCriacao,
  LocalEstoque,
  Quantidade,
  Preco)
  values 
      (1, 
       'Arroz', 
       'Saco de Arroz de 1 kg do tipo parbolizado',
       ('2017/04/28'), 
       'Alimentícios',
       99,
       4.99);
insert into Produto 
(
  IDProduto, 
  NomeProduto, 
  DescricaoProduto,
  Quantidade,
  Preco)
  values 
  (2,
  'Feijao',
  'Saco de feijão preto de 0,5kg',
  22,
  6.99);*/



-- Exercícios SQL Server

--Crie a tabela CidadeAux a partir de uma cópia da tabela Cidade. Considere todos os registros existentes.
Select * into CidadeAux from Cidade;

--Limpe a tabela CidadeAux (Truncate table CidadeAux). E em seguida insira todas os registros da tabela Cidade onde o estado seja RS.
Truncate table CidadeAux;
Insert into CidadeAux select * from Cidade
Where UF = 'RS';

--Crie uma tabela para armazenar informações de produtos. Devem ter os seguintes atributos:
Create table Produto 
(
  IDProduto  		int         not null,
  NomeProduto		varchar(30) not null,
  DescricaoProduto  varchar(200)not null,
  DataCriacao		date,
  LocalEstoque		varchar(45),
  Quantidade		int			not null,
  Preco				float,
  );

ALTER TABLE Produto add constraint PK_IDProduto primary key (IDProduto)

--Crie dois registros nessa tabela nova (produto).

insert into Produto 
      (IDProduto, 
  NomeProduto, 
  DescricaoProduto,
  DataCriacao,
  LocalEstoque,
  Quantidade,
  Preco)
  values 
      (1, 
       'Arroz', 
       'Saco de Arroz de 1 kg do tipo parbolizado',
       ('2017/04/28'), 
       'Alimentícios',
       99,
       4.99);
insert into Produto 
(
  IDProduto, 
  NomeProduto, 
  DescricaoProduto,
  Quantidade,
  Preco)
  values 
  (2,
  'Feijao',
  'Saco de feijão preto de 0,5kg',
  22,
6.99);
