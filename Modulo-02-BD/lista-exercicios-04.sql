--Liste todos os projetos que tiveram atrasos no início da obra, exibir também o tempo previsto (em meses), e o tempo realizado (em meses) para a conclusão da obra.
Select	Projeto,
		DATEDIFF(MONTH, Data_Inicio_Prev, Data_Fim_Prev) as "Tempo previsto (em meses)",
		DATEDIFF(MONTH, Data_Inicio_Real, Data_Fim_Real) as "Tempo real (em meses)"
From Licitacao
Where Data_Inicio_Real > Data_Inicio_Prev

--Liste as TOP 10 empresas que tiveram maior faturamento, deve ser projetado também o valor médio por profissional.
Select	TOP 10
		Empresa_Licitante,
		SUM(Valor_Realizado),
		SUM(Valor_Realizado) / SUM(Profissionais) as "Valor médio por profissional"
From Licitacao
Group by Empresa_Licitante
Order by SUM(Valor_Realizado) desc

--Liste as TOP 10 cidades com maior arrecação de impostos.
Select	TOP 10
		Municipio,
		Imposto_Municipal as "Arrecadação de Impostos"
From Licitacao
Order by Imposto_Municipal Desc

--Liste todos os projetos que tiveram a data de início (real) ocorrendo em finais de semana (sábado ou domingo).
Select Projeto
From Licitacao
Where DATEPART(WEEKDAY, Data_Inicio_Real) = 1 or DATEPART(WEEKDAY, Data_Inicio_Real) = 7

--Liste todas as empresas que tiveram (ou terão) um faturamento (valor previsto) superior a 50% do seu faturamento no ano anterior.
Select Empresa_Licitante
From Licitacao
Where Valor_Previsto > Faturamento_1Ano_Anterior*50/100

--Liste os projetos exibindo o custo real do projeto. Caso o projeto seja de esfera federal deve ser descontado o imposto federal, e assim respectivamente para as esferas estaduais e municipais.
Select Projeto, 
	Case
	When Esfera LIKE 'Federal' Then Valor_Realizado - Imposto_Federal
	When Esfera LIKE 'Municipal' Then Valor_Realizado - Imposto_Municipal
	When Esfera LIKE 'Estadual' Then Valor_Realizado - Imposto_Estadual
End as "Custo Real"
From Licitacao;

--O projeto 17255 foi suspenso, o motivo foi o elevado custo para o orçamento anual do município. Com isso o projeto 17120 foi proposto para substituí-lo. A partir de uma investigação mais detalhada foi visto que esse motivo não era a verdadeira razão. Explique por que este motivo não é válido apresentando uma consulta com dados.
Select Identificador, Projeto, Esfera, Valor_Realizado, Imposto_Estadual, (Valor_Realizado - Imposto_Estadual) as "Valor Real"
From Licitacao
Where Identificador = 17255 or Identificador = 17120;
--O valor real do projeto aprovado foi mais alto do que o do projeto cancelado