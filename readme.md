# Design Patterns
## Singleton:
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

## Factory Method:
O Factory Method é um padrão criacional de projeto que fornece uma interface para criar objetos em uma superclasse, mas permite que as subclasses alterem o tipo de objeto que serão criados.

O padrão sugere que você substitua chamadas diretas de construção de objetos (usando o operador **new**), por chamadas para um método de fábrica especial.
Os objetos ainda são criados através do operador new, mas esse está sendo chamado de dentro do método fábrica. Os objetos retornados por um método fábrica geralmente são chamados de produtos.

Temos uma estrutura como a seguir:
![Factory Method](https://drive.google.com/file/d/1Mvpi3wtf8_AzH6VG11Mb-96TxPPUclhM/view)
* O produto declara a interface, que é comum a todos os objetos que podem ser produzidos pelo criador e suas subclasses;
* Produtos concretos são implementações diferentes da interface do produto;
* A classe Creator declara o método de fábrica que retorna novos objetos do produto;
* Criadores concretos sobrescrevem o método de fábrica base para retornar um tipo diferente de produto.

O Factory Method separa o código de construção do produto do código que realmente usa o produto. Portanto, é mais fácil estender o código de construção do produto independentemente do restante do código. Por exemplo, para adicionar um novo tipo a aplicação, só será necessário criar um nova subclasse criadora e substituir o método de fábrica nela.

Dicas:
* Use o Factory Method quando não souber de antemão os tipos e dependências exatas dos objetos com os quais seu código deve funcionar.
* Use o Factory Method quando desejar fornecer aos usuários da sua biblioteca ou framework uma maneira de estender seus componentes internos.
* Use o Factory Method quando você precisar ter um método regular capaz de criar novos objetos e reutilizar os existentes.
