namespace Bitcoin_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btc_amout_input = new TextBox();
            btc_label = new Label();
            currency_selector = new ComboBox();
            sihtvaluuta = new Label();
            GetRate = new Button();
            btcResultLabel = new Label();
            ResultDisplayLabel = new Label();
            SuspendLayout();
            // 
            // btc_amout_input
            // 
            btc_amout_input.Location = new Point(82, 62);
            btc_amout_input.Name = "btc_amout_input";
            btc_amout_input.Size = new Size(216, 27);
            btc_amout_input.TabIndex = 0;
            btc_amout_input.TextChanged += textBox1_TextChanged;
            // 
            // btc_label
            // 
            btc_label.AutoSize = true;
            btc_label.BackColor = Color.Transparent;
            btc_label.Font = new Font("Segoe UI", 11F);
            btc_label.ForeColor = SystemColors.Control;
            btc_label.Location = new Point(82, 34);
            btc_label.Name = "btc_label";
            btc_label.Size = new Size(130, 25);
            btc_label.TabIndex = 1;
            btc_label.Text = "Bitcoini kogus";
            // 
            // currency_selector
            // 
            currency_selector.FormattingEnabled = true;
            currency_selector.Items.AddRange(new object[] { "EUR", "USD" });
            currency_selector.Location = new Point(82, 145);
            currency_selector.Name = "currency_selector";
            currency_selector.Size = new Size(102, 28);
            currency_selector.TabIndex = 2;
            currency_selector.Text = "USD";
            currency_selector.SelectedIndexChanged += currency_selector_SelectedIndexChanged;
            // 
            // sihtvaluuta
            // 
            sihtvaluuta.AutoSize = true;
            sihtvaluuta.BackColor = Color.Transparent;
            sihtvaluuta.Font = new Font("Segoe UI", 11F);
            sihtvaluuta.ForeColor = SystemColors.Control;
            sihtvaluuta.Location = new Point(82, 117);
            sihtvaluuta.Name = "sihtvaluuta";
            sihtvaluuta.Size = new Size(106, 25);
            sihtvaluuta.TabIndex = 3;
            sihtvaluuta.Text = "Sihtvaluuta";
            sihtvaluuta.Click += sihtvaluuta_Click;
            // 
            // GetRate
            // 
            GetRate.Location = new Point(204, 207);
            GetRate.Name = "GetRate";
            GetRate.Size = new Size(94, 29);
            GetRate.TabIndex = 4;
            GetRate.Text = "Arvuta";
            GetRate.UseVisualStyleBackColor = true;
            GetRate.Click += GetRate_Click;
            // 
            // btcResultLabel
            // 
            btcResultLabel.AutoSize = true;
            btcResultLabel.BackColor = Color.DarkGray;
            btcResultLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btcResultLabel.ForeColor = SystemColors.Control;
            btcResultLabel.Location = new Point(54, 671);
            btcResultLabel.Name = "btcResultLabel";
            btcResultLabel.Size = new Size(79, 31);
            btcResultLabel.TabIndex = 5;
            btcResultLabel.Text = "label1";
            // 
            // ResultDisplayLabel
            // 
            ResultDisplayLabel.AutoSize = true;
            ResultDisplayLabel.BackColor = Color.Transparent;
            ResultDisplayLabel.Font = new Font("Segoe UI", 11F);
            ResultDisplayLabel.ForeColor = SystemColors.Control;
            ResultDisplayLabel.Location = new Point(54, 630);
            ResultDisplayLabel.Name = "ResultDisplayLabel";
            ResultDisplayLabel.Size = new Size(158, 25);
            ResultDisplayLabel.TabIndex = 6;
            ResultDisplayLabel.Text = "Arvutuse tulemus";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(386, 737);
            Controls.Add(ResultDisplayLabel);
            Controls.Add(btcResultLabel);
            Controls.Add(GetRate);
            Controls.Add(sihtvaluuta);
            Controls.Add(currency_selector);
            Controls.Add(btc_label);
            Controls.Add(btc_amout_input);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox btc_amout_input;
        private Label btc_label;
        private ComboBox currency_selector;
        private Label sihtvaluuta;
        private Button GetRate;
        private Label btcResultLabel;
        private Label ResultDisplayLabel;
    }
}
