/******************************************************************************
Interface segregation principle — Princípio da Segregação de interface

O princípio de segregação da interface afirma que nenhum cliente deve ser 
forçado a depender dos métodos que não usa.
Simplificando: interfaces maiores devem ser divididas em menores. 
Ao fazer isso, podemos garantir que as classes de implementação só precisam 
se preocupar com os métodos que são do seu interesse.
******************************************************************************/
using solid_principles.principles.Isp.Interfaces;

namespace solid_principles.principles.Isp
{
    internal class Employee
    {
        public string Name { get; set; }
    }

    internal class Salesman : IEmployee, ICommissionable
    {
        public decimal GenerateCommission()
        {
            throw new NotImplementedException();
        }

        public decimal Salary()
        {
            throw new NotImplementedException();
        }
    }

    internal class Receptionist : IEmployee
    {
        public decimal Salary()
        {
            throw new NotImplementedException();
        }
    }

    //Aqui o princípio está violado, pois a Recepcionsita
    //não deveria receber comissão, mas como a interface 'força'
    //a implementação de métodos que não são necessários.
    //Sendo a solução o particionamento da interface em partes específicas.
    internal class ReceptionistNoIsp : IEmployeeNoIsp
    {
        public decimal GenerateCommission()
        {
            throw new NotImplementedException();
        }

        public decimal Salary()
        {
            throw new NotImplementedException();
        }
    }

}
