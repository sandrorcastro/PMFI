using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PIVOT
{
    class Program_2
    {
        static void Main_2(string[] args)
        {
            //string connectionString = "coloque_sua_string_de_conexao_aqui";
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            var connectionString = configuration.GetConnectionString("Default");

            // Consulta SQL para selecionar os campos desejados da tabela Notificacoes
            string query = @"SELECT 
                                    TribNotificacaoDA.NotificacaoDANumero As NumeroNotificacao ,
                                    TribNotificacaoDA.NotificacaoDAAno As AnoNotificacao,
                                    Contribuintes.ConCNPJCPF AS Inscricao , 
                                    --, \r\n\t\tContribuintes.ConNome as ParaNome ,
                                  --  Concat(Contribuintes.ConTipoLograd,' ',Contribuintes.ConEndereco,', ',Contribuintes.ConNumero)  as ParaEndereco,
                                   -- Contribuintes.ConComplemento as ParaComplemento,
                                   -- (select BaiNome From dbo.Bairro B where  B.BairroId = Contribuintes.ConBairroId ) as ParaBairro,
                                   -- (select CidNome From dbo.Cidade C where C.Cidadeid= contribuintes.ConCidadeId) as ParaCidade,
                                   -- Contribuintes.ConCEP as ParaCEP,
                                    TribDividasContribuinte.TipoTribID as Tributo ,
                                    TribTipoTributos.TipoTribNome As NomeTributo--,
                                   -- TribDividasContribuinte.ConDivAno,
                                    --TribDividasContribuinte.ConDivMes,
                                    --TribDividasContribuinte.ConDivParcela,
                                    --TribDividasContribuinte.ConDivVencimento,
                                    --TribLivroDividaAtiva.DataInclusao,
                                    --TribLivroDividaAtiva.LivroDASeq ,
                                    --TribLivroDividaAtiva.LivroDANumero,
                                    --TribLivroDividaAtiva.LivroDAID,
                                    --TribLivroDividaAtiva.LivroDAFolha,
                                    --TribDividasContribuinte.ConDivSubDivida,
                                    --TribDividasContribuinte.ConDivAno,
                                    --TribDividasContribuinte.ConDivValor,
                                    --dbo.ValorCorrecao(TribDividasContribuinte.ConDivDataUltimaCorrecao, TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.ConDivVlrUltimaCorrecao, TribDividasContribuinte.ConDivDataBloqCorrecao, TribDividasContribuinte.TipoBxID, TribDividasContribuinte.ConDivDataBaixa, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.Correcao, TribDividasContribuinte.TipoTribID),
                                    --dbo.ValorMulta(TribDividasContribuinte.ConDivVencimento, TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.ConDivValor + dbo.ValorCorrecao(TribDividasContribuinte.ConDivDataUltimaCorrecao, TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.ConDivVlrUltimaCorrecao, TribDividasContribuinte.ConDivDataBloqCorrecao, TribDividasContribuinte.TipoBxID, TribDividasContribuinte.ConDivDataBaixa, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.Correcao, TribDividasContribuinte.TipoTribID), TribDividasContribuinte.ConDivDataBloqMulta, TribDividasContribuinte.TipoBxID, TribDividasContribuinte.ConDivDataBaixa, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.Multa, TribDividasContribuinte.TipoTribID),
                                    --dbo.ValorMultaDividaAtivaContribuintes(TribDividasContribuinte.ConIDDivida, TribDividasContribuinte.ConDivTipoDivida, TribDividasContribuinte.ConDivValor + dbo.ValorCorrecao(TribDividasContribuinte.ConDivDataUltimaCorrecao, TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.ConDivVlrUltimaCorrecao, TribDividasContribuinte.ConDivDataBloqCorrecao, TribDividasContribuinte.TipoBxID, TribDividasContribuinte.ConDivDataBaixa, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.Correcao, TribDividasContribuinte.TipoTribID), TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.MultaDividaAtiva),
                                    --dbo.ValorJuros(TribDividasContribuinte.ConDivVencimento, TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.ConDivValor + dbo.ValorCorrecao(TribDividasContribuinte.ConDivDataUltimaCorrecao, TribNotificacaoDA.NotificacaoDAData, TribDividasContribuinte.ConDivVlrUltimaCorrecao, TribDividasContribuinte.ConDivDataBloqCorrecao, TribDividasContribuinte.TipoBxID, TribDividasContribuinte.ConDivDataBaixa, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.Correcao, TribDividasContribuinte.TipoTribID), TribDividasContribuinte.ConDivDataBloqJuros, TribDividasContribuinte.TipoBxID, TribDividasContribuinte.ConDivDataBaixa, TribDividasContribuinte.DataCalculo, TribDividasContribuinte.Juros, TribDividasContribuinte.TipoTribID)
                            FROM TribNotificacaoDA 
                                    JOIN TribLivroDividaAtiva ON TribNotificacaoDA.LivroDAID = TribLivroDividaAtiva.LivroDAID
                                    JOIN TribDividasContribuinte ON TribLivroDividaAtiva.ConIDDivida = TribDividasContribuinte.ConIDDivida AND ConDivExcluido IS NULL
                                    JOIN Contribuintes ON TribDividasContribuinte.ConID = Contribuintes.ConID 
                                    JOIN TribTipoTributos ON TribDividasContribuinte.TipoTribID = TribTipoTributos.TipoTribID 
                                    JOIN TribTextos ON TribNotificacaoDA.TextoID = TribTextos.TextoID
                                    LEFT JOIN TribAutosInfracao ON TribDividasContribuinte.AutoInfrID = TribAutosInfracao.AutoInfrID
                             WHERE (TribNotificacaoDA.NotificacaoDAData >=  '01/11/2023' ) 
                                    AND (TribNotificacaoDA.NotificacaoDAData <= '01/11/2023'  )
                                   -- and TribNotificacaoDA.NotificacaoDANumero=2673";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abra a conexão com o banco de dados
                    connection.Open();

                    // Crie um comando SQL e atribua a consulta e a conexão
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Execute o comando e obtenha um leitor de dados
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Crie um dicionário para armazenar os resultados agrupados por NumeroNotificacao
                            Dictionary<string, string> resultadosAgrupados = new Dictionary<string, string>();

                            // Itere sobre as linhas retornadas pelo leitor de dados
                            while (reader.Read())
                            {
                                // Obtenha os valores dos campos da linha atual
                                string numeroNotificacao = reader["NumeroNotificacao"].ToString();
                                string tributo = reader["Tributo"].ToString();
                                string nomeTributo = reader["NomeTributo"].ToString();

                                // Se o numeroNotificacao já existir no dicionário, adicione o tributo e nomeTributo ao valor existente
                                if (resultadosAgrupados.ContainsKey(numeroNotificacao))
                                {
                                    resultadosAgrupados[numeroNotificacao] += $", {tributo} - {nomeTributo}";
                                }
                                // Caso contrário, adicione uma nova entrada no dicionário
                                else
                                {
                                    resultadosAgrupados[numeroNotificacao] = $"{tributo} - {nomeTributo}";
                                }
                            }
                            // Imprima o cabeçalho das colunas
                            Console.WriteLine("NumeroNotificacao\tTributos");
                            // Imprima os resultados agrupados
                            foreach (var item in resultadosAgrupados)
                            {
                                Console.WriteLine("NumeroNotificacao: {0}, Tributos: {1}", item.Key, item.Value);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
