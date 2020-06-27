namespace Auto_Irrigation
{
    partial class main_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_page));
            this.Water_Bar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.water_per = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.water_quantity = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.temperature = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.temperature_per = new System.Windows.Forms.TextBox();
            this.moisture = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.moisture_bar = new System.Windows.Forms.ProgressBar();
            this.moisture_per = new System.Windows.Forms.TextBox();
            this.water_quantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.temperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.moisture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Water_Bar
            // 
            this.Water_Bar.Location = new System.Drawing.Point(6, 115);
            this.Water_Bar.Name = "Water_Bar";
            this.Water_Bar.Size = new System.Drawing.Size(213, 23);
            this.Water_Bar.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(439, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 95);
            this.button1.TabIndex = 13;
            this.button1.Text = "Irrigate";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // water_per
            // 
            this.water_per.BackColor = System.Drawing.Color.Navy;
            this.water_per.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.water_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.water_per.ForeColor = System.Drawing.Color.White;
            this.water_per.Location = new System.Drawing.Point(79, 143);
            this.water_per.Name = "water_per";
            this.water_per.ReadOnly = true;
            this.water_per.Size = new System.Drawing.Size(59, 33);
            this.water_per.TabIndex = 17;
            this.water_per.Text = "0";
            this.water_per.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 73);
            this.label1.TabIndex = 19;
            this.label1.Text = "Auto Irrigation System";
            // 
            // water_quantity
            // 
            this.water_quantity.BackColor = System.Drawing.Color.Navy;
            this.water_quantity.Controls.Add(this.label2);
            this.water_quantity.Controls.Add(this.pictureBox2);
            this.water_quantity.Controls.Add(this.pictureBox1);
            this.water_quantity.Controls.Add(this.Water_Bar);
            this.water_quantity.Controls.Add(this.water_per);
            this.water_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.water_quantity.ForeColor = System.Drawing.Color.White;
            this.water_quantity.Location = new System.Drawing.Point(401, 123);
            this.water_quantity.Name = "water_quantity";
            this.water_quantity.Size = new System.Drawing.Size(225, 189);
            this.water_quantity.TabIndex = 20;
            this.water_quantity.TabStop = false;
            this.water_quantity.Text = "Water Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "%";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(120, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 26);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // temperature
            // 
            this.temperature.BackColor = System.Drawing.Color.DarkOrange;
            this.temperature.Controls.Add(this.label4);
            this.temperature.Controls.Add(this.pictureBox3);
            this.temperature.Controls.Add(this.temperature_per);
            this.temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature.ForeColor = System.Drawing.Color.White;
            this.temperature.Location = new System.Drawing.Point(40, 123);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(225, 189);
            this.temperature.TabIndex = 21;
            this.temperature.TabStop = false;
            this.temperature.Text = "Temperature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkOrange;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 33);
            this.label4.TabIndex = 19;
            this.label4.Text = "oC";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 102);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // temperature_per
            // 
            this.temperature_per.BackColor = System.Drawing.Color.DarkOrange;
            this.temperature_per.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.temperature_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature_per.ForeColor = System.Drawing.Color.White;
            this.temperature_per.Location = new System.Drawing.Point(104, 78);
            this.temperature_per.Name = "temperature_per";
            this.temperature_per.ReadOnly = true;
            this.temperature_per.Size = new System.Drawing.Size(53, 37);
            this.temperature_per.TabIndex = 17;
            this.temperature_per.Text = "45";
            this.temperature_per.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // moisture
            // 
            this.moisture.BackColor = System.Drawing.Color.DodgerBlue;
            this.moisture.Controls.Add(this.label3);
            this.moisture.Controls.Add(this.pictureBox4);
            this.moisture.Controls.Add(this.moisture_bar);
            this.moisture.Controls.Add(this.moisture_per);
            this.moisture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moisture.ForeColor = System.Drawing.Color.White;
            this.moisture.Location = new System.Drawing.Point(753, 123);
            this.moisture.Name = "moisture";
            this.moisture.Size = new System.Drawing.Size(225, 189);
            this.moisture.TabIndex = 22;
            this.moisture.TabStop = false;
            this.moisture.Text = "Moisture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "%";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(79, 30);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(78, 69);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // moisture_bar
            // 
            this.moisture_bar.Location = new System.Drawing.Point(6, 115);
            this.moisture_bar.Name = "moisture_bar";
            this.moisture_bar.Size = new System.Drawing.Size(213, 23);
            this.moisture_bar.TabIndex = 8;
            // 
            // moisture_per
            // 
            this.moisture_per.BackColor = System.Drawing.Color.DodgerBlue;
            this.moisture_per.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moisture_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moisture_per.ForeColor = System.Drawing.Color.White;
            this.moisture_per.Location = new System.Drawing.Point(89, 144);
            this.moisture_per.Name = "moisture_per";
            this.moisture_per.Size = new System.Drawing.Size(43, 31);
            this.moisture_per.TabIndex = 17;
            this.moisture_per.Text = "0";
            this.moisture_per.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.moisture_per.TextChanged += new System.EventHandler(this.moisture_per_TextChanged);
            // 
            // main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 561);
            this.Controls.Add(this.moisture);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.water_quantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_page";
            this.Text = "Auto Irrigation";
            this.water_quantity.ResumeLayout(false);
            this.water_quantity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.temperature.ResumeLayout(false);
            this.temperature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.moisture.ResumeLayout(false);
            this.moisture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar Water_Bar;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox water_per;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox water_quantity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox temperature;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox temperature_per;
        private System.Windows.Forms.GroupBox moisture;
        private System.Windows.Forms.TextBox moisture_per;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar moisture_bar;
    }
}

