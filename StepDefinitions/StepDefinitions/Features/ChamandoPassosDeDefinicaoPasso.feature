#language: pt-BR
Funcionalidade: ChamandoPassosDeDefinicaoPasso
	Como Estudante do SpecFlow
	Eu quero fazer um teste onde passos são chamandos dentro de uma definição de passo
	De modo que eu entenda como os passos podem ser chamados

Cenario: Chmando passos de passo
	Dado que o usuário "John" existe
	E o usuário está logado como "John"
	E "John" está logado

Cenario: Chamando passos com multiplas linhas
	Dado  um relatório de despeas para jan 2019 com os dados:
	| account | description | amount |
	| INT-100 | Taxi        | 114    |
	| CUC-101 | Peeler      | 22     |
	E um simples relatório de despesa como