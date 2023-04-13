namespace CriadorCaes.Models {
   
    /// <summary>
    /// 
    /// </summary>
    public class Criadores {

        public Criadores() {
            ListaAnimais=new HashSet<Animais>();
        }

        public int Id { get; set; }

        /// <summary>
        /// nome do criador
        /// </summary>
        public string Nome { get; set; }


        /// <summary>
        /// nome da empresa do criador
        /// </summary>
        public string NomeComercial { get; set; }
        
        /// <summary>
        /// morada do criador
        /// </summary>
        public string Morada { get; set; }

        /// <summary>
        /// codigo postal do criador
        /// </summary>
        public string CodPostal { get; set; }

        /// <summary>
        /// Email do criador
        /// </summary>
        public string  Email { get; set; }


        /// <summary>
        /// telemovel do criador
        /// </summary>
        public string Telemovel { get; set; }


        /*
         * relacionamento associado ao criador
         *  
         */
        /// <summary>
        /// Lista dos animais associados ao Criador 
        /// </summary>
        public ICollection<Animais> ListaAnimais { get; set; }
    }
}
