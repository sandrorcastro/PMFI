
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infrastructure.EntitiesConfigurations
{
    public class TribAlvDocumentoConfiguration : IEntityTypeConfiguration<TribAlvDocumento>
    {
        public void Configure(EntityTypeBuilder<TribAlvDocumento> builder)
        {

            builder.HasKey(e => e.IdDocumento);

            builder.ToTable("tribAlvDocumento");

            builder.HasIndex(e => new { e.NrAno, e.NrSequencia }, "IX_tribAlvDocumento_nrAno_nrSequencia");

            builder.HasIndex(e => new { e.NrAno, e.NrSequencia, e.DsTipoDocumento }, "IX_tribAlvDocumento_nrAno_nrSequencia_dsTipoDocumento");

            builder.HasIndex(e => e.NrInscricao, "IX_tribAlvDocumento_nrInscricao")
                .HasFillFactor(90);

            builder.HasIndex(e => e.NrPropCpfcnpj, "IX_tribAlvDocumento_nrPropCPFCNPJ");

            builder.HasIndex(e => new { e.NrPropCpfcnpj, e.NrProtocolo }, "IX_tribAlvDocumento_nrPropCPFCNPJ_nrProtocolo");

            builder.HasIndex(e => e.NrSequencia, "IX_tribAlvDocumento_nrSequencia");

            builder.Property(e => e.IdDocumento).HasColumnName("idDocumento");

            builder.Property(e => e.CepObra)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("cepObra");

            builder.Property(e => e.CepProprietario)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("cepProprietario");

            builder.Property(e => e.Dispensado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("dispensado")
                .IsFixedLength();

            builder.Property(e => e.DsArea)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("dsArea");

            builder.Property(e => e.DsAvaliacaoIssqn)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("dsAvaliacaoISSQN");

            builder.Property(e => e.DsDescAreaConstrucao)
                .IsUnicode(false)
                .HasColumnName("dsDescAreaConstrucao");

            builder.Property(e => e.DsInscricaoEstatual)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("dsInscricaoEstatual");

            builder.Property(e => e.DsMotivoCancelamento)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("dsMotivoCancelamento");

            builder.Property(e => e.DsObra)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("dsObra");

            builder.Property(e => e.DsObraEndereco)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("dsObraEndereco");

            builder.Property(e => e.DsObservacao)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("dsObservacao");

            builder.Property(e => e.DsPropEndereco)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dsPropEndereco");

            builder.Property(e => e.DsPropFone)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("dsPropFone");

            builder.Property(e => e.DsTexto)
                .IsUnicode(false)
                .HasColumnName("dsTexto");

            builder.Property(e => e.DsTipoDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("dsTipoDocumento");

            builder.Property(e => e.DsTitulo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("dsTitulo");

            builder.Property(e => e.DsUsuarioExclusao)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("dsUsuarioExclusao");

            builder.Property(e => e.DsUsuarioInclusao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dsUsuarioInclusao");

            builder.Property(e => e.DtDocumento)
                .HasColumnType("date")
                .HasColumnName("dtDocumento");

            builder.Property(e => e.DtExclusaoAlvara)
                .HasColumnType("datetime")
                .HasColumnName("dtExclusaoAlvara");

            builder.Property(e => e.FlComValor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("flComValor")
                .IsFixedLength();

            builder.Property(e => e.FlOutorga)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("flOutorga")
                .IsFixedLength();

            builder.Property(e => e.FlTipoAlvara)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("flTipoAlvara")
                .IsFixedLength();

            builder.Property(e => e.IdCpfcnpjExecucao).HasColumnName("idCPFCNPJ_Execucao");

            builder.Property(e => e.IdCpfcnpjProjeto).HasColumnName("idCPFCNPJ_Projeto");

            builder.Property(e => e.IdDocumentoOrigem).HasColumnName("idDocumentoOrigem");

            builder.Property(e => e.ImDocumento).HasColumnName("imDocumento");

            builder.Property(e => e.NmProprietario)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("nmProprietario");

            builder.Property(e => e.NrAno).HasColumnName("nrAno");

            builder.Property(e => e.NrAnoOrigem).HasColumnName("nrAnoOrigem");

            builder.Property(e => e.NrAreaTerreno)
                .HasColumnType("money")
                .HasColumnName("nrAreaTerreno");

            builder.Property(e => e.NrArt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nrART");

            builder.Property(e => e.NrCmcExecucao).HasColumnName("nrCMC_Execucao");

            builder.Property(e => e.NrCmcProjeto).HasColumnName("nrCMC_Projeto");

            builder.Property(e => e.NrCreaExecucao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nrCREA_Execucao");

            builder.Property(e => e.NrCreaProjeto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nrCREA_Projeto");

            builder.Property(e => e.NrInscricao)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nrInscricao");

            builder.Property(e => e.NrLote)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("nrLote");

            builder.Property(e => e.NrNossoNumero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nrNossoNumero");

            builder.Property(e => e.NrProcessoAno).HasColumnName("nrProcessoAno");

            builder.Property(e => e.NrProcessoSequencia).HasColumnName("nrProcessoSequencia");

            builder.Property(e => e.NrPropCpfcnpj)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("nrPropCPFCNPJ");

            builder.Property(e => e.NrProtocolo).HasColumnName("nrProtocolo");

            builder.Property(e => e.NrQuadra)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("nrQuadra");

            builder.Property(e => e.NrSequencia).HasColumnName("nrSequencia");

            builder.Property(e => e.NrSequenciaOrigem).HasColumnName("nrSequenciaOrigem");

            builder.Property(e => e.RefAnterior)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("refAnterior");

            builder.Property(e => e.Situacao)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("situacao");

            builder.Property(e => e.TpRespObraExecucao)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("tpRespObraExecucao");

            builder.Property(e => e.TpRespObraProjeto)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("tpRespObraProjeto");

            builder.Property(e => e.VlAreaInfracionadaTerreno)
                .HasColumnType("money")
                .HasColumnName("vlAreaInfracionadaTerreno");

            builder.Property(e => e.VlTaxaOutorga)
                .HasColumnType("money")
                .HasColumnName("vlTaxaOutorga");

            builder.Property(e => e.VlTotalAreaConstrucao)
                .HasColumnType("money")
                .HasColumnName("vlTotalAreaConstrucao");

            builder.Property(e => e.VlVenalTerreno)
                .HasColumnType("money")
                .HasColumnName("vlVenalTerreno");



        }
    }
}
