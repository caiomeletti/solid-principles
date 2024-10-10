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
    internal class EmployeeNoIsp
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }
    
    //Aqui o princípio 'Isp' está violado, pois o Recepcionista 
    //não deveria receber comissão, mas como a interface 'força'
    //a implementação de métodos que não são necessários.
    //Sendo a solução o particionamento da interface em partes específicas.
    internal class ReceptionistNoIsp : EmployeeNoIsp, IEmployeeNoIsp
    {
        public decimal GenerateCommission()
        {
            return (decimal)0;
        }

        public decimal Salary()
        {
            return Salary;
        }
    }

    //Pará atender ao princípio 'Isp', os métodos são separados
    //em interfaces de acordo com os papéis que irão executar, 
    //dessa forma o Vendedor implemente métodos de Funcionário
    //e também de Comissionavel, enquanto que o Recepcionista 
    //implementa somente o papel de Funcionário 
    internal class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    internal class Salesman : Employee, IEmployee, ICommissionable
    {
        public decimal PercentCommision { get; set; }
        public decimal TotalSales { get; set; }

        public decimal GenerateCommission()
        {
            return TotalSales < 150000
               ? PercentCommision * TotalSales
               : (PercentCommision + 0.1) * TotalSales;
        }

        public decimal Salary()
        {
            return Salary;
        }
    }

    internal class Receptionist : IEmployee
    {
        public decimal Salary()
        {
            return Salary;
        }
    }
}
