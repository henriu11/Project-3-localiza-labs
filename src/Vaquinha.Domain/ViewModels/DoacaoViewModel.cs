using System.ComponentModel;

namespace Vaquinha.Domain.ViewModels
{
    public class DoacaoViewModel
    {
        public decimal Valor { get; set; }

        [DisplayName("Aceita pargar a taxa de 20%, ao inves de debitar da instituição?")]
        public bool AceitaTaxa { get; set; }

        public PessoaViewModel DadosPessoais { get; set; }
        public EnderecoViewModel EnderecoCobranca { get; set; }
        public CartaoCreditoViewModel FormaPagamento { get; set; }
    }
}