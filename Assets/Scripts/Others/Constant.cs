namespace game
{
    public class Constant
    {
        public const string deadElement = "Dead Element";
        public const string helpElement = "Help Element";
    }

    /// <summary>
    /// Тип элемента
    /// </summary>
    public enum TypeElement
    {
        /// <summary>
        /// Объект, приводящий к смерти игрока
        /// </summary>
        DeadElement = 1,
        /// <summary>
        /// Объект, который можно толкать
        /// </summary>
        HelpElement = 0
    }

}
