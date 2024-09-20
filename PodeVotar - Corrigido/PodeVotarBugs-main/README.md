# PodeVotar - Teste de Software com ASP.NET e xUnit

Este projeto foi desenvolvido como parte de uma atividade prática focada em **testes de software** utilizando **ASP.NET** e **xUnit**. O objetivo é que os alunos identifiquem e corrijam **bugs** no código que contém funções para validar as faixas etárias em que o voto é:

- **Obrigatório**: Para cidadãos de 18 a 70 anos.
- **Opcional**: Para cidadãos entre 16 e 17 anos, ou acima de 70 anos.
- **Não pode Votar**: Para cidadãos abaixo de 16 anos.

## Objetivo da Atividade

A atividade tem como objetivo reforçar o aprendizado em:

- Identificação e correção de bugs.
- Implementação e validação de testes unitários.
- Uso do framework de testes **xUnit**.

Os alunos devem revisar o código, entender as regras de votação e corrigir eventuais problemas nos testes e nas funções associadas à verificação de idade.

## Como Executar o Projeto

### Requisitos

- **ASP.NET Core** 5.0 ou superior
- **xUnit** para testes unitários

### Passos para Clonar e Executar o Projeto

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/seu-usuario/PodeVotar.git
   ```
2. **Navegue até a pasta do projeto**:
   ```bash
   cd PodeVotar
   ```
3. **Abra o projeto no Visual Studio** ou outro IDE de sua preferência.
4. **Restaure as dependências**:
   No Visual Studio, clique com o botão direito no projeto e selecione "Restore NuGet Packages".
   
5. **Execute os testes**:
   Você pode executar os testes unitários diretamente do Visual Studio ou via terminal usando o seguinte comando:
   ```bash
   dotnet test
   ```

## Tarefa do Aluno

- Identificar bugs nas funções de validação de idade.
- Verificar se os testes estão cobrindo todos os cenários corretamente.
- Corrigir os bugs e melhorar os testes, se necessário.
- Enviar o repositório no GitHub.

## Exemplo de Cenários de Teste

- **Voto obrigatório**: Cidadãos com idade entre 18 e 70 anos.
- **Voto opcional**: Cidadãos de 16-17 anos ou acima de 70 anos.
- **Não pode Votar**: Cidadãos com menos de 16 anos.

## Licença

Este projeto é distribuído sob a licença [MIT](LICENSE).
