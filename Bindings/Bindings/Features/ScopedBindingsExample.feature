Feature: ScopedBindingsExample

@mytag
Scenario: Teste de scope para tags
	Given Que eu tenha uma tag
	When eu faço uma ação relacionada a esse tag
	Then vejo que ela foi executada


Scenario: Teste de scope sem tag	
	Given Que eu tenha um cenário sem tag
	When eu faço uma ação no cenário sem tag
	Then vejo que a ação não foi executada
