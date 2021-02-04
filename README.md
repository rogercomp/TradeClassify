# TradeClassify

Este projeto consiste em realizar uma classificação de uma negociação(TRADE) baseado em uma lista de negociações passada como argumento


### Configuraçao Inicial

No Vs2019 deve-se abrir as propriedades do projeto seleciona a aba Debug e adicionar a lista de parâmetros de entrada conforme modelo abaixo:

```bash
Ex.: "11/12/2020" "4" "2000000 Privado 29/12/2025" "400000 Público 01/07/2020" "5000000 Público 01/02/2024" "3000000 Público 26/10/2023"
```

Obs.: Essa lista já está sendo enviada na inicialização do projeto. Caso queira realizar a entrada passando os parêmetros em tempo de execução esse campo deve ser apagado e o seguinte comando deve ser executado no caminho onde se encontra o binario TradeClassification.exe

```bash
Ex.: TradeClassification.exe "11/12/2020" "4" "2000000 Privado 29/12/2025" "400000 Público 01/07/2020" "5000000 Público 01/02/2024" "3000000 Público 26/10/2023"
```

#### Argument 1 - Data Referência
Type: `String`  
Formato: Data 'mm/dd/aaaa'`

Exemplo:
```bash
"11/12/2020"
```

#### Argument 2 - Número de linhas de trade
Type: `String`  
Inteiro: > 0 
Exemplo:
```bash
"4"
```

#### Argument 3 - Linha trade a ser classificada
Type: `String`  
Formato: "Arg1 Arg2 Arg3"  

Arg1: Double 
Arg2: String 
Arg3: Data 'mm/dd/aaaa'`

Exemplo:
```bash
"2000000 Privado 29/12/2025"
```






