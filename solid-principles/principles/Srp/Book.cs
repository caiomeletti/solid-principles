/******************************************************************************
Single-responsiblity principle — Princípio da responsabilidade única

O Princípio da responsabilidade única declara que cada módulo ou classe deve ter 
responsabilidade sobre uma única parte da funcionalidade fornecida pelo software.
Robert C. Martin define uma responsabilidade como um “motivo para mudar” e conclui 
que uma classe ou módulo deve ter um e apenas um motivo para ser alterado.
******************************************************************************/
namespace solid.principles.Srp;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Text { get; set; }

    public string ReplaceWordInText(string word)
    {
        return Text.Replace(word, Text);
    }

    public bool IsWordInText(string word)
    {
        return Text.Contains(word);
    }

    //Ao adicionar este método no código estamos violando o princípio de 
    //responsabilidade única descrito anteriormente
    public void PrintTextToConsole()
    {
        Console.WriteLine($"Título: {Title}");
        Console.WriteLine($"Autor: {Author}");
        Console.WriteLine($"{Text}");
    }
}

//Para aplicar o SRP da forma correta, devemos implementar uma classe 
//separada que se preocupe apenas com a impressão de nossos textos
public class BookPrinter
{
    public static void PrintTextToConsole(Book book)
    {
        Console.WriteLine($"Título: {book.Title}");
        Console.WriteLine($"Autor: {book.Author}");
        Console.WriteLine($"{book.Text}");
    }
}