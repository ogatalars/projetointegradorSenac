# Projeto Integrador II

## Integrantes do Grupo
- Felipe de Mello Ogata - @ogatalars
- Lorena Camila de Almeida Lopes - @LorenaCamila
- Matheus Felipe dos Santos - @matheusfsantoz
- Rafael Augusto Felipe
- Vinicios Raiser - @viniciosraiser
- Vinicius Valadares

## Professor Orientador
- 

## Descrição do Projeto
Este projeto visa a criação de um sistema universitário para a gestão acadêmica. As funcionalidades principais incluem a gestão de cadastros de pessoas físicas, jurídicas, professores, fornecedores e alunos, além de outras funcionalidades essenciais para a administração acadêmica.

## Objetivo
O objetivo deste sistema é simplificar e automatizar tarefas administrativas, como matrículas, lançamento de notas, controle de frequência e divulgação de horários de aulas, promovendo a eficiência, transparência e qualidade na gestão acadêmica.

## Ferramentas Utilizadas
- Linguagem de Modelagem Unificada (UML) para a modelagem do sistema
- Ferramentas de prototipagem: Miro e Figma
- Plataforma de versionamento de código: GitHub

## Estrutura do Projeto

### Tela de Login
**Campos:**
- E-mail
- Senha

**Botões:**
- Login
- Esqueci minha senha
- Cadastro

### Tela de Navegação
**Menus:**
- Cadastro de Pessoa Física
- Cadastro de Pessoa Jurídica
- Cadastro de Professores
- Cadastro de Fornecedores
- Cadastro de Alunos

### Formulários de Cadastro
#### Cadastro de Pessoa Física
**Campos:**
- Nome
- CPF
- Endereço
- Telefone
- E-mail

#### Cadastro de Pessoa Jurídica
**Campos:**
- Nome da Empresa
- CNPJ
- Endereço
- Telefone
- E-mail

#### Cadastro de Professores
**Campos:**
- Nome
- CPF
- Área de Atuação
- Telefone
- E-mail

#### Cadastro de Fornecedores
**Campos:**
- Nome da Empresa
- CNPJ
- Produtos Fornecidos
- Telefone
- E-mail

#### Cadastro de Alunos
**Campos:**
- Nome
- CPF
- Curso
- Matrícula
- Telefone
- E-mail

## Diagramas
### Diagrama de Casos de Uso
![Diagrama de Casos de Uso](link_para_o_diagrama_de_casos_de_uso)

### Diagrama de Classes
![Diagrama de Classes](link_para_o_diagrama_de_classes)

## Prototipagem
Os protótipos desenvolvidos estão disponíveis no Figma. Acesse o projeto através do link abaixo:
- [Protótipos no Figma](https://www.figma.com/design/JOYHEW8jkCYhhG80oVqeMS/Untitled?node-id=0-1&t=4WF95HVpqHkz06fK-0)

## Requisitos de Sistema
- Plataforma Web
- Segurança dos dados dos usuários
- Usabilidade intuitiva

## Metodologia
Este projeto foi desenvolvido utilizando os princípios fundamentais de segurança e usabilidade, garantindo a proteção dos dados dos usuários e uma interface amigável para uma navegação fácil e gerenciamento eficiente.

## Como Contribuir
1. Crie uma conta no GitHub.
2. O repositório será criado por um dos integrantes do grupo.
3. O integrante responsável pelo repositório deve adicionar os demais integrantes como colaboradores.
4. Todos os integrantes devem colaborar na criação e atualização do arquivo `readme.md` e na anexação dos protótipos desenvolvidos.

## Licença
Este projeto está licenciado sob a licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## Como Rodar o Projeto

### Pré-requisitos
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio Code](https://code.visualstudio.com/) (ou qualquer outro editor de sua preferência)
- [Git](https://git-scm.com/)
- Download .NET 6.0 Runtime

### Passos para Rodar o Projeto

1. **Clone o Repositório**
   
   Abra o terminal e execute o seguinte comando para clonar o repositório:
   ```sh
   git clone https://github.com/seu-usuario/seu-repositorio.git

cd projetointegradorSenac

2. Instale as dependências
dotnet restore

3 - Compilar e executar
dotnet build
dotnet run


4 - Acessando a aplicação 
http://localhost:5092/index/index.html
