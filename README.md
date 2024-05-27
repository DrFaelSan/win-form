# WIN CRUD - Windows Forms

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Windows](https://img.shields.io/badge/Windows-000?style=for-the-badge&logo=windows&logoColor=2CA5E0)

## Sobre

## Configurações de instalação

1. Antes de executar o aplicativo, você precisa criar um banco de dados com o nome **win_crud_app**. 
Você pode fazer isso usando um banco de dados SQL Server Management Studio ou qualquer outra ferramenta de gerenciamento de banco de dados de sua preferência.

2. Depois de criar o banco de dados, é necessário definir a variável de ambiente `DB_STRING` com a string de conexão adequada. Siga as instruções abaixo para fazer isso:

-  No Prompt de Comando (cmd):
  
Execute o seguinte comando para definir a variável de ambiente `DB_STRING` com a string de conexão:

```cmd
setx DB_STRING "Data Source=localhost\SQLEXPRESS;Initial Catalog=win_crud_app;Integrated Security=True;"
```

>**Observação Importante**
Se você estiver com o Visual Studio aberto enquanto define a variável de ambiente, pode ser necessário fechar e reabrir o Visual Studio para que ele reconheça a variável de ambiente recém-definida.

Certifique-se de ajustar os valores conforme necessário para a sua configuração de banco de dados.


