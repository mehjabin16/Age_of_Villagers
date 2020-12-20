using System.Windows.Forms;

namespace AgeOfVillagers
{
    partial class DrawingWindow
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
            this.Drawingpanel = new System.Windows.Forms.Panel();
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.villagebox = new System.Windows.Forms.TextBox();
            this.changeNation = new System.Windows.Forms.ComboBox();
            this.nationlabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ToolsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Drawingpanel
            // 
            this.Drawingpanel.Location = new System.Drawing.Point(3, 3);
            this.Drawingpanel.Name = "Drawingpanel";
            this.Drawingpanel.Size = new System.Drawing.Size(600, 400);
            this.Drawingpanel.TabIndex = 0;
            this.Drawingpanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Drawingpanel_MouseClick);
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ToolsPanel.Controls.Add(this.villagebox);
            this.ToolsPanel.Controls.Add(this.changeNation);
            this.ToolsPanel.Controls.Add(this.nationlabel);
            this.ToolsPanel.Controls.Add(this.button3);
            this.ToolsPanel.Controls.Add(this.button2);
            this.ToolsPanel.Controls.Add(this.button1);
            this.ToolsPanel.Controls.Add(this.radioButton3);
            this.ToolsPanel.Controls.Add(this.radioButton2);
            this.ToolsPanel.Controls.Add(this.radioButton1);
            this.ToolsPanel.Controls.Add(this.label1);
            this.ToolsPanel.Location = new System.Drawing.Point(609, 3);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(200, 400);
            this.ToolsPanel.TabIndex = 1;
            // 
            // villagebox
            // 
            this.villagebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.villagebox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.villagebox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.villagebox.Location = new System.Drawing.Point(30, 53);
            this.villagebox.Name = "villagebox";
            this.villagebox.Size = new System.Drawing.Size(143, 34);
            this.villagebox.TabIndex = 11;
            this.villagebox.Text = "Village name\r\n";
            this.villagebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.villagebox.TextChanged += new System.EventHandler(this.villagebox_TextChanged);
            this.villagebox.VisibleChanged += new System.EventHandler(this.villagebox_TextChanged);
            // 
            // changeNation
            // 
            this.changeNation.BackColor = System.Drawing.SystemColors.Menu;
            this.changeNation.FormattingEnabled = true;
            this.changeNation.Items.AddRange(new object[] {
            "Bangladeshi Farmers",
            "Arab Beduins",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.changeNation.Location = new System.Drawing.Point(15, 127);
            this.changeNation.Name = "changeNation";
            this.changeNation.Size = new System.Drawing.Size(174, 33);
            this.changeNation.TabIndex = 10;
            this.changeNation.SelectedIndexChanged += new System.EventHandler(this.changeNation_SelectedIndexChanged);
            // 
            // nationlabel
            // 
            this.nationlabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nationlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nationlabel.Location = new System.Drawing.Point(15, 90);
            this.nationlabel.Name = "nationlabel";
            this.nationlabel.Size = new System.Drawing.Size(174, 30);
            this.nationlabel.TabIndex = 9;
            this.nationlabel.Text = "Select Nation";
            this.nationlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "Open Village";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OpenVillage_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "New Village";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NewVillage_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save Village";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveVillage_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(38, 234);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(137, 29);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "WaterSource";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(38, 199);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 29);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "House";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(38, 164);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 29);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tree";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age Of Villagers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrawingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 408);
            this.Controls.Add(this.ToolsPanel);
            this.Controls.Add(this.Drawingpanel);
            this.Name = "DrawingWindow";
            this.Text = "VillageEditor";
            this.Load += new System.EventHandler(this.DrawingWindow_Load);
            this.ToolsPanel.ResumeLayout(false);
            this.ToolsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Drawingpanel;
        private System.Windows.Forms.Panel ToolsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label nationlabel;
        private ComboBox changeNation;
        private TextBox villagebox;
    }
}