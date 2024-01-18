using CelsonApi.Models.DTOs;
using CelsonApi.Models.Tabelas;

namespace CelsonApi.Models.Interfaces;

public interface IUser
{
    public DTO_Resposta VerUsers();
    public DTO_Resposta CadastrarUser(DTO_User tbUser);
    public DTO_Resposta AtualizarUser(Guid id, DTO_User tbUser);
    public DTO_Resposta RemoverUser(Guid id, DTO_User tbUser);

}