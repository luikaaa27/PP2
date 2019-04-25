namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.input = new System.Windows.Forms.TextBox();
            this.factorial = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
            this.coPrime = new System.Windows.Forms.Button();
            this.Closest = new System.Windows.Forms.Button();
            this.Fibonacci = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.allClear = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.inv = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.binary = new System.Windows.Forms.Button();
            this.octal = new System.Windows.Forms.Button();
            this.Hexadecimal = new System.Windows.Forms.Button();
            this.sqrtY = new System.Windows.Forms.Button();
            this.PowOf10 = new System.Windows.Forms.Button();
            this.LCM = new System.Windows.Forms.Button();
            this.Reverse = new System.Windows.Forms.Button();
            this.FromHexToDec = new System.Windows.Forms.Button();
            this.f = new System.Windows.Forms.Button();
            this.SumOfPrimes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.input.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.input.Enabled = false;
            this.input.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input.HideSelection = false;
            this.input.Location = new System.Drawing.Point(16, 47);
            this.input.Margin = new System.Windows.Forms.Padding(4);
            this.input.Name = "input";
            this.input.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input.Size = new System.Drawing.Size(392, 43);
            this.input.TabIndex = 2;
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // factorial
            // 
            this.factorial.BackColor = System.Drawing.Color.LightBlue;
            this.factorial.ForeColor = System.Drawing.Color.MidnightBlue;
            this.factorial.Location = new System.Drawing.Point(73, 98);
            this.factorial.Margin = new System.Windows.Forms.Padding(4);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(49, 34);
            this.factorial.TabIndex = 3;
            this.factorial.Text = "x!";
            this.factorial.UseVisualStyleBackColor = false;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // pow
            // 
            this.pow.BackColor = System.Drawing.Color.LightBlue;
            this.pow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pow.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pow.Location = new System.Drawing.Point(16, 98);
            this.pow.Margin = new System.Windows.Forms.Padding(4);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(49, 34);
            this.pow.TabIndex = 4;
            this.pow.Text = "x^y";
            this.pow.UseVisualStyleBackColor = false;
            this.pow.Click += new System.EventHandler(this.pow_Click);
            // 
            // coPrime
            // 
            this.coPrime.BackColor = System.Drawing.Color.LightBlue;
            this.coPrime.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coPrime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.coPrime.Location = new System.Drawing.Point(131, 98);
            this.coPrime.Margin = new System.Windows.Forms.Padding(4);
            this.coPrime.Name = "coPrime";
            this.coPrime.Size = new System.Drawing.Size(49, 34);
            this.coPrime.TabIndex = 7;
            this.coPrime.Text = "gcd";
            this.coPrime.UseVisualStyleBackColor = false;
            this.coPrime.Click += new System.EventHandler(this.coPrime_Click);
            // 
            // Closest
            // 
            this.Closest.BackColor = System.Drawing.Color.LightBlue;
            this.Closest.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Closest.Location = new System.Drawing.Point(188, 98);
            this.Closest.Margin = new System.Windows.Forms.Padding(4);
            this.Closest.Name = "Closest";
            this.Closest.Size = new System.Drawing.Size(49, 34);
            this.Closest.TabIndex = 8;
            this.Closest.Text = "closest";
            this.Closest.UseVisualStyleBackColor = false;
            this.Closest.Click += new System.EventHandler(this.Closest_Click);
            // 
            // Fibonacci
            // 
            this.Fibonacci.BackColor = System.Drawing.Color.LightBlue;
            this.Fibonacci.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Fibonacci.Location = new System.Drawing.Point(245, 98);
            this.Fibonacci.Margin = new System.Windows.Forms.Padding(4);
            this.Fibonacci.Name = "Fibonacci";
            this.Fibonacci.Size = new System.Drawing.Size(51, 34);
            this.Fibonacci.TabIndex = 9;
            this.Fibonacci.Text = "FBNC";
            this.Fibonacci.UseVisualStyleBackColor = false;
            this.Fibonacci.Click += new System.EventHandler(this.Fibonacci_Click);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.Color.LightBlue;
            this.sqrt.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.sqrt.Location = new System.Drawing.Point(245, 182);
            this.sqrt.Margin = new System.Windows.Forms.Padding(4);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(49, 34);
            this.sqrt.TabIndex = 14;
            this.sqrt.Text = "√x";
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.Color.LightBlue;
            this.sign.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sign.ForeColor = System.Drawing.Color.MidnightBlue;
            this.sign.Location = new System.Drawing.Point(188, 140);
            this.sign.Margin = new System.Windows.Forms.Padding(4);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(49, 34);
            this.sign.TabIndex = 13;
            this.sign.Text = "±";
            this.sign.UseVisualStyleBackColor = false;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // allClear
            // 
            this.allClear.BackColor = System.Drawing.Color.LightBlue;
            this.allClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allClear.ForeColor = System.Drawing.Color.MidnightBlue;
            this.allClear.Location = new System.Drawing.Point(131, 140);
            this.allClear.Margin = new System.Windows.Forms.Padding(4);
            this.allClear.Name = "allClear";
            this.allClear.Size = new System.Drawing.Size(49, 34);
            this.allClear.TabIndex = 12;
            this.allClear.Text = "C";
            this.allClear.UseVisualStyleBackColor = false;
            this.allClear.Click += new System.EventHandler(this.allClear_Click);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.Color.LightBlue;
            this.backspace.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backspace.ForeColor = System.Drawing.Color.MidnightBlue;
            this.backspace.Location = new System.Drawing.Point(16, 140);
            this.backspace.Margin = new System.Windows.Forms.Padding(4);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(49, 34);
            this.backspace.TabIndex = 11;
            this.backspace.Text = "←";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.Color.LightBlue;
            this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CE.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CE.Location = new System.Drawing.Point(73, 140);
            this.CE.Margin = new System.Windows.Forms.Padding(4);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(49, 34);
            this.CE.TabIndex = 10;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // mod
            // 
            this.mod.BackColor = System.Drawing.Color.LightBlue;
            this.mod.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mod.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mod.Location = new System.Drawing.Point(246, 224);
            this.mod.Margin = new System.Windows.Forms.Padding(4);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(49, 34);
            this.mod.TabIndex = 19;
            this.mod.Text = "%";
            this.mod.UseVisualStyleBackColor = false;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.Color.LightBlue;
            this.div.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.div.ForeColor = System.Drawing.Color.MidnightBlue;
            this.div.Location = new System.Drawing.Point(188, 182);
            this.div.Margin = new System.Windows.Forms.Padding(4);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(49, 34);
            this.div.TabIndex = 18;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.SystemColors.Control;
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.b9.Location = new System.Drawing.Point(131, 182);
            this.b9.Margin = new System.Windows.Forms.Padding(4);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(49, 34);
            this.b9.TabIndex = 17;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.SystemColors.Control;
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.b7.Location = new System.Drawing.Point(16, 182);
            this.b7.Margin = new System.Windows.Forms.Padding(4);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(49, 34);
            this.b7.TabIndex = 16;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.SystemColors.Control;
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.b8.Location = new System.Drawing.Point(73, 182);
            this.b8.Margin = new System.Windows.Forms.Padding(4);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(49, 34);
            this.b8.TabIndex = 15;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.SystemColors.Control;
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.b5.Location = new System.Drawing.Point(73, 224);
            this.b5.Margin = new System.Windows.Forms.Padding(4);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(49, 34);
            this.b5.TabIndex = 20;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.SystemColors.Control;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.b4.Location = new System.Drawing.Point(16, 224);
            this.b4.Margin = new System.Windows.Forms.Padding(4);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(49, 34);
            this.b4.TabIndex = 21;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.SystemColors.Control;
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.b6.Location = new System.Drawing.Point(131, 224);
            this.b6.Margin = new System.Windows.Forms.Padding(4);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(49, 34);
            this.b6.TabIndex = 22;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.Color.LightBlue;
            this.mult.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mult.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mult.Location = new System.Drawing.Point(188, 224);
            this.mult.Margin = new System.Windows.Forms.Padding(4);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(49, 34);
            this.mult.TabIndex = 23;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // inv
            // 
            this.inv.BackColor = System.Drawing.Color.LightBlue;
            this.inv.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inv.ForeColor = System.Drawing.Color.MidnightBlue;
            this.inv.Location = new System.Drawing.Point(245, 266);
            this.inv.Margin = new System.Windows.Forms.Padding(4);
            this.inv.Name = "inv";
            this.inv.Size = new System.Drawing.Size(49, 34);
            this.inv.TabIndex = 24;
            this.inv.Text = "1/x";
            this.inv.UseVisualStyleBackColor = false;
            this.inv.Click += new System.EventHandler(this.inv_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.LightBlue;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.equal.Location = new System.Drawing.Point(247, 308);
            this.equal.Margin = new System.Windows.Forms.Padding(4);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(49, 34);
            this.equal.TabIndex = 29;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.LightBlue;
            this.plus.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.plus.Location = new System.Drawing.Point(189, 308);
            this.plus.Margin = new System.Windows.Forms.Padding(4);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(49, 34);
            this.plus.TabIndex = 28;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // comma
            // 
            this.comma.BackColor = System.Drawing.SystemColors.Control;
            this.comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comma.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comma.Location = new System.Drawing.Point(132, 308);
            this.comma.Margin = new System.Windows.Forms.Padding(4);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(49, 34);
            this.comma.TabIndex = 27;
            this.comma.Text = ",";
            this.comma.UseVisualStyleBackColor = false;
            this.comma.Click += new System.EventHandler(this.comma_Click);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.SystemColors.Control;
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b0.ForeColor = System.Drawing.Color.MidnightBlue;
            this.b0.Location = new System.Drawing.Point(17, 308);
            this.b0.Margin = new System.Windows.Forms.Padding(4);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(105, 34);
            this.b0.TabIndex = 26;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.Control;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.b2.Location = new System.Drawing.Point(73, 266);
            this.b2.Margin = new System.Windows.Forms.Padding(4);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(49, 34);
            this.b2.TabIndex = 25;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.Control;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.b1.Location = new System.Drawing.Point(16, 266);
            this.b1.Margin = new System.Windows.Forms.Padding(4);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(49, 34);
            this.b1.TabIndex = 26;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.Control;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.b3.Location = new System.Drawing.Point(131, 266);
            this.b3.Margin = new System.Windows.Forms.Padding(4);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(49, 34);
            this.b3.TabIndex = 27;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.LightBlue;
            this.minus.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.minus.Location = new System.Drawing.Point(188, 266);
            this.minus.Margin = new System.Windows.Forms.Padding(4);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(49, 34);
            this.minus.TabIndex = 28;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.history.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.history.Enabled = false;
            this.history.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.history.HideSelection = false;
            this.history.Location = new System.Drawing.Point(245, 12);
            this.history.Margin = new System.Windows.Forms.Padding(4);
            this.history.Name = "history";
            this.history.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.history.Size = new System.Drawing.Size(161, 27);
            this.history.TabIndex = 30;
            this.history.TextChanged += new System.EventHandler(this.history_TextChanged);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.LightBlue;
            this.log.ForeColor = System.Drawing.Color.MidnightBlue;
            this.log.Location = new System.Drawing.Point(248, 140);
            this.log.Margin = new System.Windows.Forms.Padding(4);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(48, 34);
            this.log.TabIndex = 31;
            this.log.Text = "log";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.log_click);
            // 
            // ln
            // 
            this.ln.BackColor = System.Drawing.Color.LightBlue;
            this.ln.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ln.Location = new System.Drawing.Point(360, 224);
            this.ln.Margin = new System.Windows.Forms.Padding(4);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(48, 34);
            this.ln.TabIndex = 32;
            this.ln.Text = "ln";
            this.ln.UseVisualStyleBackColor = false;
            this.ln.Click += new System.EventHandler(this.ln_Click);
            // 
            // sin
            // 
            this.sin.BackColor = System.Drawing.Color.LightBlue;
            this.sin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.sin.Location = new System.Drawing.Point(304, 140);
            this.sin.Margin = new System.Windows.Forms.Padding(4);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(48, 34);
            this.sin.TabIndex = 33;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = false;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // cos
            // 
            this.cos.BackColor = System.Drawing.Color.LightBlue;
            this.cos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cos.Location = new System.Drawing.Point(304, 182);
            this.cos.Margin = new System.Windows.Forms.Padding(4);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(48, 34);
            this.cos.TabIndex = 34;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = false;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // binary
            // 
            this.binary.BackColor = System.Drawing.Color.LightBlue;
            this.binary.ForeColor = System.Drawing.Color.MidnightBlue;
            this.binary.Location = new System.Drawing.Point(304, 224);
            this.binary.Margin = new System.Windows.Forms.Padding(4);
            this.binary.Name = "binary";
            this.binary.Size = new System.Drawing.Size(48, 34);
            this.binary.TabIndex = 35;
            this.binary.Text = "binary";
            this.binary.UseVisualStyleBackColor = false;
            this.binary.Click += new System.EventHandler(this.binary_Click);
            // 
            // octal
            // 
            this.octal.BackColor = System.Drawing.Color.LightBlue;
            this.octal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.octal.Location = new System.Drawing.Point(304, 267);
            this.octal.Margin = new System.Windows.Forms.Padding(4);
            this.octal.Name = "octal";
            this.octal.Size = new System.Drawing.Size(48, 34);
            this.octal.TabIndex = 36;
            this.octal.Text = "octal";
            this.octal.UseVisualStyleBackColor = false;
            this.octal.Click += new System.EventHandler(this.octal_Click);
            // 
            // Hexadecimal
            // 
            this.Hexadecimal.BackColor = System.Drawing.Color.LightBlue;
            this.Hexadecimal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Hexadecimal.Location = new System.Drawing.Point(304, 306);
            this.Hexadecimal.Margin = new System.Windows.Forms.Padding(4);
            this.Hexadecimal.Name = "Hexadecimal";
            this.Hexadecimal.Size = new System.Drawing.Size(48, 34);
            this.Hexadecimal.TabIndex = 37;
            this.Hexadecimal.Text = "hexadecimal";
            this.Hexadecimal.UseVisualStyleBackColor = false;
            this.Hexadecimal.Click += new System.EventHandler(this.Hexadecimal_Click);
            // 
            // sqrtY
            // 
            this.sqrtY.BackColor = System.Drawing.Color.LightBlue;
            this.sqrtY.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrtY.ForeColor = System.Drawing.Color.MidnightBlue;
            this.sqrtY.Location = new System.Drawing.Point(361, 306);
            this.sqrtY.Margin = new System.Windows.Forms.Padding(4);
            this.sqrtY.Name = "sqrtY";
            this.sqrtY.Size = new System.Drawing.Size(49, 34);
            this.sqrtY.TabIndex = 38;
            this.sqrtY.Text = "y√x";
            this.sqrtY.UseVisualStyleBackColor = false;
            this.sqrtY.Click += new System.EventHandler(this.sqrtY_Click);
            // 
            // PowOf10
            // 
            this.PowOf10.BackColor = System.Drawing.Color.LightBlue;
            this.PowOf10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PowOf10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PowOf10.Location = new System.Drawing.Point(360, 267);
            this.PowOf10.Margin = new System.Windows.Forms.Padding(4);
            this.PowOf10.Name = "PowOf10";
            this.PowOf10.Size = new System.Drawing.Size(49, 34);
            this.PowOf10.TabIndex = 39;
            this.PowOf10.Text = "10^x";
            this.PowOf10.UseVisualStyleBackColor = false;
            this.PowOf10.Click += new System.EventHandler(this.PowOf10_Click);
            // 
            // LCM
            // 
            this.LCM.BackColor = System.Drawing.Color.LightBlue;
            this.LCM.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LCM.Location = new System.Drawing.Point(304, 98);
            this.LCM.Margin = new System.Windows.Forms.Padding(4);
            this.LCM.Name = "LCM";
            this.LCM.Size = new System.Drawing.Size(49, 34);
            this.LCM.TabIndex = 40;
            this.LCM.Text = "lcm";
            this.LCM.UseVisualStyleBackColor = false;
            this.LCM.Click += new System.EventHandler(this.LCM_Click);
            // 
            // Reverse
            // 
            this.Reverse.BackColor = System.Drawing.Color.LightBlue;
            this.Reverse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Reverse.Location = new System.Drawing.Point(360, 184);
            this.Reverse.Margin = new System.Windows.Forms.Padding(4);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(48, 34);
            this.Reverse.TabIndex = 41;
            this.Reverse.Text = "reverse";
            this.Reverse.UseVisualStyleBackColor = false;
            this.Reverse.Click += new System.EventHandler(this.Reverse_Click);
            // 
            // FromHexToDec
            // 
            this.FromHexToDec.BackColor = System.Drawing.Color.LightBlue;
            this.FromHexToDec.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FromHexToDec.Location = new System.Drawing.Point(360, 140);
            this.FromHexToDec.Margin = new System.Windows.Forms.Padding(4);
            this.FromHexToDec.Name = "FromHexToDec";
            this.FromHexToDec.Size = new System.Drawing.Size(48, 34);
            this.FromHexToDec.TabIndex = 42;
            this.FromHexToDec.Text = "ToDec";
            this.FromHexToDec.UseVisualStyleBackColor = false;
            this.FromHexToDec.Click += new System.EventHandler(this.FromHexToDec_Click);
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.LightBlue;
            this.f.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f.ForeColor = System.Drawing.Color.MidnightBlue;
            this.f.Location = new System.Drawing.Point(361, 98);
            this.f.Margin = new System.Windows.Forms.Padding(4);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(49, 34);
            this.f.TabIndex = 43;
            this.f.Text = "f";
            this.f.UseVisualStyleBackColor = false;
            this.f.Click += new System.EventHandler(this.f_Click);
            // 
            // SumOfPrimes
            // 
            this.SumOfPrimes.BackColor = System.Drawing.Color.LightBlue;
            this.SumOfPrimes.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumOfPrimes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SumOfPrimes.Location = new System.Drawing.Point(418, 308);
            this.SumOfPrimes.Margin = new System.Windows.Forms.Padding(4);
            this.SumOfPrimes.Name = "SumOfPrimes";
            this.SumOfPrimes.Size = new System.Drawing.Size(49, 34);
            this.SumOfPrimes.TabIndex = 44;
            this.SumOfPrimes.Text = "SumOfPrimes";
            this.SumOfPrimes.UseVisualStyleBackColor = false;
            this.SumOfPrimes.Click += new System.EventHandler(this.SumOfPrimes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(494, 349);
            this.Controls.Add(this.SumOfPrimes);
            this.Controls.Add(this.f);
            this.Controls.Add(this.FromHexToDec);
            this.Controls.Add(this.Reverse);
            this.Controls.Add(this.LCM);
            this.Controls.Add(this.PowOf10);
            this.Controls.Add(this.sqrtY);
            this.Controls.Add(this.Hexadecimal);
            this.Controls.Add(this.octal);
            this.Controls.Add(this.binary);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.log);
            this.Controls.Add(this.history);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.comma);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.inv);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.div);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.allClear);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.Fibonacci);
            this.Controls.Add(this.Closest);
            this.Controls.Add(this.coPrime);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button pow;
        private System.Windows.Forms.Button coPrime;
        private System.Windows.Forms.Button Closest;
        private System.Windows.Forms.Button Fibonacci;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button allClear;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button inv;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.TextBox history;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button binary;
        private System.Windows.Forms.Button octal;
        private System.Windows.Forms.Button Hexadecimal;
        private System.Windows.Forms.Button sqrtY;
        private System.Windows.Forms.Button PowOf10;
        private System.Windows.Forms.Button LCM;
        private System.Windows.Forms.Button Reverse;
        private System.Windows.Forms.Button FromHexToDec;
        private System.Windows.Forms.Button f;
        private System.Windows.Forms.Button SumOfPrimes;
    }
}