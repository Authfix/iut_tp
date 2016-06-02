namespace MvvmSample.Models
{
    public class Character
    {
        /// <summary>
        /// Initialize a default <see cref="Character"/>
        /// </summary>
        /// <param name="name">The name of the character</param>
        /// <param name="surname">The surname of the character</param>
        public Character(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        /// <summary>
        /// Gets the character's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the character's surname
        /// </summary>
        public string Surname { get; set; }
    }
}
