namespace CelsonApi.Models.Tabelas;

public class TbUser
{
    public Guid Id {get; set;}
    public required string Nome {get; set;}
    public required string Email {get; set;}
    public required string Senha {get; set;}
    public virtual ICollection<TbAvaliacao>? Avaliacaos {get; set;}
}