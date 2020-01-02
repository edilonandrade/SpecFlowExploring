Feature: Search

Scenario: Busca	
	When I perform a simple search on 'livro'
	Then the book list should exactly contain book 'livro'
