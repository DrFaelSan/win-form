# WIN CRUD - Windows Forms

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Windows](https://img.shields.io/badge/Windows-000?style=for-the-badge&logo=windows&logoColor=2CA5E0)

## Sobre

Sistema de Gestão para pessoas, nesse sistema conseguimos fazer a adição, edição, exclusão e listagem de pessoas.
Um pessoa pode ter um endereço, geramos também um relatório da listagem de pessoas e conseguimos filtrar a listagem com Nome, CPF e Idade.

#### Segue imagens: 

<img src="https://raw.githubusercontent.com/DrFaelSan/win-form/main/win-crud/Instalador/WinCRUDSetup/Assets/list.png" alt="Listagem">
<img src="https://raw.githubusercontent.com/DrFaelSan/win-form/main/win-crud/Instalador/WinCRUDSetup/Assets/add.png" alt="Cadastro">
<img src="https://raw.githubusercontent.com/DrFaelSan/win-form/main/win-crud/Instalador/WinCRUDSetup/Assets/edit.png" alt="Edição">
<img src="https://raw.githubusercontent.com/DrFaelSan/win-form/main/win-crud/Instalador/WinCRUDSetup/Assets/context-menu.png" alt="ContextMenu">
<img src="https://raw.githubusercontent.com/DrFaelSan/win-form/main/win-crud/Instalador/WinCRUDSetup/Assets/report.png" alt="Relatório">


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

3. Na pasta

 ```shell
  ├── instalador
  │   └── Install v1
  │       └── setup.exe
 ```
   
> **setup.exe** Este é o arquivo executável do instalador. Ele é o que os usuários irão executar para instalar o aplicativo em seus sistemas. Este arquivo geralmente contém todos os arquivos necessários para a instalação, como os binários do aplicativo, bibliotecas compartilhadas, recursos, etc.

>**Observação Importante** O Sistema deve ser executado como administrador;
