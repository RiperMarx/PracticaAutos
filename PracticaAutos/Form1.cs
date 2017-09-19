using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaAutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_FabricarAuto_Click(object sender, EventArgs e)
        {
            //If de validacion de checkbox
            if (cbx_AConv.Checked == true)
            {
                //Inicializacion de clase Convencionales
                Convencionales c = new Convencionales();
                //Llamado a metodo NPuertas de la clase Convencionales
                c.NPuertas();
                MessageBox.Show("XD");
            }
        }
    }
    //Clase abstracta GenericMethod
    abstract class GenericMethod
    {
        //Declaracion de metodos abstractos
        public abstract void NPuertas();
        public abstract void NLlantas();
        public abstract void Potencia();
    }
    //Clase Convencionales, que hereda de GenericMethod
    class Convencionales : GenericMethod
    {
        //Inicializacion de la forma 1
        Form1 fm = new Form1();
        //Llamado de metodo NPuertas 
        public override void NPuertas()
        {
            //Declaracion de variable de texto
            string puertas = "2 a 4 puertas";
            //Manipulacion del texto de label, desde forma 1
            fm.lbl_RPuertas.Text = puertas.ToString();
            MessageBox.Show("Hola");
        }
        public override void NLlantas()
        {
            string llantas = "Llantas sencillas";
            fm.lbl_RLlantas.Text = llantas.ToString();
        }
        public override void Potencia()
        {
            string potencia = "De 90 a 110 caballos de fuerza";
            fm.lbl_RPotencia.Text = potencia.ToString();
        }
    }
}
