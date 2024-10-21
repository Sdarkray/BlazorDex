namespace BlazorDex.Models
{
    /// <summary>
    /// Representa un Pokémon con sus características básicas.
    /// </summary>
    public class Pokemon 
    {
        /// <summary>
        /// Obtiene o establece el identificador único del Pokémon.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del Pokémon.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Obtiene o establece el peso del Pokémon en kilogramos.
        /// </summary>
        public int weight { get; set; }

        /// <summary>
        /// Obtiene o establece la altura del Pokémon en decímetros.
        /// </summary>
        public int height { get; set; }

        /// <summary>
        /// Obtiene o establece los sprites (imágenes) del Pokémon.
        /// </summary>
        public Sprites sprites { get; set; }

        /// <summary>
        /// Obtiene o establece la lista de estadísticas del Pokémon.
        /// </summary>
        public List<Stat> stats { get; set; }

        /// <summary>
        /// Obtiene o establece la lista de tipos del Pokémon.
        /// </summary>
        public List<Type> types { get; set; }
    }
}