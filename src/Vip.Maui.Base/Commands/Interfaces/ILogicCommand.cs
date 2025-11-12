namespace Vip.Maui.Base.Commands.Interfaces
{
    public interface ILogicCommand<in TIn, out TOut>
    {
        TOut Execute(TIn request);
    }
}