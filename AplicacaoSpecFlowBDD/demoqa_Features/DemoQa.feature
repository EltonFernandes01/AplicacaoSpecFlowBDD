Feature: DemoQa

ToolsQA

@tag1
Scenario: Acesso Elements
	Given acesso a pagina demo QA
	When clicar no menu Elements
	Then acesso realizado com sucesso


@tag2
Scenario: Validar tela Elements
	Given  Acesso realizado a pagina elements
	When  Acessar a pagina 
	Then validar todos button 'presente'
	| menu || presente |