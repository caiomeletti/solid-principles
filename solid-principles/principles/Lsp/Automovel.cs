/******************************************************************************
Liskov substitution principle — Princípio da substituição de Liskov

Classes derivadas (ou classes-filhas) devem ser capazes de substituir suas 
classes-base (ou classes-mães)
******************************************************************************/
namespace solid_principles.principles.Lsp;

//Essa implementação viola o 'LSP', porque todos as classes que derivam de
//AutomovelNoLsp irão herdar o método AbastecerCombustivel() que é restrito
//ao veículos que utilizam combustíveis líquidos, mesmo que o seu 
//"abastecimento" seja realizado de outras formas
public class AutomovelNoLsp
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public void AbastecerCombustivel()
    {
    }
}

public class AutomovelMotorCombustaoNoLsp : AutomovelNoLsp
{
    public decimal ConsumoPorLitro { get; set; }
    
    //Aqui o método AbastecerCombustivel está sendo herdado e se aplica devido 
    //ao tipo de motorização do veículo
}

public class AutomovelMotorEletricoNoLsp : AutomovelNoLsp
{
    //O método AbastecerCombustivel não se aplica devido o veículo não
    //utilizar a combustão como força motriz, mas como a classe é filha de
    //AutomovelNoLsp terá herdado o método que não faz sentido na sua utilização
    public void CarregarBateria()
    {
    }
}


//Para atender o princípio 'Lsp' os métodos com implementação específica devem 
//migrar para as classes específicas de forma que a classe derivada (a que herda)
//possa substituir a classe base ao utilizar polimorfismo
public class Automovel
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

}

//As classes derivadas herdam da classe base e implementam cada uma, 
//métodos específicos que atendem ao tipo de motorização
public class AutomovelMotorCombustao : Automovel
{
    public void AbastecerCombustivel()
    {
    }
}

public class AutomovelMotorEletrico : Automovel
{
    public void CarregarBateria()
    {
    }
}