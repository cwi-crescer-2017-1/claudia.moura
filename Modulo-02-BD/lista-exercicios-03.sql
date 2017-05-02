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