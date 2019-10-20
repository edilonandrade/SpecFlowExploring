#language: pt-BR
#Referência: https://specflow.org/documentation/Step-Definitions/

Funcionalidade: AcoesIguais
	Como Estudante do SpecFlow
	Eu quero fazer um teste de duas ações fazendo a mesmo coisa
	De modo que eu consiga validar que precisar usar epenas um Binding

Cenario: Acoes fazendo a mesma ação com sucesso
	Dado que o usuário informe a soma de um número numa váriavel
	E que o usuário some a um na váriavel novamente
	Quando eu verifico a quantidade
	Então verifico que o valor é igual a 2