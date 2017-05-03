--Liste o nome do empregado, o nome do gerente e o departamento de cada um.

SELECT e2.NomeEmpregado,  e.NomeEmpregado as NomeGerente, d.NomeDepartamento
FROM Empregado e
INNER JOIN Empregado e2 ON e2.IDGerente = e.IDEmpregado
INNER JOIN Departamento d on d.IDDepartamento = e.IDDepartamento


select * from Empregado
select * from Departamento

--Liste o deparamento (id e nome) com o empregado de maior salário.

Select top 1 d.IDDepartamento, d.NomeDepartamento, MAX(e.salario) as MaiorSalario
FROM Empregado e 
Inner join Departamento d on e.IDDepartamento = d.IDDepartamento
GROUP BY d.IDDepartamento, d.NomeDepartamento, e.Salario
Order by e.Salario desc

-- Aplique uma alteração salarial em todos os empregados que o departamento fique 
--na localidade de SAO PAULO, este reajuste deve ser de 17,3%. 
--Por segurança faça uma cópia da tabela Empregado antes de iniciar esta tarefa.


--SELECT * INTO EmpSalarioReajustado
  -- FROM Empregado
   
UPDATE EmpSalarioReajustado SET Salario = Salario + (Salario*17.3/100)  
from EmpSalarioReajustado e 
inner join Departamento d on e.IDDepartamento = d.IDDepartamento
where d.Localizacao = 'SAO PAULO'


--Liste todas as cidades duplicadas (nome e UF iguais).
SELECT Nome, UF FROM Cidade
GROUP BY Nome, UF
HAVING COUNT(*)>1

--Faça uma alteraçao nas cidades que tenham nome+UF duplicados, 
--adicione no final do nome um asterisco. 
--Mas atenção! apenas a cidade com maior ID deve ser alterada.


UPDATE Cidade SET Nome = Nome + '*'
WHERE IDCidade IN (SELECT DISTINCT MAX(IDCidade)
FROM Cidade
GROUP BY Nome, UF
HAVING COUNT (*) > 1);