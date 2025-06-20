# 🧩 Resumo do Projeto — Gerenciador de Clientes (CRUD completo) - MVC 5

Desenvolvi um sistema web de gestão de clientes (Pessoa Física e Jurídica) com funcionalidades completas de **cadastro**, **listagem**, **edição**, **exclusão lógica**, **busca dinâmica** e **validações robustas**.  
O sistema foi construído com foco em **boas práticas de desenvolvimento**, **separação de responsabilidades**, **experiência do usuário** e **validação de dados eficaz**.

Este projeto demonstra minha habilidade em:

- Aplicações ASP.NET com arquitetura MVC 5
- Validações com **Data Annotations**
- Máscaras dinâmicas com **jQuery**
- Implementação de CRUD com **persistência em memória**, simulando um backend real

---

## 🚀 Funcionalidades Principais

- ✅ Cadastro de clientes com campos obrigatórios e **máscara dinâmica** (CPF/CNPJ)
- ✅ Edição e **exclusão lógica (soft delete)** de registros
- ✅ Listagem com **status visual** (ativo / excluído)
- ✅ **Busca em tempo real** por nome ou documento
- ✅ Validações no **frontend e backend**
- ✅ Interface **responsiva** e amigável

---

## 🧪 Tecnologias e Ferramentas Utilizadas

| Tecnologia/Ferramenta       | Utilização                                                                 |
|-----------------------------|---------------------------------------------------------------------------|
| **ASP.NET MVC (C#)**        | Estrutura MVC, controle de rotas e regras de negócio                      |
| **Razor (Views)**           | Renderização dinâmica das páginas                                         |
| **Data Annotations**        | Validações de CPF/CNPJ, telefone e campos obrigatórios no backend         |
| **jQuery**                  | Manipulação de DOM, eventos e controle de máscara                         |
| **jQuery Mask Plugin**      | Aplicação de máscara em CPF, CNPJ e telefone                              |
| **Bootstrap**               | Layout responsivo e componentes visuais                                   |
| **HTML / CSS / JavaScript** | Estrutura, comportamento e interatividade no frontend                     |

---

## 🔍 Detalhes Técnicos por Funcionalidade

### 🔄 CRUD de Clientes

- **Cadastrar:**  
  Via `ClientController.Add(Client)` com validação no servidor

- **Editar:**  
  Métodos `Edit(int id)` e `Edit(Client)` atualizam dados existentes

- **Excluir:**  
  `DeleteConfirmed(int id)` aplica **soft delete** (marca como excluído)

- **Listar:**  
  `Index()` exibe todos os clientes da lista estática (em memória)

---

### 🔍 Busca Inteligente

- Implementada com **JavaScript puro**
- Filtra por **nome** ou **número de documento**
- Exibe mensagem personalizada caso não encontre resultados:  
  _"Nenhum Cliente encontrado"_

---

### 🎭 Máscaras de Documento e Telefone

- **Dinâmica:** muda conforme o tipo selecionado (PF → CPF, PJ → CNPJ)
- **Implementada com:** jQuery Mask Plugin
- **Formato de telefone:** `(00) 00000-0000`

---

### ✅ Validações

#### Backend (server-side)

- Feitas com **Data Annotations**:
  - `[Required]`
  - `[RegularExpression]`
- Evita dados inválidos mesmo via requisições diretas

#### Frontend (client-side)

- Uso de `@Html.ValidationMessageFor(...)`
- Feedback visual com mensagens e realce
- **Prevenção de erro** com formatação assistida via jQuery

---

## 📦 Modelos e Repositório

### `Client.cs`
- Classe de modelo com:
  - Propriedades (Id, Nome, Tipo, Documento, Telefone)
  - Validações com `[Required]` e `[RegularExpression]`
  - Controle de exclusão lógica com `IsDeleted`

### `ClientRepository.cs`
- Simula banco de dados com `List<Client>`
- Lógica de:
  - **Auto incremento de ID**
  - **Atualização de cliente**
  - **Soft delete**

---

## 🧠 Principais Métodos e Ações

### No Controller (`ClientController.cs`)

| Método                      | Função                                        |
|----------------------------|-----------------------------------------------|
| `Index()`                  | Lista todos os clientes                       |
| `Client()`                 | Exibe o formulário de cadastro                |
| `Add(Client client)`       | Adiciona um novo cliente                      |
| `Edit(int id)`             | Carrega cliente por ID para edição            |
| `Edit(Client client)`      | Salva as alterações do cliente                |
| `Delete(int id)`           | Exibe confirmação de exclusão                 |
| `DeleteConfirmed(int id)`  | Marca o cliente como excluído (soft delete)   |

---

### No Repositório (`ClientRepository.cs`)

| Método              | Função                                                        |
|---------------------|---------------------------------------------------------------|
| `ClientList()`      | Retorna todos os clientes                                     |
| `GetById(int id)`   | Busca cliente específico por ID                               |
| `Add(Client)`       | Adiciona cliente com ID único e data de cadastro              |
| `Update(Client)`    | Atualiza as informações do cliente existente                  |
| `Remove(int id)`    | Marca o cliente como excluído (sem apagar do armazenamento)   |

---

## 🌟 Destaques Profissionais

- 🧱 **Código bem estruturado** e com separação clara de camadas (MVC)
- 🧑‍💻 **Foco na experiência do usuário**, com:
  - Máscaras dinâmicas
  - Feedback visual
  - Interface limpa e objetiva
- 🔐 **Validações robustas** para garantir a integridade dos dados
- 🧹 **Código limpo, manutenível** e pronto para futura integração com banco real
- 📚 Ideal para destacar habilidades em entrevistas e portfólios técnicos


![Imagem 1](images/1.png)  

![Imagem 2](images/2.png)  

![Imagem 3](images/3.png)  

![Imagem 4](images/4.png)  

![Imagem 5](images/5.png)  

![Imagem 6](images/6.png)  

![Imagem 7](images/7.png)  

![Imagem 8](images/8.png)  

![Imagem 9](images/9.png)  

![Imagem 10](images/10.png)  

![Imagem 11](images/11.png)  

![Imagem 12](images/12.png)  

![Imagem 13](images/13.png)  

![Imagem 14](images/14.png)  

