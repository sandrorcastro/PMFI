using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblNfse
    {
        public NfseTblNfse()
        {
            NfseTblContaNota = new HashSet<NfseTblContaNota>();
            NfseTblDeclaracaoPendentes = new HashSet<NfseTblDeclaracaoPendente>();
            NfseTblPedCancelamentos = new HashSet<NfseTblPedCancelamento>();
            NfseTblPedSubstituicaos = new HashSet<NfseTblPedSubstituicao>();
            NfseTblReciboRetencaos = new HashSet<NfseTblReciboRetencao>();
            NfseTblRpsImpressos = new HashSet<NfseTblRpsImpresso>();
        }

        public long Idnfse { get; set; }
        public int? Idempresa { get; set; }
        public int? Nunumero { get; set; }
        public string? Stcodigo { get; set; }
        public DateTime? Dtdata { get; set; }
        public byte? Idoperacao { get; set; }
        public byte? Idregime { get; set; }
        public string? Stoptantesimplesnacional { get; set; }
        public string? StincentivadorCultural { get; set; }
        public DateTime? Dtcompetencia { get; set; }
        public long? Idnfsesubst { get; set; }
        public string? Stoutrasinf { get; set; }
        public string? IdcnaeSubclasse { get; set; }
        public int? IdpreIdcidade { get; set; }
        public string? Stcodigotributacaomunicipio { get; set; }
        public string? StservicoDescricao { get; set; }
        public string? Idservico { get; set; }
        public decimal? Pcaliquota { get; set; }
        public decimal? Vlbasecalculo { get; set; }
        public decimal? Vldesccondicionado { get; set; }
        public decimal? Vldescincondicionado { get; set; }
        public string? Stissretido { get; set; }
        public decimal? Vloutrasretencoes { get; set; }
        public decimal Vlcofins { get; set; }
        public decimal? Vliof { get; set; }
        public decimal? Vlcsll { get; set; }
        public decimal? Vldeducoes { get; set; }
        public decimal? Vlinss { get; set; }
        public decimal? Vlir { get; set; }
        public decimal? Vltotaliss { get; set; }
        public decimal? Vlissretido { get; set; }
        public decimal? Vltotalliquido { get; set; }
        public decimal? Vlpis { get; set; }
        public decimal? Vlservicos { get; set; }
        public decimal? Vlcredito { get; set; }
        public string? SttomCpfcnpj { get; set; }
        public string? SttomPessoaTipo { get; set; }
        public string? SttomIm { get; set; }
        public string? SttomNome { get; set; }
        public string? SttomEndLogr { get; set; }
        public string? SttomEndNumero { get; set; }
        public string? SttomEndComplemento { get; set; }
        public string? SttomEndBairro { get; set; }
        public int? IdtomIdcidade { get; set; }
        public string? SttomCep { get; set; }
        public string? SttomEmail { get; set; }
        public string? SttomTelefone { get; set; }
        public string? StintNome { get; set; }
        public string? StintIm { get; set; }
        public string? StintCpfcnpj { get; set; }
        public int? NucodigomunicipioOrgaogerador { get; set; }
        public string? Stcei { get; set; }
        public string? Stnumeroart { get; set; }
        public string? Stsituacao { get; set; }
        public string? Stenviaporemail { get; set; }
        public string? Idusuarioinclusao { get; set; }
        public string? Strecolheiss { get; set; }
        public string? StpreCpfcnpj { get; set; }
        public string? StpreIm { get; set; }
        public string? StpreRazaosocial { get; set; }
        public string? StpreNomefantasia { get; set; }
        public string? StpreEndlogradouro { get; set; }
        public string? StpreEndnumero { get; set; }
        public string? StpreEndcomplemento { get; set; }
        public string? StpreEndbairro { get; set; }
        public int? IdpresIdcidade { get; set; }
        public string? StpreEmail { get; set; }
        public string? StpreCep { get; set; }
        public string? StpreTelefone { get; set; }
        public string? Stserie { get; set; }
        public string? Stunideco { get; set; }
        public string? Stobservacao { get; set; }
        public int? Idempincfisc { get; set; }

        public virtual NfseTblNfseLiquidadum? NfseTblNfseLiquidadum { get; set; }
        public virtual NfseTblRp? NfseTblRp { get; set; }
        public virtual NfseTblRpssub? NfseTblRpssub { get; set; }
        public virtual ICollection<NfseTblContaNota> NfseTblContaNota { get; set; }
        public virtual ICollection<NfseTblDeclaracaoPendente> NfseTblDeclaracaoPendentes { get; set; }
        public virtual ICollection<NfseTblPedCancelamento> NfseTblPedCancelamentos { get; set; }
        public virtual ICollection<NfseTblPedSubstituicao> NfseTblPedSubstituicaos { get; set; }
        public virtual ICollection<NfseTblReciboRetencao> NfseTblReciboRetencaos { get; set; }
        public virtual ICollection<NfseTblRpsImpresso> NfseTblRpsImpressos { get; set; }

        public virtual NfseTblEmpresa Empresa { get; set; }
    }
}
