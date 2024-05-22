namespace laboratorySystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            eqCondition = new TextBox();
            label6 = new Label();
            eqUse = new TextBox();
            label7 = new Label();
            eqSize = new TextBox();
            label8 = new Label();
            eqStatus = new TextBox();
            label9 = new Label();
            eqSupplier = new TextBox();
            label10 = new Label();
            eqPrice = new TextBox();
            label5 = new Label();
            eqQuantity = new TextBox();
            label4 = new Label();
            eqCatagory = new TextBox();
            label3 = new Label();
            eqName = new TextBox();
            label2 = new Label();
            eqID = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(eqCondition);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(eqUse);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(eqSize);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(eqStatus);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(eqSupplier);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(eqPrice);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(eqQuantity);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(eqCatagory);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(eqName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(eqID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(28, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(929, 520);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Laboratory Table";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(703, 449);
            button4.Name = "button4";
            button4.Size = new Size(162, 54);
            button4.TabIndex = 22;
            button4.Text = "DISPLAY";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(487, 449);
            button3.Name = "button3";
            button3.Size = new Size(162, 54);
            button3.TabIndex = 21;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(278, 449);
            button2.Name = "button2";
            button2.Size = new Size(162, 54);
            button2.TabIndex = 20;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(70, 449);
            button1.Name = "button1";
            button1.Size = new Size(162, 54);
            button1.TabIndex = 1;
            button1.Text = "INSERT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // eqCondition
            // 
            eqCondition.Location = new Point(738, 361);
            eqCondition.Name = "eqCondition";
            eqCondition.Size = new Size(150, 31);
            eqCondition.TabIndex = 19;
            eqCondition.TextChanged += eqCondition_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(487, 362);
            label6.Name = "label6";
            label6.Size = new Size(233, 30);
            label6.TabIndex = 18;
            label6.Text = "Equipment Condition";
            // 
            // eqUse
            // 
            eqUse.Location = new Point(738, 286);
            eqUse.Name = "eqUse";
            eqUse.Size = new Size(150, 31);
            eqUse.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(487, 287);
            label7.Name = "label7";
            label7.Size = new Size(170, 30);
            label7.TabIndex = 16;
            label7.Text = "Equipment Use";
            // 
            // eqSize
            // 
            eqSize.Location = new Point(738, 215);
            eqSize.Name = "eqSize";
            eqSize.Size = new Size(150, 31);
            eqSize.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(487, 216);
            label8.Name = "label8";
            label8.Size = new Size(173, 30);
            label8.TabIndex = 14;
            label8.Text = "Equipment Size";
            // 
            // eqStatus
            // 
            eqStatus.Location = new Point(738, 135);
            eqStatus.Name = "eqStatus";
            eqStatus.Size = new Size(150, 31);
            eqStatus.TabIndex = 13;
            eqStatus.TextChanged += eqStatus_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(487, 136);
            label9.Name = "label9";
            label9.Size = new Size(196, 30);
            label9.TabIndex = 12;
            label9.Text = "Equipment Status";
            // 
            // eqSupplier
            // 
            eqSupplier.Location = new Point(738, 59);
            eqSupplier.Name = "eqSupplier";
            eqSupplier.Size = new Size(150, 31);
            eqSupplier.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(487, 60);
            label10.Name = "label10";
            label10.Size = new Size(218, 30);
            label10.TabIndex = 10;
            label10.Text = "Equipment Supplier";
            // 
            // eqPrice
            // 
            eqPrice.Location = new Point(302, 360);
            eqPrice.Name = "eqPrice";
            eqPrice.Size = new Size(150, 31);
            eqPrice.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(51, 361);
            label5.Name = "label5";
            label5.Size = new Size(184, 30);
            label5.TabIndex = 8;
            label5.Text = "Equipment Price";
            // 
            // eqQuantity
            // 
            eqQuantity.Location = new Point(302, 285);
            eqQuantity.Name = "eqQuantity";
            eqQuantity.Size = new Size(150, 31);
            eqQuantity.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 286);
            label4.Name = "label4";
            label4.Size = new Size(223, 30);
            label4.TabIndex = 6;
            label4.Text = "Equipment Quantity";
            // 
            // eqCatagory
            // 
            eqCatagory.Location = new Point(302, 214);
            eqCatagory.Name = "eqCatagory";
            eqCatagory.Size = new Size(150, 31);
            eqCatagory.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 215);
            label3.Name = "label3";
            label3.Size = new Size(228, 30);
            label3.TabIndex = 4;
            label3.Text = "Equipment Catagory";
            // 
            // eqName
            // 
            eqName.Location = new Point(302, 134);
            eqName.Name = "eqName";
            eqName.Size = new Size(150, 31);
            eqName.TabIndex = 3;
            eqName.TextChanged += eqName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 135);
            label2.Name = "label2";
            label2.Size = new Size(193, 30);
            label2.TabIndex = 2;
            label2.Text = "Equipment Name";
            // 
            // eqID
            // 
            eqID.Location = new Point(302, 58);
            eqID.Name = "eqID";
            eqID.Size = new Size(150, 31);
            eqID.TabIndex = 1;
            eqID.TextChanged += eqID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 59);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 0;
            label1.Text = "Equipment ID";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(991, 554);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Laboratory System";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox eqID;
        private TextBox eqCatagory;
        private Label label3;
        private TextBox eqName;
        private Label label2;
        private TextBox eqCondition;
        private Label label6;
        private TextBox eqUse;
        private Label label7;
        private TextBox eqSize;
        private Label label8;
        private TextBox eqStatus;
        private Label label9;
        private TextBox eqSupplier;
        private Label label10;
        private TextBox eqPrice;
        private Label label5;
        private TextBox eqQuantity;
        private Label label4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
    }
}
