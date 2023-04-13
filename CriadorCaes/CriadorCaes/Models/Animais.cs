using System.ComponentModel.DataAnnotations.Schema;

namespace CriadorCaes.Models {
   
    /// <summary>
    /// descrição dos Cães
    /// </summary>
    public class Animais {

        public int Id { get; set; }

        /// <summary>
        /// Nome do cão
        /// </summary>
        public string Nome { get; set; } 


        /// <summary>
        /// data de nascimento do cão
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// data de aquisição do cão
        /// </summary>
        public DateTime DataCompra { get; set; }    

        /// <summary>
        /// sexo do animal:
        /// f-femea
        /// m-macho
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// LOP do registo dos animais
        /// </summary>
        public string NumLOP { get; set; }


        /*++++++++++++++++++++++++++++++++++
         * criação das chaves forasteiras
         * 
         *++++++++++++++++++++++++++++++++++
         */

        /// <summary>
        /// FK para o criador do cão/cadela
        /// </summary>
        [ForeignKey(nameof(Criador))]
        public int CriadorFK { get; set; }

        public Criadores Criador { get; set; }// efetivamente, esta é q e a FK 

        /*
         * o uso de [anotadores] serve para formatar o comportamento
         * dos objetos por ele refrenciados
         * estes objetos podem ser:
         *  -atributos
         *  -funçoes 
         *  -classes
         * 
         * 
         */

    }
}
