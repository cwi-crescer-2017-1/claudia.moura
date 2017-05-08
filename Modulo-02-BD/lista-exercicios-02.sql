/*Lista de exercícios 02
#exercício 01:
select IDEmpregado, NomeEmpregado from Empregado
order by DataAdmissao;
#exercício 02:
select NomeEmpregado from Empregado
where Comissao is null or Comissao = 0
order by Salario;
#exercício 03:
select IDEmpregado, NomeEmpregado, Salario*13 as SalarioAnual, Comissao*12 as ComissaoAnual,
Salario*13 + Comissao*12 as RendaAnual
from Empregado;
#exercício 04:
select IDEmpregado, NomeEmpregado, Cargo, Salario as SalarioMensal from Empregado
where (Salario*13 < 18500) or Cargo = 'Atendente';*/


--Exercícios SQL Server

--Faça uma consulta que retorne os empregados em ordem de admissão, projetar apenas ID e Nome.
Select	IDEmpregado, 
		NomeEmpregado
From Empregado
Order by DataAdmissao

--Faça uma consulta que liste todos os empregados que não recebam comissão, deve ser ordenado pelo salário.
Select NomeEmpregado
From Empregado
Where Comissao is null or Comissao=0
Order by Salario 

--Faça uma consulta que retorno o nome dos empregados, o salário anual (considere 13 salários), projete também a comissão (considere 12x). 
Select	IDEmpregado as "Id do Empregado", 
		NomeEmpregado as Nome, 
		Salario*13 as "Salario Anual", 
		Comissao*12 as "Comissao Anual",
		(Salario*13 + ISNULL(Comissao*12, 0)) as "Renda Anual"
From Empregado

--Faça uma consulta que liste todos os empregados que tenham o salário anual seja inferior a R$ 18500 ou que tenham o cargo de Atendente. 
Select	IDEmpregado as "Id do Empregado", 
		NomeEmpregado as Nome, 
		Cargo, 
		Salario as "Salário Mensal"
From Empregado
Where Salario*13 < 18500 or Cargo = 'Atendente'