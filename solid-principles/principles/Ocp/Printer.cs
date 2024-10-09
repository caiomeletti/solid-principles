/******************************************************************************
Open-closed principle — Princípio aberto-fechado

Esse principio diz que as classes "devem estar abertas para extensão, mas fechadas 
para modificação", com isso passamos evitar possíveis erros a um aplicativo em 
ambiente produtivo, claro que se a modificação for para corrigir um erro existente 
no código esse principio não deveria ser aplicado.
******************************************************************************/
namespace solid_principles.principles.Ocp;

public class Printer
{
    internal static void Add(string postMessage)
    {
        throw new NotImplementedException();
    }

    internal static void AddTag(string postMessage)
    {
        throw new NotImplementedException();
    }
}