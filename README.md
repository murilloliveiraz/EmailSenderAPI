# EmailSenderAPI

Esta é uma API simples para enviar e-mails utilizando .NET 8, MimeKit, MailKit e o serviço SMTP do Gmail.

## Funcionalidades

- Envio de e-mails com conteúdo HTML.
- Integração com o SMTP do Gmail.

## Tecnologias Utilizadas

- **.NET 8**
- **MimeKit**: Biblioteca para criação de mensagens de e-mail em diferentes formatos.
- **MailKit**: Biblioteca para envio de e-mails via SMTP.
- **SMTP do Gmail**: Utilizado para o envio dos e-mails.

## Instalação

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/seu-usuario/EmailSenderAPI.git
   cd EmailSenderAPI
   ```

2. **Instale as dependências do projeto:**
   Certifique-se de que você tem o .NET 8 instalado e execute o comando:
   ```bash
   dotnet restore
   ```

3. **Configuração do SMTP do Gmail:**
   Adicione as suas credenciais do Gmail no arquivo `appsettings.json`:
   ```json
   "EmailSettings": {
     "SmtpServer": "smtp.gmail.com",
     "SmtpPort": 587,
     "SmtpUsername": "seuemail@gmail.com",
     "SmtpPassword": "suasenha"
   }
   ```

4. **Compile e execute o projeto:**
   ```bash
   dotnet run
   ```

## Endpoints

### POST `/api/email`

Este endpoint permite o envio de um e-mail.

**Parâmetros:**

- `email` (string, obrigatório): Endereço de e-mail do destinatário.
- `subject` (string, obrigatório): Assunto do e-mail.

**Exemplo de Requisição:**
```bash
curl -X POST "https://localhost:5001/api/email" -F "email=destinatario@gmail.com" -F "subject=Seu Assunto"
```

**Exemplo de Resposta:**
```json
{
  "message": "Email enviado"
}
```

## Contribuição

1. Faça um fork do projeto.
2. Crie uma nova branch (`git checkout -b feature/sua-feature`).
3. Commit suas mudanças (`git commit -m 'Adiciona nova funcionalidade'`).
4. Faça o push para a branch (`git push origin feature/sua-feature`).
5. Abra um Pull Request.
