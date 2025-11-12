using System.Threading.Tasks;
using Vip.Maui.Base.Commands.Results;

namespace Vip.Maui.Base.Commands.Interfaces
{
    public interface IAsyncLogicCommand<TIn, TOut> : ILogicCommand<TIn, TOut> where TOut : CommandResult
    {
        Task<TOut> ExecuteAsync(TIn request);
    }
}