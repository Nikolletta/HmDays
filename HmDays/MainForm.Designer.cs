namespace HmDays
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Мишки");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Зайцы");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Проекты изделий", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Мишки");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Зайцы");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Проекты изделий", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Мишки");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Зайцы");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Проекты изделий", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.MainPanel = new System.Windows.Forms.SplitContainer();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabTable = new System.Windows.Forms.TabPage();
            this.tabProjects = new System.Windows.Forms.TabPage();
            this.splitPrj_Tab = new System.Windows.Forms.SplitContainer();
            this.treePrj = new System.Windows.Forms.TreeView();
            this.pnlPrj_btnTree = new System.Windows.Forms.Panel();
            this.btnPrj_DelBranch = new System.Windows.Forms.Button();
            this.btnPrj_AddBranch = new System.Windows.Forms.Button();
            this.splitPrj_Body = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolSPrj = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.tabIdea = new System.Windows.Forms.TabPage();
            this.tabBalance = new System.Windows.Forms.TabPage();
            this.splitEvents = new System.Windows.Forms.SplitContainer();
            this.pnlEvents = new System.Windows.Forms.GroupBox();
            this.tblEventsMain = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkListMain = new System.Windows.Forms.CheckedListBox();
            this.pnlMonth = new System.Windows.Forms.GroupBox();
            this.clnrMain = new System.Windows.Forms.MonthCalendar();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completedataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ideaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deleteDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hmDDataSet1 = new HmDays.HmDDataSet();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hmDDataSet = new HmDays.HmDDataSet();
            this.eventsTableAdapter = new HmDays.HmDDataSetTableAdapters.eventsTableAdapter();
            this.projectsTableAdapter = new HmDays.HmDDataSetTableAdapters.projectsTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tabMaterials = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.MainPanel)).BeginInit();
            this.MainPanel.Panel1.SuspendLayout();
            this.MainPanel.Panel2.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPrj_Tab)).BeginInit();
            this.splitPrj_Tab.Panel1.SuspendLayout();
            this.splitPrj_Tab.Panel2.SuspendLayout();
            this.splitPrj_Tab.SuspendLayout();
            this.pnlPrj_btnTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPrj_Body)).BeginInit();
            this.splitPrj_Body.Panel1.SuspendLayout();
            this.splitPrj_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolSPrj.SuspendLayout();
            this.tabOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitEvents)).BeginInit();
            this.splitEvents.Panel1.SuspendLayout();
            this.splitEvents.Panel2.SuspendLayout();
            this.splitEvents.SuspendLayout();
            this.pnlEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsMain)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.pnlMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hmDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hmDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabMaterials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            // 
            // MainPanel.Panel1
            // 
            this.MainPanel.Panel1.Controls.Add(this.tabMain);
            // 
            // MainPanel.Panel2
            // 
            this.MainPanel.Panel2.Controls.Add(this.splitEvents);
            this.MainPanel.Panel2.Controls.Add(this.pnlMonth);
            this.MainPanel.Size = new System.Drawing.Size(864, 573);
            this.MainPanel.SplitterDistance = 678;
            this.MainPanel.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabTable);
            this.tabMain.Controls.Add(this.tabProjects);
            this.tabMain.Controls.Add(this.tabOrder);
            this.tabMain.Controls.Add(this.tabIdea);
            this.tabMain.Controls.Add(this.tabBalance);
            this.tabMain.Controls.Add(this.tabMaterials);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(678, 573);
            this.tabMain.TabIndex = 0;
            // 
            // tabTable
            // 
            this.tabTable.Location = new System.Drawing.Point(4, 29);
            this.tabTable.Name = "tabTable";
            this.tabTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTable.Size = new System.Drawing.Size(670, 540);
            this.tabTable.TabIndex = 0;
            this.tabTable.Text = "Рабочий стол";
            this.tabTable.UseVisualStyleBackColor = true;
            // 
            // tabProjects
            // 
            this.tabProjects.Controls.Add(this.splitPrj_Tab);
            this.tabProjects.Location = new System.Drawing.Point(4, 29);
            this.tabProjects.Name = "tabProjects";
            this.tabProjects.Size = new System.Drawing.Size(670, 540);
            this.tabProjects.TabIndex = 1;
            this.tabProjects.Text = "Проекты";
            this.tabProjects.UseVisualStyleBackColor = true;
            // 
            // splitPrj_Tab
            // 
            this.splitPrj_Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPrj_Tab.Location = new System.Drawing.Point(0, 0);
            this.splitPrj_Tab.Name = "splitPrj_Tab";
            // 
            // splitPrj_Tab.Panel1
            // 
            this.splitPrj_Tab.Panel1.Controls.Add(this.treePrj);
            this.splitPrj_Tab.Panel1.Controls.Add(this.pnlPrj_btnTree);
            // 
            // splitPrj_Tab.Panel2
            // 
            this.splitPrj_Tab.Panel2.Controls.Add(this.splitPrj_Body);
            this.splitPrj_Tab.Panel2.Controls.Add(this.toolSPrj);
            this.splitPrj_Tab.Panel2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.splitPrj_Tab.Size = new System.Drawing.Size(670, 540);
            this.splitPrj_Tab.SplitterDistance = 141;
            this.splitPrj_Tab.TabIndex = 0;
            // 
            // treePrj
            // 
            this.treePrj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treePrj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treePrj.Location = new System.Drawing.Point(0, 0);
            this.treePrj.Name = "treePrj";
            treeNode1.Name = "Узел1";
            treeNode1.Text = "Мишки";
            treeNode2.Name = "Узел2";
            treeNode2.Text = "Зайцы";
            treeNode3.Name = "Узел0";
            treeNode3.Text = "Проекты изделий";
            this.treePrj.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treePrj.Size = new System.Drawing.Size(141, 440);
            this.treePrj.TabIndex = 1;
            // 
            // pnlPrj_btnTree
            // 
            this.pnlPrj_btnTree.Controls.Add(this.btnPrj_DelBranch);
            this.pnlPrj_btnTree.Controls.Add(this.btnPrj_AddBranch);
            this.pnlPrj_btnTree.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPrj_btnTree.Location = new System.Drawing.Point(0, 440);
            this.pnlPrj_btnTree.Name = "pnlPrj_btnTree";
            this.pnlPrj_btnTree.Size = new System.Drawing.Size(141, 100);
            this.pnlPrj_btnTree.TabIndex = 0;
            // 
            // btnPrj_DelBranch
            // 
            this.btnPrj_DelBranch.AutoSize = true;
            this.btnPrj_DelBranch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrj_DelBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrj_DelBranch.Location = new System.Drawing.Point(0, 27);
            this.btnPrj_DelBranch.Name = "btnPrj_DelBranch";
            this.btnPrj_DelBranch.Size = new System.Drawing.Size(141, 27);
            this.btnPrj_DelBranch.TabIndex = 1;
            this.btnPrj_DelBranch.Text = "Удалить ветку";
            this.btnPrj_DelBranch.UseVisualStyleBackColor = true;
            // 
            // btnPrj_AddBranch
            // 
            this.btnPrj_AddBranch.AutoSize = true;
            this.btnPrj_AddBranch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrj_AddBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrj_AddBranch.Location = new System.Drawing.Point(0, 0);
            this.btnPrj_AddBranch.Name = "btnPrj_AddBranch";
            this.btnPrj_AddBranch.Size = new System.Drawing.Size(141, 27);
            this.btnPrj_AddBranch.TabIndex = 0;
            this.btnPrj_AddBranch.Text = "Добавить ветку";
            this.btnPrj_AddBranch.UseVisualStyleBackColor = true;
            // 
            // splitPrj_Body
            // 
            this.splitPrj_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPrj_Body.Location = new System.Drawing.Point(3, 25);
            this.splitPrj_Body.Name = "splitPrj_Body";
            this.splitPrj_Body.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPrj_Body.Panel1
            // 
            this.splitPrj_Body.Panel1.Controls.Add(this.dataGridView1);
            this.splitPrj_Body.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitPrj_Body.Size = new System.Drawing.Size(522, 515);
            this.splitPrj_Body.SplitterDistance = 240;
            this.splitPrj_Body.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn1,
            this.desDataGridViewTextBoxColumn,
            this.createdataDataGridViewTextBoxColumn,
            this.completedataDataGridViewTextBoxColumn,
            this.statusidDataGridViewTextBoxColumn1,
            this.ideaidDataGridViewTextBoxColumn,
            this.picDataGridViewCheckBoxColumn,
            this.deleteDataGridViewCheckBoxColumn1});
            this.dataGridView1.DataSource = this.projectsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(522, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolSPrj
            // 
            this.toolSPrj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolSPrj.Location = new System.Drawing.Point(3, 0);
            this.toolSPrj.Name = "toolSPrj";
            this.toolSPrj.Size = new System.Drawing.Size(522, 25);
            this.toolSPrj.TabIndex = 0;
            this.toolSPrj.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.splitContainer1);
            this.tabOrder.Location = new System.Drawing.Point(4, 29);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Size = new System.Drawing.Size(670, 540);
            this.tabOrder.TabIndex = 2;
            this.tabOrder.Text = "Заказы";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // tabIdea
            // 
            this.tabIdea.Location = new System.Drawing.Point(4, 29);
            this.tabIdea.Name = "tabIdea";
            this.tabIdea.Size = new System.Drawing.Size(670, 540);
            this.tabIdea.TabIndex = 3;
            this.tabIdea.Text = "Идеи";
            this.tabIdea.UseVisualStyleBackColor = true;
            // 
            // tabBalance
            // 
            this.tabBalance.Location = new System.Drawing.Point(4, 29);
            this.tabBalance.Name = "tabBalance";
            this.tabBalance.Size = new System.Drawing.Size(670, 540);
            this.tabBalance.TabIndex = 4;
            this.tabBalance.Text = "Баланс";
            this.tabBalance.UseVisualStyleBackColor = true;
            // 
            // splitEvents
            // 
            this.splitEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitEvents.Location = new System.Drawing.Point(0, 181);
            this.splitEvents.Name = "splitEvents";
            this.splitEvents.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitEvents.Panel1
            // 
            this.splitEvents.Panel1.Controls.Add(this.pnlEvents);
            // 
            // splitEvents.Panel2
            // 
            this.splitEvents.Panel2.Controls.Add(this.groupBox3);
            this.splitEvents.Size = new System.Drawing.Size(182, 392);
            this.splitEvents.SplitterDistance = 181;
            this.splitEvents.TabIndex = 1;
            // 
            // pnlEvents
            // 
            this.pnlEvents.Controls.Add(this.tblEventsMain);
            this.pnlEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEvents.Location = new System.Drawing.Point(0, 0);
            this.pnlEvents.Name = "pnlEvents";
            this.pnlEvents.Size = new System.Drawing.Size(182, 181);
            this.pnlEvents.TabIndex = 0;
            this.pnlEvents.TabStop = false;
            this.pnlEvents.Text = "События";
            // 
            // tblEventsMain
            // 
            this.tblEventsMain.AutoGenerateColumns = false;
            this.tblEventsMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEventsMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.createdateDataGridViewTextBoxColumn,
            this.projectidDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.orderidDataGridViewTextBoxColumn,
            this.statusidDataGridViewTextBoxColumn,
            this.deleteDataGridViewCheckBoxColumn});
            this.tblEventsMain.DataSource = this.eventsBindingSource;
            this.tblEventsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEventsMain.Location = new System.Drawing.Point(3, 16);
            this.tblEventsMain.Name = "tblEventsMain";
            this.tblEventsMain.Size = new System.Drawing.Size(176, 162);
            this.tblEventsMain.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkListMain);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 207);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Чек-лист";
            // 
            // checkListMain
            // 
            this.checkListMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkListMain.FormattingEnabled = true;
            this.checkListMain.Items.AddRange(new object[] {
            "Привет"});
            this.checkListMain.Location = new System.Drawing.Point(3, 16);
            this.checkListMain.Name = "checkListMain";
            this.checkListMain.Size = new System.Drawing.Size(176, 188);
            this.checkListMain.TabIndex = 0;
            // 
            // pnlMonth
            // 
            this.pnlMonth.Controls.Add(this.clnrMain);
            this.pnlMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMonth.Location = new System.Drawing.Point(0, 0);
            this.pnlMonth.Name = "pnlMonth";
            this.pnlMonth.Size = new System.Drawing.Size(182, 181);
            this.pnlMonth.TabIndex = 0;
            this.pnlMonth.TabStop = false;
            this.pnlMonth.Text = "Календарь";
            // 
            // clnrMain
            // 
            this.clnrMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clnrMain.Location = new System.Drawing.Point(3, 16);
            this.clnrMain.Name = "clnrMain";
            this.clnrMain.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // desDataGridViewTextBoxColumn
            // 
            this.desDataGridViewTextBoxColumn.DataPropertyName = "des";
            this.desDataGridViewTextBoxColumn.HeaderText = "des";
            this.desDataGridViewTextBoxColumn.Name = "desDataGridViewTextBoxColumn";
            this.desDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdataDataGridViewTextBoxColumn
            // 
            this.createdataDataGridViewTextBoxColumn.DataPropertyName = "create_data";
            this.createdataDataGridViewTextBoxColumn.HeaderText = "create_data";
            this.createdataDataGridViewTextBoxColumn.Name = "createdataDataGridViewTextBoxColumn";
            this.createdataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // completedataDataGridViewTextBoxColumn
            // 
            this.completedataDataGridViewTextBoxColumn.DataPropertyName = "complete_data";
            this.completedataDataGridViewTextBoxColumn.HeaderText = "complete_data";
            this.completedataDataGridViewTextBoxColumn.Name = "completedataDataGridViewTextBoxColumn";
            this.completedataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusidDataGridViewTextBoxColumn1
            // 
            this.statusidDataGridViewTextBoxColumn1.DataPropertyName = "status_id";
            this.statusidDataGridViewTextBoxColumn1.HeaderText = "status_id";
            this.statusidDataGridViewTextBoxColumn1.Name = "statusidDataGridViewTextBoxColumn1";
            this.statusidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ideaidDataGridViewTextBoxColumn
            // 
            this.ideaidDataGridViewTextBoxColumn.DataPropertyName = "idea_id";
            this.ideaidDataGridViewTextBoxColumn.HeaderText = "idea_id";
            this.ideaidDataGridViewTextBoxColumn.Name = "ideaidDataGridViewTextBoxColumn";
            this.ideaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // picDataGridViewCheckBoxColumn
            // 
            this.picDataGridViewCheckBoxColumn.DataPropertyName = "pic";
            this.picDataGridViewCheckBoxColumn.HeaderText = "pic";
            this.picDataGridViewCheckBoxColumn.Name = "picDataGridViewCheckBoxColumn";
            this.picDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // deleteDataGridViewCheckBoxColumn1
            // 
            this.deleteDataGridViewCheckBoxColumn1.DataPropertyName = "delete";
            this.deleteDataGridViewCheckBoxColumn1.HeaderText = "delete";
            this.deleteDataGridViewCheckBoxColumn1.Name = "deleteDataGridViewCheckBoxColumn1";
            this.deleteDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "projects";
            this.projectsBindingSource.DataSource = this.hmDDataSet1;
            // 
            // hmDDataSet1
            // 
            this.hmDDataSet1.DataSetName = "HmDDataSet";
            this.hmDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // createdateDataGridViewTextBoxColumn
            // 
            this.createdateDataGridViewTextBoxColumn.DataPropertyName = "create_date";
            this.createdateDataGridViewTextBoxColumn.HeaderText = "create_date";
            this.createdateDataGridViewTextBoxColumn.Name = "createdateDataGridViewTextBoxColumn";
            // 
            // projectidDataGridViewTextBoxColumn
            // 
            this.projectidDataGridViewTextBoxColumn.DataPropertyName = "project_id";
            this.projectidDataGridViewTextBoxColumn.HeaderText = "project_id";
            this.projectidDataGridViewTextBoxColumn.Name = "projectidDataGridViewTextBoxColumn";
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "order_id";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            // 
            // statusidDataGridViewTextBoxColumn
            // 
            this.statusidDataGridViewTextBoxColumn.DataPropertyName = "status_id";
            this.statusidDataGridViewTextBoxColumn.HeaderText = "status_id";
            this.statusidDataGridViewTextBoxColumn.Name = "statusidDataGridViewTextBoxColumn";
            // 
            // deleteDataGridViewCheckBoxColumn
            // 
            this.deleteDataGridViewCheckBoxColumn.DataPropertyName = "delete";
            this.deleteDataGridViewCheckBoxColumn.HeaderText = "delete";
            this.deleteDataGridViewCheckBoxColumn.Name = "deleteDataGridViewCheckBoxColumn";
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "events";
            this.eventsBindingSource.DataSource = this.hmDDataSet;
            // 
            // hmDDataSet
            // 
            this.hmDDataSet.DataSetName = "HmDDataSet";
            this.hmDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(670, 540);
            this.splitContainer1.SplitterDistance = 141;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode4.Name = "Узел1";
            treeNode4.Text = "Мишки";
            treeNode5.Name = "Узел2";
            treeNode5.Text = "Зайцы";
            treeNode6.Name = "Узел0";
            treeNode6.Text = "Проекты изделий";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(141, 440);
            this.treeView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 100);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Удалить ветку";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "Добавить ветку";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 25);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView2);
            this.splitContainer2.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer2.Size = new System.Drawing.Size(522, 515);
            this.splitContainer2.SplitterDistance = 240;
            this.splitContainer2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2});
            this.dataGridView2.DataSource = this.projectsBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(522, 240);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn2.HeaderText = "title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "des";
            this.dataGridViewTextBoxColumn3.HeaderText = "des";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "create_data";
            this.dataGridViewTextBoxColumn4.HeaderText = "create_data";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "complete_data";
            this.dataGridViewTextBoxColumn5.HeaderText = "complete_data";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "status_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "status_id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "idea_id";
            this.dataGridViewTextBoxColumn7.HeaderText = "idea_id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "pic";
            this.dataGridViewCheckBoxColumn1.HeaderText = "pic";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "delete";
            this.dataGridViewCheckBoxColumn2.HeaderText = "delete";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(522, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton2";
            // 
            // tabMaterials
            // 
            this.tabMaterials.Controls.Add(this.splitContainer3);
            this.tabMaterials.Location = new System.Drawing.Point(4, 29);
            this.tabMaterials.Name = "tabMaterials";
            this.tabMaterials.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaterials.Size = new System.Drawing.Size(670, 540);
            this.tabMaterials.TabIndex = 5;
            this.tabMaterials.Text = "Материалы";
            this.tabMaterials.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.treeView2);
            this.splitContainer3.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer3.Panel2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.splitContainer3.Size = new System.Drawing.Size(664, 534);
            this.splitContainer3.SplitterDistance = 140;
            this.splitContainer3.TabIndex = 1;
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Name = "treeView2";
            treeNode7.Name = "Узел1";
            treeNode7.Text = "Мишки";
            treeNode8.Name = "Узел2";
            treeNode8.Text = "Зайцы";
            treeNode9.Name = "Узел0";
            treeNode9.Text = "Проекты изделий";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView2.Size = new System.Drawing.Size(140, 434);
            this.treeView2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 100);
            this.panel2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(0, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 27);
            this.button3.TabIndex = 1;
            this.button3.Text = "Удалить ветку";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 27);
            this.button4.TabIndex = 0;
            this.button4.Text = "Добавить ветку";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 25);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dataGridView3);
            this.splitContainer4.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer4.Size = new System.Drawing.Size(517, 509);
            this.splitContainer4.SplitterDistance = 238;
            this.splitContainer4.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4});
            this.dataGridView3.DataSource = this.projectsBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(517, 238);
            this.dataGridView3.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn8.HeaderText = "id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn9.HeaderText = "title";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "des";
            this.dataGridViewTextBoxColumn10.HeaderText = "des";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "create_data";
            this.dataGridViewTextBoxColumn11.HeaderText = "create_data";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "complete_data";
            this.dataGridViewTextBoxColumn12.HeaderText = "complete_data";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "status_id";
            this.dataGridViewTextBoxColumn13.HeaderText = "status_id";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "idea_id";
            this.dataGridViewTextBoxColumn14.HeaderText = "idea_id";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "pic";
            this.dataGridViewCheckBoxColumn3.HeaderText = "pic";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "delete";
            this.dataGridViewCheckBoxColumn4.HeaderText = "delete";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip2.Location = new System.Drawing.Point(3, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(517, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip1";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton1";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 573);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.Text = "HmDays";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.Panel1.ResumeLayout(false);
            this.MainPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPanel)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabProjects.ResumeLayout(false);
            this.splitPrj_Tab.Panel1.ResumeLayout(false);
            this.splitPrj_Tab.Panel2.ResumeLayout(false);
            this.splitPrj_Tab.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPrj_Tab)).EndInit();
            this.splitPrj_Tab.ResumeLayout(false);
            this.pnlPrj_btnTree.ResumeLayout(false);
            this.pnlPrj_btnTree.PerformLayout();
            this.splitPrj_Body.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPrj_Body)).EndInit();
            this.splitPrj_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolSPrj.ResumeLayout(false);
            this.toolSPrj.PerformLayout();
            this.tabOrder.ResumeLayout(false);
            this.splitEvents.Panel1.ResumeLayout(false);
            this.splitEvents.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitEvents)).EndInit();
            this.splitEvents.ResumeLayout(false);
            this.pnlEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsMain)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.pnlMonth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hmDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hmDDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabMaterials.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainPanel;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabTable;
        private System.Windows.Forms.TabPage tabProjects;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.TabPage tabIdea;
        private System.Windows.Forms.TabPage tabBalance;
        private System.Windows.Forms.SplitContainer splitEvents;
        private System.Windows.Forms.GroupBox pnlEvents;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox checkListMain;
        private System.Windows.Forms.GroupBox pnlMonth;
        private System.Windows.Forms.DataGridView tblEventsMain;
        private System.Windows.Forms.MonthCalendar clnrMain;
        private HmDDataSet hmDDataSet;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private HmDDataSetTableAdapters.eventsTableAdapter eventsTableAdapter;
        private System.Windows.Forms.SplitContainer splitPrj_Tab;
        private System.Windows.Forms.TreeView treePrj;
        private System.Windows.Forms.Panel pnlPrj_btnTree;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deleteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnPrj_DelBranch;
        private System.Windows.Forms.Button btnPrj_AddBranch;
        private System.Windows.Forms.SplitContainer splitPrj_Body;
        private System.Windows.Forms.ToolStrip toolSPrj;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private HmDDataSetTableAdapters.projectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HmDDataSet hmDDataSet1;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn desDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completedataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ideaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn picDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deleteDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TabPage tabMaterials;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
    }
}

