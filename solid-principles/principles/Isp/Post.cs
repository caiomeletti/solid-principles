/******************************************************************************
Interface segregation principle — Princípio da Segregação de interface

O princípio de segregação da interface afirma que nenhum cliente deve ser 
forçado a depender dos métodos que não usa.
Simplificando: interfaces maiores devem ser divididas em menores. 
Ao fazer isso, podemos garantir que as classes de implementação só precisam 
se preocupar com os métodos que são do seu interesse.
******************************************************************************/
using solid_principles.principles.Isp.Interfaces;

namespace solid_principles.principles.Isp;

//Cada classe implementa somente os métodos necessários
public class PostOnlyCreate : IPostCreate
{
    public void Create()
    {
    }
}

public class PostOnlyRead : IPostRead
{
    public void Read()
    {
    }
}

//Ou ainda trás mais implementações de acordo com o interesse
public class Post : IPostRead, IPostCreate 
{
    public void Create()
    {
    }

    public void Read()
    {
    }
}

//Como a interface está 'poluída' de métodos, a classe é obrigada  
//a lidar com implementações, mesmo que não sejam necessárias
public class PostNoIsp : IPostNew
{
    public void Create()
    {
    }

    public void Read()
    {
    }
}