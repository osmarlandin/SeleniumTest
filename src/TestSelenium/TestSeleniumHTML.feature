#language: pt-br

Funcionalidade: TestSeleniumHTML
	Para entender como o Selenium funciona
	Como um leigo
	Eu quero testar a API

@chrome
Cenário: Selecionar um valor no combo
	Dado que eu estou na home
	Quando eu seleciono o Valor 2 no combo
	Então o Valor 2 fica selecionado

@chrome
Cenário: Selecionar um checkbox
	Dado que eu estou na home
	Quando eu clico no checkbox 3
	Então o checkbox 3 fica selecionado

@chrome
Cenário: Selecionar um radio
	Dado que eu estou na home
	Quando eu clico no radio 1
	Então o radio 1 fica selecionado

@chrome
Cenário: Clicar na li
	Dado que eu estou na home
	Quando eu clico na Minha Li 1
	Então o textto Você clicou na Minha Li 1 deve aparecer