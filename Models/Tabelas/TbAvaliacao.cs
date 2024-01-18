namespace CelsonApi.Models.Tabelas;

public class TbAvaliacao
{
    public Guid Id {get; set;}
    public virtual TbUser? user {get; set;}
    public virtual TbManga? manga {get; set;}
    public int nota {
        get {return nota;}
        set {
            if(value <= 10 && value >0)
                nota = value;
        }
    }
}