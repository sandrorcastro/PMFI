// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Data.SqlClient;
using System.Numerics;
using Microsoft.Extensions.Configuration;

namespace PIVOT
{
    class Program_
    {
        static void Main_(string[] args)

        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            var connectionString = configuration.GetConnectionString("Default");
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Execute suas consultas aqui
                using (var command = new SqlCommand("SELECT \r\n\t\tTribNotificacaoDA.NotificacaoDANumero As Numero ,\r\n\t\tTribNotificacaoDA.NotificacaoDAAno As AnoNotificacao,\r\n\t\tContribuintes.ConCNPJCPF AS Inscricao ,\r\n\t\t--TribLivroDividaAtiva.ConIDDivida AS IDDivida--, \r\n\t\tContribuintes.ConNome as ParaNome ,\r\n\t\t/*Concat(Contribuintes.ConTipoLograd,' ',Contribuintes.ConEndereco,', ',Contribuintes.ConNumero)  as ParaEndereco,\r\n\t\tContribuintes.ConComplemento as ParaComplemento,\r\n\t\t(select BaiNome From dbo.Bairro B where  B.BairroId = Contribuintes.ConBairroId ) as ParaBairro,\r\n\t\t(select CidNome From dbo.Cidade C where C.Cidadeid= contribuintes.ConCidadeId) as ParaCidade,\r\n\t\tContribuintes.ConCEP as ParaCEP,*/\r\n\t\tTribDividasContribuinte.TipoTribID ,\r\n\t\tTribTipoTributos.TipoTribNome ,\r\n\t\tTribDividasContribuinte.ConDivAno,\r\n\t\tTribDividasContribuinte.ConDivMes,\r\n\t\tTribDividasContribuinte.ConDivParcela,\r\n\t\tTribDividasContribuinte.ConDivVencimento,\r\n\t\tTribLivroDividaAtiva.DataInclusao,\r\n\t\tTribLivroDividaAtiva.LivroDASeq ,\r\n\t\tTribLivroDividaAtiva.LivroDANumero,\r\n\t\tTribLivroDividaAtiva.LivroDAID,\r\n\t\tTribLivroDividaAtiva.LivroDAFolha,\r\n\t\tTribDividasContribuinte.ConDivSubDivida, \r\n\t\tTribDividasContribuinte.ConDivAno,\r\n\t\tTribDividasContribuinte.ConDivValor,\r\n\t\tdbo.ValorCorrecao(TribDividasContribuinte.ConDivDataUltimaCorrecao, TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.ConDivVlrUltimaCorrecao, TribDividasContribuinte.ConDivDataBloqCorrecao, TribDividasContribuinte.TipoBxID, TribDividasContribuinte.ConDivDataBaixa, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.Correcao, TribDividasContribuinte.TipoTribID),\r\n\t\tdbo.ValorMulta(TribDividasContribuinte.ConDivVencimento, TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.ConDivValor + dbo.ValorCorrecao(TribDividasContribuinte.ConDivDataUltimaCorrecao, TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.ConDivVlrUltimaCorrecao, TribDividasContribuinte.ConDivDataBloqCorrecao, TribDividasContribuinte.TipoBxID, TribDividasContribuinte.ConDivDataBaixa, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.Correcao, TribDividasContribuinte.TipoTribID), TribDividasContribuinte.ConDivDataBloqMulta, TribDividasContribuinte.TipoBxID, TribDividasContribuinte.ConDivDataBaixa, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.Multa, TribDividasContribuinte.TipoTribID),\r\n\t\tdbo.ValorMultaDividaAtivaContribuintes(TribDividasContribuinte.ConIDDivida, TribDividasContribuinte.ConDivTipoDivida, TribDividasContribuinte.ConDivValor + dbo.ValorCorrecao(TribDividasContribuinte.ConDivDataUltimaCorrecao, TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.ConDivVlrUltimaCorrecao, TribDividasContribuinte.ConDivDataBloqCorrecao, TribDividasContribuinte.TipoBxID, TribDividasContribuinte.ConDivDataBaixa, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.Correcao, TribDividasContribuinte.TipoTribID), TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.MultaDividaAtiva),\r\n\t\tdbo.ValorJuros(TribDividasContribuinte.ConDivVencimento, TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.ConDivValor + dbo.ValorCorrecao(TribDividasContribuinte.ConDivDataUltimaCorrecao, TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.ConDivVlrUltimaCorrecao, TribDividasContribuinte.ConDivDataBloqCorrecao, TribDividasContribuinte.TipoBxID, TribDividasContribuinte.ConDivDataBaixa, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.Correcao, TribDividasContribuinte.TipoTribID), TribDividasContribuinte.ConDivDataBloqJuros, TribDividasContribuinte.TipoBxID, TribDividasContribuinte.ConDivDataBaixa, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.Juros, TribDividasContribuinte.TipoTribID)\r\n\t\t\t\t\t\t\t\t\t \r\n\tFROM TribNotificacaoDA \r\n\t\tJOIN TribLivroDividaAtiva ON TribNotificacaoDA.LivroDAID = TribLivroDividaAtiva.LivroDAID \r\n\t\tJOIN TribDividasContribuinte ON TribLivroDividaAtiva.ConIDDivida = TribDividasContribuinte.ConIDDivida AND ConDivExcluido IS NULL\r\n\t\tJOIN Contribuintes ON TribDividasContribuinte.ConID = Contribuintes.ConID \r\n\t\tJOIN TribTipoTributos ON TribDividasContribuinte.TipoTribID = TribTipoTributos.TipoTribID \r\n\t\tJOIN TribTextos ON TribNotificacaoDA.TextoID = TribTextos.TextoID\r\n\t\tLEFT JOIN TribAutosInfracao ON TribDividasContribuinte.AutoInfrID = TribAutosInfracao.AutoInfrID\r\n\tWHERE (TribNotificacaoDA.NotificacaoDAData >=  '01/11/2023' ) \r\n\t\tAND (TribNotificacaoDA.NotificacaoDAData <= '01/11/2023'  )\r\n\t\t --and TribNotificacaoDA.NotificacaoDANumero=2673", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                             string NumeroNotificacao = reader.GetInt64(0).ToString() ;  //    --GetInt32(0);
                             string AnoNotificacao = reader.GetInt16(1).ToString();
                             string Inscricao = reader.GetString(2).ToString();

                            Console.WriteLine($"NumeroNotificacao:{NumeroNotificacao}/{AnoNotificacao} Inscricao: {Inscricao} ");
                        }
                    }
                }
            }
        }
    }
}
