namespace Ch11
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.btnPosition = new System.Windows.Forms.Button();
            this.lbResultPosition = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.lbHobby = new System.Windows.Forms.Label();
            this.lbResultHobby = new System.Windows.Forms.Label();
            this.btnHobby = new System.Windows.Forms.Button();
            this.cbHobby = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstCountry = new System.Windows.Forms.ListBox();
            this.lbResultCountry = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "데이터를 공급해주는 컨트롤";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ConsoleBox 연습";
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPosition.Location = new System.Drawing.Point(29, 75);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(34, 17);
            this.lbPosition.TabIndex = 3;
            this.lbPosition.Text = "직업";
            // 
            // btnPosition
            // 
            this.btnPosition.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPosition.Location = new System.Drawing.Point(249, 72);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(86, 23);
            this.btnPosition.TabIndex = 4;
            this.btnPosition.Text = "확인";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // lbResultPosition
            // 
            this.lbResultPosition.AutoSize = true;
            this.lbResultPosition.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbResultPosition.Location = new System.Drawing.Point(341, 75);
            this.lbResultPosition.Name = "lbResultPosition";
            this.lbResultPosition.Size = new System.Drawing.Size(42, 17);
            this.lbResultPosition.TabIndex = 3;
            this.lbResultPosition.Text = "결과 :";
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(69, 72);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(174, 25);
            this.cbPosition.TabIndex = 5;
            // 
            // lbHobby
            // 
            this.lbHobby.AutoSize = true;
            this.lbHobby.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHobby.Location = new System.Drawing.Point(29, 109);
            this.lbHobby.Name = "lbHobby";
            this.lbHobby.Size = new System.Drawing.Size(34, 17);
            this.lbHobby.TabIndex = 3;
            this.lbHobby.Text = "취미";
            // 
            // lbResultHobby
            // 
            this.lbResultHobby.AutoSize = true;
            this.lbResultHobby.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbResultHobby.Location = new System.Drawing.Point(341, 109);
            this.lbResultHobby.Name = "lbResultHobby";
            this.lbResultHobby.Size = new System.Drawing.Size(42, 17);
            this.lbResultHobby.TabIndex = 3;
            this.lbResultHobby.Text = "결과 :";
            // 
            // btnHobby
            // 
            this.btnHobby.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHobby.Location = new System.Drawing.Point(249, 106);
            this.btnHobby.Name = "btnHobby";
            this.btnHobby.Size = new System.Drawing.Size(86, 23);
            this.btnHobby.TabIndex = 4;
            this.btnHobby.Text = "확인";
            this.btnHobby.UseVisualStyleBackColor = true;
            this.btnHobby.Click += new System.EventHandler(this.btnHobby_Click);
            // 
            // cbHobby
            // 
            this.cbHobby.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbHobby.FormattingEnabled = true;
            this.cbHobby.Location = new System.Drawing.Point(69, 106);
            this.cbHobby.Name = "cbHobby";
            this.cbHobby.Size = new System.Drawing.Size(174, 25);
            this.cbHobby.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "ListBox 연습";
            // 
            // lstCountry
            // 
            this.lstCountry.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstCountry.FormattingEnabled = true;
            this.lstCountry.ItemHeight = 17;
            this.lstCountry.Location = new System.Drawing.Point(19, 184);
            this.lstCountry.Name = "lstCountry";
            this.lstCountry.Size = new System.Drawing.Size(206, 89);
            this.lstCountry.TabIndex = 6;
            this.lstCountry.SelectedIndexChanged += new System.EventHandler(this.lstCountry_SelectedIndexChanged);
            // 
            // lbResultCountry
            // 
            this.lbResultCountry.AutoSize = true;
            this.lbResultCountry.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbResultCountry.Location = new System.Drawing.Point(249, 256);
            this.lbResultCountry.Name = "lbResultCountry";
            this.lbResultCountry.Size = new System.Drawing.Size(42, 17);
            this.lbResultCountry.TabIndex = 3;
            this.lbResultCountry.Text = "결과 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data";
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(19, 314);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowTemplate.Height = 25;
            this.dgvMember.Size = new System.Drawing.Size(534, 213);
            this.dgvMember.TabIndex = 7;
            this.dgvMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 539);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.lstCountry);
            this.Controls.Add(this.cbHobby);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.btnHobby);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.lbResultCountry);
            this.Controls.Add(this.lbResultHobby);
            this.Controls.Add(this.lbResultPosition);
            this.Controls.Add(this.lbHobby);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbPosition;
        private Button btnPosition;
        private Label lbResultPosition;
        private ComboBox cbPosition;
        private Label lbHobby;
        private Label lbResultHobby;
        private Button btnHobby;
        private ComboBox cbHobby;
        private Label label3;
        private ListBox lstCountry;
        private Label lbResultCountry;
        private Label label4;
        private DataGridView dgvMember;
    }
}