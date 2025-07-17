public interface IDispatcher
{
    Task DispatchAsync(ICommand command);
    Task<TResult> DispatchAsync<TResult>(IQuery<TResult> query);
}
