# 💻 GS C#
Sistema desktop desenvolvido em C# para registrar e monitorar falhas de energia elétrica e ameaças cibernéticas.

---

🌐 **Descrição da Solução**
O projeto **GS C#** tem como objetivo principal monitorar e registrar falhas de energia elétrica, assim como possíveis ameaças cibernéticas que possam ocorrer durante essas interrupções. 

A aplicação oferece uma interface de console simples e intuitiva, permitindo ao usuário cadastrar eventos de falhas de energia com criticidade (baixa, média, alta), falhas cibernéticas com tipo de ataque, listar eventos registrados e gerar relatórios em formato `.txt`.

Além disso, o sistema exige login obrigatório para acesso, reforçando a segurança e controle de uso.

---

🎯 **Funcionalidades**
- Login obrigatório com autenticação de usuário fixo.
- Registro de falhas de energia com criticidade.
- Registro de falhas cibernéticas com descrição do tipo de ataque.
- Listagem completa dos eventos registrados.
- Geração de relatórios de eventos salvos em arquivo `.txt`.

---

🔐 **Login**
- **Usuário:** `RM98630`
- **Senha:** `230804`

---

🛠️ **Tecnologias**
- C#
- .NET 8.0
- Visual Studio 2022

---

🚀 **Instruções de Execução**
1. Clone ou baixe o repositório do GitHub para sua máquina.
2. Abra a solução no Visual Studio 2022.
3. Compile e execute o projeto pressionando `F5`.
4. Na tela de login, utilize:
   - Usuário: `RM98630`
   - Senha: `230804`
5. Escolha a funcionalidade desejada no menu.

---

📦 **Dependências**
- .NET 8.0 SDK
- Visual Studio 2022

---

🗂️ **Estrutura de Pastas**
GS_C_/
├── Models/
│ ├── Evento.cs
│ ├── FalhaEnergia.cs
│ ├── FalhaCibernetica.cs
│ └── Usuario.cs
├── Controllers/
│ └── GerenciadorEventos.cs
├── Views/
│ └── InterfaceConsole.cs
├── Program.cs
├── relatorio_eventos.txt (gerado pela aplicação)
├── README.md

👥 **Desenvolvedores**
- Bryan Willian – RM 551305
- Gabriel Fernandes Doms – RM 98630
- Lucas Braga – RM 98607

---

📌 **Observações**
Este projeto foi desenvolvido para fins acadêmicos, simulando cenários reais de falhas de energia e ameaças cibernéticas.
