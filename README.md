# GERADORCERTIFICADOS
Um programa que gera certificados de acordo com imagens e uma lista de palavras informadas pelo usuario

Informações a serem coletadas no inicio

- Caminho da imagem de origem
- Texto a ser inserido
- Caminho para o deposito das imagens geradas

```mermaid
graph LR;
    A["(User) Caminho da Imagem fa:fa-globe"]
    B["(User) Texto a ser inserido em CSV fa:fa-globe"]
    C["(User) Caminho a ser depositado o resultado gerado fa:fa-globe"]
    
    D[("Geracao da Imagem fa:fa-globe")]

    E[("Lista de imagens geradas fa:fa-globe")]


    A --> D
    B --> D
    C --> D
    D --> E
```
