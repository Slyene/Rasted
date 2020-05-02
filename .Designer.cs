using System;

namespace Rasted
{
    partial class FormRasted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRasted));
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBoxDraw = new System.Windows.Forms.PictureBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOpenFile,
            this.ToolStripMenuItemSaveFile,
            this.toolStripMenuItemExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItemFile.Text = "Файл";
            // 
            // ToolStripMenuItemOpenFile
            // 
            this.ToolStripMenuItemOpenFile.Name = "ToolStripMenuItemOpenFile";
            this.ToolStripMenuItemOpenFile.Size = new System.Drawing.Size(133, 22);
            this.ToolStripMenuItemOpenFile.Text = "Открыть";
            this.ToolStripMenuItemOpenFile.Click += new System.EventHandler(this.ToolStripMenuItemOpenFile_Click);
            // 
            // ToolStripMenuItemSaveFile
            // 
            this.ToolStripMenuItemSaveFile.Name = "ToolStripMenuItemSaveFile";
            this.ToolStripMenuItemSaveFile.Size = new System.Drawing.Size(133, 22);
            this.ToolStripMenuItemSaveFile.Text = "Сохранить";
            this.ToolStripMenuItemSaveFile.Click += new System.EventHandler(this.ToolStripMenuItemSaveFile_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItemExit.Text = "Выход";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(886, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(0, 497);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMode,
            this.toolStripStatusLabelLocation});
            this.statusStrip.Location = new System.Drawing.Point(0, 499);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(886, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMode
            // 
            this.toolStripStatusLabelMode.Name = "toolStripStatusLabelMode";
            this.toolStripStatusLabelMode.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabelMode.Text = "toolStripStatusLabel";
            // 
            // toolStripStatusLabelLocation
            // 
            this.toolStripStatusLabelLocation.Name = "toolStripStatusLabelLocation";
            this.toolStripStatusLabelLocation.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelLocation.Text = "toolStripStatusLabel1";
            // 
            // pictureBoxDraw
            // 
            this.pictureBoxDraw.BackColor = System.Drawing.Color.White;
            this.pictureBoxDraw.Location = new System.Drawing.Point(109, 52);
            this.pictureBoxDraw.Name = "pictureBoxDraw";
            this.pictureBoxDraw.Size = new System.Drawing.Size(777, 444);
            this.pictureBoxDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDraw.TabIndex = 3;
            this.pictureBoxDraw.TabStop = false;
            this.pictureBoxDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxDraw_MouseDown);
            this.pictureBoxDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxDraw_MouseMove);
            this.pictureBoxDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBoxDraw_MouseUp);
            pictureBoxDraw.Paint += this.PictureBoxDraw_Paint;
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonClear,
            this.toolStripButtonColor,
            this.toolStripTextBoxText,
            this.toolStripComboBox});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(886, 25);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClear.Image")));
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(112, 22);
            this.toolStripButtonClear.Text = "Очистить рисунок";
            this.toolStripButtonClear.Click += new System.EventHandler(this.ToolStripMenuItemClear_Click);
            // 
            // toolStripButtonColor
            // 
            this.toolStripButtonColor.BackColor = System.Drawing.Color.Black;
            this.toolStripButtonColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonColor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonColor.Image")));
            this.toolStripButtonColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColor.Name = "toolStripButtonColor";
            this.toolStripButtonColor.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonColor.Click += new System.EventHandler(this.ToolStripButtonColor_Click);
            // 
            // toolStripTextBoxText
            // 
            this.toolStripTextBoxText.AccessibleDescription = "";
            this.toolStripTextBoxText.Name = "toolStripTextBoxText";
            this.toolStripTextBoxText.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxText.Tag = "";
            this.toolStripTextBoxText.ToolTipText = "Введите текст";
            // 
            // toolStripComboBox
            // 
            this.toolStripComboBox.Name = "toolStripComboBox";
            this.toolStripComboBox.Size = new System.Drawing.Size(150, 25);
            this.toolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.ToolStripComboBoxPicture_SelectedIndexChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FormRasted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 521);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.pictureBoxDraw);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormRasted";
            this.Text = "Rasted";
            this.Load += new System.EventHandler(this.FormRasted_Load);
            this.Click += new System.EventHandler(this.ToolStripMenuItemClear_Click);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpenFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveFile;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.PictureBox pictureBoxDraw;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
        private System.Windows.Forms.ToolStripButton toolStripButtonColor;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxText;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMode;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLocation;
    }
}

