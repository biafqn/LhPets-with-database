# LH Pets - Protótipo 1

## Descrição do Projeto

Este projeto consiste na criação de um sistema fictício para aplicação back-end, configurado para um ambiente de projetos web. Ele inclui rotas básicas para exibição de páginas estáticas e uma rota para listar clientes armazenados em banco de dados SQL Server.

---

## Requisitos

Antes de iniciar, é necessário:

- Instalar o SQL Server.
- Instalar o SQL Server Management Studio (SSMS).

---

## Funcionalidades

- **Rota "/"**: Exibe a versão inicial do projeto com o texto `"LH Pets - Protótipo 1"`.
- **Rota "/index"**: Exibe a página inicial `index.html` fornecida pelo front-end.
- **Rota "/listaClientes"**: Exibe a lista de clientes armazenados no banco de dados.

---

## Configurações Técnicas

- A classe `Banco.cs` deve ser editada para incluir a lista de clientes como atributo.
- A classe `Program.cs` deve ser configurada para tratar a rota `/listaClientes` e retornar os dados da lista.

---

## Como Executar

1. Certifique-se que o SQL Server e o SSMS estão instalados e configurados corretamente.
2. Crie o banco de dados e as tabelas necessárias para armazenar os clientes.
3. Configure o projeto back-end para rodar localmente.
4. Acesse as rotas `/`, `/index` e `/listaClientes` para testar as funcionalidades.

---

## Referências

- Tutorial oficial do SQL Server e SSMS.
- Vídeos e tutoriais para instalação e uso do SSMS disponíveis no YouTube.

---

## Instruções Adicionais

Após a instalação, você deve criar a instalação e a configuração de um sistema fictício para uma aplicação back-end. Prepare um ambiente para projetos de sistemas web, com a criação do projeto configurado com as rotas “/” e “/index”.

- Na rota "/" deverá exibir a versão inicial do projeto que é `"LH Pets - Protótipo 1"`.
- A página inicial `index.html` fornecida pelo front-end deverá ser exibida através da rota "/index".
- A lista de clientes que foram inseridas em um banco de dados deverá ser exibida pela requisição "/listaClientes".

  ---
- Edite a classe `Banco.cs` inserindo a lista como atributo.
- Edite a classe `Program.cs` para a rota `/listaClientes`.

---

