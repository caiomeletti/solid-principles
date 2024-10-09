/******************************************************************************
Dependency Inversion Principle — Princípio da inversão de dependência

O princípio da inversão de dependência refere-se à dissociação de módulos de 
software. Dessa forma, em vez de módulos de alto nível, dependendo de módulos 
de baixo nível, ambos dependerão de abstrações.
******************************************************************************/
using solid_principles.principles.Dip.Interfaces;

namespace solid_principles.principles.Dip;

public class WindowsMachine
{
    private readonly IKeyboard _keyboard;
    private readonly IMonitor _monitor;

    public WindowsMachine(IKeyboard keyboard, IMonitor monitor)
    {
        _keyboard = keyboard;
        _monitor = monitor;
    }
}


// Como 'quebrar' o Dependency Inversion Principle?
// Ao declarar o Keyboard e o Monitor com 'new' palavra-chave, juntamos essas três classes.
// Isso não apenas torna o nosso WindowsMachine difícil de testar, 
// mas também perdemos a capacidade de mudar nossa classe Keyboard por outra diferente, 
// caso seja necessário. E também estamos presos à nossa classe Monitor.

public class WindowsMachineNoDip
{
    private readonly Keyboard _keyboard;
    private readonly Monitor _monitor;

    public WindowsMachineNoDip()
    {
        _keyboard = new Keyboard();
        _monitor = new Monitor();
    }
}
