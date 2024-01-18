using CelsonApi.Models.DTOs;

namespace CelsonApi.Api;
public static class UserEndpoint
{
    private static IUser _iuser;
    public static void SetDependency(Repo_User user)
    {
        _iuser = user;
    }
    public static void UserEndpoints(this WebApplication app)
    {
        SetDependency(new Repo_User(new AppDbContext()));
        app.MapPost("/v1/Cadastrar/Users", (DTO_User user) =>
        {
            return (user!=null) ? Results.Ok(_iuser.CadastrarUser(user)) : Results.BadRequest(); 
        });

        app.MapGet("/v1/Todos/Users", ()=>
        {
            return Results.Ok(_iuser.VerUsers());
        });
        
    }
}