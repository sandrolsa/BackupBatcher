namespace Teste_1
{
    public class BatBackup
    {
        private readonly criaBat criaBat;
        private readonly dadosArq dadosArq;
        public BatBackup(criaBat cria, dadosArq dados)
        {
            criaBat = cria;
            dadosArq = dados;
        }
        public void Bat_Backup()
        {
            string Diretorio = @"C:\DATABASE\BACKUP\BAT\";
            string Arquivo = "backup.bat";
            string Bat =
                "@ECHO OFF\r\n\r\n" +
                ":: =========== CONFIGURAÇÕES BÁSICAS ===============\r\n::" +
                "=========== CONEXAO ===============\r\n\t" +
                "set \"SERVIDOR=" + criaBat.dadosServidor + "\"\r\n\t" +
                "set \"USUARIO=" + criaBat.dadosUsuario + "\"\r\n\t" +
                "set \"BANCO=" + criaBat.dadosBanco + "\"\r\n\t" +
                "set \"SENHA=" + criaBat.dadosSenha + "\"\r\n" +
                ":: =========== NOME-ARQUIVO ===============\r\n\t" +
                "set \"EMPRESA=" + dadosArq.dadosEmpresa + "\"\r\n\t" +
                "set \"CAIXA=" + dadosArq.dadosCaixa + "\"\r\n" +
                ":: =========== LOCAIS ===============\r\n\t" +
                "set \"BACKUP=" + dadosArq.backup + "\"\r\n\t" +
                "set \"COPIA=" + dadosArq.copia + "\"\r\n\t" +
                "set \"DIAS=" + dadosArq.qtdDias + "\"\r\n" +
                ":: --------------------------------------\r\n\t" +
                "set \"MYSQL=C:\\Program Files\\MySQL\\MySQL Server 5.7\\bin\\\"\r\n" +
                ":: --------------------------------------\r\n" +
                ":: =========== CONFIGURAÇÕES BÁSICAS ===============\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" +
                ":: ========= PARAMETROS =============\r\n\t" +
                "::captura data atual (AAMMDD)\r\n\t\t" +
                "for /f \"tokens=1-4 delims=/ \" %%a IN ('DATE /T') do (set MYDATE=%%c%%b%%a%)\r\n\t" +
                "::captura hora e minuto (HHhMMm)\r\n\t\tfor /f \"tokens=1-2 delims=: \" %%a in ('TIME /T') do (set MYTIME=%%ah%%bm)\r\n\t" +
                "::cria o arquivo (EMPRESA)\r\n\t\t" +
                "set \"FILE=%empresa%-%caixa%_%MYDATE:~2%-%MYTIME%\"\r\n" +
                ":: ========= PARAMETROS =============\r\n\r\n" +
                ":: ======== CHECA PASTA ===========\r\n\t" +
                "if exist %backup% (\r\n\t\t" +
                "call :dump\r\n\t\texit /b\r\n\t" +
                ") else (\r\n\t\t" +
                "mkdir %backup%\r\n\t\t" +
                "call :dump\r\n\t)\r\n" +
                ":: ======== CHECA PASTA ===========\r\n\r\n" +
                ":: ======== DUMP ===========\r\n\t" +
                ":dump\r\n\tCOLOR 0a\r\n\t" +
                "echo Backup em andamento...\r\n\t" +
                "\"%mysql%\"mysqldump -u %USUARIO% -p%SENHA% -h %SERVIDOR% %BANCO% --ssl-mode=disabled --routines --triggers --events -P3306 > \"%BACKUP%%FILE%.sql\"\r\n" +
                ":: ======== DUMP ===========\r\n\r\n\r\n" +
                ":: ======== ZIP ===========\r\n\t" +
                "if exist c:\\windows\\system32\\7z.exe (\r\n\t\t" +
                "call :zip\r\n\t\texit /b\r\n\t" +
                ") else (\r\n\t\t" +
                "copy %~f1\\7z\\* c:\\windows\\system32\\\r\n\t\t" +
                "call :zip\r\n\t)\r\n\t" +
                ":zip\r\n\t\t" +
                "7z a %backup%%file%.rar %backup%%file%.sql -sdel\r\n" +
                ":: ======== ZIP ===========\r\n\r\n" +
                ":: ======== DELETA ANTIGOS ===========\r\n\t" +
                "forfiles -p %BACKUP% -m *.rar -d -%DIAS% -c \"cmd /c del %copia%@PATH\"\r\n\t" +
                "forfiles -p %BACKUP% -m *.rar -d -%DIAS% -c \"cmd /c del @PATH\"\r\n" +
                ":: ======== DELETA ANTIGOS ===========\r\n\r\n" +
                ":: ======== COPIA ARQUIVO ===========\r\n\t" +
                ":copy\r\n\tif exist \"%COPIA%\" (\r\n\t\t" +
                "copy %backup%%file%.rar \"%COPIA%\" /y\r\n\t\t" +
                "exit /b\r\n\t" +
                ") else (\r\n\t\t" +
                "mkdir \"%COPIA%\"\r\n\t\t" +
                "call :copy\r\n\t" +
                ")\r\n" +
                ":: ======== COPIA ARQUIVO ===========\r\n\r\n" +
                "@echo exit";
            if (string.IsNullOrEmpty(criaBat.dadosSenha))
            {
                Bat = Bat.Replace(" -p%SENHA% ", " ");
            }
            if (!Directory.Exists(Diretorio))
            {
                // Se não existir, cria a pasta
                _ = Directory.CreateDirectory(Diretorio);
            }
            File.WriteAllText(Path.Combine(Diretorio, Arquivo), Bat);
        }
    }
}