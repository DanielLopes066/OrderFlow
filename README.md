## 🚀 OrderFlow API

API desenvolvida com ASP.NET Core Web API com o objetivo de praticar conceitos fundamentais de backend, como:

Criação de APIs REST
Estruturação de projetos
Separação de responsabilidades
Injeção de dependência (Dependency Injection)
📌 Objetivo do Projeto

Simular um sistema de gerenciamento de pedidos, com foco em aprendizado e evolução gradual da arquitetura.

🧱 Estrutura do Projeto:

|── OrderFlow

├── Controllers
 
├── Models

├── Services


🧠 Conceitos Aplicados:
✅ Controllers

Responsáveis por receber as requisições HTTP e retornar respostas.

✅ Models

Representam as entidades da aplicação (ex: Order).

✅ Services

Contêm a lógica de negócio (mesmo que simples nesse estágio).

✅ Dependency Injection

O OrderService é injetado no OrdersController, evitando acoplamento direto.

🔌 Endpoint Disponível

🔹 GET /api/orders

⚙️ Tecnologias Utilizadas até o momento:

.NET 8
ASP.NET Core Web API
Swagger (OpenAPI)


