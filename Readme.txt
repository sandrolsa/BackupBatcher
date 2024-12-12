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