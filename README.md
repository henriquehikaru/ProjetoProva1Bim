# ProjetoProva1Bim

Projeto em Windows Forms (.NET) desenvolvido em C#, com base em dois programas apresentados em um exercício da prova do 1º bimestre do meu curso, contendo um menu com funcionalidades simples para cálculo de **média de notas** e **acréscimo percentual de temperatura**.

## Visão geral do aplicativo (GIF)
<img src="https://github.com/user-attachments/assets/d7c1da80-470e-4076-bfb8-f97a952b1afb" alt="projeto1bim" width="70%" height="70%">



## Funcionalidades

### Menu Principal (`frmMenu`)
- Tela inicial com duas opções:
  - **Temperatura**
  - **Média de Notas**
- Confirmação ao fechar o formulário principal.

### Cálculo de Temperatura (`frmTemperatura`)
- Campo de entrada para temperatura em °C.
- Campo numérico para percentual de acréscimo.
- Cálculo do novo valor com base no percentual informado.
- Validação para evitar campos vazios ou com valor zero.
- Botão **Novo** para limpar os campos.
- Botão **Sair** com confirmação.

### Cálculo de Média de Notas (`frmMedia`)
- Três campos numéricos para inserção das notas (N1, N2, N3).
- Cálculo da média aritmética com uma casa decimal.
- Validação para evitar notas zeradas.
- Botão **Novo** para resetar os campos.
- Botão **Sair** com confirmação.
- Mudança de cor ao focar nos campos de nota para melhor experiência visual.

## Requisitos

- Visual Studio (versão 2019 ou superior)
- .NET Framework compatível com Windows Forms (ex: 4.7.2)
- Sistema Operacional: Windows

## Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/henriquehikaru/ProjetoProva1Bim.git
   ````
2. Abra o projeto no Visual Studio.

3. Compile e execute o projeto com F5 ou clique em Iniciar.
