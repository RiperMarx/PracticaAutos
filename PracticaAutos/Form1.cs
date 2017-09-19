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
    //Clase VariableG
    public class VariablesG
    {
        //Declaracion de variables globales np, nl y p todas con sus respecivos get y set
        public static string np { get; set; }
        public static string nl { get; set; }
        public static string p { get; set; }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Evento click del boton btn_FabricarAuto
        private void btn_FabricarAuto_Click(object sender, EventArgs e)
        {
            //If de validacion de checkbox
            if (cbx_AConv.Checked == true)
            {
                //Inicializacion de clase Convencionales
                Convencionales c = new Convencionales();
                //Llamado a metodo NPuertas de la clase Convencionales
                c.NPuertas();
                //Manipulacion del texto de label por medio de la variable global
                lbl_RPuertas.Text = VariablesG.np;
                //Llamado a metodo NLlantas de la clase Convencionales
                c.NLlantas();
                //Manipulacion del texto de label por medio de la variable global
                lbl_RLlantas.Text = VariablesG.nl;
                //Llamado a metodo Potencia de la clase Convencionales
                c.Potencia();
                //Manipulacion del texto de label por medio de la variable global
                lbl_RPotencia.Text = VariablesG.p;
                MessageBox.Show("XD");
            }
            //If de validacion de checkbox
            else if (cbx_ALuj.Checked == true)
            {
                //Inicializacion de clase Convencionales
                DeLujo l = new DeLujo();
                //Llamado a metodo NPuertas de la clase Convencionales
                l.DNPuertas();
                //Manipulacion del texto de label por medio de la variable global
                lbl_RPuertas.Text = VariablesG.np;
                //Llamado a metodo NLlantas de la clase Convencionales
                l.DNLlantas();
                //Manipulacion del texto de label por medio de la variable global
                lbl_RLlantas.Text = VariablesG.nl;
                //Llamado a metodo Potencia de la clase Convencionales
                l.DPotencia();
                //Manipulacion del texto de label por medio de la variable global
                lbl_RPotencia.Text = VariablesG.p;
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
        //Llamado de metodo NPuertas 
        public override void NPuertas()
        {

            //Declaracion de variable de texto
            VariablesG.np = "2 a 4 puertas";
        }
        public override void NLlantas()
        {
            //Declaracion de variable de texto
            VariablesG.nl = "Llantas sencillas";
        }
        public override void Potencia()
        {
            //Declaracion de variable de texto
            VariablesG.p = "De 90 a 110 caballos de fuerza";
        }
    }
    class DeLujo
    {
        public virtual void DNPuertas()
        {
            string np = "2 puertas";
        }
        public virtual void DNLlantas()
        {
            string nl = "Llantas reforzadas";
        }
        public virtual void DPotencia()
        {
            string p = "De 110 a 250 caballos de fuerza";
        }
    }
    class Formula1 : DeLujo
    {
        public override void DNPuertas()
        {
            string puertas = "Sin puertas";
        }
        public override void DNLlantas()
        {
            string llantas = "Llantas de alto rendimiento";
        }
        public override void DPotencia()
        {
            string potencia = "De 600 a 750 caballos de fuerza";
        }
    }
}
