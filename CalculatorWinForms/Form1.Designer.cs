namespace CalculatorWinForms
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
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ans = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_reverse = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_sqrt = new System.Windows.Forms.Button();
            this.btn_square = new System.Windows.Forms.Button();
            this.btn_DivideOne = new System.Windows.Forms.Button();
            this.btn_backSpace = new System.Windows.Forms.Button();
            this.btn_clearAll = new System.Windows.Forms.Button();
            this.btn_clearRow = new System.Windows.Forms.Button();
            this.btn_percent = new System.Windows.Forms.Button();
            this.btn_mStore = new System.Windows.Forms.Button();
            this.btn_mplus = new System.Windows.Forms.Button();
            this.btn_mr = new System.Windows.Forms.Button();
            this.btn_mc = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDisplayGeneral = new System.Windows.Forms.TextBox();
            this.txtCurrentDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutMain.SuspendLayout();
            this.tableLayoutButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutMain.ColumnCount = 1;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMain.Controls.Add(this.tableLayoutButtons, 0, 1);
            this.tableLayoutMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutMain.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 2;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutMain.Size = new System.Drawing.Size(274, 426);
            this.tableLayoutMain.TabIndex = 0;
            // 
            // tableLayoutButtons
            // 
            this.tableLayoutButtons.ColumnCount = 4;
            this.tableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutButtons.Controls.Add(this.btn_ans, 3, 6);
            this.tableLayoutButtons.Controls.Add(this.btn_dot, 2, 6);
            this.tableLayoutButtons.Controls.Add(this.btn_0, 1, 6);
            this.tableLayoutButtons.Controls.Add(this.btn_reverse, 0, 6);
            this.tableLayoutButtons.Controls.Add(this.btn_add, 3, 5);
            this.tableLayoutButtons.Controls.Add(this.btn_3, 2, 5);
            this.tableLayoutButtons.Controls.Add(this.btn_2, 1, 5);
            this.tableLayoutButtons.Controls.Add(this.btn_1, 0, 5);
            this.tableLayoutButtons.Controls.Add(this.btn_minus, 3, 4);
            this.tableLayoutButtons.Controls.Add(this.btn_6, 2, 4);
            this.tableLayoutButtons.Controls.Add(this.btn_5, 1, 4);
            this.tableLayoutButtons.Controls.Add(this.btn_4, 0, 4);
            this.tableLayoutButtons.Controls.Add(this.btn_multiply, 3, 3);
            this.tableLayoutButtons.Controls.Add(this.btn_9, 2, 3);
            this.tableLayoutButtons.Controls.Add(this.btn_8, 1, 3);
            this.tableLayoutButtons.Controls.Add(this.btn_7, 0, 3);
            this.tableLayoutButtons.Controls.Add(this.btn_divide, 3, 2);
            this.tableLayoutButtons.Controls.Add(this.btn_sqrt, 2, 2);
            this.tableLayoutButtons.Controls.Add(this.btn_square, 1, 2);
            this.tableLayoutButtons.Controls.Add(this.btn_DivideOne, 0, 2);
            this.tableLayoutButtons.Controls.Add(this.btn_backSpace, 3, 1);
            this.tableLayoutButtons.Controls.Add(this.btn_clearAll, 2, 1);
            this.tableLayoutButtons.Controls.Add(this.btn_clearRow, 1, 1);
            this.tableLayoutButtons.Controls.Add(this.btn_percent, 0, 1);
            this.tableLayoutButtons.Controls.Add(this.btn_mStore, 3, 0);
            this.tableLayoutButtons.Controls.Add(this.btn_mplus, 2, 0);
            this.tableLayoutButtons.Controls.Add(this.btn_mr, 1, 0);
            this.tableLayoutButtons.Controls.Add(this.btn_mc, 0, 0);
            this.tableLayoutButtons.Location = new System.Drawing.Point(3, 88);
            this.tableLayoutButtons.Name = "tableLayoutButtons";
            this.tableLayoutButtons.RowCount = 7;
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutButtons.Size = new System.Drawing.Size(268, 335);
            this.tableLayoutButtons.TabIndex = 1;
            // 
            // btn_ans
            // 
            this.btn_ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ans.Location = new System.Drawing.Point(204, 286);
            this.btn_ans.Name = "btn_ans";
            this.btn_ans.Size = new System.Drawing.Size(61, 44);
            this.btn_ans.TabIndex = 27;
            this.btn_ans.Text = "=";
            this.btn_ans.UseVisualStyleBackColor = true;
            this.btn_ans.Click += new System.EventHandler(this.btn_ans_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dot.Location = new System.Drawing.Point(137, 286);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(61, 44);
            this.btn_dot.TabIndex = 26;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(70, 286);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(61, 44);
            this.btn_0.TabIndex = 25;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_reverse
            // 
            this.btn_reverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reverse.Location = new System.Drawing.Point(3, 286);
            this.btn_reverse.Name = "btn_reverse";
            this.btn_reverse.Size = new System.Drawing.Size(61, 44);
            this.btn_reverse.TabIndex = 24;
            this.btn_reverse.Text = "+/-";
            this.btn_reverse.UseVisualStyleBackColor = true;
            this.btn_reverse.Click += new System.EventHandler(this.btn_reverse_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(204, 236);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(61, 44);
            this.btn_add.TabIndex = 23;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_Operation_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(137, 236);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(61, 44);
            this.btn_3.TabIndex = 22;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(70, 236);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(61, 44);
            this.btn_2.TabIndex = 21;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(3, 236);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(61, 44);
            this.btn_1.TabIndex = 20;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.Location = new System.Drawing.Point(204, 186);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(61, 44);
            this.btn_minus.TabIndex = 19;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_Operation_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(137, 186);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(61, 44);
            this.btn_6.TabIndex = 18;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(70, 186);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(61, 44);
            this.btn_5.TabIndex = 17;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(3, 186);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(61, 44);
            this.btn_4.TabIndex = 16;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiply.Location = new System.Drawing.Point(204, 136);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(61, 44);
            this.btn_multiply.TabIndex = 15;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_Operation_Click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(137, 136);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(61, 44);
            this.btn_9.TabIndex = 14;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(70, 136);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(61, 44);
            this.btn_8.TabIndex = 13;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(3, 136);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(61, 44);
            this.btn_7.TabIndex = 12;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_Num_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divide.Location = new System.Drawing.Point(204, 86);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(61, 44);
            this.btn_divide.TabIndex = 11;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_Operation_Click);

            // 
            // btn_sqrt
            // 
            this.btn_sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sqrt.Location = new System.Drawing.Point(137, 86);
            this.btn_sqrt.Name = "btn_sqrt";
            this.btn_sqrt.Size = new System.Drawing.Size(61, 44);
            this.btn_sqrt.TabIndex = 10;
            this.btn_sqrt.Text = "sqrt(x)";
            this.btn_sqrt.UseVisualStyleBackColor = true;
            this.btn_sqrt.Click += new System.EventHandler(this.btn_sqrt_Click);
            // 
            // btn_square
            // 
            this.btn_square.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_square.Location = new System.Drawing.Point(70, 86);
            this.btn_square.Name = "btn_square";
            this.btn_square.Size = new System.Drawing.Size(61, 44);
            this.btn_square.TabIndex = 9;
            this.btn_square.Text = "x^2";
            this.btn_square.UseVisualStyleBackColor = true;
            this.btn_square.Click += new System.EventHandler(this.btn_square_Click);
            // 
            // btn_DivideOne
            // 
            this.btn_DivideOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DivideOne.Location = new System.Drawing.Point(3, 86);
            this.btn_DivideOne.Name = "btn_DivideOne";
            this.btn_DivideOne.Size = new System.Drawing.Size(61, 44);
            this.btn_DivideOne.TabIndex = 8;
            this.btn_DivideOne.Text = "1/x";
            this.btn_DivideOne.UseVisualStyleBackColor = true;
            this.btn_DivideOne.Click += new System.EventHandler(this.btn_DivideOne_Click);
            // 
            // btn_backSpace
            // 
            this.btn_backSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backSpace.Location = new System.Drawing.Point(204, 36);
            this.btn_backSpace.Name = "btn_backSpace";
            this.btn_backSpace.Size = new System.Drawing.Size(61, 44);
            this.btn_backSpace.TabIndex = 7;
            this.btn_backSpace.Text = "<";
            this.btn_backSpace.UseVisualStyleBackColor = true;
            this.btn_backSpace.Click += new System.EventHandler(this.btn_backSpace_Click);
            // 
            // btn_clearAll
            // 
            this.btn_clearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearAll.Location = new System.Drawing.Point(137, 36);
            this.btn_clearAll.Name = "btn_clearAll";
            this.btn_clearAll.Size = new System.Drawing.Size(61, 44);
            this.btn_clearAll.TabIndex = 6;
            this.btn_clearAll.Text = "C";
            this.btn_clearAll.UseVisualStyleBackColor = true;
            this.btn_clearAll.Click += new System.EventHandler(this.btn_clearAll_Click);
            // 
            // btn_clearRow
            // 
            this.btn_clearRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearRow.Location = new System.Drawing.Point(70, 36);
            this.btn_clearRow.Name = "btn_clearRow";
            this.btn_clearRow.Size = new System.Drawing.Size(61, 44);
            this.btn_clearRow.TabIndex = 5;
            this.btn_clearRow.Text = "CE";
            this.btn_clearRow.UseVisualStyleBackColor = true;
            this.btn_clearRow.Click += new System.EventHandler(this.btn_clearRow_Click);
            // 
            // btn_percent
            // 
            this.btn_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_percent.Location = new System.Drawing.Point(3, 36);
            this.btn_percent.Name = "btn_percent";
            this.btn_percent.Size = new System.Drawing.Size(61, 44);
            this.btn_percent.TabIndex = 4;
            this.btn_percent.Text = "%";
            this.btn_percent.UseVisualStyleBackColor = true;
            this.btn_percent.Click += new System.EventHandler(this.btn_percent_Click);
            // 
            // btn_mStore
            // 
            this.btn_mStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mStore.Location = new System.Drawing.Point(204, 3);
            this.btn_mStore.Name = "btn_mStore";
            this.btn_mStore.Size = new System.Drawing.Size(61, 27);
            this.btn_mStore.TabIndex = 3;
            this.btn_mStore.Text = "MS";
            this.btn_mStore.UseVisualStyleBackColor = true;
            this.btn_mStore.Click += new System.EventHandler(this.btn_mStore_Click);
            // 
            // btn_mplus
            // 
            this.btn_mplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mplus.Location = new System.Drawing.Point(137, 3);
            this.btn_mplus.Name = "btn_mplus";
            this.btn_mplus.Size = new System.Drawing.Size(61, 27);
            this.btn_mplus.TabIndex = 2;
            this.btn_mplus.Text = "M+";
            this.btn_mplus.UseVisualStyleBackColor = true;
            this.btn_mplus.Click += new System.EventHandler(this.btn_mplus_Click);
            // 
            // btn_mr
            // 
            this.btn_mr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mr.Location = new System.Drawing.Point(70, 3);
            this.btn_mr.Name = "btn_mr";
            this.btn_mr.Size = new System.Drawing.Size(61, 27);
            this.btn_mr.TabIndex = 1;
            this.btn_mr.Text = "MR";
            this.btn_mr.UseVisualStyleBackColor = true;
            this.btn_mr.Click += new System.EventHandler(this.btn_mr_Click);
            // 
            // btn_mc
            // 
            this.btn_mc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mc.Location = new System.Drawing.Point(3, 3);
            this.btn_mc.Name = "btn_mc";
            this.btn_mc.Size = new System.Drawing.Size(61, 27);
            this.btn_mc.TabIndex = 0;
            this.btn_mc.Text = "MC";
            this.btn_mc.UseVisualStyleBackColor = true;
            this.btn_mc.Click += new System.EventHandler(this.btn_mc_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtDisplayGeneral, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCurrentDisplay, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(268, 79);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtDisplayGeneral
            // 
            this.txtDisplayGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayGeneral.Location = new System.Drawing.Point(3, 3);
            this.txtDisplayGeneral.Multiline = true;
            this.txtDisplayGeneral.Name = "txtDisplayGeneral";
            this.txtDisplayGeneral.Size = new System.Drawing.Size(262, 33);
            this.txtDisplayGeneral.TabIndex = 0;
            this.txtDisplayGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCurrentDisplay
            // 
            this.txtCurrentDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentDisplay.Location = new System.Drawing.Point(3, 42);
            this.txtCurrentDisplay.Multiline = true;
            this.txtCurrentDisplay.Name = "txtCurrentDisplay";
            this.txtCurrentDisplay.Size = new System.Drawing.Size(262, 34);
            this.txtCurrentDisplay.TabIndex = 1;
            this.txtCurrentDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 450);
            this.Controls.Add(this.tableLayoutMain);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutButtons;
        private System.Windows.Forms.Button btn_ans;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_reverse;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_sqrt;
        private System.Windows.Forms.Button btn_square;
        private System.Windows.Forms.Button btn_DivideOne;
        private System.Windows.Forms.Button btn_backSpace;
        private System.Windows.Forms.Button btn_clearAll;
        private System.Windows.Forms.Button btn_clearRow;
        private System.Windows.Forms.Button btn_percent;
        private System.Windows.Forms.Button btn_mStore;
        private System.Windows.Forms.Button btn_mplus;
        private System.Windows.Forms.Button btn_mr;
        private System.Windows.Forms.Button btn_mc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtDisplayGeneral;
        private System.Windows.Forms.TextBox txtCurrentDisplay;
    }
}

