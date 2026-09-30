namespace LauncherConfigurator
{
    partial class ConfigForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();

            this.tabMain = new System.Windows.Forms.TabControl();

            // Tab 1: Servidor & Conexão
            this.tabServer = new System.Windows.Forms.TabPage();
            this.grpMainRoute = new System.Windows.Forms.GroupBox();
            this.lblMainIp = new System.Windows.Forms.Label();
            this.txtMainIp = new System.Windows.Forms.TextBox();
            this.lblMainConnectPort = new System.Windows.Forms.Label();
            this.txtMainConnectPort = new System.Windows.Forms.TextBox();
            this.lblMainPort = new System.Windows.Forms.Label();
            this.txtMainPort = new System.Windows.Forms.TextBox();
            this.btnTestMain = new System.Windows.Forms.Button();
            this.lblMainRouteTip = new System.Windows.Forms.Label();

            this.grpAltRoute = new System.Windows.Forms.GroupBox();
            this.lblAltIp = new System.Windows.Forms.Label();
            this.txtAltIp = new System.Windows.Forms.TextBox();
            this.lblAltConnectPort = new System.Windows.Forms.Label();
            this.txtAltConnectPort = new System.Windows.Forms.TextBox();
            this.lblAltPort = new System.Windows.Forms.Label();
            this.txtAltPort = new System.Windows.Forms.TextBox();
            this.btnTestAlt = new System.Windows.Forms.Button();
            this.lblAltRouteTip = new System.Windows.Forms.Label();

            // Tab 2: Executável & Parâmetros
            this.tabGame = new System.Windows.Forms.TabPage();
            this.grpExecutable = new System.Windows.Forms.GroupBox();
            this.lblExecutable = new System.Windows.Forms.Label();
            this.txtExecutable = new System.Windows.Forms.TextBox();
            this.lblArgsMode = new System.Windows.Forms.Label();
            this.cboArgsMode = new System.Windows.Forms.ComboBox();
            this.lblArgsHelp = new System.Windows.Forms.Label();

            // Tab 3: Links & Web
            this.tabLinks = new System.Windows.Forms.TabPage();
            this.grpLinks = new System.Windows.Forms.GroupBox();
            this.lblWebsiteUrl = new System.Windows.Forms.Label();
            this.txtWebsiteUrl = new System.Windows.Forms.TextBox();
            this.lblRegisterUrl = new System.Windows.Forms.Label();
            this.txtRegisterUrl = new System.Windows.Forms.TextBox();
            this.lblRegisterApiUrl = new System.Windows.Forms.Label();
            this.txtRegisterApiUrl = new System.Windows.Forms.TextBox();
            this.lblRankingUrl = new System.Windows.Forms.Label();
            this.txtRankingUrl = new System.Windows.Forms.TextBox();
            this.lblNewsUrl = new System.Windows.Forms.Label();
            this.txtNewsUrl = new System.Windows.Forms.TextBox();
            this.lblUpdateUrl = new System.Windows.Forms.Label();
            this.txtUpdateUrl = new System.Windows.Forms.TextBox();

            // Tab 4: Segurança & Criptografia
            this.tabSecurity = new System.Windows.Forms.TabPage();
            this.grpClientSecurity = new System.Windows.Forms.GroupBox();
            this.chkVerifyIntegrity = new System.Windows.Forms.CheckBox();
            this.chkAntiCheat = new System.Windows.Forms.CheckBox();
            this.chkDllWhitelist = new System.Windows.Forms.CheckBox();
            this.chkLauncherGuard = new System.Windows.Forms.CheckBox();
            this.chkRestoreLauncher = new System.Windows.Forms.CheckBox();
            this.chkMutexLock = new System.Windows.Forms.CheckBox();
            this.lblMutexName = new System.Windows.Forms.Label();
            this.txtMutexName = new System.Windows.Forms.TextBox();

            this.grpEncryption = new System.Windows.Forms.GroupBox();
            this.chkEncryptConfig = new System.Windows.Forms.CheckBox();
            this.lblMainHash = new System.Windows.Forms.Label();
            this.txtMainHash = new System.Windows.Forms.TextBox();
            this.btnGetLocalHash = new System.Windows.Forms.Button();

            // Footer
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooterInfo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.pnlTop.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabServer.SuspendLayout();
            this.grpMainRoute.SuspendLayout();
            this.grpAltRoute.SuspendLayout();
            this.tabGame.SuspendLayout();
            this.grpExecutable.SuspendLayout();
            this.tabLinks.SuspendLayout();
            this.grpLinks.SuspendLayout();
            this.tabSecurity.SuspendLayout();
            this.grpClientSecurity.SuspendLayout();
            this.grpEncryption.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.lblHeaderSubtitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(734, 60);
            this.pnlTop.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.lblTitle.Location = new System.Drawing.Point(14, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(434, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CONFIGURADOR DO CONNECTSERVER && LAUNCHER";

            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(15, 34);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(487, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Painel de Gerenciamento de Rotas, Conexão, Argumentos e Segurança Local do Jogo";

            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabServer);
            this.tabMain.Controls.Add(this.tabGame);
            this.tabMain.Controls.Add(this.tabLinks);
            this.tabMain.Controls.Add(this.tabSecurity);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabMain.ItemSize = new System.Drawing.Size(160, 28);
            this.tabMain.Location = new System.Drawing.Point(0, 60);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(734, 422);
            this.tabMain.TabIndex = 1;

            // 
            // tabServer
            // 
            this.tabServer.AutoScroll = true;
            this.tabServer.BackColor = System.Drawing.SystemColors.Control;
            this.tabServer.Controls.Add(this.grpAltRoute);
            this.tabServer.Controls.Add(this.grpMainRoute);
            this.tabServer.Location = new System.Drawing.Point(4, 32);
            this.tabServer.Name = "tabServer";
            this.tabServer.Padding = new System.Windows.Forms.Padding(12);
            this.tabServer.Size = new System.Drawing.Size(726, 386);
            this.tabServer.TabIndex = 0;
            this.tabServer.Text = "Servidor && Rotas";

            // 
            // grpMainRoute
            // 
            this.grpMainRoute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMainRoute.Controls.Add(this.lblMainRouteTip);
            this.grpMainRoute.Controls.Add(this.btnTestMain);
            this.grpMainRoute.Controls.Add(this.txtMainPort);
            this.grpMainRoute.Controls.Add(this.lblMainPort);
            this.grpMainRoute.Controls.Add(this.txtMainConnectPort);
            this.grpMainRoute.Controls.Add(this.lblMainConnectPort);
            this.grpMainRoute.Controls.Add(this.txtMainIp);
            this.grpMainRoute.Controls.Add(this.lblMainIp);
            this.grpMainRoute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpMainRoute.Location = new System.Drawing.Point(12, 12);
            this.grpMainRoute.Name = "grpMainRoute";
            this.grpMainRoute.Size = new System.Drawing.Size(702, 150);
            this.grpMainRoute.TabIndex = 0;
            this.grpMainRoute.TabStop = false;
            this.grpMainRoute.Text = "ROTA PRINCIPAL (CONEXÃO PADRÃO DO SERVIDOR)";

            // 
            // lblMainIp
            // 
            this.lblMainIp.AutoSize = true;
            this.lblMainIp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMainIp.Location = new System.Drawing.Point(18, 32);
            this.lblMainIp.Name = "lblMainIp";
            this.lblMainIp.Size = new System.Drawing.Size(71, 15);
            this.lblMainIp.TabIndex = 0;
            this.lblMainIp.Text = "IP / Domínio:";

            // 
            // txtMainIp
            // 
            this.txtMainIp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMainIp.Location = new System.Drawing.Point(95, 29);
            this.txtMainIp.Name = "txtMainIp";
            this.txtMainIp.Size = new System.Drawing.Size(250, 23);
            this.txtMainIp.TabIndex = 1;

            // 
            // lblMainConnectPort
            // 
            this.lblMainConnectPort.AutoSize = true;
            this.lblMainConnectPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMainConnectPort.Location = new System.Drawing.Point(365, 32);
            this.lblMainConnectPort.Name = "lblMainConnectPort";
            this.lblMainConnectPort.Size = new System.Drawing.Size(56, 15);
            this.lblMainConnectPort.TabIndex = 2;
            this.lblMainConnectPort.Text = "Porta CS:";

            // 
            // txtMainConnectPort
            // 
            this.txtMainConnectPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMainConnectPort.Location = new System.Drawing.Point(427, 29);
            this.txtMainConnectPort.Name = "txtMainConnectPort";
            this.txtMainConnectPort.Size = new System.Drawing.Size(80, 23);
            this.txtMainConnectPort.TabIndex = 3;

            // 
            // lblMainPort
            // 
            this.lblMainPort.AutoSize = true;
            this.lblMainPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMainPort.Location = new System.Drawing.Point(525, 32);
            this.lblMainPort.Name = "lblMainPort";
            this.lblMainPort.Size = new System.Drawing.Size(56, 15);
            this.lblMainPort.TabIndex = 4;
            this.lblMainPort.Text = "Porta GS:";

            // 
            // txtMainPort
            // 
            this.txtMainPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMainPort.Location = new System.Drawing.Point(587, 29);
            this.txtMainPort.Name = "txtMainPort";
            this.txtMainPort.Size = new System.Drawing.Size(80, 23);
            this.txtMainPort.TabIndex = 5;

            // 
            // btnTestMain
            // 
            this.btnTestMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTestMain.Location = new System.Drawing.Point(95, 65);
            this.btnTestMain.Name = "btnTestMain";
            this.btnTestMain.Size = new System.Drawing.Size(160, 28);
            this.btnTestMain.TabIndex = 6;
            this.btnTestMain.Text = "Testar Rota Principal";
            this.btnTestMain.UseVisualStyleBackColor = true;
            this.btnTestMain.Click += new System.EventHandler(this.BtnTestMain_Click);

            // 
            // lblMainRouteTip
            // 
            this.lblMainRouteTip.AutoSize = true;
            this.lblMainRouteTip.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMainRouteTip.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblMainRouteTip.Location = new System.Drawing.Point(92, 105);
            this.lblMainRouteTip.Name = "lblMainRouteTip";
            this.lblMainRouteTip.Size = new System.Drawing.Size(527, 15);
            this.lblMainRouteTip.TabIndex = 7;
            this.lblMainRouteTip.Text = "Porta CS padrão: 44405. Porta GS padrão: 55901. O Launcher tenta conectar primeiro nesta rota.";

            // 
            // grpAltRoute
            // 
            this.grpAltRoute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAltRoute.Controls.Add(this.lblAltRouteTip);
            this.grpAltRoute.Controls.Add(this.btnTestAlt);
            this.grpAltRoute.Controls.Add(this.txtAltPort);
            this.grpAltRoute.Controls.Add(this.lblAltPort);
            this.grpAltRoute.Controls.Add(this.txtAltConnectPort);
            this.grpAltRoute.Controls.Add(this.lblAltConnectPort);
            this.grpAltRoute.Controls.Add(this.txtAltIp);
            this.grpAltRoute.Controls.Add(this.lblAltIp);
            this.grpAltRoute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpAltRoute.Location = new System.Drawing.Point(12, 175);
            this.grpAltRoute.Name = "grpAltRoute";
            this.grpAltRoute.Size = new System.Drawing.Size(702, 150);
            this.grpAltRoute.TabIndex = 1;
            this.grpAltRoute.TabStop = false;
            this.grpAltRoute.Text = "ROTA ALTERNATIVA (PROXY / PROVEDOR SECUNDÁRIO - OPCIONAL)";

            // 
            // lblAltIp
            // 
            this.lblAltIp.AutoSize = true;
            this.lblAltIp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAltIp.Location = new System.Drawing.Point(18, 32);
            this.lblAltIp.Name = "lblAltIp";
            this.lblAltIp.Size = new System.Drawing.Size(71, 15);
            this.lblAltIp.TabIndex = 0;
            this.lblAltIp.Text = "IP / Domínio:";

            // 
            // txtAltIp
            // 
            this.txtAltIp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAltIp.Location = new System.Drawing.Point(95, 29);
            this.txtAltIp.Name = "txtAltIp";
            this.txtAltIp.Size = new System.Drawing.Size(250, 23);
            this.txtAltIp.TabIndex = 1;

            // 
            // lblAltConnectPort
            // 
            this.lblAltConnectPort.AutoSize = true;
            this.lblAltConnectPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAltConnectPort.Location = new System.Drawing.Point(365, 32);
            this.lblAltConnectPort.Name = "lblAltConnectPort";
            this.lblAltConnectPort.Size = new System.Drawing.Size(56, 15);
            this.lblAltConnectPort.TabIndex = 2;
            this.lblAltConnectPort.Text = "Porta CS:";

            // 
            // txtAltConnectPort
            // 
            this.txtAltConnectPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAltConnectPort.Location = new System.Drawing.Point(427, 29);
            this.txtAltConnectPort.Name = "txtAltConnectPort";
            this.txtAltConnectPort.Size = new System.Drawing.Size(80, 23);
            this.txtAltConnectPort.TabIndex = 3;

            // 
            // lblAltPort
            // 
            this.lblAltPort.AutoSize = true;
            this.lblAltPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAltPort.Location = new System.Drawing.Point(525, 32);
            this.lblAltPort.Name = "lblAltPort";
            this.lblAltPort.Size = new System.Drawing.Size(56, 15);
            this.lblAltPort.TabIndex = 4;
            this.lblAltPort.Text = "Porta GS:";

            // 
            // txtAltPort
            // 
            this.txtAltPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAltPort.Location = new System.Drawing.Point(587, 29);
            this.txtAltPort.Name = "txtAltPort";
            this.txtAltPort.Size = new System.Drawing.Size(80, 23);
            this.txtAltPort.TabIndex = 5;

            // 
            // btnTestAlt
            // 
            this.btnTestAlt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTestAlt.Location = new System.Drawing.Point(95, 65);
            this.btnTestAlt.Name = "btnTestAlt";
            this.btnTestAlt.Size = new System.Drawing.Size(160, 28);
            this.btnTestAlt.TabIndex = 6;
            this.btnTestAlt.Text = "Testar Rota Alternativa";
            this.btnTestAlt.UseVisualStyleBackColor = true;
            this.btnTestAlt.Click += new System.EventHandler(this.BtnTestAlt_Click);

            // 
            // lblAltRouteTip
            // 
            this.lblAltRouteTip.AutoSize = true;
            this.lblAltRouteTip.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAltRouteTip.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblAltRouteTip.Location = new System.Drawing.Point(92, 105);
            this.lblAltRouteTip.Name = "lblAltRouteTip";
            this.lblAltRouteTip.Size = new System.Drawing.Size(536, 15);
            this.lblAltRouteTip.TabIndex = 7;
            this.lblAltRouteTip.Text = "Se preenchida, o Launcher alterna para este IP se o ConnectServer principal estiver inacessível.";

            // 
            // tabGame
            // 
            this.tabGame.BackColor = System.Drawing.SystemColors.Control;
            this.tabGame.Controls.Add(this.grpExecutable);
            this.tabGame.Location = new System.Drawing.Point(4, 32);
            this.tabGame.Name = "tabGame";
            this.tabGame.Padding = new System.Windows.Forms.Padding(12);
            this.tabGame.Size = new System.Drawing.Size(726, 386);
            this.tabGame.TabIndex = 1;
            this.tabGame.Text = "Executável && Parâmetros";

            // 
            // grpExecutable
            // 
            this.grpExecutable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExecutable.Controls.Add(this.lblArgsHelp);
            this.grpExecutable.Controls.Add(this.cboArgsMode);
            this.grpExecutable.Controls.Add(this.lblArgsMode);
            this.grpExecutable.Controls.Add(this.txtExecutable);
            this.grpExecutable.Controls.Add(this.lblExecutable);
            this.grpExecutable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpExecutable.Location = new System.Drawing.Point(12, 12);
            this.grpExecutable.Name = "grpExecutable";
            this.grpExecutable.Size = new System.Drawing.Size(702, 230);
            this.grpExecutable.TabIndex = 0;
            this.grpExecutable.TabStop = false;
            this.grpExecutable.Text = "INICIALIZAÇÃO DO EXECUTÁVEL DO JOGO";

            // 
            // lblExecutable
            // 
            this.lblExecutable.AutoSize = true;
            this.lblExecutable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExecutable.Location = new System.Drawing.Point(20, 36);
            this.lblExecutable.Name = "lblExecutable";
            this.lblExecutable.Size = new System.Drawing.Size(128, 15);
            this.lblExecutable.TabIndex = 0;
            this.lblExecutable.Text = "Nome do Executável:";

            // 
            // txtExecutable
            // 
            this.txtExecutable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExecutable.Location = new System.Drawing.Point(165, 33);
            this.txtExecutable.Name = "txtExecutable";
            this.txtExecutable.Size = new System.Drawing.Size(240, 23);
            this.txtExecutable.TabIndex = 1;
            this.txtExecutable.Text = "main.exe";

            // 
            // lblArgsMode
            // 
            this.lblArgsMode.AutoSize = true;
            this.lblArgsMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArgsMode.Location = new System.Drawing.Point(20, 75);
            this.lblArgsMode.Name = "lblArgsMode";
            this.lblArgsMode.Size = new System.Drawing.Size(126, 15);
            this.lblArgsMode.TabIndex = 2;
            this.lblArgsMode.Text = "Modo de Argumentos:";

            // 
            // cboArgsMode
            // 
            this.cboArgsMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArgsMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboArgsMode.FormattingEnabled = true;
            this.cboArgsMode.Items.AddRange(new object[] {
            "Modo Padrão MuOnline (connect /u...)",
            "Conexão Direta ConnectServer (IP + Porta)",
            "Sem Argumentos (Execução Limpa)"});
            this.cboArgsMode.Location = new System.Drawing.Point(165, 72);
            this.cboArgsMode.Name = "cboArgsMode";
            this.cboArgsMode.Size = new System.Drawing.Size(320, 23);
            this.cboArgsMode.TabIndex = 3;

            // 
            // lblArgsHelp
            // 
            this.lblArgsHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArgsHelp.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArgsHelp.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblArgsHelp.Location = new System.Drawing.Point(20, 115);
            this.lblArgsHelp.Name = "lblArgsHelp";
            this.lblArgsHelp.Size = new System.Drawing.Size(660, 95);
            this.lblArgsHelp.TabIndex = 4;
            this.lblArgsHelp.Text = "• Modo Padrão: envia argumentos criptografados clássicos de Mu Online para validação do main.exe.\n• Conexão Direta: repassa os parâmetros IP e Porta do ConnectServer na linha de comando.\n• Sem Argumentos: abre o executável diretamente (ideal se o IP estiver configurado internamente no main.exe ou dll).";

            // 
            // tabLinks
            // 
            this.tabLinks.AutoScroll = true;
            this.tabLinks.BackColor = System.Drawing.SystemColors.Control;
            this.tabLinks.Controls.Add(this.grpLinks);
            this.tabLinks.Location = new System.Drawing.Point(4, 32);
            this.tabLinks.Name = "tabLinks";
            this.tabLinks.Padding = new System.Windows.Forms.Padding(12);
            this.tabLinks.Size = new System.Drawing.Size(726, 386);
            this.tabLinks.TabIndex = 2;
            this.tabLinks.Text = "Links && Web";

            // 
            // grpLinks
            // 
            this.grpLinks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLinks.Controls.Add(this.txtUpdateUrl);
            this.grpLinks.Controls.Add(this.lblUpdateUrl);
            this.grpLinks.Controls.Add(this.txtNewsUrl);
            this.grpLinks.Controls.Add(this.lblNewsUrl);
            this.grpLinks.Controls.Add(this.txtRankingUrl);
            this.grpLinks.Controls.Add(this.lblRankingUrl);
            this.grpLinks.Controls.Add(this.txtRegisterApiUrl);
            this.grpLinks.Controls.Add(this.lblRegisterApiUrl);
            this.grpLinks.Controls.Add(this.txtRegisterUrl);
            this.grpLinks.Controls.Add(this.lblRegisterUrl);
            this.grpLinks.Controls.Add(this.txtWebsiteUrl);
            this.grpLinks.Controls.Add(this.lblWebsiteUrl);
            this.grpLinks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpLinks.Location = new System.Drawing.Point(12, 12);
            this.grpLinks.Name = "grpLinks";
            this.grpLinks.Size = new System.Drawing.Size(702, 280);
            this.grpLinks.TabIndex = 0;
            this.grpLinks.TabStop = false;
            this.grpLinks.Text = "ENDEREÇOS WEB E INTEGRAÇÕES";

            // 
            // lblWebsiteUrl
            // 
            this.lblWebsiteUrl.AutoSize = true;
            this.lblWebsiteUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWebsiteUrl.Location = new System.Drawing.Point(20, 32);
            this.lblWebsiteUrl.Name = "lblWebsiteUrl";
            this.lblWebsiteUrl.Size = new System.Drawing.Size(89, 15);
            this.lblWebsiteUrl.TabIndex = 0;
            this.lblWebsiteUrl.Text = "Website Oficial:";

            // 
            // txtWebsiteUrl
            // 
            this.txtWebsiteUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWebsiteUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWebsiteUrl.Location = new System.Drawing.Point(180, 29);
            this.txtWebsiteUrl.Name = "txtWebsiteUrl";
            this.txtWebsiteUrl.Size = new System.Drawing.Size(500, 23);
            this.txtWebsiteUrl.TabIndex = 1;

            // 
            // lblRegisterUrl
            // 
            this.lblRegisterUrl.AutoSize = true;
            this.lblRegisterUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterUrl.Location = new System.Drawing.Point(20, 72);
            this.lblRegisterUrl.Name = "lblRegisterUrl";
            this.lblRegisterUrl.Size = new System.Drawing.Size(126, 15);
            this.lblRegisterUrl.TabIndex = 2;
            this.lblRegisterUrl.Text = "Cadastro (Navegador):";

            // 
            // txtRegisterUrl
            // 
            this.txtRegisterUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegisterUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegisterUrl.Location = new System.Drawing.Point(180, 69);
            this.txtRegisterUrl.Name = "txtRegisterUrl";
            this.txtRegisterUrl.Size = new System.Drawing.Size(500, 23);
            this.txtRegisterUrl.TabIndex = 3;

            // 
            // lblRegisterApiUrl
            // 
            this.lblRegisterApiUrl.AutoSize = true;
            this.lblRegisterApiUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterApiUrl.Location = new System.Drawing.Point(20, 112);
            this.lblRegisterApiUrl.Name = "lblRegisterApiUrl";
            this.lblRegisterApiUrl.Size = new System.Drawing.Size(147, 15);
            this.lblRegisterApiUrl.TabIndex = 4;
            this.lblRegisterApiUrl.Text = "API Registro no Launcher:";

            // 
            // txtRegisterApiUrl
            // 
            this.txtRegisterApiUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegisterApiUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegisterApiUrl.Location = new System.Drawing.Point(180, 109);
            this.txtRegisterApiUrl.Name = "txtRegisterApiUrl";
            this.txtRegisterApiUrl.Size = new System.Drawing.Size(500, 23);
            this.txtRegisterApiUrl.TabIndex = 5;

            // 
            // lblRankingUrl
            // 
            this.lblRankingUrl.AutoSize = true;
            this.lblRankingUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRankingUrl.Location = new System.Drawing.Point(20, 152);
            this.lblRankingUrl.Name = "lblRankingUrl";
            this.lblRankingUrl.Size = new System.Drawing.Size(107, 15);
            this.lblRankingUrl.TabIndex = 6;
            this.lblRankingUrl.Text = "Página de Ranking:";

            // 
            // txtRankingUrl
            // 
            this.txtRankingUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRankingUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRankingUrl.Location = new System.Drawing.Point(180, 149);
            this.txtRankingUrl.Name = "txtRankingUrl";
            this.txtRankingUrl.Size = new System.Drawing.Size(500, 23);
            this.txtRankingUrl.TabIndex = 7;

            // 
            // lblNewsUrl
            // 
            this.lblNewsUrl.AutoSize = true;
            this.lblNewsUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewsUrl.Location = new System.Drawing.Point(20, 192);
            this.lblNewsUrl.Name = "lblNewsUrl";
            this.lblNewsUrl.Size = new System.Drawing.Size(135, 15);
            this.lblNewsUrl.TabIndex = 8;
            this.lblNewsUrl.Text = "Feed Notícias (JSON/Txt):";

            // 
            // txtNewsUrl
            // 
            this.txtNewsUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewsUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewsUrl.Location = new System.Drawing.Point(180, 189);
            this.txtNewsUrl.Name = "txtNewsUrl";
            this.txtNewsUrl.Size = new System.Drawing.Size(500, 23);
            this.txtNewsUrl.TabIndex = 9;
            // 
            // lblUpdateUrl
            // 
            this.lblUpdateUrl.AutoSize = true;
            this.lblUpdateUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateUrl.Location = new System.Drawing.Point(20, 232);
            this.lblUpdateUrl.Name = "lblUpdateUrl";
            this.lblUpdateUrl.Size = new System.Drawing.Size(124, 15);
            this.lblUpdateUrl.TabIndex = 10;
            this.lblUpdateUrl.Text = "URL Base do Update:";
            // 
            // txtUpdateUrl
            // 
            this.txtUpdateUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUpdateUrl.Location = new System.Drawing.Point(180, 229);
            this.txtUpdateUrl.Name = "txtUpdateUrl";
            this.txtUpdateUrl.Size = new System.Drawing.Size(500, 23);
            this.txtUpdateUrl.TabIndex = 11;

            // 
            // tabSecurity
            // 
            this.tabSecurity.AutoScroll = true;
            this.tabSecurity.BackColor = System.Drawing.SystemColors.Control;
            this.tabSecurity.Controls.Add(this.grpEncryption);
            this.tabSecurity.Controls.Add(this.grpClientSecurity);
            this.tabSecurity.Location = new System.Drawing.Point(4, 32);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Padding = new System.Windows.Forms.Padding(12);
            this.tabSecurity.Size = new System.Drawing.Size(726, 386);
            this.tabSecurity.TabIndex = 3;
            this.tabSecurity.Text = "Segurança && Criptografia";

            // 
            // grpClientSecurity
            // 
            this.grpClientSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpClientSecurity.Controls.Add(this.txtMutexName);
            this.grpClientSecurity.Controls.Add(this.lblMutexName);
            this.grpClientSecurity.Controls.Add(this.chkMutexLock);
            this.grpClientSecurity.Controls.Add(this.chkRestoreLauncher);
            this.grpClientSecurity.Controls.Add(this.chkLauncherGuard);
            this.grpClientSecurity.Controls.Add(this.chkDllWhitelist);
            this.grpClientSecurity.Controls.Add(this.chkAntiCheat);
            this.grpClientSecurity.Controls.Add(this.chkVerifyIntegrity);
            this.grpClientSecurity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpClientSecurity.Location = new System.Drawing.Point(12, 12);
            this.grpClientSecurity.Name = "grpClientSecurity";
            this.grpClientSecurity.Size = new System.Drawing.Size(702, 215);
            this.grpClientSecurity.TabIndex = 0;
            this.grpClientSecurity.TabStop = false;
            this.grpClientSecurity.Text = "MÓDULOS DE INTEGRIDADE E PROTEÇÃO DO CLIENTE";

            // 
            // chkVerifyIntegrity
            // 
            this.chkVerifyIntegrity.AutoSize = true;
            this.chkVerifyIntegrity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkVerifyIntegrity.Location = new System.Drawing.Point(20, 26);
            this.chkVerifyIntegrity.Name = "chkVerifyIntegrity";
            this.chkVerifyIntegrity.Size = new System.Drawing.Size(370, 19);
            this.chkVerifyIntegrity.TabIndex = 0;
            this.chkVerifyIntegrity.Text = "Verificar integridade do executável principal (Cabeçalho PE e MD5)";
            this.chkVerifyIntegrity.UseVisualStyleBackColor = true;

            // 
            // chkAntiCheat
            // 
            this.chkAntiCheat.AutoSize = true;
            this.chkAntiCheat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkAntiCheat.Location = new System.Drawing.Point(20, 52);
            this.chkAntiCheat.Name = "chkAntiCheat";
            this.chkAntiCheat.Size = new System.Drawing.Size(437, 19);
            this.chkAntiCheat.TabIndex = 1;
            this.chkAntiCheat.Text = "Ativar escaneamento anti-cheat de processos e assinaturas de ferramentas hacker";
            this.chkAntiCheat.UseVisualStyleBackColor = true;

            // 
            // chkDllWhitelist
            // 
            this.chkDllWhitelist.AutoSize = true;
            this.chkDllWhitelist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkDllWhitelist.Location = new System.Drawing.Point(20, 78);
            this.chkDllWhitelist.Name = "chkDllWhitelist";
            this.chkDllWhitelist.Size = new System.Drawing.Size(378, 19);
            this.chkDllWhitelist.TabIndex = 2;
            this.chkDllWhitelist.Text = "Ativar verificação rigorosa de Whitelist de DLLs carregadas no cliente";
            this.chkDllWhitelist.UseVisualStyleBackColor = true;

            // 
            // chkLauncherGuard
            // 
            this.chkLauncherGuard.AutoSize = true;
            this.chkLauncherGuard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkLauncherGuard.Location = new System.Drawing.Point(20, 104);
            this.chkLauncherGuard.Name = "chkLauncherGuard";
            this.chkLauncherGuard.Size = new System.Drawing.Size(417, 19);
            this.chkLauncherGuard.TabIndex = 3;
            this.chkLauncherGuard.Text = "Launcher Guard (Permanecer ativo na bandeja do Windows vigiando o jogo)";
            this.chkLauncherGuard.UseVisualStyleBackColor = true;

            // 
            // chkRestoreLauncher
            // 
            this.chkRestoreLauncher.AutoSize = true;
            this.chkRestoreLauncher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkRestoreLauncher.Location = new System.Drawing.Point(20, 130);
            this.chkRestoreLauncher.Name = "chkRestoreLauncher";
            this.chkRestoreLauncher.Size = new System.Drawing.Size(350, 19);
            this.chkRestoreLauncher.TabIndex = 4;
            this.chkRestoreLauncher.Text = "Restaurar janela do Launcher automaticamente ao fechar o jogo";
            this.chkRestoreLauncher.UseVisualStyleBackColor = true;

            // 
            // chkMutexLock
            // 
            this.chkMutexLock.AutoSize = true;
            this.chkMutexLock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkMutexLock.Location = new System.Drawing.Point(20, 156);
            this.chkMutexLock.Name = "chkMutexLock";
            this.chkMutexLock.Size = new System.Drawing.Size(394, 19);
            this.chkMutexLock.TabIndex = 5;
            this.chkMutexLock.Text = "Impedir múltiplas instâncias simultâneas do Launcher (Bloqueio Mutex)";
            this.chkMutexLock.UseVisualStyleBackColor = true;

            // 
            // lblMutexName
            // 
            this.lblMutexName.AutoSize = true;
            this.lblMutexName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMutexName.Location = new System.Drawing.Point(20, 185);
            this.lblMutexName.Name = "lblMutexName";
            this.lblMutexName.Size = new System.Drawing.Size(100, 15);
            this.lblMutexName.TabIndex = 6;
            this.lblMutexName.Text = "Nome do Mutex:";

            // 
            // txtMutexName
            // 
            this.txtMutexName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMutexName.Location = new System.Drawing.Point(125, 182);
            this.txtMutexName.Name = "txtMutexName";
            this.txtMutexName.Size = new System.Drawing.Size(320, 23);
            this.txtMutexName.TabIndex = 7;

            // 
            // grpEncryption
            // 
            this.grpEncryption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEncryption.Controls.Add(this.btnGetLocalHash);
            this.grpEncryption.Controls.Add(this.txtMainHash);
            this.grpEncryption.Controls.Add(this.lblMainHash);
            this.grpEncryption.Controls.Add(this.chkEncryptConfig);
            this.grpEncryption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpEncryption.Location = new System.Drawing.Point(12, 235);
            this.grpEncryption.Name = "grpEncryption";
            this.grpEncryption.Size = new System.Drawing.Size(702, 130);
            this.grpEncryption.TabIndex = 1;
            this.grpEncryption.TabStop = false;
            this.grpEncryption.Text = "PROTEÇÃO AES-256 E CHECKSUM MD5";

            // 
            // chkEncryptConfig
            // 
            this.chkEncryptConfig.AutoSize = true;
            this.chkEncryptConfig.Checked = true;
            this.chkEncryptConfig.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEncryptConfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkEncryptConfig.Location = new System.Drawing.Point(20, 28);
            this.chkEncryptConfig.Name = "chkEncryptConfig";
            this.chkEncryptConfig.Size = new System.Drawing.Size(437, 19);
            this.chkEncryptConfig.TabIndex = 0;
            this.chkEncryptConfig.Text = "Criptografar 'launcher_config.json' com AES-256 (Impedir edição por jogadores)";
            this.chkEncryptConfig.UseVisualStyleBackColor = true;

            // 
            // lblMainHash
            // 
            this.lblMainHash.AutoSize = true;
            this.lblMainHash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMainHash.Location = new System.Drawing.Point(20, 65);
            this.lblMainHash.Name = "lblMainHash";
            this.lblMainHash.Size = new System.Drawing.Size(124, 15);
            this.lblMainHash.TabIndex = 1;
            this.lblMainHash.Text = "Hash MD5 Esperado:";

            // 
            // txtMainHash
            // 
            this.txtMainHash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMainHash.Location = new System.Drawing.Point(155, 62);
            this.txtMainHash.Name = "txtMainHash";
            this.txtMainHash.Size = new System.Drawing.Size(320, 23);
            this.txtMainHash.TabIndex = 2;

            // 
            // btnGetLocalHash
            // 
            this.btnGetLocalHash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetLocalHash.Location = new System.Drawing.Point(485, 61);
            this.btnGetLocalHash.Name = "btnGetLocalHash";
            this.btnGetLocalHash.Size = new System.Drawing.Size(195, 25);
            this.btnGetLocalHash.TabIndex = 3;
            this.btnGetLocalHash.Text = "Obter MD5 do main.exe local";
            this.btnGetLocalHash.UseVisualStyleBackColor = true;
            this.btnGetLocalHash.Click += new System.EventHandler(this.BtnGetLocalHash_Click);

            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFooter.Controls.Add(this.btnExit);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Controls.Add(this.lblFooterInfo);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 482);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(734, 48);
            this.pnlFooter.TabIndex = 2;

            // 
            // lblFooterInfo
            // 
            this.lblFooterInfo.AutoEllipsis = true;
            this.lblFooterInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFooterInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(140)))));
            this.lblFooterInfo.Location = new System.Drawing.Point(14, 15);
            this.lblFooterInfo.Name = "lblFooterInfo";
            this.lblFooterInfo.Size = new System.Drawing.Size(430, 20);
            this.lblFooterInfo.TabIndex = 0;
            this.lblFooterInfo.Text = "Proteção: Arquivo 'launcher_config.json' com AES-256";

            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(460, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Salvar Configurações";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);

            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(640, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);

            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(734, 530);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurador do ConnectServer && Launcher - MuOnline";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabServer.ResumeLayout(false);
            this.grpMainRoute.ResumeLayout(false);
            this.grpMainRoute.PerformLayout();
            this.grpAltRoute.ResumeLayout(false);
            this.grpAltRoute.PerformLayout();
            this.tabGame.ResumeLayout(false);
            this.grpExecutable.ResumeLayout(false);
            this.grpExecutable.PerformLayout();
            this.tabLinks.ResumeLayout(false);
            this.grpLinks.ResumeLayout(false);
            this.grpLinks.PerformLayout();
            this.tabSecurity.ResumeLayout(false);
            this.grpClientSecurity.ResumeLayout(false);
            this.grpClientSecurity.PerformLayout();
            this.grpEncryption.ResumeLayout(false);
            this.grpEncryption.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabServer;
        private System.Windows.Forms.GroupBox grpMainRoute;
        private System.Windows.Forms.Label lblMainIp;
        private System.Windows.Forms.TextBox txtMainIp;
        private System.Windows.Forms.Label lblMainConnectPort;
        private System.Windows.Forms.TextBox txtMainConnectPort;
        private System.Windows.Forms.Label lblMainPort;
        private System.Windows.Forms.TextBox txtMainPort;
        private System.Windows.Forms.Button btnTestMain;
        private System.Windows.Forms.Label lblMainRouteTip;

        private System.Windows.Forms.GroupBox grpAltRoute;
        private System.Windows.Forms.Label lblAltIp;
        private System.Windows.Forms.TextBox txtAltIp;
        private System.Windows.Forms.Label lblAltConnectPort;
        private System.Windows.Forms.TextBox txtAltConnectPort;
        private System.Windows.Forms.Label lblAltPort;
        private System.Windows.Forms.TextBox txtAltPort;
        private System.Windows.Forms.Button btnTestAlt;
        private System.Windows.Forms.Label lblAltRouteTip;

        private System.Windows.Forms.TabPage tabGame;
        private System.Windows.Forms.GroupBox grpExecutable;
        private System.Windows.Forms.Label lblExecutable;
        private System.Windows.Forms.TextBox txtExecutable;
        private System.Windows.Forms.Label lblArgsMode;
        private System.Windows.Forms.ComboBox cboArgsMode;
        private System.Windows.Forms.Label lblArgsHelp;

        private System.Windows.Forms.TabPage tabLinks;
        private System.Windows.Forms.GroupBox grpLinks;
        private System.Windows.Forms.Label lblWebsiteUrl;
        private System.Windows.Forms.TextBox txtWebsiteUrl;
        private System.Windows.Forms.Label lblRegisterUrl;
        private System.Windows.Forms.TextBox txtRegisterUrl;
        private System.Windows.Forms.Label lblRegisterApiUrl;
        private System.Windows.Forms.TextBox txtRegisterApiUrl;
        private System.Windows.Forms.Label lblRankingUrl;
        private System.Windows.Forms.TextBox txtRankingUrl;
        private System.Windows.Forms.Label lblNewsUrl;
        private System.Windows.Forms.TextBox txtNewsUrl;
        private System.Windows.Forms.Label lblUpdateUrl;
        private System.Windows.Forms.TextBox txtUpdateUrl;

        private System.Windows.Forms.TabPage tabSecurity;
        private System.Windows.Forms.GroupBox grpClientSecurity;
        private System.Windows.Forms.CheckBox chkVerifyIntegrity;
        private System.Windows.Forms.CheckBox chkAntiCheat;
        private System.Windows.Forms.CheckBox chkDllWhitelist;
        private System.Windows.Forms.CheckBox chkLauncherGuard;
        private System.Windows.Forms.CheckBox chkRestoreLauncher;
        private System.Windows.Forms.CheckBox chkMutexLock;
        private System.Windows.Forms.Label lblMutexName;
        private System.Windows.Forms.TextBox txtMutexName;

        private System.Windows.Forms.GroupBox grpEncryption;
        private System.Windows.Forms.CheckBox chkEncryptConfig;
        private System.Windows.Forms.Label lblMainHash;
        private System.Windows.Forms.TextBox txtMainHash;
        private System.Windows.Forms.Button btnGetLocalHash;

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooterInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}
