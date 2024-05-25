# Instruções de Execução do Aplicativo Windows Forms

Este README fornece instruções sobre como executar o aplicativo Windows Forms "win-crud".

## 1. Criar o Banco de Dados

Antes de executar o aplicativo, você precisa criar um banco de dados com o nome `win_crud_app`. 
Você pode fazer isso usando um banco de dados SQL Server Management Studio ou qualquer outra ferramenta de gerenciamento de banco de dados de sua preferência.

```sql
CREATE DATABASE win_crud_app;
```


## 2. Definir a Variável de Ambiente `DB_STRING`

Depois de criar o banco de dados, é necessário definir a variável de ambiente `DB_STRING` com a string de conexão adequada. Siga as instruções abaixo para fazer isso:

### No Prompt de Comando (cmd):

Execute o seguinte comando para definir a variável de ambiente `DB_STRING` com a string de conexão:

```cmd
setx DB_STRING "Data Source=localhost\SQLEXPRESS;Initial Catalog=win_crud_app;Integrated Security=True;"
```

Certifique-se de ajustar os valores conforme necessário para a sua configuração de banco de dados.

# Observação Importante

Se você estiver com o Visual Studio aberto enquanto define a variável de ambiente, pode ser necessário fechar e reabrir o Visual Studio para que ele reconheça a variável de ambiente recém-definida.

