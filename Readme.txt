Versão v1.2:
Corrigido alguns bugs nos formulários e caixas de diálogo.
	- O título dos formulários estava com o nome do formulário.
	- O formulário "CriaBat" estava permitindo redimensionamento da janela.
	- TabIndex estava invertido em alguns campos.
	- O TextBox para senha estava recebendo o valor de PlaceHolderText quando nulo ou empty.
	- As caixas de dialógo não estava exibindo o valor do erro.
	- Crash do sistema em campos não anuláveis com valor nulo.

Adicionado as seguintes funcionalidades:
	- Adicionado ícone 256x256 ao sistema.
	- Adicionado ícone nos formulários.
	- Adicionado ícone nos botões "buscar diretório".
	- Adicionado funcionalidade DbMysql para ler um arquivo .ini e preencher os campos de conexão.
	- Adicionado botão para testar conexão com banco de dados MySql.
	- Adicionado função para deixar senha em branco e alterar a bat para realizar o dump sem exigir senha.
	- Adicionado função "buscar diretório" nos botões para carregar os diretórios de backup e cópia na rede.
	- Adicionado função para agendar a bat no agendador de tarefas para criar o backup diário com horário definido pelo usuário.
	- Adicionado função para excluir o arquivo de bat e tarefa do agendador de tarefas.
	- Adicionado messageboxes em todos os erros para não crashar o sistema.


Versão v1.0:
Funcionalidades adicionais serão implementadas futuramente.

Utilização:
	- Clique no botão "Criar Bat"
	- Preencha os campos referentes à conexão do banco
		- Campos em branco serão preenchidos com valor padrão.
		- Apenas bancos com senha são permitidos por enquanto.
	- Clique em próximo.
	- Preencha os campos referentes ao arquivo de dump.
		- Campos em branco serão preenchidos com valor padrão.
	- Selecione o caminho da pasta local.
	- Selecione o caminho da cópia na rede.
		- Campos em branco serão preenchidos com valor padrão.
	- Clique em finalizar. A BAT será criada em "C:\DATABASE\BACKUP\BAT".

Informações adicionais:

 Todos os campos precisam ser preenchidos. 
 O programa vai preencher o valor padrão para os campos em branco.
 O local do arquivo .bat não pode ser alterado, mas o arquivo pode ser transferido para outra pasta de sua preferência.
 É necessário criara rotina de backup pelo Agendador de Tarefas.

Implementações planejadas:

 - Backup de bancos sem senha.
 - Alterar o diretório principal C:\DATABASE\BACKUP\BAT\
 - Criar rotina no Agendador de Tarefas pelo software.
 - Definir permissões de execução e edição do arquivo.
 - Tela de configurações.