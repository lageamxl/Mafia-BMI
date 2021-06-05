/*
 * Vytvořeno aplikací SharpDevelop.
 * Uživatel: Asus
 * Datum: 05.06.2021
 * Čas: 12:49
 * 
 * Tento template můžete změnit pomocí Nástroje | Možnosti | Psaní kódu | Upravit standardní hlavičky souborů.
 */
namespace Mafia_BMI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureTom;
		private System.Windows.Forms.PictureBox pictureAutor;
		private System.Windows.Forms.PictureBox pictureBiff;
		private System.Windows.Forms.PictureBox pictureSalvatore;
		private System.Windows.Forms.PictureBox pictureVavra;
		private System.Windows.Forms.PictureBox picturePetr;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureTom = new System.Windows.Forms.PictureBox();
			this.pictureAutor = new System.Windows.Forms.PictureBox();
			this.pictureBiff = new System.Windows.Forms.PictureBox();
			this.pictureSalvatore = new System.Windows.Forms.PictureBox();
			this.pictureVavra = new System.Windows.Forms.PictureBox();
			this.picturePetr = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureTom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureAutor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBiff)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureSalvatore)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureVavra)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picturePetr)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(116, 28);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(116, 95);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 1;
			// 
			// btnCalculate
			// 
			this.btnCalculate.BackColor = System.Drawing.Color.Honeydew;
			this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnCalculate.Location = new System.Drawing.Point(522, 275);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(205, 134);
			this.btnCalculate.TabIndex = 2;
			this.btnCalculate.Text = "VYPOČÍTEJ BMI";
			this.btnCalculate.UseVisualStyleBackColor = false;
			this.btnCalculate.Click += new System.EventHandler(this.BtnCalculateClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(248, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(230, 99);
			this.label1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(10, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Váha (kg)";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(10, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Výška (cm)";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, -72);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(478, 508);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// pictureTom
			// 
			this.pictureTom.Image = ((System.Drawing.Image)(resources.GetObject("pictureTom.Image")));
			this.pictureTom.Location = new System.Drawing.Point(522, 40);
			this.pictureTom.Name = "pictureTom";
			this.pictureTom.Size = new System.Drawing.Size(205, 203);
			this.pictureTom.TabIndex = 7;
			this.pictureTom.TabStop = false;
			this.pictureTom.Visible = false;
			// 
			// pictureAutor
			// 
			this.pictureAutor.Image = ((System.Drawing.Image)(resources.GetObject("pictureAutor.Image")));
			this.pictureAutor.Location = new System.Drawing.Point(522, 40);
			this.pictureAutor.Name = "pictureAutor";
			this.pictureAutor.Size = new System.Drawing.Size(205, 203);
			this.pictureAutor.TabIndex = 8;
			this.pictureAutor.TabStop = false;
			// 
			// pictureBiff
			// 
			this.pictureBiff.Image = ((System.Drawing.Image)(resources.GetObject("pictureBiff.Image")));
			this.pictureBiff.Location = new System.Drawing.Point(522, 40);
			this.pictureBiff.Name = "pictureBiff";
			this.pictureBiff.Size = new System.Drawing.Size(205, 203);
			this.pictureBiff.TabIndex = 9;
			this.pictureBiff.TabStop = false;
			this.pictureBiff.Visible = false;
			// 
			// pictureSalvatore
			// 
			this.pictureSalvatore.Image = ((System.Drawing.Image)(resources.GetObject("pictureSalvatore.Image")));
			this.pictureSalvatore.Location = new System.Drawing.Point(522, 40);
			this.pictureSalvatore.Name = "pictureSalvatore";
			this.pictureSalvatore.Size = new System.Drawing.Size(205, 203);
			this.pictureSalvatore.TabIndex = 10;
			this.pictureSalvatore.TabStop = false;
			this.pictureSalvatore.Visible = false;
			// 
			// pictureVavra
			// 
			this.pictureVavra.Image = ((System.Drawing.Image)(resources.GetObject("pictureVavra.Image")));
			this.pictureVavra.Location = new System.Drawing.Point(522, 40);
			this.pictureVavra.Name = "pictureVavra";
			this.pictureVavra.Size = new System.Drawing.Size(205, 203);
			this.pictureVavra.TabIndex = 11;
			this.pictureVavra.TabStop = false;
			this.pictureVavra.Visible = false;
			// 
			// picturePetr
			// 
			this.picturePetr.Image = ((System.Drawing.Image)(resources.GetObject("picturePetr.Image")));
			this.picturePetr.Location = new System.Drawing.Point(522, 40);
			this.picturePetr.Name = "picturePetr";
			this.picturePetr.Size = new System.Drawing.Size(205, 203);
			this.picturePetr.TabIndex = 12;
			this.picturePetr.TabStop = false;
			this.picturePetr.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(740, 421);
			this.Controls.Add(this.picturePetr);
			this.Controls.Add(this.pictureVavra);
			this.Controls.Add(this.pictureSalvatore);
			this.Controls.Add(this.pictureBiff);
			this.Controls.Add(this.pictureTom);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureAutor);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Mafia BMI";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureTom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureAutor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBiff)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureSalvatore)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureVavra)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picturePetr)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
