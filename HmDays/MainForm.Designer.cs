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
            this.MainPanel = new System.Windows.Forms.SplitContainer();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabTable = new System.Windows.Forms.TabPage();
            this.tabProjects = new System.Windows.Forms.TabPage();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.tabIdea = new System.Windows.Forms.TabPage();
            this.tabBalance = new System.Windows.Forms.TabPage();
            this.pnlMonth = new System.Windows.Forms.GroupBox();
            this.splitEvents = new System.Windows.Forms.SplitContainer();
            this.pnlEvents = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkListMain = new System.Windows.Forms.CheckedListBox();
            this.tblEventsMain = new System.Windows.Forms.DataGridView();
            this.clnrMain = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.MainPanel)).BeginInit();
            this.MainPanel.Panel1.SuspendLayout();
            this.MainPanel.Panel2.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.pnlMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitEvents)).BeginInit();
            this.splitEvents.Panel1.SuspendLayout();
            this.splitEvents.Panel2.SuspendLayout();
            this.splitEvents.SuspendLayout();
            this.pnlEvents.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsMain)).BeginInit();
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
            this.tabProjects.Location = new System.Drawing.Point(4, 29);
            this.tabProjects.Name = "tabProjects";
            this.tabProjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabProjects.Size = new System.Drawing.Size(670, 540);
            this.tabProjects.TabIndex = 1;
            this.tabProjects.Text = "Проекты";
            this.tabProjects.UseVisualStyleBackColor = true;
            // 
            // tabOrder
            // 
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
            // tblEventsMain
            // 
            this.tblEventsMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEventsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEventsMain.Location = new System.Drawing.Point(3, 16);
            this.tblEventsMain.Name = "tblEventsMain";
            this.tblEventsMain.Size = new System.Drawing.Size(176, 162);
            this.tblEventsMain.TabIndex = 0;
            // 
            // clnrMain
            // 
            this.clnrMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clnrMain.Location = new System.Drawing.Point(3, 16);
            this.clnrMain.Name = "clnrMain";
            this.clnrMain.TabIndex = 0;
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
            this.pnlMonth.ResumeLayout(false);
            this.splitEvents.Panel1.ResumeLayout(false);
            this.splitEvents.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitEvents)).EndInit();
            this.splitEvents.ResumeLayout(false);
            this.pnlEvents.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsMain)).EndInit();
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
    }
}

