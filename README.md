# Boas-vindas ao repositório do projeto da API de Receitas

Para realizar o projeto, atente-se a cada passo descrito a seguir. Se tiver qualquer dúvida, nos envie por _Slack_! #vqv 🚀

Aqui você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir deste repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

# Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do Código de Conduta e do Manual da Pessoa Estudante da Trybe.

# Orientações

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/acc-csharp-0x-project-recipe-api.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd acc-csharp-0x-project-recipe-api`

  2. Instale as dependências
  
  - Entre na pasta `src/`.
  - Execute o comando: `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`

  - Verifique se você está na branch `master`
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`
    - Exemplo: `git checkout master`
  - Agora crie uma branch à qual você vai submeter os `commits` do seu projeto
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-acc-csharp-0x-project-recipe-api`

  4. Adicione as mudanças ao _stage_ do Git e faça um `commit`

  - Verifique que as mudanças ainda não estão no _stage_
    - Exemplo: `git status` (deve aparecer listada a pasta _joaozinho_ em vermelho)
  - Adicione o novo arquivo ao _stage_ do Git
    - Exemplo:
      - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
      - `git status` (deve aparecer listado o arquivo _joaozinho/README.md_ em verde)
  - Faça o `commit` inicial
    - Exemplo:
      - `git commit -m 'iniciando o projeto x'` (fazendo o primeiro commit)
      - `git status` (deve aparecer uma mensagem tipo essa: _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-acc-csharp-0x-project-recipe-api`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/acc-csharp-0x-project-recipe-api/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/acc-csharp-0x-project-recipe-api/pulls) e confira que o seu _Pull Request_ está criado

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente

  - Lembre-se sempre de, após um (ou alguns) `commits`, atualizar o repositório remoto

  - Os comandos que você utilizará com mais frequência são:
    1. `git status` _(para verificar o que está em vermelho - fora do stage - e o que está em verde - no stage)_
    2. `git add` _(para adicionar arquivos ao stage do Git)_
    3. `git commit` _(para criar um commit com os arquivos que estão no stage do Git)_
    4. `git push -u origin nome-da-branch` _(para enviar o commit para o repositório remoto na primeira vez que fizer o `push` de uma nova branch)_
    5. `git push` _(para enviar o commit para o repositório remoto após o passo anterior)_

</details>

