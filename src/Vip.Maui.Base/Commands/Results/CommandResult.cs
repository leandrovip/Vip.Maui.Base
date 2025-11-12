namespace Vip.Maui.Base.Commands.Results
{
    public abstract class CommandResult
    {
        #region Propriedades

        public bool IsValid { get; set; }
        public string Message { get; set; }

        #endregion

        #region Construtores

        protected CommandResult()
        {
            IsValid = true;
        }

        #endregion
    }
}