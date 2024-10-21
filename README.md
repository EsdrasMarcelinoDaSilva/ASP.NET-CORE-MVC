# ASP.NET-CORE-MVC

# RecodeProject

Um projeto ASP.NET Core que utiliza Entity Framework Core com SQL Server. Este projeto foi desenvolvido para gerenciar informações sobre cursos.

## Tabela de Conteúdos

- [Instalação](#instalação)
- [Uso](#uso)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Dependências](#dependências)
- [Contribuição](#contribuição)


## Instalação

1. Clone o repositório:
   ```bash
   git clone https://github.com/EsdrasMarcelinoDaSilva/RecodeProject.git

Navegue até o diretório do projeto:
- cd RecodeProject

Restaure as dependências:
- dotnet restore

Crie o banco de dados e aplique as migrações:
dotnet ef database update

Para iniciar a aplicação, utilize o seguinte comando:
dotnet run

Funcionalidades
Gerenciamento de cursos
Listagem de cursos 

Estrutura do Projeto
Controllers: Contém os controladores MVC que gerenciam a lógica da aplicação.
Models: Contém as classes de modelo que representam as entidades do banco de dados.
Views: Contém as views que representam a interface do usuário.
Data: Contém o contexto do Entity Framework e as migrações.

Dependências
Este projeto utiliza as seguintes bibliotecas:

Microsoft.VisualStudio.Web.CodeGenerators.Mvc (Versão 8.0.6)

Geração de código e scaffolding para MVC.
Microsoft.EntityFrameworkCore (Versão 8.0.10)

ORM para acesso e manipulação de dados.
Microsoft.EntityFrameworkCore.SqlServer (Versão 8.0.10)

Provedor para usar SQL Server com Entity Framework Core.
Microsoft.EntityFrameworkCore.Tools (Versão 8.0.10)

Ferramentas para migrações e gerenciamento de banco de dados.

Contribuição
Contribuições são bem-vindas! Se você deseja contribuir, siga os passos abaixo:

Fork o repositório.
Crie uma nova branch para sua feature:
git checkout -b feature/nome-da-feature

Faça suas alterações e commit:
git commit -m "Adiciona nova feature"

Faça push para a branch:
git push origin feature/nome-da-feature