<details>
  <summary><strong>🤝 Depois de terminar o desenvolvimento (opcional)</strong></summary><br/>

  Para sinalizar que o seu projeto está pronto para o _"Code Review"_, faça o seguinte:

  - Vá até a página **DO SEU** _Pull Request_, adicione a label de _"code-review"_ e marque seus colegas:

    - No menu à direita, clique no _link_ **"Labels"** e escolha a _label_ **code-review**;

    - No menu à direita, clique no _link_ **"Assignees"** e escolha **o seu usuário**;

    - No menu à direita, clique no _link_ **"Reviewers"** e digite `students`, selecione o time `tryber/students-sd-0x`.

  Caso tenha alguma dúvida, [aqui tem um vídeo explicativo](https://vimeo.com/362189205).

</details>

<details>
  <summary><strong>🕵🏿 Revisando um pull request</strong></summary><br />

  Use o conteúdo sobre [Code Review](https://app.betrybe.com/course/real-life-engineer/code-review) para te ajudar a revisar os _Pull Requests_.

</details>

<details>
  <summary><strong>🎛 Linter</strong></summary><br />

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `.csproj`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências.

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/recipes-api` ou de seus testes `src/recipes-api.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste específico, basta executar o comando `dotnet test --filter Name~TestMethod1`.

  :warning: **Importante:** o comando irá executar testes cujo nome contém `TestMethod1`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibe a descrição completa de como utilizar o comando.
    -  `-t|--list-tests`: lista todos os testes, ao invés de executá-los.
    -  `-v|--verbosity <LEVEL>`: define o nível de detalhe na resposta dos testes.
      - `q | quiet`
      - `m | minimal`
      - `n | normal`
      - `d | detailed`
      - `diag | diagnostic`
      - Exemplo de uso: 
         ```
           dotnet test -v diag
         ```
         ou
         ```            
           dotnet test --verbosity=diagnostic
         ``` 
</details>

<details>
  <summary><strong>🗣 Nos dê feedbacks sobre o projeto!</strong></summary><br />

Ao finalizar e submeter o projeto, não se esqueça de avaliar sua experiência preenchendo o formulário. 
**Leva menos de 3 minutos!**

[FORMULÁRIO DE AVALIAÇÃO DE PROJETO](https://be-trybe.typeform.com/to/ZTeR4IbH)

</details>

<details>
  <summary><strong>🗂 Compartilhe seu portfólio!</strong></summary><br />

  Você sabia que o LinkedIn é a principal rede social profissional e que compartilhar aprendizados lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe este projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>

# Requisitos

Sua empresa do coração desenvolveu um aplicativo de Receitas que está totalmente funcional 😉.
Agora, ela quer expandir esse negócio e criar uma **api de receitas** que vai retornar todas as receitas disponíveis, adicionar, remover e atualizar as receitas.

Você recebeu a atribuição de desenvolver essa api de receitas e criar os testes unitários para eles com ASP.NET e xUnit.
 
## 1 - Implemente as funções ReadAll, ReadOne e seus testes
`Em src/recipes-api/RecipesController.cs`

<details>
  <summary>Implemente a Action para ler todas as receitas</summary><br />

A action deve ser do tipo `HttpGet`;

A action deve retornar uma `IActionResult` do tipo `Ok` com um array com todas as receitas.
  
</details>

<details>
  <summary>Implemente a Action para ler uma receita</summary><br />

A action deve ser do tipo `HttpGet` e deve receber um parâmetro `name`;

A action deve retornar uma `IActionResult` do tipo `Ok` com o objeto do tipo `Recipe` que corresponde à busca.

Se não for encontrada uma receita com o nome passado por parâmetro, a Action deve retornar uma `IActionResult` do tipo `NotFound`.
  
</details>

> Os testes desse requisito já estão implementados para serem usados como **base**

> Os testes devem verificar se, quando chamada a action, ela retorna respectivamente uma receita específica, buscada por nome e todas as receitas.


## 2 - Implemente a função Create e seus testes

`Em src/recipes-api/RecipesController.cs`

<details>
  <summary>Implemente a Action para criar uma nova receita</summary><br />

A action deve ser do tipo `HttpPost`;
A action deve receber uma `Recipe` pelo corpo da requisição;

Se a receita passada por parâmetro for nula, deve ser retornado um `IActionResult` do tipo `BadRequest`;

A action deve adicionar a receita criada por parâmetro ao service e retornar um `IActionResult` do tipo `CreatedAtRoute` com a receita;
  
</details>

<details>
  <summary>Implemente os testes para a função de Create</summary><br />

Crie sua lógica em `src/recipes-api.Test/TestRecipesControllerCreate.cs`
  
Seu teste deve verificar se, quando chamada a action, ela adiciona corretamente a Recipe para o service.

</details>

## 3 - Implemente a função Update e seus testes
`Em src/recipes-api/RecipesController.cs`

<details>
  <summary>Implemente a Action para criar uma nova receita</summary><br />

A action deve ser do tipo `HttpPut`;
A action deve receber uma string de nome por parâmetro e uma `Recipe` pelo corpo da requisição;

Se a receita passada por parâmetro for nula ou o nome passado por parâmetro for diferente do nome da receita, deve ser retornado um `IActionResult` do tipo `BadRequest`;

A action deve atualizar a receita no service corretamente e retornar um `IActionResult` do tipo `NoContent` com a receita;
  
</details>

<details>
  <summary>Implemente os testes para a função de Update</summary><br />

Crie sua lógica em `src/recipes-api.Test/TestRecipesControllerUpdate.cs`
  
Seu teste deve verificar se, quando chamada a action, ela altera corretamente a Recipe no service.

</details>




## 4 - Implemente a função Delete e seus testes
`Em src/recipes-api/RecipesController.cs`

<details>
  <summary>Implemente a Action para deletar uma nova receita</summary><br />

A action deve ser do tipo `HttpDelete`;
A action deve receber uma string de nome por parâmetro;

Se a receita a ser deletada não existir no service, deve ser retornado um `IActionResult` do tipo `NotFound`;

A action deve deletar a receita no service corretamente e retornar um `IActionResult` do tipo `NoContent` com a receita;
  
</details>

<details>
  <summary>Implemente os testes para a função de Delete</summary><br />

Crie sua lógica em `src/recipes-api.Test/TestRecipesControllerDelete.cs`
  
Seu teste deve verificar se, quando chamada a action, ela deleta corretamente a Recipe no service.

</details>
