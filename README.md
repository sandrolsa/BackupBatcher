
# Backup Batcher

Backup Batcher é uma ferramenta para facilitar a criação, manipulação e agendamento de backups de rotina em bancos de dados mysql local.


## Usabilidade

O software é bem intuitivo e possui 3 botões principais:

    - Criar
    - Agendar
    - Excluir

## Tela Principal:
O primeiro botão como o nome sugere possui a função de criar o arquivo "backup.bat" que será alocado no diretório "C:\Database\Backup\BAT\". 

O segundo botão "Agendar" possui a função de agendar a bat no Agendador de Tarefas do Windows para ser executado diratiamente no horário definido pelo usuário.

O terceiro botão faz a exclusão tanto do arquivo "backup.bat" quanto da tarefa "BackupDiario" no agendador de tarefas.

## Criar:
Ao pressionar o botão "Criar" será exibido a tela de configurações iniciais do arquivo:

    - Hospedagem: hostname ou ip do servidor.
    - Usuario: user id ou user name do servidor.
    - Banco: shcemename do banco mysql.
    - Senha: a senha de acesso ao banco.

Estes campos possuem um PlaceHolder Text de sugestão do que pode ser preenchido. Caso nada seja preenchido o sistema assumirá o valor PlaceHolder como padrão.

    - DbMysql: botão para carregar os dados de conexão de um arquivo DbMysql.ini.
    - Testar: botão para testar conexão com o banco MySql via MySql.Data.

Caso a conexão não seja bem sucedida o sistema irá retornar a mensagem de erro da conexão informando se houve conexão com o host ou se o usuário/senha estão incorretos.

A tela seguinte é a de configuração do arquivo de dump.

    - Empresa/Filial: o nome da empresa ou filial desse banco.
    - Caixa: o número do caixa ou da empresa (ex E99).
    - Caminho Backup: o diretório onde o arquivo .sql ou .rar será extraído.
    - Caminho Copia: o diretório de um micro na rede com pasta compartilhada para realizar uma cópia do dump.

Estas configurações vão criar um arquivo com o padrão: 

"EMPRESA-CX00-DDMMAA-HHhMMm".

Exemplo: PELADINHO-E99-271024-14h42m.sql

Se o 7z-dos ou 7z-console estiver instalado, a bat automaticamente comprime o arquivo .sql em .rar reduzindo consideramente o seu tamanho.

## Agendar:
Ao pressionar o botão "Agendar" será exibido a tela de configuração do horário de execução da bat:

    - Horário da Tarefa: selecionar o horário em que a bat será executada todos os dias.
    - Botão Confirmar: cria a tarefa.
    - Para cancelar é só fechar a janela através do "X" no cantosuperior direito.

## Excluir:
Ao pressionar o botão "Excluir" o sistema vai excluir:

    - Tarefa "BackupDiário" no Agendador de Tarefas do Windows.
    - Arquivo bat localizado em C:\DATABASE\BACKUP\BAT\

## Funcionalidades

- Criar arquivo backup.bat
- Carregar dados de conexão de um arquivo DbMysql.ini
- Testar conexão com banco de dados.
- Agendar rotina de backup no Agendador de Tarefas do Windows
- Excluir bat e tarefa do agendador.


## Feedback

Se você tiver algum feedback, por favor deixe-me saber através do contato: sandro.luiz@totalcontrol.com


## Autores

- [@sandrolsa](https://github.com/sandrolsa)
## Referência
 
 - [@prof.tiagotas](https://www.youtube.com/@prof.tiagotas)
 - [@cfbcursos](https://www.youtube.com/@cfbcursos)
  - [OpenIA - Chat Gpt](https://chatgpt.com/)
