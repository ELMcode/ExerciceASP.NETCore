namespace ExerciceASP.NETCore.Models.Repositories
{
    public interface IUserRepository
    {
        User? GetByCredentials(string username, string password);
        void Add(User user);
    }
} 