/******************************************************************************
Liskov substitution principle — Princípio da substituição de Liskov

Classes derivadas (ou classes-filhas) devem ser capazes de substituir suas 
classes-base (ou classes-mães)
******************************************************************************/
namespace solid_principles.principles.Lsp;

public class StudentNoLsp
{
    internal string name;

    public StudentNoLsp(string name)
    {
        this.name = name;
    }

    public virtual void Study()
    {
        Console.WriteLine($"{name} está estudando.");
    }

    //Esta implementação viola o princípio de substituição pois qualquer 
    //classe-filha herdará o método abaixo mesmo que a classe represente 
    //um tipo de estudante que não entregue TCC.
    public void PresentCCWNoLsp()
    {
        //Entregando TCC
    }
}

//Apesar do estudante de pós-graduação não entregar TCC como é uma classe 
//herdada de Estudante irá 'carregar' o método, implementando um 
//comportamento anômalo a classe.
public class StudentPosGraduateNoLsp : StudentNoLsp
{
    public StudentPosGraduateNoLsp(string name) : base(name)
    {
    }

    public override void Study()
    {
        Console.WriteLine($"{name} está estudando e pesquisando.");
    }
}

//Para atender ao 'Lsp', removemos o método de entrega de TCC, deixando que as 
//classes filhas escolham implementar localmente (ou não) de forma 
//especializada de acordo com o comportamento necessário em cada caso.
public class Student
{
    internal string name;

    public Student(string name)
    {
        this.name = name;
    }

    public virtual void Study()
    {
        Console.WriteLine($"{name} está estudando.");
    }
}

public class StudentGraduate : Student
{
    public StudentGraduate(string name) : base(name)
    {
    }

    public override void Study()
    {
        Console.WriteLine($"{name} está estudando na graduação.");
    }

    public void PresentCCW()
    {
        //Dessa forma, a classe representa melhor o mundo real. Não estamos 
        //forçando uma classe a fazer algo que ela originalmente não faz. 
        //Além disso, se precisarmos utilizar uma instância de Student, 
        //podemos passar, sem medo, uma instância de StudentGraduate ou 
        //de StudentPosGraduate.
    }
}

public class StudentPosGraduate : Student
{
    public StudentPosGraduate(string name) : base(name)
    {
    }

    public override void Study()
    {
        Console.WriteLine($"{name} está estudando e pesquisando.");
    }
}
