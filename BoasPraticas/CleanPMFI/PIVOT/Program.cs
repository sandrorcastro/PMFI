using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace PIVOT
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            var connectionString = configuration.GetConnectionString("Default");

            // Consulta SQL para selecionar os campos desejados da tabela Notificacoes

            string queryString = @"SET LANGUAGE 'Portuguese';
                                SELECT 
                                Concat(RIGHT('000000' + Cast(TribNotificacaoDA.NotificacaoDANumero as varchar(6)),6) ,'/',TribNotificacaoDA.NotificacaoDAAno) AS NumeroNotificacao,
                                    --TribNotificacaoDA.NotificacaoDANumero As NumeroNotificacao,
                                    --TribNotificacaoDA.NotificacaoDAAno As AnoNotificacao,
                                    Contribuintes.ConCNPJCPF AS Inscricao, 
                                    Contribuintes.ConNome as ParaNome ,
                                  --  Concat(Contribuintes.ConTipoLograd,' ',Contribuintes.ConEndereco,', ',Contribuintes.ConNumero)  as ParaEndereco,
                                   -- Contribuintes.ConComplemento as ParaComplemento,
                                   -- (select BaiNome From dbo.Bairro B where  B.BairroId = Contribuintes.ConBairroId ) as ParaBairro,
                                   -- (select CidNome From dbo.Cidade C where C.Cidadeid= contribuintes.ConCidadeId) as ParaCidade,
                                   -- Contribuintes.ConCEP as ParaCEP,
                                  concat(TribDividasContribuinte.TipoTribID,'-',TribTipoTributos.TipoTribNome) As TituloTributo,
                                    --  TribDividasContribuinte.TipoTribID as Tributo ,
                                    -- TribTipoTributos.TipoTribNome As NomeTributo,
                                    TribDividasContribuinte.ConDivAno As AnoDivida,
                                    TribDividasContribuinte.ConDivMes As MesDivida,
                                    TribDividasContribuinte.ConDivParcela As Parcela ,
                                    Format(TribDividasContribuinte.ConDivVencimento,'%d/%M/%y') As Vencimento,
                                    Format(TribLivroDividaAtiva.DataInclusao,'%d/%M/%y') As DataInscricao,
                                    TribLivroDividaAtiva.LivroDASeq As InscricaoDA,
                                    TribLivroDividaAtiva.LivroDANumero As Livro,
                                    concat(TribLivroDividaAtiva.LivroDAID,' ',TribLivroDividaAtiva.LivroDAFolha) As LivroIDFol,
                                    CAST(TribDividasContribuinte.ConDivSubDivida AS VARCHAR(15)) + '/' + CAST(TribDividasContribuinte.ConDivAno AS VARCHAR(5)) As Lancamento,
                                      format(TribDividasContribuinte.ConDivValor,'N','pt_BR') AS ValorPrincipal,
                                    --TribDividasContribuinte.ConDivAno,
                                    --TribDividasContribuinte.ConDivValor,
                                    format(dbo.ValorCorrecao(TribDividasContribuinte.ConDivDataUltimaCorrecao, TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.ConDivVlrUltimaCorrecao, TribDividasContribuinte.ConDivDataBloqCorrecao, TribDividasContribuinte.TipoBxID, TribDividasContribuinte.ConDivDataBaixa, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.Correcao, TribDividasContribuinte.TipoTribID),'N','pt-BR') As AtM,
                                    format(dbo.ValorMulta(TribDividasContribuinte.ConDivVencimento, TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.ConDivValor + dbo.ValorCorrecao(TribDividasContribuinte.ConDivDataUltimaCorrecao, TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.ConDivVlrUltimaCorrecao, TribDividasContribuinte.ConDivDataBloqCorrecao, TribDividasContribuinte.TipoBxID, TribDividasContribuinte.ConDivDataBaixa, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.Correcao, TribDividasContribuinte.TipoTribID), TribDividasContribuinte.ConDivDataBloqMulta, TribDividasContribuinte.TipoBxID, TribDividasContribuinte.ConDivDataBaixa, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.Multa, TribDividasContribuinte.TipoTribID),'N','pt-BR') As MMora,
                                    format(dbo.ValorMultaDividaAtivaContribuintes(TribDividasContribuinte.ConIDDivida, TribDividasContribuinte.ConDivTipoDivida, TribDividasContribuinte.ConDivValor + dbo.ValorCorrecao(TribDividasContribuinte.ConDivDataUltimaCorrecao, TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.ConDivVlrUltimaCorrecao, TribDividasContribuinte.ConDivDataBloqCorrecao, TribDividasContribuinte.TipoBxID, TribDividasContribuinte.ConDivDataBaixa, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.Correcao, TribDividasContribuinte.TipoTribID), TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.MultaDividaAtiva),'N','pt-BR') As MDAt,
                                    format(dbo.ValorJuros(TribDividasContribuinte.ConDivVencimento, TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.ConDivValor + dbo.ValorCorrecao(TribDividasContribuinte.ConDivDataUltimaCorrecao, TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.ConDivVlrUltimaCorrecao, TribDividasContribuinte.ConDivDataBloqCorrecao, TribDividasContribuinte.TipoBxID, TribDividasContribuinte.ConDivDataBaixa, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.Correcao, TribDividasContribuinte.TipoTribID), TribDividasContribuinte.ConDivDataBloqJuros, TribDividasContribuinte.TipoBxID, TribDividasContribuinte.ConDivDataBaixa, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.Juros, TribDividasContribuinte.TipoTribID),'N','pt-BR') As Juros
                            FROM TribNotificacaoDA 
                                    JOIN TribLivroDividaAtiva ON TribNotificacaoDA.LivroDAID = TribLivroDividaAtiva.LivroDAID
                                    JOIN TribDividasContribuinte ON TribLivroDividaAtiva.ConIDDivida = TribDividasContribuinte.ConIDDivida AND ConDivExcluido IS NULL
                                    JOIN Contribuintes ON TribDividasContribuinte.ConID = Contribuintes.ConID 
                                    JOIN TribTipoTributos ON TribDividasContribuinte.TipoTribID = TribTipoTributos.TipoTribID 
                                    JOIN TribTextos ON TribNotificacaoDA.TextoID = TribTextos.TextoID
                                    LEFT JOIN TribAutosInfracao ON TribDividasContribuinte.AutoInfrID = TribAutosInfracao.AutoInfrID
                             WHERE (TribNotificacaoDA.NotificacaoDAData >=  '01/11/2023' ) 
                                    AND (TribNotificacaoDA.NotificacaoDAData <= '01/11/2023'  )
                               --  and TribNotificacaoDA.NotificacaoDANumero=2665";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var query = queryString;

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                      //  Console.WriteLine("Numero | Tributo | Nome | SEQ");
                      //  Console.WriteLine("-----------------------------------------");

                        while (reader.Read())
                        {
                            var numero = reader["NumeroNotificacao"].ToString();
                            var tributos = reader.GetString(1);
                            var nomes = reader.GetString(2);
                            var seqs = reader.GetString(3);

                            Console.WriteLine($"{numero} | {tributos} | {nomes} | {seqs}");
                            
                        }
                    }
                }
            }
        }
    }
}
