/******************************************************************************
Open-closed principle — Princípio aberto-fechado

Esse principio diz que as classes "devem estar abertas para extensão, mas fechadas 
para modificação", com isso passamos evitar possíveis erros a um aplicativo em 
ambiente produtivo, claro que se a modificação for para corrigir um erro existente 
no código esse principio não deveria ser aplicado.
******************************************************************************/
namespace solid_principles.principles.Ocp;

public class Post
{
    public virtual void Create(string postMessage) 
    { 
        Printer.Add(postMessage);
    }

    /*
    A implementação abaixo viola o princípio "OCP" da maneira como esse 
    código difere o comportamento na letra inicial.
    Se posteriormente quisermos incluir também menções iniciadas com '@', 
    teremos que modificar a classe com um 'else if' extra no método CreatePost.
    */
    public virtual void CreateNoOcp(string postMessage) 
    { 
        if(postMessage.StartsWith("#"))
        {
            Printer.AddTag(postMessage);
        }
        else
        {
            Printer.Add(postMessage);
        }
    }
}

//Usando a herança é muito mais fácil criar um comportamento 
//estendido para o objeto TagPost substituindo o método Create().
//A avaliação do primeiro caractere '#' agora será tratada em outro lugar 
//(provavelmente em um nível mais alto) do nosso software, e o mais 
//interessante é que, se queremos mudar a maneira como uma postMessage é avaliada, 
//podemos alterar o código lá, sem afetar nenhuma dessas partes subjacentes.
public class TagPost : Post
{
    public override void Create(string postMessage) 
    {
        Printer.AddTag(postMessage);
    }
}
