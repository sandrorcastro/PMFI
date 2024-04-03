using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIVOT
{
    class Program_1
    {
        static void Main_1(string[] args)
        {
            //string connectionString = "coloque_sua_string_de_conexao_aqui";
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            var connectionString = configuration.GetConnectionString("Default");
            // Consulta SQL para selecionar os campos desejados da tabela Notificacoes
            //string query = @"SELECT NumeroNotificacao, Tributo, NomeTributo FROM Notificacoes";
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
                                    and TribNotificacaoDA.NotificacaoDANumero=2673";
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
                            // Crie uma lista para armazenar os resultados da consulta
                            List<Notificacao> resultados = new List<Notificacao>();

                            // Itere sobre as linhas retornadas pelo leitor de dados
                            while (reader.Read())
                            {
                                // Crie um objeto Notificacao e preencha com os dados da linha atual
                                Notificacao notificacao = new Notificacao
                                {
                                    NumeroNotificacao = reader["NumeroNotificacao"].ToString(),
                                    Tributo = Convert.ToInt32(reader["Tributo"]),
                                    NomeTributo = reader["NomeTributo"].ToString()
                                };

                                // Adicione o objeto à lista de resultados
                                resultados.Add(notificacao);
                            }

                            // Imprima os resultados
                            foreach (Notificacao notificacao in resultados)
                            {
                                Console.WriteLine("NumeroNotificacao: {0}, Tributo: {1}, NomeTributo: {2}",
                                    notificacao.NumeroNotificacao, notificacao.Tributo, notificacao.NomeTributo);
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

    // Classe para representar uma linha da tabela Notificacoes
    public class Notificacao
    {
        public string NumeroNotificacao { get; set; }
        public int Tributo { get; set; }
        public string NomeTributo { get; set; }
    }
}

