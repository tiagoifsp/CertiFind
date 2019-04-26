# CertiFind
Gerenciador de Certificados.

Sistema desenvolvido como avaliação da disciplina Projeto Integrado I.

Documentação:
# https://docs.google.com/document/d/1GQTh-4wJRzOXwebKNwHl4De-wAt0L2Lvp9mYmn2J8m0/edit?usp=sharing
>> As alterações no documento de requisitos devem ser enviadas como sugestão.

Backup inicial do banco de dados:
# https://github.com/tiagoifsp/CertiFind/tree/master/Backup

Grupos:

Grupo 1
Marcelo, Rafael, Fabio, André, Giovane, Harbs, Gabriel Rocha

Grupo 2
Juliene, Igor, Danilo, Eduardo, Jonathas, Gabriel Reis

Grupo 3
Nathan, Bruno, Emerson, Evelyn, Alan, Getulio

Grupo 4
Fabricio, Eliane, Agatha, João, Mikael, Murilo, Vinicius

Requisitos:

Grupo 4
RF01	Configuração inicial
RF02	Entrada no sistema
RF03	Edição das configurações do sistema
RF04	Criação de usuário
RF05	Manutenção de usuário
RF06	Alteração de senha por parte do próprio usuário
RF07	Recuperação de senha por parte do usuário
RF08	Saída do sistema

Grupo 1
RF09	Cadastro de Campo
RF10	Manutenção de Campo
RF11	Cadastro de Tipo de Atividade
RF12	Manutenção de Tipo de Atividade
RF13	Cadastro de Certificado
RF14	Manutenção de Certificado
RF15	Relatório de Certificado

Grupo 2
RF16	Cadastro de Grupo de Pesquisa
RF17	Manutenção de Grupo de Pesquisa
RF18	Vinculação Docente / Grupo de Pesquisa
RF19	Transferência de liderança do Grupo de Pesquisa
RF20	Relatório por grupo de pesquisa
RF21	Comunicados do sistema

Grupo 3
RF22	Histórico de erros do sistema
RF23	Backup do sistema
RF24	Envio e leitura de sugestões
RF25	Status do sistema
RF26	Relatório de utilização do sistema
RF27	Auditoria do sistema

Regras:

@GitHub
1) Ninguém deverá alterar a branch Master;
2) Cada grupo deverá trabalhar em suas próprias branches;
3) Cada requisito deverá ser desenvolvido em sua própria branch;
4) Cada bug deverá ser corrigido em sua própria branch;
5) O pull request deverá ser solicitado pelo grupo, e apenas o gerente poderá fazer o merge.

@Banco de Dados
1) O backup inicial do banco de dados não poderá ser alterado;
2) Qualquer alteração deverá ser realizada por consultas SQL;
3) Todas as alterações devem ser inseridas no arquivo #https://github.com/tiagoifsp/CertiFind/blob/master/Backup/Alteracoes;
4) Restaurar o backup no PC do desenvolvedor. Futuramente teremos um servidor com um banco de dados para testes.

@Código-fonte
1) Utilizar o FormTeste para chamada de outros formulários;
2) Após o login do sistema estar funcionando, o FormTeste será removido;
3) Seguir o padrão MVC;
4) Nomenclatura das classes:
  a) Model : M<nomedaclasse>. Exemplo: MAluno
  b) DAL: D<nomedaclasse>. Exemplo: DAluno
  c) Controller: C<nomedaclasse>. Exemplo: CAluno
  d) View: V<nomedaclasse><funcionalidade>. Exemplo: VAlunoPesquisar
5) Nomenclatura dos arquivos: cada arquivo deverá conter uma classe apenas, e o nome do arquivo deve ser igual ao nome da classe. Exemplo: MAluno.cs
6) Não alterar os nomes dos namespaces;
7) Exemplo de nomenclatura dos controles:
  a) TextBox/MaskedTextBox: txtNome
  b) ComboBox: cboTipo
  c) Label (quando o valor é alterado no código): lblSituacao
  d) DateTimePicker: dtpData
  e) DataGridView: dgvResultado
  f) NumericUpDown: nudFilhos
  g) Checkbox: chkAtivo
  h) PictureBox: pcbFoto
  i) RadioButton: rdoGrupo
  j) RichTextBox: rtbDescricao
  k) Button: btnSalvar
8) Verificar os forms de Exemplo para desenvolver a interface;
9) Em CRUDs básicos, o mesmo form deve ser utilizado para salvar/editar informações.  
