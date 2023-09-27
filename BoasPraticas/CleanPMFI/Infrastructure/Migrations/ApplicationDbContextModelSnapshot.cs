﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entities.Bairro", b =>
                {
                    b.Property<int>("IdBairro")
                        .HasColumnType("int");

                    b.Property<int?>("IdRegiao")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("IdBairro");

                    b.HasIndex("IdRegiao");

                    b.ToTable("Bairro", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Cidade", b =>
                {
                    b.Property<int>("IdCidade")
                        .HasColumnType("int")
                        .HasColumnName("id_cidade");

                    b.Property<int?>("CodigoIbge")
                        .HasColumnType("int")
                        .HasColumnName("codigo_ibge");

                    b.Property<int?>("IdPais")
                        .HasColumnType("int")
                        .HasColumnName("id_pais");

                    b.Property<int?>("IdUf")
                        .HasColumnType("int")
                        .HasColumnName("id_uf");

                    b.Property<decimal?>("Latitude")
                        .HasColumnType("numeric(9,6)")
                        .HasColumnName("latitude");

                    b.Property<decimal?>("Longitude")
                        .HasColumnType("numeric(9,6)")
                        .HasColumnName("longitude");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<string>("SinCapital")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("sin_capital")
                        .IsFixedLength();

                    b.HasKey("IdCidade")
                        .HasName("pk_cidade");

                    b.HasIndex(new[] { "IdUf", "Nome" }, "ak1_cidade")
                        .IsUnique()
                        .HasFilter("[id_uf] IS NOT NULL");

                    b.HasIndex(new[] { "IdPais" }, "fk_cidade_pais");

                    b.HasIndex(new[] { "IdUf" }, "fk_cidade_uf");

                    b.HasIndex(new[] { "IdPais", "IdUf", "SinCapital", "CodigoIbge" }, "i01_cidade");

                    b.ToTable("cidade", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Documento", b =>
                {
                    b.Property<long>("IdDocumento")
                        .HasColumnType("bigint");

                    b.Property<long>("IdPessoa")
                        .HasColumnType("bigint");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PessoaIdPessoa")
                        .HasColumnType("bigint");

                    b.Property<int>("TipoDocumento")
                        .HasColumnType("int");

                    b.HasKey("IdDocumento");

                    b.HasIndex("PessoaIdPessoa");

                    b.ToTable("Documento", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Endereco", b =>
                {
                    b.Property<long>("IdEndereco")
                        .HasColumnType("bigint");

                    b.Property<bool?>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("CEP")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("CidadeIdCidade")
                        .HasColumnType("int");

                    b.Property<string>("Complemento")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool?>("Correspondencia")
                        .HasColumnType("bit");

                    b.Property<long?>("EntidadeEnderecoIdEntidadeEndereco")
                        .HasColumnType("bigint");

                    b.Property<int?>("IdCidade")
                        .HasColumnType("int");

                    b.Property<int>("IdLogradouro")
                        .HasColumnType("int");

                    b.Property<int?>("IdPais")
                        .HasColumnType("int");

                    b.Property<int?>("IdUf")
                        .HasColumnType("int");

                    b.Property<int>("LogradouroIdLogradouro")
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PaisIdPais")
                        .HasColumnType("int");

                    b.Property<string>("Referencia")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("UfIdUf")
                        .HasColumnType("int");

                    b.HasKey("IdEndereco");

                    b.HasIndex("CidadeIdCidade");

                    b.HasIndex("EntidadeEnderecoIdEntidadeEndereco");

                    b.HasIndex("LogradouroIdLogradouro");

                    b.HasIndex("PaisIdPais");

                    b.HasIndex("UfIdUf");

                    b.ToTable("Endereco", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.EntidadeEndereco", b =>
                {
                    b.Property<long>("IdEntidadeEndereco")
                        .HasColumnType("bigint");

                    b.Property<long>("IdEndereco")
                        .HasColumnType("bigint");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long?>("PessoaIdPessoa")
                        .HasColumnType("bigint");

                    b.HasKey("IdEntidadeEndereco");

                    b.HasIndex("PessoaIdPessoa");

                    b.ToTable("EntidadeEndereco", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Logradouro", b =>
                {
                    b.Property<int>("IdLogradouro")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoLogradouro")
                        .HasColumnType("int");

                    b.Property<string>("NomeLogradouro")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.HasKey("IdLogradouro");

                    b.HasIndex("IdTipoLogradouro");

                    b.ToTable("Logradouro", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Property<int>("IdPais")
                        .HasColumnType("int")
                        .HasColumnName("id_pais");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.HasKey("IdPais")
                        .HasName("pk_pais");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pessoa", b =>
                {
                    b.Property<long>("IdPessoa")
                        .HasColumnType("bigint");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPessoa");

                    b.ToTable("Pessoa", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Regiao", b =>
                {
                    b.Property<int>("IdRegiao")
                        .HasColumnType("int");

                    b.Property<string>("CentroGrauLat")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("CentroGrauLon")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int?>("CidadeId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("PercentualUvc")
                        .HasColumnType("money");

                    b.HasKey("IdRegiao");

                    b.HasIndex("CidadeId");

                    b.ToTable("Regiao", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoLogradouro", b =>
                {
                    b.Property<int>("IdTipoLogadouro")
                        .HasColumnType("int");

                    b.Property<string>("Dstipologradouro")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdTipoLogadouro");

                    b.ToTable("TipoLogradouro", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TribAlvDocumento", b =>
                {
                    b.Property<int>("IdDocumento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idDocumento");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDocumento"), 1L, 1);

                    b.Property<string>("CepObra")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("cepObra");

                    b.Property<string>("CepProprietario")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("cepProprietario");

                    b.Property<string>("Dispensado")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("dispensado")
                        .IsFixedLength();

                    b.Property<string>("DsArea")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("dsArea");

                    b.Property<string>("DsAvaliacaoIssqn")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("dsAvaliacaoISSQN");

                    b.Property<string>("DsDescAreaConstrucao")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("dsDescAreaConstrucao");

                    b.Property<string>("DsInscricaoEstatual")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("dsInscricaoEstatual");

                    b.Property<string>("DsMotivoCancelamento")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("dsMotivoCancelamento");

                    b.Property<string>("DsObra")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("dsObra");

                    b.Property<string>("DsObraEndereco")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("dsObraEndereco");

                    b.Property<string>("DsObservacao")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("dsObservacao");

                    b.Property<string>("DsPropEndereco")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("dsPropEndereco");

                    b.Property<string>("DsPropFone")
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("dsPropFone");

                    b.Property<string>("DsTexto")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("dsTexto");

                    b.Property<string>("DsTipoDocumento")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("dsTipoDocumento");

                    b.Property<string>("DsTitulo")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("dsTitulo");

                    b.Property<string>("DsUsuarioExclusao")
                        .HasMaxLength(31)
                        .IsUnicode(false)
                        .HasColumnType("varchar(31)")
                        .HasColumnName("dsUsuarioExclusao");

                    b.Property<string>("DsUsuarioInclusao")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("dsUsuarioInclusao");

                    b.Property<DateTime?>("DtDocumento")
                        .HasColumnType("date")
                        .HasColumnName("dtDocumento");

                    b.Property<DateTime?>("DtExclusaoAlvara")
                        .HasColumnType("datetime")
                        .HasColumnName("dtExclusaoAlvara");

                    b.Property<string>("FlComValor")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("flComValor")
                        .IsFixedLength();

                    b.Property<string>("FlOutorga")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("flOutorga")
                        .IsFixedLength();

                    b.Property<string>("FlTipoAlvara")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("flTipoAlvara")
                        .IsFixedLength();

                    b.Property<int?>("IdCpfcnpjExecucao")
                        .HasColumnType("int")
                        .HasColumnName("idCPFCNPJ_Execucao");

                    b.Property<int?>("IdCpfcnpjProjeto")
                        .HasColumnType("int")
                        .HasColumnName("idCPFCNPJ_Projeto");

                    b.Property<int?>("IdDocumentoOrigem")
                        .HasColumnType("int")
                        .HasColumnName("idDocumentoOrigem");

                    b.Property<byte[]>("ImDocumento")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("imDocumento");

                    b.Property<string>("NmProprietario")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("nmProprietario");

                    b.Property<short?>("NrAno")
                        .HasColumnType("smallint")
                        .HasColumnName("nrAno");

                    b.Property<short?>("NrAnoOrigem")
                        .HasColumnType("smallint")
                        .HasColumnName("nrAnoOrigem");

                    b.Property<decimal?>("NrAreaTerreno")
                        .HasColumnType("money")
                        .HasColumnName("nrAreaTerreno");

                    b.Property<string>("NrArt")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nrART");

                    b.Property<long?>("NrCmcExecucao")
                        .HasColumnType("bigint")
                        .HasColumnName("nrCMC_Execucao");

                    b.Property<long?>("NrCmcProjeto")
                        .HasColumnType("bigint")
                        .HasColumnName("nrCMC_Projeto");

                    b.Property<string>("NrCreaExecucao")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nrCREA_Execucao");

                    b.Property<string>("NrCreaProjeto")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nrCREA_Projeto");

                    b.Property<string>("NrInscricao")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("nrInscricao");

                    b.Property<string>("NrLote")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("nrLote");

                    b.Property<string>("NrNossoNumero")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nrNossoNumero");

                    b.Property<short?>("NrProcessoAno")
                        .HasColumnType("smallint")
                        .HasColumnName("nrProcessoAno");

                    b.Property<int?>("NrProcessoSequencia")
                        .HasColumnType("int")
                        .HasColumnName("nrProcessoSequencia");

                    b.Property<string>("NrPropCpfcnpj")
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("nrPropCPFCNPJ");

                    b.Property<int?>("NrProtocolo")
                        .HasColumnType("int")
                        .HasColumnName("nrProtocolo");

                    b.Property<string>("NrQuadra")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("nrQuadra");

                    b.Property<int?>("NrSequencia")
                        .HasColumnType("int")
                        .HasColumnName("nrSequencia");

                    b.Property<int?>("NrSequenciaOrigem")
                        .HasColumnType("int")
                        .HasColumnName("nrSequenciaOrigem");

                    b.Property<string>("RefAnterior")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("refAnterior");

                    b.Property<string>("Situacao")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("situacao");

                    b.Property<string>("TpRespObraExecucao")
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("tpRespObraExecucao");

                    b.Property<string>("TpRespObraProjeto")
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("tpRespObraProjeto");

                    b.Property<decimal?>("VlAreaInfracionadaTerreno")
                        .HasColumnType("money")
                        .HasColumnName("vlAreaInfracionadaTerreno");

                    b.Property<decimal?>("VlTaxaOutorga")
                        .HasColumnType("money")
                        .HasColumnName("vlTaxaOutorga");

                    b.Property<decimal?>("VlTotalAreaConstrucao")
                        .HasColumnType("money")
                        .HasColumnName("vlTotalAreaConstrucao");

                    b.Property<decimal?>("VlVenalTerreno")
                        .HasColumnType("money")
                        .HasColumnName("vlVenalTerreno");

                    b.HasKey("IdDocumento");

                    b.HasIndex(new[] { "NrAno", "NrSequencia" }, "IX_tribAlvDocumento_nrAno_nrSequencia");

                    b.HasIndex(new[] { "NrAno", "NrSequencia", "DsTipoDocumento" }, "IX_tribAlvDocumento_nrAno_nrSequencia_dsTipoDocumento");

                    b.HasIndex(new[] { "NrInscricao" }, "IX_tribAlvDocumento_nrInscricao");

                    SqlServerIndexBuilderExtensions.HasFillFactor(b.HasIndex(new[] { "NrInscricao" }, "IX_tribAlvDocumento_nrInscricao"), 90);

                    b.HasIndex(new[] { "NrPropCpfcnpj" }, "IX_tribAlvDocumento_nrPropCPFCNPJ");

                    b.HasIndex(new[] { "NrPropCpfcnpj", "NrProtocolo" }, "IX_tribAlvDocumento_nrPropCPFCNPJ_nrProtocolo");

                    b.HasIndex(new[] { "NrSequencia" }, "IX_tribAlvDocumento_nrSequencia");

                    b.ToTable("tribAlvDocumento", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Uf", b =>
                {
                    b.Property<int>("IdUf")
                        .HasColumnType("int")
                        .HasColumnName("id_uf");

                    b.Property<int?>("CodigoIbge")
                        .HasColumnType("int")
                        .HasColumnName("codigo_ibge");

                    b.Property<int>("IdPais")
                        .HasColumnType("int")
                        .HasColumnName("id_pais");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<string>("Sigla")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("sigla")
                        .IsFixedLength();

                    b.HasKey("IdUf")
                        .HasName("pk_uf");

                    b.HasIndex(new[] { "IdPais" }, "fk_uf_pais");

                    b.ToTable("uf", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Bairro", b =>
                {
                    b.HasOne("Domain.Entities.Regiao", "Regiao")
                        .WithMany()
                        .HasForeignKey("IdRegiao");

                    b.Navigation("Regiao");
                });

            modelBuilder.Entity("Domain.Entities.Cidade", b =>
                {
                    b.HasOne("Domain.Entities.Pais", "IdPaisNavigation")
                        .WithMany("Cidades")
                        .HasForeignKey("IdPais")
                        .HasConstraintName("fk_cidade_pais");

                    b.HasOne("Domain.Entities.Uf", "IdUfNavigation")
                        .WithMany("Cidades")
                        .HasForeignKey("IdUf")
                        .HasConstraintName("fk_cidade_uf");

                    b.Navigation("IdPaisNavigation");

                    b.Navigation("IdUfNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Documento", b =>
                {
                    b.HasOne("Domain.Entities.Pessoa", "Pessoa")
                        .WithMany("Documentos")
                        .HasForeignKey("PessoaIdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("Domain.Entities.Endereco", b =>
                {
                    b.HasOne("Domain.Entities.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeIdCidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.EntidadeEndereco", null)
                        .WithMany("Enderecos")
                        .HasForeignKey("EntidadeEnderecoIdEntidadeEndereco");

                    b.HasOne("Domain.Entities.Logradouro", "Logradouro")
                        .WithMany()
                        .HasForeignKey("LogradouroIdLogradouro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisIdPais")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Uf", "Uf")
                        .WithMany()
                        .HasForeignKey("UfIdUf")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");

                    b.Navigation("Logradouro");

                    b.Navigation("Pais");

                    b.Navigation("Uf");
                });

            modelBuilder.Entity("Domain.Entities.EntidadeEndereco", b =>
                {
                    b.HasOne("Domain.Entities.Pessoa", null)
                        .WithMany("Enderecos")
                        .HasForeignKey("PessoaIdPessoa");
                });

            modelBuilder.Entity("Domain.Entities.Logradouro", b =>
                {
                    b.HasOne("Domain.Entities.TipoLogradouro", "TipoLogradouro")
                        .WithMany("Logradouros")
                        .HasForeignKey("IdTipoLogradouro");

                    b.Navigation("TipoLogradouro");
                });

            modelBuilder.Entity("Domain.Entities.Regiao", b =>
                {
                    b.HasOne("Domain.Entities.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId");

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("Domain.Entities.Uf", b =>
                {
                    b.HasOne("Domain.Entities.Pais", "IdPaisNavigation")
                        .WithMany("Ufs")
                        .HasForeignKey("IdPais")
                        .IsRequired()
                        .HasConstraintName("fk_uf_pais");

                    b.Navigation("IdPaisNavigation");
                });

            modelBuilder.Entity("Domain.Entities.EntidadeEndereco", b =>
                {
                    b.Navigation("Enderecos");
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Navigation("Cidades");

                    b.Navigation("Ufs");
                });

            modelBuilder.Entity("Domain.Entities.Pessoa", b =>
                {
                    b.Navigation("Documentos");

                    b.Navigation("Enderecos");
                });

            modelBuilder.Entity("Domain.Entities.TipoLogradouro", b =>
                {
                    b.Navigation("Logradouros");
                });

            modelBuilder.Entity("Domain.Entities.Uf", b =>
                {
                    b.Navigation("Cidades");
                });
#pragma warning restore 612, 618
        }
    }
}
