# Design Patterns
## Padrões Criacionais:
### Singleton
O Singleton é um padrão de projeto criacional que permite a você garantir que uma classe tenha apenas uma instância, enquanto provê
um ponto de acesso global para essa instância.

O padrão Singleton resolve dois problemas de uma só vez, violando o princípio da responsabilidade única (SRP Single Responsability Principle):
* Garante que uma classe tenha apenas uma única instância;
* Fornece um ponto de acesso global para aquela instância;

Todas as implementações do Singleton possuem esses dois passos em comum:
* Tornar o construtor padrão privado, para prevenir que outros objetos usem o operador **new** com a classe Singleton.
* Criar um método estático de criação que age como um construtor. Esse método chama o construtor privado por debaixo dos panos para criar um objeto e o salva em um campo estático. Todas as chamadas para esse método retornam um objeto em cache.

Se o seu código tem acesso à classe Singleton, então ele será capaz de chamar o método estático da referida classe. Esse método tanto cria um novo objeto ou retorna um único objeto existente se ele já tiver sido criado.

Utilize o padrão Singleton quando uma classe em seu programa deve ter apenas uma instância disponível para todos os seu clientes - por exemplo um objeto de dados compartilhado por diferentes partes do programa.

### Factory Method:
O Factory Method é um padrão criacional de projeto que fornece uma interface para criar objetos em uma superclasse, mas permite que as subclasses alterem o tipo de objeto que serão criados.

O padrão sugere que você substitua chamadas diretas de construção de objetos (usando o operador **new**), por chamadas para um método de fábrica especial.
Os objetos ainda são criados através do operador new, mas esse está sendo chamado de dentro do método fábrica. Os objetos retornados por um método fábrica geralmente são chamados de produtos.

Temos uma estrutura como a seguir:
* O produto declara a interface, que é comum a todos os objetos que podem ser produzidos pelo criador e suas subclasses;
* Produtos concretos são implementações diferentes da interface do produto;
* A classe Creator declara o método de fábrica que retorna novos objetos do produto;
* Criadores concretos sobrescrevem o método de fábrica base para retornar um tipo diferente de produto.

O Factory Method separa o código de construção do produto do código que realmente usa o produto. Portanto, é mais fácil estender o código de construção do produto independentemente do restante do código. Por exemplo, para adicionar um novo tipo a aplicação, só será necessário criar um nova subclasse criadora e substituir o método de fábrica nela.

Dicas:
* Use o Factory Method quando não souber de antemão os tipos e dependências exatas dos objetos com os quais seu código deve funcionar.
* Use o Factory Method quando desejar fornecer aos usuários da sua biblioteca ou framework uma maneira de estender seus componentes internos.
* Use o Factory Method quando você precisar ter um método regular capaz de criar novos objetos e reutilizar os existentes.

### Abstract Factory
O Abstract Factory é um padrão criacional que permite que você produza famílias de objetos relacionados sem ter que especificar suas classes concretas.

Solução: 
* A primeira coisa que o padrão Abstract Factory sugere é declarar explicitamente interfaces para cada produto distinto da família de produtos. Então você pode fazer todas as variantes dos produtos seguirem essas interfaces. 
* O próximo passo é declarar a fábrica abstrata - uma interface com uma lista de métodos de criação para todos os produtos que fazem parte da família de produtos. Esses métodos devem retornar tipos abstratos de produtos representados pelas interfaces que extraímos previamente. 

Dicas: 
* Use o Abstract Factory quando seu código precisa trabalhar como diversas famílias de produtos relacionados, mas que você não quer depender de classes concretas daqueles produtos - eles podem ser desconhecidos de antemão ou você simplesmente quer permitir uma futura escalabilidade.

Benefícios: 
* Você evita um vínculo forte entre produtos concretos e clientes;
* Princípio da Responsabilidade Única: Você pode extrair o código de criação do produto para algum lugar, fazendo o código ser de fácil de manutenção;
* Princípio do aberto/fechado: Você pode introduzir novas variantes de produtos sem quebrar o código cliente existente.

Contras: 
* O código pode tornar-se mais complicado do que deveria ser, uma vez que muitas interfaces e classes são introduzidas junto com o padrão.

## Padrões Estruturais
### Adapter
Adapter é um padrão de design estrutural que permite que objetos com interfaces incompatíveis colaborem, através de uma classe intermediária que serve como um tradutor entre o seu código e uma classa legada, uma classe de terceiros ou qualquer outra classe estranha.

Dicas:
* Use a classe Adapter quando quiser usar alguma classe existente, mas sua interface não for compatível com o restante do seu código.

Detalhes de implementação:
* Certifique-se de ter pelo menos duas classes com intefaces incompatíveis: uma classe de serviço que você não pode alterar (geralmente de terceiros) e uma ou várias classes que se beneficiariam do uso da classe de serviço;
* Declare a interface do cliente e descreva como os clientes se comunicam com o serviço;
* Crie a classe do adaptador e faça-a seguir a interface do cliente;
* Inclua um campo na classe do adptador para armazenar uma referência ao objeto de serviço. A prática mais comum é inicializar esse campo por meio do construtor, mas às vezes é mais conveniente passá-lo para o adaptador ao chamar seus metódos.
* Implemente todos os métodos da interface do cliente na classe do adaptador. O adaptador deve delegar a maior parte do trabalho real ao 
objeto de serviço, manipulando apenas a interface  ou a conversão de formato de dados;
* Os clientes devem usar o adaptador por meio da interface do cliente. Isso permitirá que você altere ou estenda os adaptadores sem afetar
o código do cliente.

Benefícios:
* Princípio da Responsabilidade Única: Você pode separar a interface ou o código de conversão de dados da lógica de negócios primária do programa.
* Princípio do Aberto/Fechado: Você pode introduzir novos tipos de adaptadores no programa sem quebrar o código do cliente existente, desde que  funcionem com os adaptadores por meio da interface do cliente.