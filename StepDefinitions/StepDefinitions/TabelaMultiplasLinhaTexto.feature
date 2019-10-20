#language: pt-BR

Funcionalidade: Teste de especificação com tabela
	Como Estudante do SpecFlow
	Eu quero fazer um teste com tabela
	De modo que eu possa entender como os dados de tabela se comportam

Cenario: Utilização de tabela com sucesso
	Dado os livros abaixo
	| Autor         | Titulo                        |
	| Martin Fowler | Analysis Patterns             |
	| Gojko Adzic   | Briding the Communication Gap |
	Quando eu faço a tranferencia dos livro para uma outra variavel
	Então verifico que os dados estão iguais aos abaixo
	| Autor         | Titulo                        |
	| Martin Fowler | Analysis Patterns             |
	| Gojko Adzic   | Briding the Communication Gap |