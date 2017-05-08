/*MySQL
Select IDEmpregado, NomeEmpregado, year(from_days(to_days(now())-to_days(DataAdmissao))) as Idade 
from Empregado 
where year(DataAdmissao) = 1980;

SELECT COUNT(IDEmpregado), Cargo  
FROM Empregado  
GROUP BY Cargo;

SELECT COUNT(IDEmpregado), Cargo 
FROM Empregado 
GROUP BY Cargo 
Order by COUNT(IDEmpregado) desc 
LIMIT 1;

Select count(IDCidade) as QtdeCidades, UF
From Cidade
Group by UF;

insert into Departamento
(IDDepartamento, NomeDepartamento, Localizacao)
Values (70, 'Inovação', 'SÃO LEOPOLDO');
UPDATE Empregado SET IDDepartamento = 70 
WHERE month(DataAdmissao) = 12 and Cargo != 'Atendente';
*/



--SQL Server

--Faça uma consulta que liste o total de empregados admitidos no ano de 1980. Deve ser projetado nesta consulta: ID, Nome e Idade no momento da admissão.
Select	IDEmpregado as ID,
		NomeEmpregado as Nome,
		DATEDIFF(year, DataNascimento, DataAdmissao) as "Idade no momento da admissão"
From Empregado
Where	DataAdmissao between CONVERT(date, '01/01/1980', 103)   
		and CONVERT(date, '31/12/1980', 103)

--Qual o cargo (tabela empregado) possui mais empregados? Deve ser projetado apenas um registro.
SELECT  Cargo, COUNT(IDEmpregado) as "Quantidade de empregados"
FROM Empregado 
GROUP BY Cargo 
Order by COUNT(IDEmpregado) desc 
OFFSET  0 ROWS 
FETCH NEXT 1 ROWS ONLY 

--Liste os estados (atributo UF) e o total de cidades existente em cada estado na tabela cidade.
 Select UF,
        COUNT(Nome) as "Total Cidades"
From Cidade
Group by UF

--Crie um novo departamento, denominado 'Inovação' com localização em 'SÃO LEOPOLDO'. Todos os empregados que foram admitidos no mês de dezembro (qualquer ano) que não ocupam o cargo de 'Atendente' devem ser ter o departamento (IDDepartamento) atualizado para este novo registro (inovação).

insert into Departamento
(IDDepartamento, NomeDepartamento, Localizacao)
Values (70, 'Inovação', 'SÃO LEOPOLDO');

UPDATE Empregado SET IDDepartamento = 70 
WHERE month(DataAdmissao) = 12 and Cargo != 'Atendente';