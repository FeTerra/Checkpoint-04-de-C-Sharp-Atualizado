Checkpoint 04 – Desenvolvimento de Software com C#
Turma: 3ESPW
Aluno: Felipe Masera Terra de Almeida
RM: 99405

Descrição do Projeto
Este trabalho tem como foco a criação de uma API RESTful utilizando .NET, com uma estrutura modular que facilita a organização e manutenção do código. A aplicação realiza operações de leitura e escrita em um banco de dados Oracle, seguindo boas práticas de desenvolvimento e separação de responsabilidades entre as camadas.

Organização da Solução
O projeto está dividido em três partes principais:

Checkpoint.Api: é o ponto de entrada da aplicação, responsável por disponibilizar os endpoints da API.
Checkpoint.Model: contém os modelos de dados utilizados na aplicação, como Produto, Pedido e Fornecedor.
Checkpoint.Data: cuida da comunicação com o banco de dados Oracle, utilizando o Entity Framework Core. Aqui estão definidos o DbContext e as migrações.


Tecnologias Aplicadas

Plataforma .NET 8
ASP.NET Core
Entity Framework Core versão 8
Banco de Dados Oracle
Documentação via Swagger/OpenAPI


Instruções para Execução
Requisitos
Antes de iniciar, é necessário ter:

O SDK do .NET 8 instalado
Acesso a um banco Oracle funcional
Uma ferramenta para testar APIs, como Postman, Insomnia ou o Swagger UI

Etapas


Obtenha o projeto:
Faça o clone do repositório com o comando apropriado do Git.


Configure a conexão com o banco:
No arquivo appsettings.json, localizado na pasta Checkpoint.Api, atualize a string de conexão (DefaultConnection) com os dados do seu banco Oracle.


Acesse a pasta da API:
Navegue até o diretório onde está o projeto principal da API.


Restaure os pacotes:
Execute o comando para restaurar as dependências do projeto.


Atualize o banco de dados:
As migrações já estão prontas. Basta aplicar com o comando que atualiza o banco conforme os modelos definidos.


Inicie a aplicação:
Execute o projeto para que a API fique disponível para testes.