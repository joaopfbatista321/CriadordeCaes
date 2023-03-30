namespace CriadorCaes.Models {
   
    /// <summary>
    /// Fotografia dos cães, nas suas Atividades
    /// </summary>
    public class Fotografias {

        public int Id { get; set; }


        /// <summary>
        /// nome do ficheiro com a fotografia
        /// </summary>
        public string NomeFicheiro { get; set; }


        /// <summary>
        /// nome do local onde a fotografia foi colocada
        /// </summary>
        public string Local { get; set; }


        /// <summary>
        /// data em que a fotografia foi tirada
        /// </summary>
        public DateTime DataFotografia { get; set; }


    }
}
