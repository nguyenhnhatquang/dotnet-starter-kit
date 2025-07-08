namespace Application.Authentication;

public interface IUserContext<out T>
{
    T UserId { get; }
}
