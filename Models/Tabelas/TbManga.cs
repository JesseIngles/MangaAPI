namespace CelsonApi.Models.Tabelas;

public class TbManga
{
    public Guid Id {get; set;}
    public string Titulo {get; set;}
    public string Descricao {get; set;}
    public virtual ICollection<TbCategory>? Categories {get; set;} 
    public virtual ICollection<TbAvaliacao>? Avaliacaos {get; set;} 
}