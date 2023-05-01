/*
 * Vytvořeno aplikací SharpDevelop.
 * Uživatel: amonv
 * Datum: 11.10.2022
 * Čas: 0:23
 * 
 * Tento template můžete změnit pomocí Nástroje | Možnosti | Psaní kódu | Upravit standardní hlavičky souborů.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExamplePhoneListAmonV
{
	/// <summary>
	/// Description of Uzivatel.
	/// </summary>
	public class Uzivatel
	{
	    [XmlAttribute("Jméno")]
        public string Jmeno { get; set; }

        [XmlAttribute("Přijmení")]
        public string Prijmeni { get; set; }

        [XmlAttribute("TelefonniCislo")]
        public string Telefon { get; set; }
        
        [XmlAttribute("EmailovaAdresa")]
        public string Email { get; set; }
        
        [XmlAttribute("PracovniFunkce")]
        public string Funkce { get; set; }

        public override string ToString()
        {
            return "Jméno: " + Jmeno +
                " Přijmení: " + Prijmeni +
                " Telefon: " + Telefon +
            	" Email: " + Email + 
            	" Funkce: " + Funkce;
        }
	}
}
