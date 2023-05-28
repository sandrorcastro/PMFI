namespace Domain.Entities
{
    public class ObjetoProcesso
    {
/*
        public ObjetoProcesso(Economia economia)
        {
            Economia = economia;
            EconomiaId = Economia.EconomiaId;
            ImovelId = Economia.ImovelId;
            ObjetoProcessoId = long.Parse(String.Concat(ImovelId.ToString() + EconomiaId.ToString().PadLeft(3, '0')));
            TipoObjetoProcesso = 1;
            DescricaoObjetoProcesso = "Economia";
        }
        public ObjetoProcesso(Pessoa pessoa)
        {
            Pessoa = pessoa;
            PessoaId = Pessoa.PessoaId;
            TipoObjetoProcesso = 2;
            DescricaoObjetoProcesso = "Pessoa";


        }*/
        /*public ObjetoProcesso(Object? objeto, string? tipo) {
            if (tipo != null)
            {
                if (tipo == "Economia")
                {
                    Economia = (Economia) objeto;
                    EconomiaId = Economia.EconomiaId;
                    ImovelId= Economia.ImovelId;
                    //var entidadeId = long.Parse(String.Concat(ImovelId.ToString() + EconomiaId.ToString().PadLeft(3, '0')));
                    ObjetoProcessoId = long.Parse(String.Concat(ImovelId.ToString() + EconomiaId.ToString().PadLeft(3, '0')));
                }
                if (tipo == "Pessoa")
                {
                    Pessoa = (Pessoa) objeto;
                    PessoaId = Pessoa.PessoaId;
                }
            }
        }*/
       // public long ObjetoProcessoId { get; set; }
        public long ProcessoId { get; set; }
        public Processo Processo { get; set; }
        //public ICollection<Processo>? Processos { get; set; }
        public int TipoObjetoProcesso { get; set; }
        public string DescricaoObjetoProcesso { get; set; }
        public long? PessoaId { get; set; }
        public Pessoa? Pessoa { get; set; }
        public long? EconomiaId { get; set; }   
        public Economia? Economia { get; set; }
        public long? ImovelId { get; set; }
        public Imovel? Imovel { get; set; }
        public long? EnderecoId { get;set; }
        public Endereco? Endereco { get; set; }
    }
}