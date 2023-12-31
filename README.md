# .NET-MyWallet-api

MyWallet é um aplicativo mobile para android para gestão das finanças do usuário. Esta é a API utilizada no aplicativo.

Link para o deploy do projeto: https://mywallet-dotnet-api.onrender.com/api

## Sobre

Principais funcionalidades implementadas:

- Sign up
- Login
- CRUD de registros

A autenticação é feita com JWT.

## Tecnologias

Algumas das principais tecnologias e frameworks utilizados no projeto.<br/><br/>

<div>
    <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" height="22px"/>
    <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" height="22px" />
    <img src="https://img.shields.io/badge/PostgreSQL-316192?style=for-the-badge&logo=postgresql&logoColor=white" height="22px" />
    <img src="https://img.shields.io/badge/Docker-2CA5E0?style=for-the-badge&logo=docker&logoColor=white" height="22px" />
    
</div>

## Como rodar o projeto

1. Clone o repositório

2. Forneça uma string de conexão para o banco de dados PostgreSQL, preenchendo cada parâmetro que aparece na string abaixo:

```bash
export ConnectionStringMyWallet="User Id=; Password=; Host=; Port=; Database=;"
```

3. Forneça uma string com nome "TokenJwt" como fonte para autenticação JWT (mín. 80 caracteres). Exemplo:

```bash
export TokenJwt="Lorem ipsum mollis porttitor, duis laoreet lacinia libero, viverra potenti."
```

4. Execute o projeto (Verifique se possui alguma versão do SDK 6+ instalado )

```bash
dotnet run
```

5. Acesse o endereço http://localhost:5008 no navegador de sua preferência. 