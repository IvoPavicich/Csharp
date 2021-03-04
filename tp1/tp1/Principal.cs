using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Ejercicio 01": { new Ejercicio01().Show(); } break;
                case "Ejercicio 02": { new Ejercicio02().Show(); } break;
                case "Ejercicio 03": { new Ejercicio03().Show(); } break;
                case "Ejercicio 04": { new Ejercicio4().Show(); } break;
                case "Ejercicio 05": { new Ejercicio05().Show(); } break;
                case "Ejercicio 06": { new Ejercicio06().Show(); } break;
                case "Ejercicio 07": { new Ejercicio07().Show(); } break;
                case "Ejercicio 08": { new Ejercicio08().Show(); } break;
                //case "Ejercicio 09": { new Ejercicio09().Show(); } break;
                case "Ejercicio 10": { new Ejercicio10().Show(); } break;//no iba
                case "Ejercicio 11": { new Ejercicio11().Show(); } break;
                case "Ejercicio 12": { new Ejercicio12().Show(); } break;
                case "Ejercicio 13": { new Ejercicio13().Show(); } break;
                case "Ejercicio 14": { new Ejercicio14().Show(); } break;
                case "Ejercicio 15": { new Ejercicio15().Show(); } break;
                case "Ejercicio 16": { new Ejercicio16().Show(); } break;
                case "Ejercicio 17": { new Ejercicio17().Show(); } break;
                case "Ejercicio 18": { new Ejercicio18().Show(); } break;
                case "Ejercicio 19": { new Ejercicio19().Show(); } break;
                case "Ejercicio 20": { new Ejercicio20().Show(); } break;
                case "Ejercicio 21": { new Ejercicio21().Show(); } break;
                case "Ejercicio 22": { new Ejercicio22().Show(); } break;
                case "Ejercicio 23": { new Ejercicio23().Show(); } break;
                case "Ejercicio 24": { new Ejercicio24().Show(); } break;
                case "Ejercicio 25": { new Ejercicio25().Show(); } break;
                case "Ejercicio 26": { new Ejercicio26().Show(); } break;
                case "Ejercicio 27": { new Ejercicio27().Show(); } break;
                case "Ejercicio 28": { new Ejercicio28().Show(); } break;
                case "Ejercicio 29": { new Ejercicio29().Show(); } break;
                case "Ejercicio 30": { new Ejercicio30().Show(); } break;
                case "Ejercicio 31": { new Ejercicio31().Show(); } break;
                case "Ejercicio 32": { new Ejercicio32().Show(); } break;
                case "Funcion1": { new Funcion1().Show(); } break;
                case "Funcion2": { new Funcion2().Show(); } break;
                case "Funcion3": { new Funcion3().Show(); } break;
                case "Funcion4": { new Funcion4().Show(); } break;
                case "Funcion5": { new Funcion5().Show(); } break;
                case "Funcion6": { new Funcion6().Show(); } break;
                case "Funcion7": { new Funcion7().Show(); } break;
                case "Funcion8": { new Funcion8().Show(); } break;
                case "Funcion9": { new Funcion9().Show(); } break;
                //case "FuncionesEjercicio10": { new FuncionesEjercicio10().Show(); } break;
            }

        }
    }
}
