using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mafia_BMI
{
	/// <summary>
	/// Vytvořil Lagemaxl 2021
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void BtnCalculateClick(object sender, EventArgs e)
		{
			double vaha = Convert.ToDouble(textBox1.Text); //deklarace váhy 		
			double vyska = Convert.ToDouble(textBox2.Text); //deklarace výšky  
			double BMI = vaha / ((vyska/100) * (vyska/100)); //vypočet BMI 

			

				
				if (BMI >= 18 && BMI <= 24)
				{
					label1.Text = BMI.ToString("F2") + "\n" + "jsi v normě clap";
					pictureTom.Visible = true;
					pictureBiff.Visible = false;
					pictureSalvatore.Visible = false;
					pictureVavra.Visible = false;
					picturePetr.Visible = false;
				}
				
				if (BMI < 18)
				{
					label1.Text = BMI.ToString("F2") + "\n" + "zajdi občas k Pepému! Ty jeho sýry hmmm";
					pictureTom.Visible = false;
					pictureBiff.Visible = false;
					pictureSalvatore.Visible = true;
					pictureVavra.Visible = false;
					picturePetr.Visible = false;
				}
				
				if (BMI > 24)
				{
					label1.Text = BMI.ToString("F2") + "\n" + "možná jsi u pepého moc často...";
					pictureTom.Visible = false;
					pictureBiff.Visible = true;
					pictureSalvatore.Visible = false;
					pictureVavra.Visible = false;
					picturePetr.Visible = false;
				}
				
				if (BMI > 68 && BMI < 70 )
				{
					label1.Text ="BMI = 69";
					pictureTom.Visible = false;
					pictureBiff.Visible = false;
					pictureSalvatore.Visible = false;
					pictureVavra.Visible = true;
					picturePetr.Visible = false;
				}
				
				if (BMI > 100)
				{
					label1.Text = BMI.ToString("F2") + "\n" + "fakt k tomu Pepému nechoď už!";
					pictureTom.Visible = false;
					pictureBiff.Visible = false;
					pictureSalvatore.Visible = false;
					pictureVavra.Visible = false;
					picturePetr.Visible = true;
				}

		}
		
		
	}
}
