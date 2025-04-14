### Descrição Funcional do Projeto

O **WarSpoting** é um aplicativo Windows Forms desenvolvido em C# com o objetivo de consultar, exibir e interagir com dados de perdas militares. Ele utiliza uma API externa para obter informações detalhadas sobre perdas, como tipo, modelo, status, data, localização geográfica, unidade e tags associadas. O aplicativo apresenta essas informações em uma interface gráfica amigável, permitindo ao usuário filtrar os dados, visualizar detalhes e explorar geolocalizações diretamente em um mapa integrado.

#### Funcionalidades Principais:
1. **Consulta de Perdas Militares**:
   - O usuário pode selecionar uma data específica para consultar perdas militares através de uma API externa.
   - Os dados retornados são exibidos em um `ListView` com colunas detalhadas.

2. **Filtragem de Dados**:
   - O usuário pode filtrar os dados exibidos no `ListView` com base em critérios como tipo, modelo e status.

3. **Visualização de Geolocalização**:
   - Ao selecionar ou clicar duas vezes em uma linha do `ListView`, o aplicativo exibe a localização geográfica correspondente no mapa integrado.

4. **Navegação no Mapa**:
   - Um navegador embutido (`ChromiumWebBrowser`) permite a navegação para exibir mapas e geolocalizações.

5. **Mensagens de Status**:
   - O aplicativo exibe mensagens de status e alertas para informar o usuário sobre erros, como geolocalizações inválidas ou problemas de conexão.

6. **Interface Intuitiva**:
   - O aplicativo organiza as informações em abas, com seções dedicadas para dados de perdas e mapas.

7. **Gerenciamento de Recursos**:
   - O aplicativo gerencia recursos do navegador integrado, garantindo o encerramento adequado ao fechar o programa.

---

### Lista de Componentes e Suas Utilizações

#### **Componentes de Interface Gráfica (Windows Forms)**:
1. **`Form` (WarSpotingForm)**:
   - Componente principal que hospeda todos os controles e gerencia a interface do usuário.

2. **`ListView` (`listView`)**:
   - Exibe os dados de perdas militares em formato tabular com colunas como ID, Tipo, Modelo, Status, Data, Geo, Unidade e Tags.
   - Permite seleção de itens para interação com o mapa.

3. **`TabControl` (`tabControl`)**:
   - Organiza a interface em abas, separando a visualização de dados (`tabPerdas`) e o mapa (`tabMapa`).

4. **`ProgressBar` (`progressBar`)**:
   - Indica o progresso durante a consulta de dados na API.

5. **`ComboBox` (`cBoxTipo`, `cBoxModelo`, `cBoxStatus`)**:
   - Permite ao usuário filtrar os dados exibidos no `ListView` com base em critérios específicos.

6. **`Button` (`btnConsultarPerdas`, `btnLimparFiltros`)**:
   - `btnConsultarPerdas`: Inicia a consulta de dados na API.
   - `btnLimparFiltros`: Restaura os filtros para seus valores padrão.

7. **`DateTimePicker` (`dateTimePicker`)**:
   - Permite ao usuário selecionar uma data para consulta de perdas.

8. **`ToolStripStatusLabel` (`toolStripStatusLabel`)**:
   - Exibe mensagens de status e alertas para o usuário.

9. **`GroupBox` (`grpBoxContribuicaoUnica`, `grpBoxContribuicaoMensal`)**:
   - Organiza opções de contribuição única ou mensal (aparentemente relacionado a outra funcionalidade do aplicativo).

10. **`ListBox` (`listBox`)**:
    - Exibe mensagens e logs de ações realizadas pelo aplicativo, como status de consultas.

---

#### **Componentes de Integração com API**:
1. **`HttpClient`**:
   - Realiza requisições HTTP para consultar dados de perdas militares na API externa.

2. **`JsonConvert` (Newtonsoft.Json)**:
   - Desserializa os dados JSON retornados pela API em objetos C# (`LossResponse`).

---

#### **Componentes de Navegação e Mapa**:
1. **`ChromiumWebBrowser` (`chromeBrowser`)**:
   - Navegador embutido baseado no CefSharp para exibir mapas e geolocalizações.

2. **`CefSettings` e `Cef.Initialize`**:
   - Configura e inicializa o navegador CefSharp.

---

#### **Outros Componentes e Recursos**:
1. **`BackgroundWorker` (`bgWorker`)**:
   - Gerencia operações assíncronas, como cancelamento de requisições.

2. **`LossResponse` e `Loss` (Classes)**:
   - Representam os dados retornados pela API, incluindo uma lista de perdas (`Losses`).

3. **`about:blank`**:
   - Página em branco carregada no navegador quando a geolocalização é inválida ou ausente.

---

### Estrutura do Projeto

1. **Formulário Principal**:
   - `WarSpotingForm`: Gerencia a interface e as interações do usuário.

2. **Arquivos Auxiliares**:
   - `WarSpoting.Designer.cs`: Define os componentes visuais e suas propriedades.
   - `WarSpoting.resx`: Contém recursos como strings e imagens.

3. **Classes de Dados**:
   - `LossResponse`: Representa a resposta da API.
   - `Loss`: Representa cada perda individual.

---

### Fluxo de Uso do Aplicativo

1. O usuário seleciona uma data no `DateTimePicker` e clica em "Consultar Perdas".
2. O aplicativo faz uma requisição à API e exibe os dados no `ListView`.
3. O usuário pode filtrar os dados usando os `ComboBox` ou clicar duas vezes em uma linha para visualizar a localização no mapa.
4. Caso a geolocalização seja inválida, uma página em branco é exibida no navegador integrado.