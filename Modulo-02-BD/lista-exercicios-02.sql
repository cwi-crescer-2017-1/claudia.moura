#Lista de exercícios 02

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
where (Salario*13 < 18500) or Cargo = 'Atendente';