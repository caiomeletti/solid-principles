/******************************************************************************
Interface segregation principle — Princípio da Segregação de interface

O princípio de segregação da interface afirma que nenhum cliente deve ser 
forçado a depender dos métodos que não usa.
Simplificando: interfaces maiores devem ser divididas em menores. 
Ao fazer isso, podemos garantir que as classes de implementação só precisam 
se preocupar com os métodos que são do seu interesse.
******************************************************************************/
using solid.principles.Isp.Interfaces;

namespace solid.principles.Isp;

internal class EmployeeNoIsp
{
    public string Name { get; set; }
    public decimal AmountSalary { get; set; }
}

//Aqui o princípio 'Isp' está violado, pois o Recepcionista não deveria 
//receber comissão, mas como a interface 'força' a implementação de métodos 
//que não são necessários. Sendo a solução o particionamento da interface 
//em partes específicas.
internal class ReceptionistNoIsp : EmployeeNoIsp, IEmployeeNoIsp
{
    public decimal GenerateCommission()
    {
        return 0;
    }

    public decimal Salary()
    {
        return AmountSalary;
    }
}

//Para atender ao princípio 'Isp', os métodos são separados em interfaces de
//acordo com os papéis que irão executar, dessa forma o Vendedor 
//implemente métodos de Funcionário e também de Comissionável, enquanto 
//que o Recepcionista implementa somente o papel de Funcionário 
internal class Employee
{
    public string Name { get; set; }
    public decimal AmountSalary { get; set; }
}

internal class Salesman : Employee, IEmployee, ICommissionable
{
    public decimal PercentCommision { get; set; }
    public decimal TotalSales { get; set; }

    public decimal GenerateCommission()
    {
        return TotalSales < 150000
           ? PercentCommision * TotalSales
           : (PercentCommision + (decimal)0.1) * TotalSales;
    }

    public decimal Salary()
    {
        return AmountSalary;
    }
}

internal class Receptionist : Employee, IEmployee
{
    public int NumberHours { get; set; }

    public decimal Salary()
    {
        return NumberHours > 160
            ? AmountSalary + (decimal)(160 - NumberHours) * (decimal)(AmountSalary / 160)
            : AmountSalary;
    }
}
