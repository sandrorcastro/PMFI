using System;
using System.Collections;
using System.Configuration;
using System.Runtime.Remoting;
using BlazorWebAppITBI.Model;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
//using RemoGeraCrystalPDF;
//namespace BlazorWebAppITBI.Uteis;

//esta classe até agora não tem utilidade
namespace clsGeraCrystalPDF
{

    #region assembly clsGeraCrystalPDF, Version=1.0.1748.33409, Culture=neutral, PublicKeyToken=null
    // C:\tfs-GIIGNet\GIIGNet\Bibliotecas\Bibliotecas\NET\clsGeraCrystalPDF.dll
    // Decompiled with ICSharpCode.Decompiler 8.1.1.7464
    #endregion
    public class cGeraCrystalPDF : MarshalByRefObject
    {
        public IOptions<AppSettings> AppSettings;
        private cGeraCrystalPDF geraPDFComPlus;

        private string lLogin;

        private string lPathPDF;

        private string lNomeRelatorio;

        private string lNomeRelatorioAmigavel;

        private string lErro;

        private string lUsuario;

        private ArrayList ArrSortField;

        private ArrayList ArrParameterField;

        private ArrayList ArrFormulas;

        private ArrayList ArrSubReport;

        public string pErro
        {
            get
            {
                if (StringType.StrCmp(Strings.Trim(geraPDFComPlus.pErro), "", TextCompare: false) != 0)
                {
                    return geraPDFComPlus.pErro;
                }

                return lErro;
            }
            set
            {
                lErro = value;
            }
        }

        public ArrayList mSortField => ArrSortField;

        public ArrayList mParameterField => ArrParameterField;

        public ArrayList mFormulas => ArrFormulas;

        public ArrayList SubReport => ArrSubReport;

        public string Servidor
        {
            set
            {
                geraPDFComPlus.Servidor = value;
            }
        }

        public string Database
        {
            set
            {
                geraPDFComPlus.Database = value;
            }
        }

        public string Usuario
        {
            set
            {
                geraPDFComPlus.Usuario = value;
                lUsuario = value;
            }
        }

        public string Senha
        {
            set
            {
                geraPDFComPlus.Senha = value;
            }
        }

        public string PathFile
        {
            set
            {
                if (Information.IsNothing(AppSettings.Value.PathRPT))
                {
                    throw new Exception("Parâmetro PathPRT para gerar o relatório não informado.");
                }

                string newValue = AppSettings.Value.PathRPT;
                geraPDFComPlus.PathFile = value.Replace(Strings.Mid(value, 1, value.LastIndexOf("\\")), newValue);
            }
        }

        public string pSelectionFormula
        {
            set
            {
                geraPDFComPlus.pSelectionFormula = value;
            }
        }

        public string TituloRel
        {
            set
            {
                geraPDFComPlus.TituloRel = value;
            }
        }

        public string PathPDF
        {
            set
            {
                geraPDFComPlus.PathPDF = value;
                lPathPDF = value;
            }
        }

        public string NomeRelatorio
        {
            set
            {
                geraPDFComPlus.NomeRelatorio = value;
                lNomeRelatorio = Strings.Replace(Strings.LCase(value), ".rpt", ".pdf");
            }
        }

        //public cGeraCrystalPDF(IOptions<AppSettings> _AppSettings)
        public cGeraCrystalPDF()
        {
            //AppSettings = new Options<AppSettings>();
            //IL_00c1: Unknown result type (might be due to invalid IL or missing references)
            //IL_00cb: Expected O, but got Unknown
            ArrSortField = new ArrayList();
            ArrParameterField = new ArrayList();
            ArrFormulas = new ArrayList();
            ArrSubReport = new ArrayList();
            //if (Information.IsNothing(ConfigurationSettings.AppSettings["ServerCrystalPDF"]))
            if (Information.IsNothing(AppSettings.Value.ServerCrystalPDF))
            {
                throw new Exception("Parâmetro ServerCrystalPDF para gerar o relatório não informado.");
            }

            string text = AppSettings.Value.ServerCrystalPDF;
            bool flag = false;
       //--     ActivatedClientTypeEntry[] registeredActivatedClientTypes = RemotingConfiguration.GetRegisteredActivatedClientTypes();
          //--  int num = Information.UBound(registeredActivatedClientTypes);
           /*--     if (StringType.StrCmp(Strings.UCase(registeredActivatedClientTypes[i].ObjectType.FullName), Strings.UCase("RemoGeraCrystalPDF.cGeraCrystalPDF"), TextCompare: false) == 0)
            for (int i = 0; i <= num; i = checked(i + 1))
            {
                {
                    flag = true;
                    break;
            }

            if (!flag)
            {
               //-- RemotingConfiguration.RegisterActivatedClientType(typeof(cGeraCrystalPDF), text);
            }
                }*/

            geraPDFComPlus = new cGeraCrystalPDF();
            string text2 = AppSettings.Value.MsgSpooler;
            if (Information.IsNothing(text2))
            {
                //  geraPDFComPlus.MsgSpooler = "Atenção o parâmetro da aplicação  'MsgSpooler' com a Mensagem do Spooler não foi encontrada.";
            }
            else
            {
                // geraPDFComPlus.MsgSpooler = text2;
            }
        }

