Feature: Crear un nuevo usuario

A short summary of the feature

Background:
	Given que el administrador está en la página de login
	And inicia sesión con credenciales válidas


@regresion
Scenario Outline: El administrador crea un usuario exitosamente	
	When da click en agregar nuevo usuario
	And llena los campos con nombre "<nombre>", apellido "<apellido>", email "<email>", telefono "<telefono>"
	And da click en guardar
	Then debería guardarse exitosamente el usuario con nombre "<nombre>"

	Examples: 
		| nombre   | apellido | email                  | telefono  |
		| Alberto  | Alonso   | alberto@mail.com       | 614111222 |
		| Camila   | Díaz     | camila.diaz@mail.com   | 614222333 |
		| Ricardo  | Torres   | ricardo@mail.com       | 614333444 |


@regresion @negativo
Scenario: No se permite crear un usuario con email duplicado
	Given que el administrador está en la página de login
	And inicia sesión con credenciales válidas
	When da click en agregar nuevo usuario
	And llena los campos con nombre "Alberto", apellido "Alonso", email "alberto@mail.com", telefono "614111222"
	And da click en guardar
	Then debería mostrarse un mensaje de error por email duplicado