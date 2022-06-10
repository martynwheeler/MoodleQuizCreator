namespace MoodleQuizCreator
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addcatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addsubcatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTreeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSelectedQuestionImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPageQuestionData = new System.Windows.Forms.TabPage();
            this.dataGridViewQuestions = new System.Windows.Forms.DataGridView();
            this.tabPageControlPanel = new System.Windows.Forms.TabPage();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonGCSE = new System.Windows.Forms.RadioButton();
            this.radioButtonALevel = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.labelTolerance = new System.Windows.Forms.Label();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.textBoxTolerance = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxAnswers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.txtExamPaperName = new System.Windows.Forms.TextBox();
            this.btnSaveImg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblImagePreview = new System.Windows.Forms.Label();
            this.txtQuestionName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.numCounter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewALevel = new System.Windows.Forms.TreeView();
            this.treeViewGCSE = new System.Windows.Forms.TreeView();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.sharpClipboard1 = new WK.Libraries.SharpClipboardNS.SharpClipboard(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPageQuestionData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).BeginInit();
            this.tabPageControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCounter)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MoodleQuizCreator";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuRestore,
            this.toolStripMenuClose});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 48);
            // 
            // toolStripMenuRestore
            // 
            this.toolStripMenuRestore.Name = "toolStripMenuRestore";
            this.toolStripMenuRestore.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuRestore.Text = "Restore";
            this.toolStripMenuRestore.Click += new System.EventHandler(this.ToolStripMenuRestore_Click);
            // 
            // toolStripMenuClose
            // 
            this.toolStripMenuClose.Name = "toolStripMenuClose";
            this.toolStripMenuClose.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuClose.Text = "Close";
            this.toolStripMenuClose.Click += new System.EventHandler(this.ToolStripMenuClose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.toolsToolStripMenuItem,
            this.questionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1701, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem1,
            this.openCSVToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem1.Image")));
            this.openToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.openToolStripMenuItem1.Text = "&Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.OpenToolStripMenuItem1_Click);
            // 
            // openCSVToolStripMenuItem
            // 
            this.openCSVToolStripMenuItem.Name = "openCSVToolStripMenuItem";
            this.openCSVToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.openCSVToolStripMenuItem.Text = "Open &CSV";
            this.openCSVToolStripMenuItem.Click += new System.EventHandler(this.OpenCSVToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(138, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addcatToolStripMenuItem,
            this.addsubcatToolStripMenuItem,
            this.editSelectedToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.saveTreeViewToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // addcatToolStripMenuItem
            // 
            this.addcatToolStripMenuItem.Name = "addcatToolStripMenuItem";
            this.addcatToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addcatToolStripMenuItem.Text = "Add &Category";
            this.addcatToolStripMenuItem.Click += new System.EventHandler(this.AddcatToolStripMenuItem_Click);
            // 
            // addsubcatToolStripMenuItem
            // 
            this.addsubcatToolStripMenuItem.Name = "addsubcatToolStripMenuItem";
            this.addsubcatToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addsubcatToolStripMenuItem.Text = "Add &Subcategory";
            this.addsubcatToolStripMenuItem.Click += new System.EventHandler(this.AddsubcatToolStripMenuItem_Click);
            // 
            // editSelectedToolStripMenuItem
            // 
            this.editSelectedToolStripMenuItem.Name = "editSelectedToolStripMenuItem";
            this.editSelectedToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.editSelectedToolStripMenuItem.Text = "&Edit Selected";
            this.editSelectedToolStripMenuItem.Click += new System.EventHandler(this.EditSelectedToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.deleteToolStripMenuItem.Text = "Delete S&elected";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // saveTreeViewToolStripMenuItem
            // 
            this.saveTreeViewToolStripMenuItem.Name = "saveTreeViewToolStripMenuItem";
            this.saveTreeViewToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.saveTreeViewToolStripMenuItem.Text = "&Save";
            this.saveTreeViewToolStripMenuItem.Visible = false;
            this.saveTreeViewToolStripMenuItem.Click += new System.EventHandler(this.SaveTreeViewToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Enabled = false;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Visible = false;
            // 
            // questionsToolStripMenuItem
            // 
            this.questionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedToolStripMenuItem,
            this.viewSelectedQuestionImageToolStripMenuItem});
            this.questionsToolStripMenuItem.Name = "questionsToolStripMenuItem";
            this.questionsToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.questionsToolStripMenuItem.Text = "&Questions";
            // 
            // deleteSelectedToolStripMenuItem
            // 
            this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            this.deleteSelectedToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.deleteSelectedToolStripMenuItem.Text = "&Delete Selected Rows";
            this.deleteSelectedToolStripMenuItem.Click += new System.EventHandler(this.DeleteSelectedToolStripMenuItem_Click);
            // 
            // viewSelectedQuestionImageToolStripMenuItem
            // 
            this.viewSelectedQuestionImageToolStripMenuItem.Name = "viewSelectedQuestionImageToolStripMenuItem";
            this.viewSelectedQuestionImageToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.viewSelectedQuestionImageToolStripMenuItem.Text = "&Edit Selected Question";
            this.viewSelectedQuestionImageToolStripMenuItem.Click += new System.EventHandler(this.EditSelectedQuestionToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Enabled = false;
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.instructionsToolStripMenuItem.Text = "&Instructions";
            this.instructionsToolStripMenuItem.Visible = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPageQuestionData
            // 
            this.tabPageQuestionData.Controls.Add(this.dataGridViewQuestions);
            this.tabPageQuestionData.Location = new System.Drawing.Point(4, 24);
            this.tabPageQuestionData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageQuestionData.Name = "tabPageQuestionData";
            this.tabPageQuestionData.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageQuestionData.Size = new System.Drawing.Size(1693, 650);
            this.tabPageQuestionData.TabIndex = 1;
            this.tabPageQuestionData.Text = "Question Data";
            this.tabPageQuestionData.UseVisualStyleBackColor = true;
            // 
            // dataGridViewQuestions
            // 
            this.dataGridViewQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewQuestions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewQuestions.Location = new System.Drawing.Point(4, 3);
            this.dataGridViewQuestions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewQuestions.Name = "dataGridViewQuestions";
            this.dataGridViewQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuestions.Size = new System.Drawing.Size(1685, 644);
            this.dataGridViewQuestions.TabIndex = 0;
            this.dataGridViewQuestions.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewQuestions_RowHeaderMouseDoubleClick);
            this.dataGridViewQuestions.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridView_RowPostPaint);
            this.dataGridViewQuestions.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGridView_RowPrePaint);
            // 
            // tabPageControlPanel
            // 
            this.tabPageControlPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageControlPanel.Controls.Add(this.splitContainerMain);
            this.tabPageControlPanel.Location = new System.Drawing.Point(4, 24);
            this.tabPageControlPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageControlPanel.Name = "tabPageControlPanel";
            this.tabPageControlPanel.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageControlPanel.Size = new System.Drawing.Size(1693, 650);
            this.tabPageControlPanel.TabIndex = 0;
            this.tabPageControlPanel.Text = "Control Panel";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(4, 3);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.panelControl);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.treeViewALevel);
            this.splitContainerMain.Panel2.Controls.Add(this.treeViewGCSE);
            this.splitContainerMain.Size = new System.Drawing.Size(1685, 644);
            this.splitContainerMain.SplitterDistance = 600;
            this.splitContainerMain.SplitterWidth = 5;
            this.splitContainerMain.TabIndex = 17;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.panel1);
            this.panelControl.Controls.Add(this.label6);
            this.panelControl.Controls.Add(this.labelUnit);
            this.panelControl.Controls.Add(this.labelTolerance);
            this.panelControl.Controls.Add(this.textBoxUnit);
            this.panelControl.Controls.Add(this.textBoxTolerance);
            this.panelControl.Controls.Add(this.comboBoxType);
            this.panelControl.Controls.Add(this.label5);
            this.panelControl.Controls.Add(this.comboBoxAnswers);
            this.panelControl.Controls.Add(this.label4);
            this.panelControl.Controls.Add(this.btnDiscard);
            this.panelControl.Controls.Add(this.txtExamPaperName);
            this.panelControl.Controls.Add(this.btnSaveImg);
            this.panelControl.Controls.Add(this.label3);
            this.panelControl.Controls.Add(this.pictureBox1);
            this.panelControl.Controls.Add(this.lblImagePreview);
            this.panelControl.Controls.Add(this.txtQuestionName);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Controls.Add(this.btnReset);
            this.panelControl.Controls.Add(this.numCounter);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(600, 644);
            this.panelControl.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonGCSE);
            this.panel1.Controls.Add(this.radioButtonALevel);
            this.panel1.Location = new System.Drawing.Point(126, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 25);
            this.panel1.TabIndex = 28;
            // 
            // radioButtonGCSE
            // 
            this.radioButtonGCSE.AutoSize = true;
            this.radioButtonGCSE.Location = new System.Drawing.Point(3, 1);
            this.radioButtonGCSE.Name = "radioButtonGCSE";
            this.radioButtonGCSE.Size = new System.Drawing.Size(53, 19);
            this.radioButtonGCSE.TabIndex = 28;
            this.radioButtonGCSE.TabStop = true;
            this.radioButtonGCSE.Text = "GCSE";
            this.radioButtonGCSE.UseVisualStyleBackColor = true;
            this.radioButtonGCSE.CheckedChanged += new System.EventHandler(this.RadioButtonGCSE_CheckedChanged);
            // 
            // radioButtonALevel
            // 
            this.radioButtonALevel.AutoSize = true;
            this.radioButtonALevel.Location = new System.Drawing.Point(59, 1);
            this.radioButtonALevel.Name = "radioButtonALevel";
            this.radioButtonALevel.Size = new System.Drawing.Size(65, 19);
            this.radioButtonALevel.TabIndex = 27;
            this.radioButtonALevel.TabStop = true;
            this.radioButtonALevel.Text = "A-Level";
            this.radioButtonALevel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Level";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(387, 545);
            this.labelUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(29, 15);
            this.labelUnit.TabIndex = 25;
            this.labelUnit.Text = "Unit";
            // 
            // labelTolerance
            // 
            this.labelTolerance.AutoSize = true;
            this.labelTolerance.Location = new System.Drawing.Point(254, 545);
            this.labelTolerance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTolerance.Name = "labelTolerance";
            this.labelTolerance.Size = new System.Drawing.Size(57, 15);
            this.labelTolerance.TabIndex = 24;
            this.labelTolerance.Text = "Tolerance";
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(387, 566);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(113, 23);
            this.textBoxUnit.TabIndex = 23;
            // 
            // textBoxTolerance
            // 
            this.textBoxTolerance.Location = new System.Drawing.Point(254, 566);
            this.textBoxTolerance.Name = "textBoxTolerance";
            this.textBoxTolerance.Size = new System.Drawing.Size(113, 23);
            this.textBoxTolerance.TabIndex = 22;
            // 
            // comboBoxType
            // 
            this.comboBoxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(126, 530);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(112, 23);
            this.comboBoxType.TabIndex = 21;
            this.comboBoxType.SelectedValueChanged += new System.EventHandler(this.ComboBoxType_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 533);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Question Type";
            // 
            // comboBoxAnswers
            // 
            this.comboBoxAnswers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxAnswers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAnswers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnswers.FormattingEnabled = true;
            this.comboBoxAnswers.Items.AddRange(new object[] {
            "Select",
            "A",
            "B",
            "C",
            "D"});
            this.comboBoxAnswers.Location = new System.Drawing.Point(125, 566);
            this.comboBoxAnswers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxAnswers.Name = "comboBoxAnswers";
            this.comboBoxAnswers.Size = new System.Drawing.Size(112, 23);
            this.comboBoxAnswers.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 569);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Question Answer";
            // 
            // btnDiscard
            // 
            this.btnDiscard.Location = new System.Drawing.Point(254, 601);
            this.btnDiscard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(113, 27);
            this.btnDiscard.TabIndex = 4;
            this.btnDiscard.Text = "Discard Image";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.BtnDiscard_Click);
            // 
            // txtExamPaperName
            // 
            this.txtExamPaperName.Location = new System.Drawing.Point(125, 42);
            this.txtExamPaperName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtExamPaperName.Name = "txtExamPaperName";
            this.txtExamPaperName.Size = new System.Drawing.Size(451, 23);
            this.txtExamPaperName.TabIndex = 6;
            this.txtExamPaperName.TextChanged += new System.EventHandler(this.TxtFileName_TextChanged);
            // 
            // btnSaveImg
            // 
            this.btnSaveImg.Location = new System.Drawing.Point(125, 601);
            this.btnSaveImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveImg.Name = "btnSaveImg";
            this.btnSaveImg.Size = new System.Drawing.Size(113, 27);
            this.btnSaveImg.TabIndex = 3;
            this.btnSaveImg.Text = "Save Question";
            this.btnSaveImg.UseVisualStyleBackColor = true;
            this.btnSaveImg.Click += new System.EventHandler(this.BtnSaveImg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Image Preview";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(125, 135);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 383);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblImagePreview
            // 
            this.lblImagePreview.AutoSize = true;
            this.lblImagePreview.Location = new System.Drawing.Point(23, 105);
            this.lblImagePreview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagePreview.Name = "lblImagePreview";
            this.lblImagePreview.Size = new System.Drawing.Size(90, 15);
            this.lblImagePreview.TabIndex = 10;
            this.lblImagePreview.Text = "Question Name";
            // 
            // txtQuestionName
            // 
            this.txtQuestionName.Location = new System.Drawing.Point(125, 102);
            this.txtQuestionName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuestionName.Name = "txtQuestionName";
            this.txtQuestionName.ReadOnly = true;
            this.txtQuestionName.Size = new System.Drawing.Size(451, 23);
            this.txtQuestionName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Question Number";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(181, 69);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 27);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset Counter";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // numCounter
            // 
            this.numCounter.Location = new System.Drawing.Point(125, 70);
            this.numCounter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numCounter.Name = "numCounter";
            this.numCounter.Size = new System.Drawing.Size(44, 23);
            this.numCounter.TabIndex = 7;
            this.numCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCounter.ValueChanged += new System.EventHandler(this.NumCounter_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Exam Paper";
            // 
            // treeViewALevel
            // 
            this.treeViewALevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewALevel.HideSelection = false;
            this.treeViewALevel.Location = new System.Drawing.Point(0, 0);
            this.treeViewALevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.treeViewALevel.Name = "treeViewALevel";
            this.treeViewALevel.Size = new System.Drawing.Size(1080, 644);
            this.treeViewALevel.TabIndex = 1;
            // 
            // treeViewGCSE
            // 
            this.treeViewGCSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewGCSE.HideSelection = false;
            this.treeViewGCSE.Location = new System.Drawing.Point(0, 0);
            this.treeViewGCSE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.treeViewGCSE.Name = "treeViewGCSE";
            this.treeViewGCSE.Size = new System.Drawing.Size(1080, 644);
            this.treeViewGCSE.TabIndex = 0;
            this.treeViewGCSE.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseDoubleClick);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageControlPanel);
            this.tabControlMain.Controls.Add(this.tabPageQuestionData);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1701, 678);
            this.tabControlMain.TabIndex = 16;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.TabControlMain_SelectedIndexChanged);
            // 
            // sharpClipboard1
            // 
            this.sharpClipboard1.MonitorClipboard = false;
            this.sharpClipboard1.ObservableFormats.All = false;
            this.sharpClipboard1.ObservableFormats.Files = false;
            this.sharpClipboard1.ObservableFormats.Images = true;
            this.sharpClipboard1.ObservableFormats.Others = false;
            this.sharpClipboard1.ObservableFormats.Texts = false;
            this.sharpClipboard1.ObserveLastEntry = true;
            this.sharpClipboard1.Tag = null;
            this.sharpClipboard1.ClipboardChanged += new System.EventHandler<WK.Libraries.SharpClipboardNS.SharpClipboard.ClipboardChangedEventArgs>(this.SharpClipboard1_ClipboardChanged);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 702);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.Text = "Moodle Quiz Creator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResizeBegin += new System.EventHandler(this.FormMain_ResizeBegin);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageQuestionData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).EndInit();
            this.tabPageControlPanel.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCounter)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuRestore;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuClose;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addcatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addsubcatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageQuestionData;
        private System.Windows.Forms.DataGridView dataGridViewQuestions;
        private System.Windows.Forms.TabPage tabPageControlPanel;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.ComboBox comboBoxAnswers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.TextBox txtExamPaperName;
        private System.Windows.Forms.Button btnSaveImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblImagePreview;
        private System.Windows.Forms.TextBox txtQuestionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown numCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewGCSE;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.ToolStripMenuItem questionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSelectedQuestionImageToolStripMenuItem;
        private WK.Libraries.SharpClipboardNS.SharpClipboard sharpClipboard1;
        private ToolStripMenuItem saveTreeViewToolStripMenuItem;
        private ToolStripMenuItem editSelectedToolStripMenuItem;
        private ComboBox comboBoxType;
        private Label label5;
        private TextBox textBoxUnit;
        private TextBox textBoxTolerance;
        private Label labelUnit;
        private Label labelTolerance;
        private ToolStripMenuItem openCSVToolStripMenuItem;
        private Panel panel1;
        private RadioButton radioButtonGCSE;
        private RadioButton radioButtonALevel;
        private Label label6;
        private TreeView treeViewALevel;
    }
}

