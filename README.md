<h1 align="center"> LeitorXML </h1>




Este é um projeto que permite processar arquivos XML relacionados a uma programação de rádio e extrair informações úteis.

![Badge em Desenvolvimento](http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=GREEN&style=flat)
## Como usar

Insira o caminho da pasta **pgm** do Playlist quando solicitado.

Escolha a data da montagem que você deseja visualizar no formato  **"dd-mm-yyyy"**.

Escolha se você deseja imprimir a programação completa, um bloco específico, ou sair.

O programa irá apagar os arquivos XML já presentes na pasta montagem e, em seguida extrair a pasta com a data escolhida, para obter um arquivo XML, e em seguida, ler este arquivo e alimentar as classes do programa.

Ao imprimir a programação no formato desejado, será gerado um arquivo .json na pasta Montagem do Playlist, contendo toda a programação no formato de Json.

### Requisitos de Sistema

- Plataforma: Windows
- .NET Framework 4.7.2 ou superior

### Estrutura do Projeto
O projeto é dividido em várias classes, incluindo ScheduleDay, Break e Insertion, que ajudam a extrair e processar informações dos arquivos XML.

> **ScheduleDay**: Classe principal para o processamento do arquivo XML e gerenciar as demais classes. <br>
> **Break**: Classe para representar os blocos de programação. <br>
> **Insertion**: Classe para representar as inserções de programação. <br>
> **Utils**: Classe com funcionalidades uteis para verificação dos inputs do usuário. <br>

### Contribuição

Sinta-se à vontade para contribuir para este projeto abrindo issues e pull requests. Sua contribuição é bem-vinda!

1. Clone este repositório:

   ```shell
   git clone https://github.com/seu-usuario/LeitorXML
   cd LeitorXML
2.  Abra o projeto no Visual Studio ou em sua IDE de preferência.
    
3.  Compile o projeto.
    
4.  Execute o programa a partir do arquivo `DesafioXml.sln`.


### Autores
- Gabriel Carlos



