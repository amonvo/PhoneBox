/*
 * Vytvořeno aplikací SharpDevelop.
 * Uživatel: amonv
 * Datum: 10.10.2022
 * Čas: 19:11
 * 
 * Tento template můžete změnit pomocí Nástroje | Možnosti | Psaní kódu | Upravit standardní hlavičky souborů.
 */
namespace ExamplePhoneListAmonV
{
	partial class MainForm
	{
		/// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		
        /// #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


			private System.Windows.Forms.Button smazVybranyBn;
			private System.Windows.Forms.Label jmenoLabel;
			private System.Windows.Forms.Label prijmeniLabel;
			private System.Windows.Forms.Label telefonLabel;
			private System.Windows.Forms.Label emailLabel;
			private System.Windows.Forms.Label funkcelLabel;
			private System.Windows.Forms.TextBox textBox1;
			private System.Windows.Forms.TextBox textBox2;
			private System.Windows.Forms.TextBox textBox3;
			private System.Windows.Forms.TextBox textBox4;
			private System.Windows.Forms.TextBox textBox5;
			private System.Windows.Forms.PictureBox pictureBox1;
			private System.Windows.Forms.Button btnPridej;
        	private System.Windows.Forms.ListBox listBoxUzivatele;
        	private System.Windows.Forms.Button pridejUzivButton;
			

		

		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.smazVybranyBn = new System.Windows.Forms.Button();
			this.jmenoLabel = new System.Windows.Forms.Label();
			this.prijmeniLabel = new System.Windows.Forms.Label();
			this.telefonLabel = new System.Windows.Forms.Label();
			this.emailLabel = new System.Windows.Forms.Label();
			this.funkcelLabel = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnPridej = new System.Windows.Forms.Button();
			this.listBoxUzivatele = new System.Windows.Forms.ListBox();
			this.pridejUzivButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// smazVybranyBn
			// 
			this.smazVybranyBn.BackColor = System.Drawing.Color.Red;
			this.smazVybranyBn.Location = new System.Drawing.Point(523, 80);
			this.smazVybranyBn.Name = "smazVybranyBn";
			this.smazVybranyBn.Size = new System.Drawing.Size(75, 23);
			this.smazVybranyBn.TabIndex = 1;
			this.smazVybranyBn.Text = "Smaz vybrany";
			this.smazVybranyBn.UseVisualStyleBackColor = false;
			this.smazVybranyBn.Click += new System.EventHandler(this.SmazVybranyBnClick);
			// 
			// jmenoLabel
			// 
			this.jmenoLabel.Location = new System.Drawing.Point(51, 21);
			this.jmenoLabel.Name = "jmenoLabel";
			this.jmenoLabel.Size = new System.Drawing.Size(100, 23);
			this.jmenoLabel.TabIndex = 3;
			this.jmenoLabel.Text = "Jmeno:";
			// 
			// prijmeniLabel
			// 
			this.prijmeniLabel.Location = new System.Drawing.Point(51, 56);
			this.prijmeniLabel.Name = "prijmeniLabel";
			this.prijmeniLabel.Size = new System.Drawing.Size(100, 23);
			this.prijmeniLabel.TabIndex = 4;
			this.prijmeniLabel.Text = "Prijmeni:";
			// 
			// telefonLabel
			// 
			this.telefonLabel.Location = new System.Drawing.Point(51, 95);
			this.telefonLabel.Name = "telefonLabel";
			this.telefonLabel.Size = new System.Drawing.Size(100, 23);
			this.telefonLabel.TabIndex = 5;
			this.telefonLabel.Text = "Telefon:";
			// 
			// emailLabel
			// 
			this.emailLabel.Location = new System.Drawing.Point(51, 129);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(100, 23);
			this.emailLabel.TabIndex = 6;
			this.emailLabel.Text = "Email:";
			// 
			// funkcelLabel
			// 
			this.funkcelLabel.Location = new System.Drawing.Point(51, 169);
			this.funkcelLabel.Name = "funkcelLabel";
			this.funkcelLabel.Size = new System.Drawing.Size(100, 23);
			this.funkcelLabel.TabIndex = 7;
			this.funkcelLabel.Text = "Funkce:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(172, 29);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(313, 22);
			this.textBox1.TabIndex = 8;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(172, 69);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(313, 22);
			this.textBox2.TabIndex = 9;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(172, 97);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(313, 22);
			this.textBox3.TabIndex = 10;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(172, 129);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(313, 22);
			this.textBox4.TabIndex = 11;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(172, 166);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(313, 22);
			this.textBox5.TabIndex = 12;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(513, 218);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(121, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// btnPridej
			// 
			this.btnPridej.Location = new System.Drawing.Point(523, 128);
			this.btnPridej.Name = "btnPridej";
			this.btnPridej.Size = new System.Drawing.Size(95, 34);
			this.btnPridej.TabIndex = 15;
			this.btnPridej.Text = "Pridej xml";
			this.btnPridej.UseVisualStyleBackColor = true;
			this.btnPridej.Click += new System.EventHandler(this.BtnPridejClick);
			// 
			// listBoxUzivatele
			// 
			this.listBoxUzivatele.FormattingEnabled = true;
			this.listBoxUzivatele.ItemHeight = 16;
			this.listBoxUzivatele.Location = new System.Drawing.Point(51, 218);
			this.listBoxUzivatele.Name = "listBoxUzivatele";
			this.listBoxUzivatele.Size = new System.Drawing.Size(434, 100);
			this.listBoxUzivatele.TabIndex = 16;
			this.listBoxUzivatele.SelectedIndexChanged += new System.EventHandler(this.ListBoxUzivateleSelectedIndexChanged);
			// 
			// pridejUzivButton
			// 
			this.pridejUzivButton.BackColor = System.Drawing.Color.Lime;
			this.pridejUzivButton.Location = new System.Drawing.Point(513, 29);
			this.pridejUzivButton.Name = "pridejUzivButton";
			this.pridejUzivButton.Size = new System.Drawing.Size(121, 31);
			this.pridejUzivButton.TabIndex = 17;
			this.pridejUzivButton.Text = "Pridat uzivatele:";
			this.pridejUzivButton.UseVisualStyleBackColor = false;
			this.pridejUzivButton.Click += new System.EventHandler(this.PridejUzivButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 340);
			this.Controls.Add(this.pridejUzivButton);
			this.Controls.Add(this.listBoxUzivatele);
			this.Controls.Add(this.btnPridej);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.funkcelLabel);
			this.Controls.Add(this.emailLabel);
			this.Controls.Add(this.telefonLabel);
			this.Controls.Add(this.prijmeniLabel);
			this.Controls.Add(this.jmenoLabel);
			this.Controls.Add(this.smazVybranyBn);
			this.Name = "MainForm";
			this.Text = "ExamplePhoneListAmonV";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
