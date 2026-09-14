namespace UpdateBuilder
{
    partial class MainForm
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
            this.lblRootDir = new System.Windows.Forms.Label();
            this.txtRootDir = new System.Windows.Forms.TextBox();
            this.btnSelectRootDir = new System.Windows.Forms.Button();

            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabManifest = new System.Windows.Forms.TabPage();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnScanFolder = new System.Windows.Forms.Button();
            this.btnAddSingleFile = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnLoadManifest = new System.Windows.Forms.Button();
            this.btnSaveManifest = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.colPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFormattedSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSizeBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.tabUpdateProvider = new System.Windows.Forms.TabPage();
            this.gbProviderSelect = new System.Windows.Forms.GroupBox();
            this.rbProviderHttp = new System.Windows.Forms.RadioButton();
            this.rbProviderGitHub = new System.Windows.Forms.RadioButton();
            this.gbHttpSettings = new System.Windows.Forms.GroupBox();
            this.lblUpdateUrl = new System.Windows.Forms.Label();
            this.txtUpdateUrl = new System.Windows.Forms.TextBox();
            this.btnTestHttpUrl = new System.Windows.Forms.Button();
            this.gbGitHubSettings = new System.Windows.Forms.GroupBox();
            this.lblGitHubOwner = new System.Windows.Forms.Label();
            this.txtGitHubOwner = new System.Windows.Forms.TextBox();
            this.lblGitHubRepo = new System.Windows.Forms.Label();
            this.txtGitHubRepo = new System.Windows.Forms.TextBox();
            this.lblGitHubBranch = new System.Windows.Forms.Label();
            this.txtGitHubBranch = new System.Windows.Forms.TextBox();
            this.lblGitHubToken = new System.Windows.Forms.Label();
            this.txtGitHubToken = new System.Windows.Forms.TextBox();
            this.chkUseGitHubReleases = new System.Windows.Forms.CheckBox();
            this.btnTestGitHub = new System.Windows.Forms.Button();
            this.gbSyncConfig = new System.Windows.Forms.GroupBox();
            this.lblConfigPathTitle = new System.Windows.Forms.Label();
            this.txtConfigPathDisplay = new System.Windows.Forms.TextBox();
            this.lblConfigEncryptStatus = new System.Windows.Forms.Label();
            this.btnLoadLauncherConfig = new System.Windows.Forms.Button();
            this.btnSaveLauncherConfig = new System.Windows.Forms.Button();

            this.tabDownloader = new System.Windows.Forms.TabPage();
            this.gbDownloaderConfig = new System.Windows.Forms.GroupBox();
            this.chkEnableDownloader = new System.Windows.Forms.CheckBox();
            this.chkDownloaderCompleted = new System.Windows.Forms.CheckBox();
            this.lblDownloaderFile1 = new System.Windows.Forms.Label();
            this.txtDownloaderFile1 = new System.Windows.Forms.TextBox();
            this.lblDownloaderFile2 = new System.Windows.Forms.Label();
            this.txtDownloaderFile2 = new System.Windows.Forms.TextBox();
            this.btnTestRelease = new System.Windows.Forms.Button();
            this.btnSaveDownloaderConfig = new System.Windows.Forms.Button();
            this.gbZipBuilder = new System.Windows.Forms.GroupBox();
            this.lblZipInfo = new System.Windows.Forms.Label();
            this.btnBuildZipWithSound = new System.Windows.Forms.Button();
            this.btnBuildZipNoSound = new System.Windows.Forms.Button();

            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();

            this.pnlTop.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabManifest.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.tabUpdateProvider.SuspendLayout();
            this.gbProviderSelect.SuspendLayout();
            this.gbHttpSettings.SuspendLayout();
            this.gbGitHubSettings.SuspendLayout();
            this.gbSyncConfig.SuspendLayout();
            this.tabDownloader.SuspendLayout();
            this.gbDownloaderConfig.SuspendLayout();
            this.gbZipBuilder.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.lblRootDir);
            this.pnlTop.Controls.Add(this.txtRootDir);
            this.pnlTop.Controls.Add(this.btnSelectRootDir);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(984, 75);
            this.pnlTop.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(425, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Gerenciador e Gerador de Updates - MuOnline Launcher";

            // 
            // lblRootDir
            // 
            this.lblRootDir.AutoSize = true;
            this.lblRootDir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRootDir.Location = new System.Drawing.Point(12, 43);
            this.lblRootDir.Name = "lblRootDir";
            this.lblRootDir.Size = new System.Drawing.Size(120, 15);
            this.lblRootDir.TabIndex = 1;
            this.lblRootDir.Text = "Diretório Raiz Cliente:";

            // 
            // txtRootDir
            // 
            this.txtRootDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRootDir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRootDir.Location = new System.Drawing.Point(145, 40);
            this.txtRootDir.Name = "txtRootDir";
            this.txtRootDir.Size = new System.Drawing.Size(664, 23);
            this.txtRootDir.TabIndex = 2;
            this.txtRootDir.TextChanged += new System.EventHandler(this.TxtRootDir_TextChanged);

            // 
            // btnSelectRootDir
            // 
            this.btnSelectRootDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectRootDir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectRootDir.Location = new System.Drawing.Point(819, 39);
            this.btnSelectRootDir.Name = "btnSelectRootDir";
            this.btnSelectRootDir.Size = new System.Drawing.Size(150, 25);
            this.btnSelectRootDir.TabIndex = 3;
            this.btnSelectRootDir.Text = "Selecionar Pasta Raiz...";
            this.btnSelectRootDir.UseVisualStyleBackColor = true;
            this.btnSelectRootDir.Click += new System.EventHandler(this.BtnSelectRootDir_Click);

            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabManifest);
            this.tabMain.Controls.Add(this.tabUpdateProvider);
            this.tabMain.Controls.Add(this.tabDownloader);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabMain.ItemSize = new System.Drawing.Size(180, 28);
            this.tabMain.Location = new System.Drawing.Point(0, 75);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(984, 550);
            this.tabMain.TabIndex = 1;

            // 
            // tabManifest
            // 
            this.tabManifest.BackColor = System.Drawing.SystemColors.Control;
            this.tabManifest.Controls.Add(this.dgvFiles);
            this.tabManifest.Controls.Add(this.pnlSearch);
            this.tabManifest.Controls.Add(this.pnlActions);
            this.tabManifest.Location = new System.Drawing.Point(4, 32);
            this.tabManifest.Name = "tabManifest";
            this.tabManifest.Padding = new System.Windows.Forms.Padding(6);
            this.tabManifest.Size = new System.Drawing.Size(976, 514);
            this.tabManifest.TabIndex = 0;
            this.tabManifest.Text = "Gerador de Manifestos";

            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnScanFolder);
            this.pnlActions.Controls.Add(this.btnAddSingleFile);
            this.pnlActions.Controls.Add(this.btnRemoveItem);
            this.pnlActions.Controls.Add(this.btnLoadManifest);
            this.pnlActions.Controls.Add(this.btnSaveManifest);
            this.pnlActions.Controls.Add(this.btnClearList);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Location = new System.Drawing.Point(6, 6);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(964, 45);
            this.pnlActions.TabIndex = 0;

            // 
            // btnScanFolder
            // 
            this.btnScanFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.btnScanFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScanFolder.ForeColor = System.Drawing.Color.White;
            this.btnScanFolder.Location = new System.Drawing.Point(3, 7);
            this.btnScanFolder.Name = "btnScanFolder";
            this.btnScanFolder.Size = new System.Drawing.Size(180, 30);
            this.btnScanFolder.TabIndex = 0;
            this.btnScanFolder.Text = "Escanear Pasta Completa";
            this.btnScanFolder.UseVisualStyleBackColor = false;
            this.btnScanFolder.Click += new System.EventHandler(this.BtnScanFolder_Click);

            // 
            // btnAddSingleFile
            // 
            this.btnAddSingleFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddSingleFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSingleFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSingleFile.ForeColor = System.Drawing.Color.White;
            this.btnAddSingleFile.Location = new System.Drawing.Point(191, 7);
            this.btnAddSingleFile.Name = "btnAddSingleFile";
            this.btnAddSingleFile.Size = new System.Drawing.Size(185, 30);
            this.btnAddSingleFile.TabIndex = 1;
            this.btnAddSingleFile.Text = "Adicionar Arquivo Único";
            this.btnAddSingleFile.UseVisualStyleBackColor = false;
            this.btnAddSingleFile.Click += new System.EventHandler(this.BtnAddSingleFile_Click);

            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveItem.Location = new System.Drawing.Point(384, 7);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(130, 30);
            this.btnRemoveItem.TabIndex = 2;
            this.btnRemoveItem.Text = "Remover Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.BtnRemoveItem_Click);

            // 
            // btnLoadManifest
            // 
            this.btnLoadManifest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadManifest.Location = new System.Drawing.Point(522, 7);
            this.btnLoadManifest.Name = "btnLoadManifest";
            this.btnLoadManifest.Size = new System.Drawing.Size(135, 30);
            this.btnLoadManifest.TabIndex = 3;
            this.btnLoadManifest.Text = "Abrir Manifesto...";
            this.btnLoadManifest.UseVisualStyleBackColor = true;
            this.btnLoadManifest.Click += new System.EventHandler(this.BtnLoadManifest_Click);

            // 
            // btnSaveManifest
            // 
            this.btnSaveManifest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnSaveManifest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveManifest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveManifest.ForeColor = System.Drawing.Color.White;
            this.btnSaveManifest.Location = new System.Drawing.Point(665, 7);
            this.btnSaveManifest.Name = "btnSaveManifest";
            this.btnSaveManifest.Size = new System.Drawing.Size(155, 30);
            this.btnSaveManifest.TabIndex = 4;
            this.btnSaveManifest.Text = "Salvar Manifesto...";
            this.btnSaveManifest.UseVisualStyleBackColor = false;
            this.btnSaveManifest.Click += new System.EventHandler(this.BtnSaveManifest_Click);

            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearList.Location = new System.Drawing.Point(828, 7);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(110, 30);
            this.btnClearList.TabIndex = 5;
            this.btnClearList.Text = "Limpar Lista";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.BtnClearList_Click);

            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(6, 51);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(964, 35);
            this.pnlSearch.TabIndex = 1;

            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(3, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(110, 15);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Filtrar por caminho:";

            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(139, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(799, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);

            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToOrderColumns = true;
            this.dgvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPath,
            this.colHash,
            this.colFormattedSize,
            this.colSizeBytes});
            this.dgvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvFiles.Location = new System.Drawing.Point(6, 86);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.RowTemplate.Height = 25;
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new System.Drawing.Size(964, 422);
            this.dgvFiles.TabIndex = 2;

            // 
            // colPath
            // 
            this.colPath.DataPropertyName = "Path";
            this.colPath.FillWeight = 50F;
            this.colPath.HeaderText = "Caminho Relativo";
            this.colPath.Name = "colPath";

            // 
            // colHash
            // 
            this.colHash.DataPropertyName = "Hash";
            this.colHash.FillWeight = 35F;
            this.colHash.HeaderText = "Hash MD5";
            this.colHash.Name = "colHash";

            // 
            // colFormattedSize
            // 
            this.colFormattedSize.DataPropertyName = "FormattedSize";
            this.colFormattedSize.FillWeight = 15F;
            this.colFormattedSize.HeaderText = "Tamanho";
            this.colFormattedSize.Name = "colFormattedSize";
            this.colFormattedSize.ReadOnly = true;

            // 
            // colSizeBytes
            // 
            this.colSizeBytes.DataPropertyName = "Size";
            this.colSizeBytes.FillWeight = 15F;
            this.colSizeBytes.HeaderText = "Bytes";
            this.colSizeBytes.Name = "colSizeBytes";

            // 
            // tabUpdateProvider
            // 
            this.tabUpdateProvider.AutoScroll = true;
            this.tabUpdateProvider.BackColor = System.Drawing.SystemColors.Control;
            this.tabUpdateProvider.Controls.Add(this.gbSyncConfig);
            this.tabUpdateProvider.Controls.Add(this.gbGitHubSettings);
            this.tabUpdateProvider.Controls.Add(this.gbHttpSettings);
            this.tabUpdateProvider.Controls.Add(this.gbProviderSelect);
            this.tabUpdateProvider.Location = new System.Drawing.Point(4, 32);
            this.tabUpdateProvider.Name = "tabUpdateProvider";
            this.tabUpdateProvider.Padding = new System.Windows.Forms.Padding(12);
            this.tabUpdateProvider.Size = new System.Drawing.Size(976, 514);
            this.tabUpdateProvider.TabIndex = 1;
            this.tabUpdateProvider.Text = "Provedor de Updates && GitHub";

            // 
            // gbProviderSelect
            // 
            this.gbProviderSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProviderSelect.Controls.Add(this.rbProviderHttp);
            this.gbProviderSelect.Controls.Add(this.rbProviderGitHub);
            this.gbProviderSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbProviderSelect.Location = new System.Drawing.Point(12, 12);
            this.gbProviderSelect.Name = "gbProviderSelect";
            this.gbProviderSelect.Size = new System.Drawing.Size(952, 60);
            this.gbProviderSelect.TabIndex = 0;
            this.gbProviderSelect.TabStop = false;
            this.gbProviderSelect.Text = "Provedor do Motor de Atualizações";

            // 
            // rbProviderHttp
            // 
            this.rbProviderHttp.AutoSize = true;
            this.rbProviderHttp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbProviderHttp.Location = new System.Drawing.Point(20, 26);
            this.rbProviderHttp.Name = "rbProviderHttp";
            this.rbProviderHttp.Size = new System.Drawing.Size(360, 19);
            this.rbProviderHttp.TabIndex = 0;
            this.rbProviderHttp.TabStop = true;
            this.rbProviderHttp.Text = "Servidor HTTP Tradicional (Patch via Web Server IIS/Apache/Nginx)";
            this.rbProviderHttp.UseVisualStyleBackColor = true;
            this.rbProviderHttp.CheckedChanged += new System.EventHandler(this.RbProvider_CheckedChanged);

            // 
            // rbProviderGitHub
            // 
            this.rbProviderGitHub.AutoSize = true;
            this.rbProviderGitHub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbProviderGitHub.Location = new System.Drawing.Point(420, 26);
            this.rbProviderGitHub.Name = "rbProviderGitHub";
            this.rbProviderGitHub.Size = new System.Drawing.Size(370, 19);
            this.rbProviderGitHub.TabIndex = 1;
            this.rbProviderGitHub.TabStop = true;
            this.rbProviderGitHub.Text = "GitHub Releases / Repositório (Recomendado - CDN Global Gratuita)";
            this.rbProviderGitHub.UseVisualStyleBackColor = true;
            this.rbProviderGitHub.CheckedChanged += new System.EventHandler(this.RbProvider_CheckedChanged);

            // 
            // gbHttpSettings
            // 
            this.gbHttpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHttpSettings.Controls.Add(this.lblUpdateUrl);
            this.gbHttpSettings.Controls.Add(this.txtUpdateUrl);
            this.gbHttpSettings.Controls.Add(this.btnTestHttpUrl);
            this.gbHttpSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbHttpSettings.Location = new System.Drawing.Point(12, 78);
            this.gbHttpSettings.Name = "gbHttpSettings";
            this.gbHttpSettings.Size = new System.Drawing.Size(952, 72);
            this.gbHttpSettings.TabIndex = 1;
            this.gbHttpSettings.TabStop = false;
            this.gbHttpSettings.Text = "Configuração do Servidor HTTP";

            // 
            // lblUpdateUrl
            // 
            this.lblUpdateUrl.AutoSize = true;
            this.lblUpdateUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateUrl.Location = new System.Drawing.Point(20, 32);
            this.lblUpdateUrl.Name = "lblUpdateUrl";
            this.lblUpdateUrl.Size = new System.Drawing.Size(124, 15);
            this.lblUpdateUrl.TabIndex = 0;
            this.lblUpdateUrl.Text = "URL Base do Patch HTTP:";

            // 
            // txtUpdateUrl
            // 
            this.txtUpdateUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpdateUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUpdateUrl.Location = new System.Drawing.Point(155, 29);
            this.txtUpdateUrl.Name = "txtUpdateUrl";
            this.txtUpdateUrl.Size = new System.Drawing.Size(630, 23);
            this.txtUpdateUrl.TabIndex = 1;

            // 
            // btnTestHttpUrl
            // 
            this.btnTestHttpUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestHttpUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTestHttpUrl.Location = new System.Drawing.Point(795, 28);
            this.btnTestHttpUrl.Name = "btnTestHttpUrl";
            this.btnTestHttpUrl.Size = new System.Drawing.Size(140, 25);
            this.btnTestHttpUrl.TabIndex = 2;
            this.btnTestHttpUrl.Text = "Testar URL HTTP";
            this.btnTestHttpUrl.UseVisualStyleBackColor = true;
            this.btnTestHttpUrl.Click += new System.EventHandler(this.BtnTestHttpUrl_Click);

            // 
            // gbGitHubSettings
            // 
            this.gbGitHubSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGitHubSettings.Controls.Add(this.lblGitHubOwner);
            this.gbGitHubSettings.Controls.Add(this.txtGitHubOwner);
            this.gbGitHubSettings.Controls.Add(this.lblGitHubRepo);
            this.gbGitHubSettings.Controls.Add(this.txtGitHubRepo);
            this.gbGitHubSettings.Controls.Add(this.lblGitHubBranch);
            this.gbGitHubSettings.Controls.Add(this.txtGitHubBranch);
            this.gbGitHubSettings.Controls.Add(this.lblGitHubToken);
            this.gbGitHubSettings.Controls.Add(this.txtGitHubToken);
            this.gbGitHubSettings.Controls.Add(this.chkUseGitHubReleases);
            this.gbGitHubSettings.Controls.Add(this.btnTestGitHub);
            this.gbGitHubSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbGitHubSettings.Location = new System.Drawing.Point(12, 156);
            this.gbGitHubSettings.Name = "gbGitHubSettings";
            this.gbGitHubSettings.Size = new System.Drawing.Size(952, 160);
            this.gbGitHubSettings.TabIndex = 2;
            this.gbGitHubSettings.TabStop = false;
            this.gbGitHubSettings.Text = "Configuração do Repositório GitHub";

            // 
            // lblGitHubOwner
            // 
            this.lblGitHubOwner.AutoSize = true;
            this.lblGitHubOwner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGitHubOwner.Location = new System.Drawing.Point(20, 32);
            this.lblGitHubOwner.Name = "lblGitHubOwner";
            this.lblGitHubOwner.Size = new System.Drawing.Size(126, 15);
            this.lblGitHubOwner.TabIndex = 0;
            this.lblGitHubOwner.Text = "Usuário / Org (Owner):";

            // 
            // txtGitHubOwner
            // 
            this.txtGitHubOwner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGitHubOwner.Location = new System.Drawing.Point(155, 29);
            this.txtGitHubOwner.Name = "txtGitHubOwner";
            this.txtGitHubOwner.Size = new System.Drawing.Size(260, 23);
            this.txtGitHubOwner.TabIndex = 1;

            // 
            // lblGitHubRepo
            // 
            this.lblGitHubRepo.AutoSize = true;
            this.lblGitHubRepo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGitHubRepo.Location = new System.Drawing.Point(440, 32);
            this.lblGitHubRepo.Name = "lblGitHubRepo";
            this.lblGitHubRepo.Size = new System.Drawing.Size(124, 15);
            this.lblGitHubRepo.TabIndex = 2;
            this.lblGitHubRepo.Text = "Nome do Repositório:";

            // 
            // txtGitHubRepo
            // 
            this.txtGitHubRepo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGitHubRepo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGitHubRepo.Location = new System.Drawing.Point(575, 29);
            this.txtGitHubRepo.Name = "txtGitHubRepo";
            this.txtGitHubRepo.Size = new System.Drawing.Size(360, 23);
            this.txtGitHubRepo.TabIndex = 3;

            // 
            // lblGitHubBranch
            // 
            this.lblGitHubBranch.AutoSize = true;
            this.lblGitHubBranch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGitHubBranch.Location = new System.Drawing.Point(20, 68);
            this.lblGitHubBranch.Name = "lblGitHubBranch";
            this.lblGitHubBranch.Size = new System.Drawing.Size(127, 15);
            this.lblGitHubBranch.TabIndex = 4;
            this.lblGitHubBranch.Text = "Branch (Padrão: main):";

            // 
            // txtGitHubBranch
            // 
            this.txtGitHubBranch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGitHubBranch.Location = new System.Drawing.Point(155, 65);
            this.txtGitHubBranch.Name = "txtGitHubBranch";
            this.txtGitHubBranch.Size = new System.Drawing.Size(260, 23);
            this.txtGitHubBranch.TabIndex = 5;

            // 
            // lblGitHubToken
            // 
            this.lblGitHubToken.AutoSize = true;
            this.lblGitHubToken.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGitHubToken.Location = new System.Drawing.Point(440, 68);
            this.lblGitHubToken.Name = "lblGitHubToken";
            this.lblGitHubToken.Size = new System.Drawing.Size(127, 15);
            this.lblGitHubToken.TabIndex = 6;
            this.lblGitHubToken.Text = "Token PAT (se privado):";

            // 
            // txtGitHubToken
            // 
            this.txtGitHubToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGitHubToken.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGitHubToken.Location = new System.Drawing.Point(575, 65);
            this.txtGitHubToken.Name = "txtGitHubToken";
            this.txtGitHubToken.PasswordChar = '•';
            this.txtGitHubToken.Size = new System.Drawing.Size(360, 23);
            this.txtGitHubToken.TabIndex = 7;

            // 
            // chkUseGitHubReleases
            // 
            this.chkUseGitHubReleases.AutoSize = true;
            this.chkUseGitHubReleases.Checked = true;
            this.chkUseGitHubReleases.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseGitHubReleases.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkUseGitHubReleases.Location = new System.Drawing.Point(23, 108);
            this.chkUseGitHubReleases.Name = "chkUseGitHubReleases";
            this.chkUseGitHubReleases.Size = new System.Drawing.Size(361, 19);
            this.chkUseGitHubReleases.TabIndex = 8;
            this.chkUseGitHubReleases.Text = "Utilizar GitHub Releases para distribuição (Recomendado)";
            this.chkUseGitHubReleases.UseVisualStyleBackColor = true;

            // 
            // btnTestGitHub
            // 
            this.btnTestGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestGitHub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTestGitHub.Location = new System.Drawing.Point(755, 104);
            this.btnTestGitHub.Name = "btnTestGitHub";
            this.btnTestGitHub.Size = new System.Drawing.Size(180, 28);
            this.btnTestGitHub.TabIndex = 9;
            this.btnTestGitHub.Text = "Testar Conexão GitHub";
            this.btnTestGitHub.UseVisualStyleBackColor = true;
            this.btnTestGitHub.Click += new System.EventHandler(this.BtnTestGitHub_Click);

            // 
            // gbSyncConfig
            // 
            this.gbSyncConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSyncConfig.Controls.Add(this.btnSaveLauncherConfig);
            this.gbSyncConfig.Controls.Add(this.btnLoadLauncherConfig);
            this.gbSyncConfig.Controls.Add(this.lblConfigEncryptStatus);
            this.gbSyncConfig.Controls.Add(this.txtConfigPathDisplay);
            this.gbSyncConfig.Controls.Add(this.lblConfigPathTitle);
            this.gbSyncConfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSyncConfig.Location = new System.Drawing.Point(12, 322);
            this.gbSyncConfig.Name = "gbSyncConfig";
            this.gbSyncConfig.Size = new System.Drawing.Size(952, 118);
            this.gbSyncConfig.TabIndex = 3;
            this.gbSyncConfig.TabStop = false;
            this.gbSyncConfig.Text = "Sincronização com o Arquivo de Configuração do Launcher";

            // 
            // lblConfigPathTitle
            // 
            this.lblConfigPathTitle.AutoSize = true;
            this.lblConfigPathTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfigPathTitle.Location = new System.Drawing.Point(20, 25);
            this.lblConfigPathTitle.Name = "lblConfigPathTitle";
            this.lblConfigPathTitle.Size = new System.Drawing.Size(262, 15);
            this.lblConfigPathTitle.TabIndex = 0;
            this.lblConfigPathTitle.Text = "Caminho do Arquivo de Configuração (launcher_config.json):";

            // 
            // txtConfigPathDisplay
            // 
            this.txtConfigPathDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfigPathDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfigPathDisplay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfigPathDisplay.Location = new System.Drawing.Point(20, 45);
            this.txtConfigPathDisplay.Name = "txtConfigPathDisplay";
            this.txtConfigPathDisplay.ReadOnly = true;
            this.txtConfigPathDisplay.Size = new System.Drawing.Size(912, 23);
            this.txtConfigPathDisplay.TabIndex = 1;

            // 
            // lblConfigEncryptStatus
            // 
            this.lblConfigEncryptStatus.AutoSize = true;
            this.lblConfigEncryptStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfigEncryptStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.lblConfigEncryptStatus.Location = new System.Drawing.Point(20, 80);
            this.lblConfigEncryptStatus.Name = "lblConfigEncryptStatus";
            this.lblConfigEncryptStatus.Size = new System.Drawing.Size(265, 15);
            this.lblConfigEncryptStatus.TabIndex = 2;
            this.lblConfigEncryptStatus.Text = "Status: Protegido com Criptografia AES-256";

            // 
            // btnLoadLauncherConfig
            // 
            this.btnLoadLauncherConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadLauncherConfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadLauncherConfig.Location = new System.Drawing.Point(545, 75);
            this.btnLoadLauncherConfig.Name = "btnLoadLauncherConfig";
            this.btnLoadLauncherConfig.Size = new System.Drawing.Size(180, 28);
            this.btnLoadLauncherConfig.TabIndex = 3;
            this.btnLoadLauncherConfig.Text = "Carregar do Arquivo";
            this.btnLoadLauncherConfig.UseVisualStyleBackColor = true;
            this.btnLoadLauncherConfig.Click += new System.EventHandler(this.BtnLoadLauncherConfig_Click);

            // 
            // btnSaveLauncherConfig
            // 
            this.btnSaveLauncherConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveLauncherConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSaveLauncherConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLauncherConfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveLauncherConfig.ForeColor = System.Drawing.Color.White;
            this.btnSaveLauncherConfig.Location = new System.Drawing.Point(735, 75);
            this.btnSaveLauncherConfig.Name = "btnSaveLauncherConfig";
            this.btnSaveLauncherConfig.Size = new System.Drawing.Size(197, 28);
            this.btnSaveLauncherConfig.TabIndex = 4;
            this.btnSaveLauncherConfig.Text = "Salvar no launcher_config.json";
            this.btnSaveLauncherConfig.UseVisualStyleBackColor = false;
            this.btnSaveLauncherConfig.Click += new System.EventHandler(this.BtnSaveLauncherConfig_Click);

            // 
            // tabDownloader
            // 
            this.tabDownloader.AutoScroll = true;
            this.tabDownloader.BackColor = System.Drawing.SystemColors.Control;
            this.tabDownloader.Controls.Add(this.gbZipBuilder);
            this.tabDownloader.Controls.Add(this.gbDownloaderConfig);
            this.tabDownloader.Location = new System.Drawing.Point(4, 32);
            this.tabDownloader.Name = "tabDownloader";
            this.tabDownloader.Padding = new System.Windows.Forms.Padding(12);
            this.tabDownloader.Size = new System.Drawing.Size(976, 514);
            this.tabDownloader.TabIndex = 2;
            this.tabDownloader.Text = "Downloader de 1ª Instalação && Pacotes ZIP";

            // 
            // gbDownloaderConfig
            // 
            this.gbDownloaderConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDownloaderConfig.Controls.Add(this.chkEnableDownloader);
            this.gbDownloaderConfig.Controls.Add(this.chkDownloaderCompleted);
            this.gbDownloaderConfig.Controls.Add(this.lblDownloaderFile1);
            this.gbDownloaderConfig.Controls.Add(this.txtDownloaderFile1);
            this.gbDownloaderConfig.Controls.Add(this.lblDownloaderFile2);
            this.gbDownloaderConfig.Controls.Add(this.txtDownloaderFile2);
            this.gbDownloaderConfig.Controls.Add(this.btnTestRelease);
            this.gbDownloaderConfig.Controls.Add(this.btnSaveDownloaderConfig);
            this.gbDownloaderConfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbDownloaderConfig.Location = new System.Drawing.Point(12, 12);
            this.gbDownloaderConfig.Name = "gbDownloaderConfig";
            this.gbDownloaderConfig.Size = new System.Drawing.Size(952, 185);
            this.gbDownloaderConfig.TabIndex = 0;
            this.gbDownloaderConfig.TabStop = false;
            this.gbDownloaderConfig.Text = "Configuração do Downloader de 1ª Instalação (Cliente)";

            // 
            // chkEnableDownloader
            // 
            this.chkEnableDownloader.AutoSize = true;
            this.chkEnableDownloader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkEnableDownloader.Location = new System.Drawing.Point(20, 30);
            this.chkEnableDownloader.Name = "chkEnableDownloader";
            this.chkEnableDownloader.Size = new System.Drawing.Size(434, 19);
            this.chkEnableDownloader.TabIndex = 0;
            this.chkEnableDownloader.Text = "Ativar Downloader de Primeira Instalação (se main.exe não estiver presente)";
            this.chkEnableDownloader.UseVisualStyleBackColor = true;

            // 
            // chkDownloaderCompleted
            // 
            this.chkDownloaderCompleted.AutoSize = true;
            this.chkDownloaderCompleted.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkDownloaderCompleted.Location = new System.Drawing.Point(20, 60);
            this.chkDownloaderCompleted.Name = "chkDownloaderCompleted";
            this.chkDownloaderCompleted.Size = new System.Drawing.Size(425, 19);
            this.chkDownloaderCompleted.TabIndex = 1;
            this.chkDownloaderCompleted.Text = "Status da Máquina Local: Instalação já concluída (downloader_completed)";
            this.chkDownloaderCompleted.UseVisualStyleBackColor = true;

            // 
            // lblDownloaderFile1
            // 
            this.lblDownloaderFile1.AutoSize = true;
            this.lblDownloaderFile1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDownloaderFile1.Location = new System.Drawing.Point(20, 95);
            this.lblDownloaderFile1.Name = "lblDownloaderFile1";
            this.lblDownloaderFile1.Size = new System.Drawing.Size(141, 15);
            this.lblDownloaderFile1.TabIndex = 2;
            this.lblDownloaderFile1.Text = "Pacote Completo (c/ som):";

            // 
            // txtDownloaderFile1
            // 
            this.txtDownloaderFile1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDownloaderFile1.Location = new System.Drawing.Point(170, 92);
            this.txtDownloaderFile1.Name = "txtDownloaderFile1";
            this.txtDownloaderFile1.Size = new System.Drawing.Size(260, 23);
            this.txtDownloaderFile1.TabIndex = 3;
            this.txtDownloaderFile1.Text = "client_com_som.zip";

            // 
            // lblDownloaderFile2
            // 
            this.lblDownloaderFile2.AutoSize = true;
            this.lblDownloaderFile2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDownloaderFile2.Location = new System.Drawing.Point(460, 95);
            this.lblDownloaderFile2.Name = "lblDownloaderFile2";
            this.lblDownloaderFile2.Size = new System.Drawing.Size(127, 15);
            this.lblDownloaderFile2.TabIndex = 4;
            this.lblDownloaderFile2.Text = "Pacote Leve (sem som):";

            // 
            // txtDownloaderFile2
            // 
            this.txtDownloaderFile2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownloaderFile2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDownloaderFile2.Location = new System.Drawing.Point(600, 92);
            this.txtDownloaderFile2.Name = "txtDownloaderFile2";
            this.txtDownloaderFile2.Size = new System.Drawing.Size(335, 23);
            this.txtDownloaderFile2.TabIndex = 5;
            this.txtDownloaderFile2.Text = "client_sem_som.zip";

            // 
            // btnTestRelease
            // 
            this.btnTestRelease.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTestRelease.Location = new System.Drawing.Point(20, 135);
            this.btnTestRelease.Name = "btnTestRelease";
            this.btnTestRelease.Size = new System.Drawing.Size(240, 30);
            this.btnTestRelease.TabIndex = 6;
            this.btnTestRelease.Text = "Testar Release no GitHub (Checar Assets)";
            this.btnTestRelease.UseVisualStyleBackColor = true;
            this.btnTestRelease.Click += new System.EventHandler(this.BtnTestRelease_Click);

            // 
            // btnSaveDownloaderConfig
            // 
            this.btnSaveDownloaderConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDownloaderConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSaveDownloaderConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDownloaderConfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveDownloaderConfig.ForeColor = System.Drawing.Color.White;
            this.btnSaveDownloaderConfig.Location = new System.Drawing.Point(715, 135);
            this.btnSaveDownloaderConfig.Name = "btnSaveDownloaderConfig";
            this.btnSaveDownloaderConfig.Size = new System.Drawing.Size(220, 30);
            this.btnSaveDownloaderConfig.TabIndex = 7;
            this.btnSaveDownloaderConfig.Text = "Salvar no launcher_config.json";
            this.btnSaveDownloaderConfig.UseVisualStyleBackColor = false;
            this.btnSaveDownloaderConfig.Click += new System.EventHandler(this.BtnSaveLauncherConfig_Click);

            // 
            // gbZipBuilder
            // 
            this.gbZipBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbZipBuilder.Controls.Add(this.lblZipInfo);
            this.gbZipBuilder.Controls.Add(this.btnBuildZipWithSound);
            this.gbZipBuilder.Controls.Add(this.btnBuildZipNoSound);
            this.gbZipBuilder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbZipBuilder.Location = new System.Drawing.Point(12, 208);
            this.gbZipBuilder.Name = "gbZipBuilder";
            this.gbZipBuilder.Size = new System.Drawing.Size(952, 160);
            this.gbZipBuilder.TabIndex = 1;
            this.gbZipBuilder.TabStop = false;
            this.gbZipBuilder.Text = "Ferramenta de Empacotamento de Releases (ZIP && SHA-256)";

            // 
            // lblZipInfo
            // 
            this.lblZipInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZipInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblZipInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblZipInfo.Location = new System.Drawing.Point(20, 28);
            this.lblZipInfo.Name = "lblZipInfo";
            this.lblZipInfo.Size = new System.Drawing.Size(915, 45);
            this.lblZipInfo.TabIndex = 0;
            this.lblZipInfo.Text = "Esta ferramenta compacta os arquivos da pasta raiz do cliente em um arquivo ZIP otimizado e calcula automaticamente o hash SHA-256 gerando o arquivo correspondente (.sha256) pronto para anexar na Release do GitHub.";

            // 
            // btnBuildZipWithSound
            // 
            this.btnBuildZipWithSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.btnBuildZipWithSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuildZipWithSound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuildZipWithSound.ForeColor = System.Drawing.Color.White;
            this.btnBuildZipWithSound.Location = new System.Drawing.Point(23, 90);
            this.btnBuildZipWithSound.Name = "btnBuildZipWithSound";
            this.btnBuildZipWithSound.Size = new System.Drawing.Size(340, 36);
            this.btnBuildZipWithSound.TabIndex = 1;
            this.btnBuildZipWithSound.Text = "Gerar Pacote ZIP Completo (Com Som) + .sha256";
            this.btnBuildZipWithSound.UseVisualStyleBackColor = false;
            this.btnBuildZipWithSound.Click += new System.EventHandler(this.BtnBuildZipWithSound_Click);

            // 
            // btnBuildZipNoSound
            // 
            this.btnBuildZipNoSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnBuildZipNoSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuildZipNoSound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuildZipNoSound.ForeColor = System.Drawing.Color.White;
            this.btnBuildZipNoSound.Location = new System.Drawing.Point(385, 90);
            this.btnBuildZipNoSound.Name = "btnBuildZipNoSound";
            this.btnBuildZipNoSound.Size = new System.Drawing.Size(350, 36);
            this.btnBuildZipNoSound.TabIndex = 2;
            this.btnBuildZipNoSound.Text = "Gerar Pacote ZIP Leve (Sem Som) + .sha256";
            this.btnBuildZipNoSound.UseVisualStyleBackColor = false;
            this.btnBuildZipNoSound.Click += new System.EventHandler(this.BtnBuildZipNoSound_Click);

            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.progressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 625);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 25);
            this.statusStrip.TabIndex = 2;

            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(767, 20);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "Pronto.";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 19);
            this.progressBar.Visible = false;

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 650);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(880, 560);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador e Gerador de Updates - MuOnline Launcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabManifest.ResumeLayout(false);
            this.pnlActions.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.tabUpdateProvider.ResumeLayout(false);
            this.gbProviderSelect.ResumeLayout(false);
            this.gbProviderSelect.PerformLayout();
            this.gbHttpSettings.ResumeLayout(false);
            this.gbHttpSettings.PerformLayout();
            this.gbGitHubSettings.ResumeLayout(false);
            this.gbGitHubSettings.PerformLayout();
            this.gbSyncConfig.ResumeLayout(false);
            this.gbSyncConfig.PerformLayout();
            this.tabDownloader.ResumeLayout(false);
            this.gbDownloaderConfig.ResumeLayout(false);
            this.gbDownloaderConfig.PerformLayout();
            this.gbZipBuilder.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRootDir;
        private System.Windows.Forms.TextBox txtRootDir;
        private System.Windows.Forms.Button btnSelectRootDir;

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabManifest;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnScanFolder;
        private System.Windows.Forms.Button btnAddSingleFile;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnLoadManifest;
        private System.Windows.Forms.Button btnSaveManifest;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFormattedSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSizeBytes;

        private System.Windows.Forms.TabPage tabUpdateProvider;
        private System.Windows.Forms.GroupBox gbProviderSelect;
        private System.Windows.Forms.RadioButton rbProviderHttp;
        private System.Windows.Forms.RadioButton rbProviderGitHub;
        private System.Windows.Forms.GroupBox gbHttpSettings;
        private System.Windows.Forms.Label lblUpdateUrl;
        private System.Windows.Forms.TextBox txtUpdateUrl;
        private System.Windows.Forms.Button btnTestHttpUrl;
        private System.Windows.Forms.GroupBox gbGitHubSettings;
        private System.Windows.Forms.Label lblGitHubOwner;
        private System.Windows.Forms.TextBox txtGitHubOwner;
        private System.Windows.Forms.Label lblGitHubRepo;
        private System.Windows.Forms.TextBox txtGitHubRepo;
        private System.Windows.Forms.Label lblGitHubBranch;
        private System.Windows.Forms.TextBox txtGitHubBranch;
        private System.Windows.Forms.Label lblGitHubToken;
        private System.Windows.Forms.TextBox txtGitHubToken;
        private System.Windows.Forms.CheckBox chkUseGitHubReleases;
        private System.Windows.Forms.Button btnTestGitHub;
        private System.Windows.Forms.GroupBox gbSyncConfig;
        private System.Windows.Forms.Label lblConfigPathTitle;
        private System.Windows.Forms.TextBox txtConfigPathDisplay;
        private System.Windows.Forms.Label lblConfigEncryptStatus;
        private System.Windows.Forms.Button btnLoadLauncherConfig;
        private System.Windows.Forms.Button btnSaveLauncherConfig;

        private System.Windows.Forms.TabPage tabDownloader;
        private System.Windows.Forms.GroupBox gbDownloaderConfig;
        private System.Windows.Forms.CheckBox chkEnableDownloader;
        private System.Windows.Forms.CheckBox chkDownloaderCompleted;
        private System.Windows.Forms.Label lblDownloaderFile1;
        private System.Windows.Forms.TextBox txtDownloaderFile1;
        private System.Windows.Forms.Label lblDownloaderFile2;
        private System.Windows.Forms.TextBox txtDownloaderFile2;
        private System.Windows.Forms.Button btnTestRelease;
        private System.Windows.Forms.Button btnSaveDownloaderConfig;
        private System.Windows.Forms.GroupBox gbZipBuilder;
        private System.Windows.Forms.Label lblZipInfo;
        private System.Windows.Forms.Button btnBuildZipWithSound;
        private System.Windows.Forms.Button btnBuildZipNoSound;

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
    }
}
