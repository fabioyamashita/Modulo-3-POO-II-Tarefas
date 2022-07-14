# Modulo-3-POO-II-Tarefas

## Tarefa "Let's Speak" para entrega até 14/07/2022

### Enunciado

Você foi contratado pela escola de idiomas “Let’s Speak” para a construção de uma aplicação de dicionário para os alunos.

A aplicação deve ser construída conforme os requisitos a seguir.

A aplicação deve armazenar termos e seus significados. Os termos podem ser compostos de uma ou mais palavras (como, por exemplo, no caso de phrasal verbs e expressões idiomáticas).

- A aplicação deve permitir que o aluno insira novos termos sempre que julgar necessário. A aplicação deve permitir a busca de termos, não havendo distinção entre maiúsculas e minúsculas.
- A busca deve ser feita apenas nos termos (não deve fazer buscas nas definições). Quando nenhum termo correspondente à busca for encontrado, a aplicação deve exibir na tela a mensagem **“Nenhum termo encontrado”.**
- Caso contrário, devem ser exibidos todos os termos que correspondem à palavra buscada. A aplicação não deve aceitar Wildcards (* e ?), a busca será feita usando-se somente palavras inteiras ou parte de palavras.
  - *Por exemplo, ao buscar por pea, o sistema deve retornar termos como speak, pear, peacock, spears, etc.*
- A aplicação deve salvar os dados em um arquivo no disco de forma que, ao ser iniciada, todos os termos salvos sejam carregados.

### My Solution

https://user-images.githubusercontent.com/98363297/179053539-e933e76a-a2fd-4f2a-abab-c15d1ba5e821.mp4

## Tarefa de Reflection para entrega até 15/07/2022

### Enunciado

Crie uma aplicação Console que contenha uma cópia da classe abaixo.
```csharp
    public class Student
    {
        public string Name { get; set; }
        public string University { get; set; }
        public int RollNumber { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} - {University} - {RollNumber}");
        }
    }
```
1. Em seguida, na classe Program, crie um método chamado DisplayPublicProperties que, usando Reflection, exiba todas as Propriedades Públicas da classe Student. No método Main da classe Program, coloque uma chamada para o método DisplayPublicProperties.
2. Agora, adicione na classe Program um outro método chamado CreateInstance que
    - Use Reflection para criar uma instância (objeto) da classe Student e, em seguida;
    - Use Reflection para preencher as propriedades públicas do objeto. Não é necessário se preocupar com a adição de novas propriedades, isto é, sempre serão preenchidos apenas o Name, University e RollNumber.
    - Use Reflection para chamar o método DisplayInfo do objeto criado no item 2.1.
3. Ao final do exercício, coloque o seu cródigo em um repositório público no GitHub e submeta o link para avaliação.
