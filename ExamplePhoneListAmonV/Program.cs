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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamplePhoneListAmonV
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	 static class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}	
	}
}
