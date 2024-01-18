namespace CelsonApi.Models.DTOs;

public class DTO_Resposta(Object resposta, string mensagem)
{
    public Object? Resposta {get; set;} = resposta;
    public string Mensagem {get; set;} = mensagem;
}