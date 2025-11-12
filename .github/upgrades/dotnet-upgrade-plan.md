# .NET 8.0 Upgrade Plan

## Execution Steps

Execute os passos abaixo sequencialmente, um por um, na ordem em que estão listados.

1. Validar que o .NET 8.0 SDK necessário para este upgrade está instalado na máquina e, se não estiver, ajudar a instalá-lo.
2. Garantir que a versão do SDK especificada em arquivos global.json é compatível com o upgrade para .NET 8.0.
3. Upgrade Vip.Maui.Base\Vip.Maui.Base.csproj

## Settings

Esta seção contém configurações e dados usados pelas etapas de execução.

### Project upgrade details

Esta seção contém detalhes sobre o upgrade de cada projeto e as modificações que precisam ser feitas.

#### Vip.Maui.Base\Vip.Maui.Base.csproj modifications

**Alterações nas propriedades do projeto:**
- Target framework deve ser alterado de `netstandard2.0` para `net8.0`

**Observações:**
- Este é um projeto de biblioteca classe que atualmente tem como alvo .NET Standard 2.0
- O upgrade para .NET 8.0 trará acesso a APIs modernas e melhor desempenho
- A biblioteca continuará compatível com projetos .NET MAUI para Android e iOS