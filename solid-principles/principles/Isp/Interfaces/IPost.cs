/******************************************************************************
Interface segregation principle — Princípio da Segregação de interface

O princípio de segregação da interface afirma que nenhum cliente deve ser 
forçado a depender dos métodos que não usa.
Simplificando: interfaces maiores devem ser divididas em menores. 
Ao fazer isso, podemos garantir que as classes de implementação só precisam 
se preocupar com os métodos que são do seu interesse.
******************************************************************************/
namespace solid.principles.Isp.Interfaces;

//interface original com um método
public interface IPost
{
    void Create();
}

//modificamos essa interface adicionando um novo método ReadPost(), 
//para que se torne a interface IPostNew.
//É aqui que violamos o princípio de segregação da interface.
public interface IPostNew
{
    void Create();
    void Read();
}

//Ao invés disso, basta criar interfaces especializadas, 
//uma IPostCreate que contém um método para Criar Postagem, 
//e uma outra interface IPostRead que contém um método para Ler a Postagem.
public interface IPostCreate
{
    void Create();
}

public interface IPostRead
{
    void Read();
}
