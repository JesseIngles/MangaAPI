using CelsonApi.Data;
using CelsonApi.Models.DTOs;
using CelsonApi.Models.Interfaces;
using CelsonApi.Models.Tabelas;

namespace CelsonApi.Models.Repositorios;

public class Repo_User : IUser
{
    private readonly AppDbContext _db;
    public Repo_User(AppDbContext dbcontext)
    {
        _db = dbcontext;
    }

    public DTO_Resposta AtualizarUser(Guid id, DTO_User tbUser)
    {
        try
        {
            var User = _db.Users.Find(id);
            if(User != null)
                User.Nome = tbUser.Nome;
                User.Email = tbUser.Email;
                User.Senha = tbUser.Senha;
                _db.SaveChanges();
                return new DTO_Resposta(User, "Usuário atualizado");
            return new DTO_Resposta(tbUser, "Usuário não encontrado");

        }catch{
            return new DTO_Resposta(tbUser, "Usuário não encontrado");
        }
    }

    public DTO_Resposta CadastrarUser(DTO_User tbUser)
    {
        try
        {
            if(tbUser != null){
                var objecto = new TbUser{
                    Id = Guid.NewGuid(),
                    Nome = tbUser.Nome,
                    Email = tbUser.Email,
                    Senha = tbUser.Senha,
                };
                _db.Users.Add(objecto);
                _db.SaveChanges();
                return new DTO_Resposta(objecto, "Usuário cadastrado");
            }
            return new DTO_Resposta(null, "Usuário inválido");
        }catch(Exception ex)
        {
            return new DTO_Resposta(ex, "Não foi possivél Cadastrar");
        }
    }


    public DTO_Resposta RemoverUser(Guid id, DTO_User tbUser)
    {
        try
        {
            var User = _db.Users.Find(id);
            if(User != null)
            {
                _db.Users.Remove(User);
                _db.SaveChanges();
                return new DTO_Resposta(tbUser, "Usuário removido com sucesso");
            }
            else
            {
                return new DTO_Resposta(tbUser, "Usuário não encontrado");
            }

        }catch
        {
            return new DTO_Resposta(tbUser, "Não foi possivél elimimar este usuário");
        }
        

    }

    public DTO_Resposta VerUsers()
    {
        try
        {
            var ListaUsuarios = _db.Users.ToList();
            return (ListaUsuarios!= null) 
            ? new DTO_Resposta(ListaUsuarios, "Todos usuários") 
            : new DTO_Resposta(null, "Não existem usuários cadastrados");
        }catch
        {
            return new DTO_Resposta(null, "Não foi possivél encontrar usuários.");
        }
    }
}