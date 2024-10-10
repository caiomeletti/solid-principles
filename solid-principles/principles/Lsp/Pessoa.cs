/******************************************************************************
Liskov substitution principle — Princípio da substituição de Liskov

Se a classe A for um subtipo da classe B , poderemos substituir B por A sem 
interromper o comportamento do nosso programa. 
Isso pode ser formulado matematicamente como:

Se F(x) é uma propriedade demonstrável sobre objetos x de tipo B.
Então F(y) deve ser verdadeiro para objetos y de tipo A, em que A é um subtipo de B.

De maneira mais geral, afirma que os objetos em um programa devem ser 
substituíveis por instâncias de seus subtipos sem alterar a correção desse programa.

Classes derivadas (ou classes-filhas) devem ser capazes de substituir suas 
classes-base (ou classes-mães)
******************************************************************************/
namespace solid.principles.Lsp;

//Essa implementação viola o 'LSP', porque uma a pessoa jurídica irá herdar o 
//método Andar() mesmo não podendo executá-lo.
public class PessoaFisicaNoLsp
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Documento { get; set; }

    public virtual void Andar()
    {
        //consegue andar
    }
}

public class PessoaJuridicaNoLsp : PessoaFisicaNoLsp
{
    public string NomeFantasia { get; set; }

    public override void Andar()
    {
        //uma pessoa jurídica não consegue andar
    }
}

//Para atender ao princípio 'Lsp', a classe Pessoa deverá conter somente 
//atributos e métodos que não afetem as classes filhas ao realizar a 
//substituição de seus objetos instanciados 
public class Pessoa
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
}

public class PessoaFisica : Pessoa
{
    public string Cpf { get; set; }

    public virtual void Andar()
    {
        //consegue andar
    }
}

//Essa implementação não 'carrega' o método que não pode ser executado pela 
//PessoaJuridica e garante que cada um tenha o seu atributo de documento especializado.
public class PessoaJuridica : Pessoa
{
    public string Cnpj { get; set; }
}