        public void GeraPDF()
        {
            try
            {
                if (Information.IsNothing(AppSettings.Value.MaxPDFSize))
                {
                    throw new Exception("Parâmetro MaxPDFSize para gerar o relatório não informado.");
                }

                //  geraPDFComPlus.MaxPDFSize = LongType.FromString(AppSettings.Value.MaxPDFSize);
               //-- geraPDFComPlus.GeraPDF(ArrSortField.ToArray(), ArrParameterField.ToArray(), ArrFormulas.ToArray(), ArrSubReport.ToArray());
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                throw new Exception(ex2.Message);
            }
        }
    }
#if false // Log de descompilação
'331' itens no cache
------------------
Resolver: 'mscorlib, Version=1.0.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Foi encontrado um assembly: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
AVISO: incompatibilidade de versão. Esperado: '1.0.3300.0', Obtido: '4.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\mscorlib.dll'
------------------
Resolver: 'Microsoft.VisualBasic, Version=7.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'Microsoft.VisualBasic, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '7.0.3300.0', Obtido: '10.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\Microsoft.VisualBasic.dll'
------------------
Resolver: 'System, Version=1.0.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Foi encontrado um assembly: 'System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
AVISO: incompatibilidade de versão. Esperado: '1.0.3300.0', Obtido: '4.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.dll'
------------------
Resolver: 'System.Data, Version=1.0.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Foi encontrado um assembly: 'System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
AVISO: incompatibilidade de versão. Esperado: '1.0.3300.0', Obtido: '4.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Data.dll'
------------------
Resolver: 'System.Xml, Version=1.0.3300.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Foi encontrado um assembly: 'System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
AVISO: incompatibilidade de versão. Esperado: '1.0.3300.0', Obtido: '4.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Xml.dll'
------------------
Resolver: 'Interop.VBA, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null'
Não foi possível encontrá-lo por nome: 'Interop.VBA, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null'
------------------
Resolver: 'RemoGeraCrystalPDF, Version=1.0.1748.33069, Culture=neutral, PublicKeyToken=null'
Não foi possível encontrá-lo por nome: 'RemoGeraCrystalPDF, Version=1.0.1748.33069, Culture=neutral, PublicKeyToken=null'
------------------
Resolver: 'Microsoft.Win32.Registry, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'Microsoft.Win32.Registry, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\Microsoft.Win32.Registry.dll'
------------------
Resolver: 'System.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Runtime.dll'
------------------
Resolver: 'System.Security.Principal.Windows, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Security.Principal.Windows, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Security.Principal.Windows.dll'
------------------
Resolver: 'System.Security.Permissions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Não foi possível encontrá-lo por nome: 'System.Security.Permissions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
------------------
Resolver: 'System.Collections, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Collections, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Collections.dll'
------------------
Resolver: 'System.Collections.NonGeneric, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Collections.NonGeneric, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Collections.NonGeneric.dll'
------------------
Resolver: 'System.Collections.Concurrent, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Collections.Concurrent, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Collections.Concurrent.dll'
------------------
Resolver: 'System.ObjectModel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.ObjectModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.ObjectModel.dll'
------------------
Resolver: 'System.Console, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Console, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Console.dll'
------------------
Resolver: 'System.Runtime.InteropServices, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Runtime.InteropServices.dll'
------------------
Resolver: 'System.Diagnostics.Contracts, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Diagnostics.Contracts, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Diagnostics.Contracts.dll'
------------------
Resolver: 'System.Diagnostics.StackTrace, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Diagnostics.StackTrace, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Diagnostics.StackTrace.dll'
------------------
Resolver: 'System.Diagnostics.Tracing, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Diagnostics.Tracing, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Diagnostics.Tracing.dll'
------------------
Resolver: 'System.IO.FileSystem.DriveInfo, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.IO.FileSystem.DriveInfo, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.IO.FileSystem.DriveInfo.dll'
------------------
Resolver: 'System.IO.IsolatedStorage, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.IO.IsolatedStorage, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.IO.IsolatedStorage.dll'
------------------
Resolver: 'System.ComponentModel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.ComponentModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.ComponentModel.dll'
------------------
Resolver: 'System.Threading.Thread, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Threading.Thread, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Threading.Thread.dll'
------------------
Resolver: 'System.Reflection.Emit, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Reflection.Emit, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Reflection.Emit.dll'
------------------
Resolver: 'System.Reflection.Emit.ILGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Reflection.Emit.ILGeneration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Reflection.Emit.ILGeneration.dll'
------------------
Resolver: 'System.Reflection.Emit.Lightweight, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Reflection.Emit.Lightweight, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Reflection.Emit.Lightweight.dll'
------------------
Resolver: 'System.Reflection.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Reflection.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Reflection.Primitives.dll'
------------------
Resolver: 'System.Resources.Writer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Resources.Writer, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Resources.Writer.dll'
------------------
Resolver: 'System.Runtime.CompilerServices.VisualC, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Runtime.CompilerServices.VisualC, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Runtime.CompilerServices.VisualC.dll'
------------------
Resolver: 'System.Runtime.Serialization.Formatters, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Runtime.Serialization.Formatters, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Runtime.Serialization.Formatters.dll'
------------------
Resolver: 'System.Security.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Security.AccessControl.dll'
------------------
Resolver: 'System.IO.FileSystem.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.IO.FileSystem.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.IO.FileSystem.AccessControl.dll'
------------------
Resolver: 'System.Threading.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Não foi possível encontrá-lo por nome: 'System.Threading.AccessControl, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
------------------
Resolver: 'System.Security.Claims, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Security.Claims, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Security.Claims.dll'
------------------
Resolver: 'System.Security.Cryptography, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Security.Cryptography, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Security.Cryptography.dll'
------------------
Resolver: 'System.Text.Encoding.Extensions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Text.Encoding.Extensions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Text.Encoding.Extensions.dll'
------------------
Resolver: 'System.Threading, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Threading, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Threading.dll'
------------------
Resolver: 'System.Threading.Overlapped, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Threading.Overlapped, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Threading.Overlapped.dll'
------------------
Resolver: 'System.Threading.ThreadPool, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Threading.ThreadPool, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Threading.ThreadPool.dll'
------------------
Resolver: 'System.Threading.Tasks.Parallel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Threading.Tasks.Parallel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Threading.Tasks.Parallel.dll'
------------------
Resolver: 'Microsoft.VisualBasic.Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'Microsoft.VisualBasic.Core, Version=13.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '13.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\Microsoft.VisualBasic.Core.dll'
------------------
Resolver: 'System.CodeDom, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Não foi possível encontrá-lo por nome: 'System.CodeDom, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
------------------
Resolver: 'Microsoft.Win32.SystemEvents, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Não foi possível encontrá-lo por nome: 'Microsoft.Win32.SystemEvents, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
------------------
Resolver: 'System.Diagnostics.Process, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Diagnostics.Process, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Diagnostics.Process.dll'
------------------
Resolver: 'System.Collections.Specialized, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Collections.Specialized, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Collections.Specialized.dll'
------------------
Resolver: 'System.ComponentModel.TypeConverter, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.ComponentModel.TypeConverter, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.ComponentModel.TypeConverter.dll'
------------------
Resolver: 'System.ComponentModel.EventBasedAsync, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.ComponentModel.EventBasedAsync, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.ComponentModel.EventBasedAsync.dll'
------------------
Resolver: 'System.ComponentModel.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.ComponentModel.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.ComponentModel.Primitives.dll'
------------------
Resolver: 'Microsoft.Win32.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'Microsoft.Win32.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\Microsoft.Win32.Primitives.dll'
------------------
Resolver: 'System.Configuration.ConfigurationManager, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Não foi possível encontrá-lo por nome: 'System.Configuration.ConfigurationManager, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
------------------
Resolver: 'System.Diagnostics.TraceSource, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Diagnostics.TraceSource, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Diagnostics.TraceSource.dll'
------------------
Resolver: 'System.Diagnostics.TextWriterTraceListener, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Diagnostics.TextWriterTraceListener, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Diagnostics.TextWriterTraceListener.dll'
------------------
Resolver: 'System.Diagnostics.PerformanceCounter, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Não foi possível encontrá-lo por nome: 'System.Diagnostics.PerformanceCounter, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
------------------
Resolver: 'System.Diagnostics.EventLog, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Foi encontrado um assembly: 'System.Diagnostics.EventLog, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.AspNetCore.App.Ref\8.0.6\ref\net8.0\System.Diagnostics.EventLog.dll'
------------------
Resolver: 'System.Diagnostics.FileVersionInfo, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Diagnostics.FileVersionInfo, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Diagnostics.FileVersionInfo.dll'
------------------
Resolver: 'System.IO.Compression, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Foi encontrado um assembly: 'System.IO.Compression, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.IO.Compression.dll'
------------------
Resolver: 'System.IO.FileSystem.Watcher, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.IO.FileSystem.Watcher, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.IO.FileSystem.Watcher.dll'
------------------
Resolver: 'System.IO.Ports, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Não foi possível encontrá-lo por nome: 'System.IO.Ports, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
------------------
Resolver: 'System.Windows.Extensions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Não foi possível encontrá-lo por nome: 'System.Windows.Extensions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
------------------
Resolver: 'System.Net.Requests, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.Requests, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Net.Requests.dll'
------------------
Resolver: 'System.Net.Primitives, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Net.Primitives.dll'
------------------
Resolver: 'System.Net.HttpListener, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Foi encontrado um assembly: 'System.Net.HttpListener, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Net.HttpListener.dll'
------------------
Resolver: 'System.Net.ServicePoint, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Foi encontrado um assembly: 'System.Net.ServicePoint, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Net.ServicePoint.dll'
------------------
Resolver: 'System.Net.NameResolution, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.NameResolution, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Net.NameResolution.dll'
------------------
Resolver: 'System.Net.WebClient, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Foi encontrado um assembly: 'System.Net.WebClient, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Net.WebClient.dll'
------------------
Resolver: 'System.Net.WebHeaderCollection, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.WebHeaderCollection, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Net.WebHeaderCollection.dll'
------------------
Resolver: 'System.Net.WebProxy, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Foi encontrado um assembly: 'System.Net.WebProxy, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Net.WebProxy.dll'
------------------
Resolver: 'System.Net.Mail, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Foi encontrado um assembly: 'System.Net.Mail, Version=8.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Net.Mail.dll'
------------------
Resolver: 'System.Net.NetworkInformation, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.NetworkInformation, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Net.NetworkInformation.dll'
------------------
Resolver: 'System.Net.Ping, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.Ping, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Net.Ping.dll'
------------------
Resolver: 'System.Net.Security, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.Security, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Net.Security.dll'
------------------
Resolver: 'System.Net.Sockets, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.Sockets, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Net.Sockets.dll'
------------------
Resolver: 'System.Net.WebSockets.Client, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.WebSockets.Client, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Net.WebSockets.Client.dll'
------------------
Resolver: 'System.Net.WebSockets, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.WebSockets, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Net.WebSockets.dll'
------------------
Resolver: 'System.Text.RegularExpressions, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Text.RegularExpressions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Text.RegularExpressions.dll'
------------------
Resolver: 'System.Data.SqlClient, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Não foi possível encontrá-lo por nome: 'System.Data.SqlClient, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
------------------
Resolver: 'System.Data.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Data.Common, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Data.Common.dll'
------------------
Resolver: 'System.Data.Odbc, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Não foi possível encontrá-lo por nome: 'System.Data.Odbc, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
------------------
Resolver: 'System.Data.OleDb, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Não foi possível encontrá-lo por nome: 'System.Data.OleDb, Version=0.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
------------------
Resolver: 'System.Xml.ReaderWriter, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Xml.ReaderWriter, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Xml.ReaderWriter.dll'
------------------
Resolver: 'System.Xml.XmlSerializer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Xml.XmlSerializer, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Xml.XmlSerializer.dll'
------------------
Resolver: 'System.Xml.XPath, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Xml.XPath, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
AVISO: incompatibilidade de versão. Esperado: '0.0.0.0', Obtido: '8.0.0.0'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Xml.XPath.dll'
------------------
Resolver: 'System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Runtime.dll'
------------------
Resolver: 'System.ComponentModel.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.ComponentModel.Primitives, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.ComponentModel.Primitives.dll'
------------------
Resolver: 'System.ObjectModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.ObjectModel, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.ObjectModel.dll'
------------------
Resolver: 'System.Net.WebHeaderCollection, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Net.WebHeaderCollection, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Net.WebHeaderCollection.dll'
------------------
Resolver: 'System.Xml.ReaderWriter, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Foi encontrado um assembly: 'System.Xml.ReaderWriter, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Carregar de: 'C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\8.0.6\ref\net8.0\System.Xml.ReaderWriter.dll'
#endif
}