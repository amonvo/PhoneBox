/*
 * Vytvořeno aplikací SharpDevelop.
 * Uživatel: amonv
 * Datum: 10.10.2022
 * Čas: 19:11
 * 
 * Tento template můžete změnit pomocí Nástroje | Možnosti | Psaní kódu | Upravit standardní hlavičky souborů.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ExamplePhoneListAmonV
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private List<Uzivatel> uzivatele = new List<Uzivatel>();
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void SmazVybranyBnClick(object sender, EventArgs e)
		{
			if (listBoxUzivatele.SelectedIndex >= 0) 
			{
				listBoxUzivatele.Items.RemoveAt(listBoxUzivatele.SelectedIndex);				
			}
		}
		
		void BtnPridejClick(object sender, EventArgs e)
		{
	    	Serializuj();
		}
		
		void Serializuj()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(uzivatele.GetType());
                using (StreamWriter sw = new StreamWriter("uzivatele.xml"))
                {
                    serializer.Serialize(sw, uzivatele);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
		void ListBoxUzivateleSelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void PridejUzivButtonClick(object sender, EventArgs e)
		{
			
    		Uzivatel uzivatel = new Uzivatel
    		{
	        	Jmeno = textBox1.Text,
	        	Prijmeni = textBox2.Text,
	        	Telefon = textBox3.Text,
	        	Email = textBox4.Text,
	        	Funkce = textBox5.Text,
	        	
    		};
    		
    		uzivatele.Add(uzivatel);
	    	listBoxUzivatele.DataSource = null;
	    	listBoxUzivatele.Items.Add(uzivatel);  
		}
	}
}
