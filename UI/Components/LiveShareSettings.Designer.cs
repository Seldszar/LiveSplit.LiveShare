namespace LiveSplit.UI.Components
{
    partial class LiveShareSettings
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSplitPath = new System.Windows.Forms.TextBox();
            this.cmsFormat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiGameName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCategoryName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAttemptCount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSplitName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSplitTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeltaTime = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSplitAheadGaining = new System.Windows.Forms.TextBox();
            this.txtSplitAheadLosing = new System.Windows.Forms.TextBox();
            this.txtSplitBehindGaining = new System.Windows.Forms.TextBox();
            this.txtSplitBehindLosing = new System.Windows.Forms.TextBox();
            this.txtBestSegment = new System.Windows.Forms.TextBox();
            this.txtUndo = new System.Windows.Forms.TextBox();
            this.txtSkip = new System.Windows.Forms.TextBox();
            this.txtPersonalBest = new System.Windows.Forms.TextBox();
            this.txtNotAPersonalBest = new System.Windows.Forms.TextBox();
            this.txtReset = new System.Windows.Forms.TextBox();
            this.txtPause = new System.Windows.Forms.TextBox();
            this.txtResume = new System.Windows.Forms.TextBox();
            this.txtStartTimer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAuthorize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.cmsFormat.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtStartTimer, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.txtResume, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.txtPause, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.txtReset, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtNotAPersonalBest, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtPersonalBest, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtSkip, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtUndo, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtBestSegment, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtSplitBehindLosing, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtSplitBehindGaining, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSplitAheadLosing, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSplitAheadGaining, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSplitPath, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 449);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 428);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Start Timer:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Split:";
            // 
            // txtSplitPath
            // 
            this.txtSplitPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSplitPath.ContextMenuStrip = this.cmsFormat;
            this.txtSplitPath.Location = new System.Drawing.Point(149, 47);
            this.txtSplitPath.Name = "txtSplitPath";
            this.txtSplitPath.Size = new System.Drawing.Size(310, 20);
            this.txtSplitPath.TabIndex = 2;
            // 
            // cmsFormat
            // 
            this.cmsFormat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGameName,
            this.tsmiCategoryName,
            this.tsmiAttemptCount,
            this.tsmiSplitName,
            this.tsmiSplitTime,
            this.tsmiDeltaTime});
            this.cmsFormat.Name = "cmsFormat";
            this.cmsFormat.Size = new System.Drawing.Size(156, 136);
            this.cmsFormat.Tag = "";
            // 
            // tsmiGameName
            // 
            this.tsmiGameName.Name = "tsmiGameName";
            this.tsmiGameName.Size = new System.Drawing.Size(155, 22);
            this.tsmiGameName.Tag = "$gameName";
            this.tsmiGameName.Text = "Game name";
            // 
            // tsmiCategoryName
            // 
            this.tsmiCategoryName.Name = "tsmiCategoryName";
            this.tsmiCategoryName.Size = new System.Drawing.Size(155, 22);
            this.tsmiCategoryName.Tag = "$categoryName";
            this.tsmiCategoryName.Text = "Category name";
            // 
            // tsmiAttemptCount
            // 
            this.tsmiAttemptCount.Name = "tsmiAttemptCount";
            this.tsmiAttemptCount.Size = new System.Drawing.Size(155, 22);
            this.tsmiAttemptCount.Tag = "$atemptCount";
            this.tsmiAttemptCount.Text = "Attempt count";
            // 
            // tsmiSplitName
            // 
            this.tsmiSplitName.Name = "tsmiSplitName";
            this.tsmiSplitName.Size = new System.Drawing.Size(155, 22);
            this.tsmiSplitName.Tag = "$splitName";
            this.tsmiSplitName.Text = "Split name";
            // 
            // tsmiSplitTime
            // 
            this.tsmiSplitTime.Name = "tsmiSplitTime";
            this.tsmiSplitTime.Size = new System.Drawing.Size(155, 22);
            this.tsmiSplitTime.Tag = "$splitTime";
            this.tsmiSplitTime.Text = "Split time";
            // 
            // tsmiDeltaTime
            // 
            this.tsmiDeltaTime.Name = "tsmiDeltaTime";
            this.tsmiDeltaTime.Size = new System.Drawing.Size(155, 22);
            this.tsmiDeltaTime.Tag = "$deltaTime";
            this.tsmiDeltaTime.Text = "Delta time";
            // 
            // txtSplitAheadGaining
            // 
            this.txtSplitAheadGaining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSplitAheadGaining.ContextMenuStrip = this.cmsFormat;
            this.txtSplitAheadGaining.Location = new System.Drawing.Point(149, 76);
            this.txtSplitAheadGaining.Name = "txtSplitAheadGaining";
            this.txtSplitAheadGaining.Size = new System.Drawing.Size(310, 20);
            this.txtSplitAheadGaining.TabIndex = 16;
            // 
            // txtSplitAheadLosing
            // 
            this.txtSplitAheadLosing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSplitAheadLosing.ContextMenuStrip = this.cmsFormat;
            this.txtSplitAheadLosing.Location = new System.Drawing.Point(149, 105);
            this.txtSplitAheadLosing.Name = "txtSplitAheadLosing";
            this.txtSplitAheadLosing.Size = new System.Drawing.Size(310, 20);
            this.txtSplitAheadLosing.TabIndex = 17;
            // 
            // txtSplitBehindGaining
            // 
            this.txtSplitBehindGaining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSplitBehindGaining.ContextMenuStrip = this.cmsFormat;
            this.txtSplitBehindGaining.Location = new System.Drawing.Point(149, 134);
            this.txtSplitBehindGaining.Name = "txtSplitBehindGaining";
            this.txtSplitBehindGaining.Size = new System.Drawing.Size(310, 20);
            this.txtSplitBehindGaining.TabIndex = 18;
            // 
            // txtSplitBehindLosing
            // 
            this.txtSplitBehindLosing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSplitBehindLosing.ContextMenuStrip = this.cmsFormat;
            this.txtSplitBehindLosing.Location = new System.Drawing.Point(149, 163);
            this.txtSplitBehindLosing.Name = "txtSplitBehindLosing";
            this.txtSplitBehindLosing.Size = new System.Drawing.Size(310, 20);
            this.txtSplitBehindLosing.TabIndex = 19;
            // 
            // txtBestSegment
            // 
            this.txtBestSegment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBestSegment.ContextMenuStrip = this.cmsFormat;
            this.txtBestSegment.Location = new System.Drawing.Point(149, 192);
            this.txtBestSegment.Name = "txtBestSegment";
            this.txtBestSegment.Size = new System.Drawing.Size(310, 20);
            this.txtBestSegment.TabIndex = 20;
            // 
            // txtUndo
            // 
            this.txtUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUndo.ContextMenuStrip = this.cmsFormat;
            this.txtUndo.Location = new System.Drawing.Point(149, 221);
            this.txtUndo.Name = "txtUndo";
            this.txtUndo.Size = new System.Drawing.Size(310, 20);
            this.txtUndo.TabIndex = 21;
            // 
            // txtSkip
            // 
            this.txtSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSkip.ContextMenuStrip = this.cmsFormat;
            this.txtSkip.Location = new System.Drawing.Point(149, 250);
            this.txtSkip.Name = "txtSkip";
            this.txtSkip.Size = new System.Drawing.Size(310, 20);
            this.txtSkip.TabIndex = 22;
            // 
            // txtPersonalBest
            // 
            this.txtPersonalBest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonalBest.ContextMenuStrip = this.cmsFormat;
            this.txtPersonalBest.Location = new System.Drawing.Point(149, 279);
            this.txtPersonalBest.Name = "txtPersonalBest";
            this.txtPersonalBest.Size = new System.Drawing.Size(310, 20);
            this.txtPersonalBest.TabIndex = 23;
            // 
            // txtNotAPersonalBest
            // 
            this.txtNotAPersonalBest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotAPersonalBest.ContextMenuStrip = this.cmsFormat;
            this.txtNotAPersonalBest.Location = new System.Drawing.Point(149, 308);
            this.txtNotAPersonalBest.Name = "txtNotAPersonalBest";
            this.txtNotAPersonalBest.Size = new System.Drawing.Size(310, 20);
            this.txtNotAPersonalBest.TabIndex = 24;
            // 
            // txtReset
            // 
            this.txtReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReset.ContextMenuStrip = this.cmsFormat;
            this.txtReset.Location = new System.Drawing.Point(149, 337);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(310, 20);
            this.txtReset.TabIndex = 25;
            // 
            // txtPause
            // 
            this.txtPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPause.ContextMenuStrip = this.cmsFormat;
            this.txtPause.Location = new System.Drawing.Point(149, 366);
            this.txtPause.Name = "txtPause";
            this.txtPause.Size = new System.Drawing.Size(310, 20);
            this.txtPause.TabIndex = 26;
            // 
            // txtResume
            // 
            this.txtResume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResume.ContextMenuStrip = this.cmsFormat;
            this.txtResume.Location = new System.Drawing.Point(149, 395);
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(310, 20);
            this.txtResume.TabIndex = 27;
            // 
            // txtStartTimer
            // 
            this.txtStartTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartTimer.ContextMenuStrip = this.cmsFormat;
            this.txtStartTimer.Location = new System.Drawing.Point(149, 424);
            this.txtStartTimer.Name = "txtStartTimer";
            this.txtStartTimer.Size = new System.Drawing.Size(310, 20);
            this.txtStartTimer.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Split (Ahead, Gaining Time):";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Split (Ahead, Losing Time):";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Split (Behind, Gaining Time):";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Split (Behind, Losing Time):";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Split (Best Segment):";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Undo Split:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Skip Split:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Personal Best:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Not a Personal Best:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Reset:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Pause:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 399);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Resume:";
            // 
            // btnAuthorize
            // 
            this.btnAuthorize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAuthorize.Location = new System.Drawing.Point(184, 10);
            this.btnAuthorize.Name = "btnAuthorize";
            this.btnAuthorize.Size = new System.Drawing.Size(100, 23);
            this.btnAuthorize.TabIndex = 42;
            this.btnAuthorize.Text = "Authorize";
            this.btnAuthorize.UseVisualStyleBackColor = true;
            this.btnAuthorize.Click += new System.EventHandler(this.btnAuthorize_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.btnAuthorize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 43);
            this.panel1.TabIndex = 43;
            // 
            // ShareSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ShareSettings";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(476, 463);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.cmsFormat.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSplitPath;
        private System.Windows.Forms.TextBox txtSplitAheadGaining;
        private System.Windows.Forms.TextBox txtSplitAheadLosing;
        private System.Windows.Forms.TextBox txtSplitBehindGaining;
        private System.Windows.Forms.TextBox txtSplitBehindLosing;
        private System.Windows.Forms.TextBox txtBestSegment;
        private System.Windows.Forms.TextBox txtUndo;
        private System.Windows.Forms.TextBox txtSkip;
        private System.Windows.Forms.TextBox txtPersonalBest;
        private System.Windows.Forms.TextBox txtNotAPersonalBest;
        private System.Windows.Forms.TextBox txtReset;
        private System.Windows.Forms.TextBox txtPause;
        private System.Windows.Forms.TextBox txtResume;
        private System.Windows.Forms.TextBox txtStartTimer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ContextMenuStrip cmsFormat;
        private System.Windows.Forms.ToolStripMenuItem tsmiGameName;
        private System.Windows.Forms.ToolStripMenuItem tsmiCategoryName;
        private System.Windows.Forms.ToolStripMenuItem tsmiAttemptCount;
        private System.Windows.Forms.ToolStripMenuItem tsmiSplitName;
        private System.Windows.Forms.ToolStripMenuItem tsmiSplitTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeltaTime;
        private System.Windows.Forms.Button btnAuthorize;
        private System.Windows.Forms.Panel panel1;
    }
}
