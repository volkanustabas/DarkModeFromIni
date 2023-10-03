namespace DarkModeFromIni
{
    partial class FrmMain
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
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_top = new System.Windows.Forms.TableLayoutPanel();
            this.btn_dark = new System.Windows.Forms.Button();
            this.btn_light = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.tlp_main.SuspendLayout();
            this.tlp_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_main
            // 
            this.tlp_main.ColumnCount = 1;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_main.Controls.Add(this.tlp_top, 0, 0);
            this.tlp_main.Controls.Add(this.lbl_info, 0, 1);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 2;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_main.Size = new System.Drawing.Size(800, 450);
            this.tlp_main.TabIndex = 0;
            // 
            // tlp_top
            // 
            this.tlp_top.ColumnCount = 2;
            this.tlp_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_top.Controls.Add(this.btn_dark, 0, 0);
            this.tlp_top.Controls.Add(this.btn_light, 1, 0);
            this.tlp_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_top.Location = new System.Drawing.Point(3, 3);
            this.tlp_top.Name = "tlp_top";
            this.tlp_top.Padding = new System.Windows.Forms.Padding(20);
            this.tlp_top.RowCount = 1;
            this.tlp_top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_top.Size = new System.Drawing.Size(794, 219);
            this.tlp_top.TabIndex = 0;
            // 
            // btn_dark
            // 
            this.btn_dark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dark.Location = new System.Drawing.Point(23, 23);
            this.btn_dark.Name = "btn_dark";
            this.btn_dark.Size = new System.Drawing.Size(371, 173);
            this.btn_dark.TabIndex = 0;
            this.btn_dark.Text = "DARK";
            this.btn_dark.UseVisualStyleBackColor = true;
            this.btn_dark.Click += new System.EventHandler(this.btn_dark_Click);
            // 
            // btn_light
            // 
            this.btn_light.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_light.Location = new System.Drawing.Point(400, 23);
            this.btn_light.Name = "btn_light";
            this.btn_light.Size = new System.Drawing.Size(371, 173);
            this.btn_light.TabIndex = 1;
            this.btn_light.Text = "LIGHT";
            this.btn_light.UseVisualStyleBackColor = true;
            this.btn_light.Click += new System.EventHandler(this.btn_light_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_info.Location = new System.Drawing.Point(3, 225);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(794, 225);
            this.lbl_info.TabIndex = 1;
            this.lbl_info.Text = "-";
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlp_main);
            this.Name = "FrmMain";
            this.Text = "DarkModeFromIni";
            this.tlp_main.ResumeLayout(false);
            this.tlp_main.PerformLayout();
            this.tlp_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_main;
        private System.Windows.Forms.TableLayoutPanel tlp_top;
        private System.Windows.Forms.Button btn_dark;
        private System.Windows.Forms.Button btn_light;
        private System.Windows.Forms.Label lbl_info;
    }
}

