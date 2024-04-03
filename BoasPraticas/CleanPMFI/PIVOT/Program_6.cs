using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

class Program_6
{
    static void Main_6()
    {
        //string connectionString = "coloque_sua_string_de_conexao_aqui";
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
                                 --  and TribNotificacaoDA.NotificacaoDANumero=2673";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            Dictionary<string, List<string>> notificacoes = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> dividas = new Dictionary<string, List<string>>();

            while (reader.Read())
            {
                string numeroNotificacao = reader["NumeroNotificacao"].ToString();
                //string anoNotificacao = reader["AnoNotificacao"].ToString();
                string inscricao = reader["Inscricao"].ToString();
             //   string tributo = reader["Tributo"].ToString();
              //  string nomeTributo = reader["NomeTributo"].ToString();

                string tituloTributo = reader["TituloTributo"].ToString();
                string anoDivida = reader["AnoDivida"].ToString();
                string mesDivida = reader["MesDivida"].ToString();
                string parcela = reader["Parcela"].ToString();
                string vencimento = reader["Vencimento"].ToString();
                string dataInscricao = reader["DataInscricao"].ToString();
                string inscricaoDA = reader["InscricaoDA"].ToString();
                string livro = reader["Livro"].ToString();
                string livroIDFol = reader["LivroIDFol"].ToString();
                string lancamento = reader["Lancamento"].ToString();
                string valorPrincipal = reader["ValorPrincipal"].ToString();
                string atM = reader["AtM"].ToString();
                string mMora = reader["MMora"].ToString();
                string mDAt = reader["MDAt"].ToString();
                string juros = reader["Juros"].ToString();
                if (!notificacoes.ContainsKey(numeroNotificacao))
                {
                    notificacoes[numeroNotificacao] = new List<string>();
                }
              
                //notificacoes[numeroNotificacao].Add(anoNotificacao);
                //notificacoes[numeroNotificacao].Add(inscricao);

               // notificacoes[numeroNotificacao].Add(tributo);
               // notificacoes[numeroNotificacao].Add(nomeTributo);
                notificacoes[numeroNotificacao].Add(tituloTributo);
                notificacoes[numeroNotificacao].Add(anoDivida);
                notificacoes[numeroNotificacao].Add(mesDivida);
                notificacoes[numeroNotificacao].Add(parcela);
                notificacoes[numeroNotificacao].Add(vencimento);
                notificacoes[numeroNotificacao].Add(dataInscricao);
                notificacoes[numeroNotificacao].Add(inscricaoDA);
                notificacoes[numeroNotificacao].Add(livro);
                notificacoes[numeroNotificacao].Add(livroIDFol);
                notificacoes[numeroNotificacao].Add(lancamento);
                notificacoes[numeroNotificacao].Add(valorPrincipal);
                notificacoes[numeroNotificacao].Add(atM);
                notificacoes[numeroNotificacao].Add(mMora);
                notificacoes[numeroNotificacao].Add(mDAt);
                notificacoes[numeroNotificacao].Add(juros);
            }

            foreach (var item in notificacoes)
            {
                Console.Write($"{item.Key} ");

                foreach (var value in item.Value)
                {
                    Console.Write($"{value} ");
                }

                Console.WriteLine();
            }

            reader.Close();
        }
    }
}
