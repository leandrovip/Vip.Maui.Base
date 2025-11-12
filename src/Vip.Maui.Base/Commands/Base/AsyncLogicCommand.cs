using System.Threading.Tasks;
using Vip.Maui.Base.Commands.Helpers;
using Vip.Maui.Base.Commands.Interfaces;
using Vip.Maui.Base.Commands.Results;

namespace Vip.Maui.Base.Commands.Base
{
    /// <summary>
    ///     Base class for which async commands can inherit.
    ///     Created to enforce single responsibility design principal in application logic implementation
    /// </summary>
    /// <typeparam name="TIn"></typeparam>
    /// <typeparam name="TOut"></typeparam>
    public abstract class AsyncLogicCommand<TIn, TOut> : LogicCommand<TIn, TOut>, IAsyncLogicCommand<TIn, TOut> where TOut : CommandResult
    {
        public override TOut Execute(TIn request)
        {
            var result = AsyncHelper.RunSync(() => ExecuteAsync(request));
            return result;
        }

        public abstract Task<TOut> ExecuteAsync(TIn request);
    }
}