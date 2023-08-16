namespace API.Interfaces;

public interface IUnitOfWork
{
    IUrlRepository UrlRepository { get; }
    IUserRepository UserRepository { get; }
    Task<bool> Complete();
    bool HasChanges();
}