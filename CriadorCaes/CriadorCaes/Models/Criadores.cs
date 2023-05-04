using System.ComponentModel.DataAnnotations;

namespace CriadorCaes.Models {
   /// <summary>
   /// Dados dos criadores dos animais
   /// </summary>
   public class Criadores {

      public Criadores() {
         // inicializar a lista de animais do criador
         ListaAnimais=new HashSet<Animais>();
         // inicializar a lista de Raças que o Criador cria
         ListaRacas=new HashSet<Racas>();
      }


      /*
       * Lista de anotadores
       * https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/data-annotations
       * https://www.entityframeworktutorial.net/code-first/dataannotation-in-code-first.aspx
       */ 

      public int Id { get; set; }

      /// <summary>
      /// nome do criador
      /// </summary>
      [Required(ErrorMessage ="O {0} é de preenchimento obrigatório.")]
        [StringLength(100)]
      public string Nome { get; set; }

      /// <summary>
      /// nome pelo qual o criador é conhecido 
      /// no mercado de venda de animais
      /// </summary>
      [Display(Name ="Nome Comercial")]
        [StringLength(50)]
      public string NomeComercial { get; set; }

        /// <summary>
        /// morada do criador
        /// </summary>
      [StringLength(60)]
      public string Morada { get; set; }

      /// <summary>
      /// Código Postal
      /// </summary>
      [Display(Name ="Código Postal")]
      [RegularExpression("[1-9][0-9]{3}-[0-9]{3}(1,3)[A-Z -ÇÀÁÉÍÓÚÂÊÎÔÛ]+", ErrorMessage ="o {0} deve ter o formato XXXX-XXX NOME DA TERRA")]
      [StringLength(40)]
      public string CodPostal { get; set; }

      /// <summary>
      /// Email do criador
      /// </summary>
      [EmailAddress]
      [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")]
      public string Email { get; set; }

      /// <summary>
      /// Telemóvel do Criador
      /// </summary>
      [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")]
      [Display(Name ="Telemóvel")]
      [StringLength(9,MinimumLength =9, ErrorMessage ="Deve escrever {1} digitos no numero de {0}")]
      [RegularExpression("([0-9]{2,5})?[0-9]{5,14}")]
      public string Telemovel { get; set; }

      /* ++++++++++++++++++++++++++++++++++++++++++++++++
       * relacionamentos associados ao Criador
       */

      /// <summary>
      /// Lista dos animais associados ao Criador
      /// </summary>
      public ICollection<Animais> ListaAnimais { get; set; }

      /// <summary>
      /// Lista das raças que um Criador cria
      /// </summary>
      public ICollection<Racas> ListaRacas { get; set; }

   }
}
