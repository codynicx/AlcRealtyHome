namespace Problem2Model_House
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBasePriceColonial = new System.Windows.Forms.TextBox();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtBasePriceSpltNtry = new System.Windows.Forms.TextBox();
            this.txtBasePriceSnglStory = new System.Windows.Forms.TextBox();
            this.txtAreaColonial = new System.Windows.Forms.TextBox();
            this.txtAreaSpltNtry = new System.Windows.Forms.TextBox();
            this.txtAreaSngleStory = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBasePriceColonial
            // 
            this.txtBasePriceColonial.Location = new System.Drawing.Point(3, 56);
            this.txtBasePriceColonial.Name = "txtBasePriceColonial";
            this.txtBasePriceColonial.Size = new System.Drawing.Size(112, 20);
            this.txtBasePriceColonial.TabIndex = 1;
            this.txtBasePriceColonial.TextChanged += new System.EventHandler(this.txtBasePriceColonial_TextChanged);
            this.txtBasePriceColonial.Leave += new System.EventHandler(this.txtBasePriceColonial_Leave);
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("SF UI  Text 2", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.Location = new System.Drawing.Point(3, 0);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(98, 16);
            this.lblBasePrice.TabIndex = 4;
            this.lblBasePrice.Text = "       Base Price";
            this.lblBasePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("SF UI  Text 2", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(123, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(112, 32);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Finished Area in Square Feet";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblArea.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtBasePriceSpltNtry
            // 
            this.txtBasePriceSpltNtry.Location = new System.Drawing.Point(3, 104);
            this.txtBasePriceSpltNtry.Name = "txtBasePriceSpltNtry";
            this.txtBasePriceSpltNtry.Size = new System.Drawing.Size(110, 20);
            this.txtBasePriceSpltNtry.TabIndex = 6;
            this.txtBasePriceSpltNtry.Leave += new System.EventHandler(this.txtBasePriceSpltNtry_Leave);
            // 
            // txtBasePriceSnglStory
            // 
            this.txtBasePriceSnglStory.Location = new System.Drawing.Point(3, 157);
            this.txtBasePriceSnglStory.Name = "txtBasePriceSnglStory";
            this.txtBasePriceSnglStory.Size = new System.Drawing.Size(110, 20);
            this.txtBasePriceSnglStory.TabIndex = 7;
            this.txtBasePriceSnglStory.Leave += new System.EventHandler(this.txtBasePriceSnglStory_Leave);
            // 
            // txtAreaColonial
            // 
            this.txtAreaColonial.Location = new System.Drawing.Point(123, 56);
            this.txtAreaColonial.Name = "txtAreaColonial";
            this.txtAreaColonial.Size = new System.Drawing.Size(110, 20);
            this.txtAreaColonial.TabIndex = 8;
            this.txtAreaColonial.Leave += new System.EventHandler(this.txtAreaColonial_Leave);
            // 
            // txtAreaSpltNtry
            // 
            this.txtAreaSpltNtry.Location = new System.Drawing.Point(123, 104);
            this.txtAreaSpltNtry.Name = "txtAreaSpltNtry";
            this.txtAreaSpltNtry.Size = new System.Drawing.Size(112, 20);
            this.txtAreaSpltNtry.TabIndex = 9;
            this.txtAreaSpltNtry.Leave += new System.EventHandler(this.txtAreaSpltNtry_Leave);
            // 
            // txtAreaSngleStory
            // 
            this.txtAreaSngleStory.Location = new System.Drawing.Point(123, 157);
            this.txtAreaSngleStory.Name = "txtAreaSngleStory";
            this.txtAreaSngleStory.Size = new System.Drawing.Size(112, 20);
            this.txtAreaSngleStory.TabIndex = 10;
            this.txtAreaSngleStory.TextChanged += new System.EventHandler(this.txtAreaSngleStory_TextChanged);
            this.txtAreaSngleStory.Leave += new System.EventHandler(this.txtAreaSngleStory_Leave);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(128)))), ((int)(((byte)(125)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(105, 275);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(128)))), ((int)(((byte)(125)))));
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Location = new System.Drawing.Point(228, 275);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(112, 23);
            this.btnResult.TabIndex = 12;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-119, -38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(232)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.btnResult);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(327, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 340);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblArea, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAreaSngleStory, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblBasePrice, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAreaSpltNtry, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBasePriceSpltNtry, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAreaColonial, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBasePriceColonial, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBasePriceSnglStory, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(102, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.47525F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.52475F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 205);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF UI  Text 2", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Colonial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF UI  Text 2", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Split - Entry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF UI  Text 2", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Single Story";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 342);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alc Realty-Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBasePriceColonial;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtBasePriceSpltNtry;
        private System.Windows.Forms.TextBox txtBasePriceSnglStory;
        private System.Windows.Forms.TextBox txtAreaColonial;
        private System.Windows.Forms.TextBox txtAreaSpltNtry;
        private System.Windows.Forms.TextBox txtAreaSngleStory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

