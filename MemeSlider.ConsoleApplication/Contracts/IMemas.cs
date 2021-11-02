namespace MemeSlider.ConsoleApplication.Contracts
{

    /// <summary>
    /// Интерфейс описывает общее требование к Мемосику
    /// </summary>
    internal interface IMemas
    {
        
        /// <summary>
        /// Имя Мемосика
        /// </summary>
        string ConcreteMemasName { get; }
        
        /// <summary>
        /// Конкретное представление Мемосика
        /// </summary>
        string ConcreteMemasView { get; }

    }
}