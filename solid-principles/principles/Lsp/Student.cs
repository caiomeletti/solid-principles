/******************************************************************************
Liskov substitution principle — Princípio da substituição de Liskov

Classes derivadas (ou classes-filhas) devem ser capazes de substituir suas 
classes-base (ou classes-mães)
******************************************************************************/
namespace solid_principles.principles.Lsp
{
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

        //Esta implementação viola o princípio de substituição
        //devido o 'estudante de pós-graduação' herdar 
        //um método que não faz parte das suas ações,
        //pois esse tipo de estudante não entrega TCC.
        public void PresentCCWNoLsp()
        {
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
            //Dessa forma, a classe representa melhor o mundo real.
            //Não estamos forçando uma classe a fazer algo que ela
            //originalmente não faz. Além disso, se precisarmos utilizar
            //uma instância de Student, podemos passar, sem medo, uma
            //instância de StudentGraduate ou de StudentPosGraduate.
        }
    }
}
