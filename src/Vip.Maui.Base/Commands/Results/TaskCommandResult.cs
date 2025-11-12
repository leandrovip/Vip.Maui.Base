using Vip.Maui.Base.Commands.Enums;

namespace Vip.Maui.Base.Commands.Results
{
    public abstract class TaskCommandResult : CommandResult
    {
        #region Propriedades

        public TaskResult TaskResult { get; set; }

        #endregion

        #region Construtores

        protected TaskCommandResult()
        {
            TaskResult = TaskResult.Success;
        }

        #endregion
    }
}