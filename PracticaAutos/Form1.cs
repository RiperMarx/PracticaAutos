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
            //Condiciones para validar que solo se marque una casilla
            if (cbx_AConv.Checked && cbx_ALuj.Checked && cbx_AFor1.Checked)
            {
                MessageBox.Show("Solo debe marcar una casilla");
            }
            else if (cbx_AConv.Checked && cbx_ALuj.Checked)
            {
                MessageBox.Show("Solo debe marcar una casilla");
            }
            else if (cbx_ALuj.Checked && cbx_AFor1.Checked)
            {
                MessageBox.Show("Solo debe marcar una casilla");
            }
            else if (cbx_AConv.Checked && cbx_AFor1.Checked)
            {
                MessageBox.Show("Solo debe marcar una casilla");
            }
            else
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
                }
                //If de validacion de checkbox
                else if (cbx_ALuj.Checked == true)
                {
                    //Inicializacion de clase DeLujo
                    DeLujo l = new DeLujo();
                    //Llamado a metodo DNPuertas de la clase Convencionales
                    l.DNPuertas();
                    //Manipulacion del texto de label por medio de la variable global
                    lbl_RPuertas.Text = VariablesG.np;
                    //Llamado a metodo DNLlantas de la clase Convencionales
                    l.DNLlantas();
                    //Manipulacion del texto de label por medio de la variable global
                    lbl_RLlantas.Text = VariablesG.nl;
                    //Llamado a metodo DPotencia de la clase Convencionales
                    l.DPotencia();
                    //Manipulacion del texto de label por medio de la variable global
                    lbl_RPotencia.Text = VariablesG.p;
                }
                else if (cbx_AFor1.Checked == true)
                {
                    //Inicializacion de clase Formula 1
                    Formula1 l = new Formula1();
                    //Llamado a los metodos de la clase Formula1 por medio de la clase DeLujo a partir de una variable nueva
                    DeLujo f = (Formula1)l;
                    //Llamado a metodo DNPuertas de la clase Convencionales
                    f.DNPuertas();
                    //Manipulacion del texto de label por medio de la variable global
                    lbl_RPuertas.Text = VariablesG.np;
                    //Llamado a metodo DNLlantas de la clase Convencionales
                    f.DNLlantas();
                    //Manipulacion del texto de label por medio de la variable global
                    lbl_RLlantas.Text = VariablesG.nl;
                    //Llamado a metodo DPotencia de la clase Convencionales
                    f.DPotencia();
                    //Manipulacion del texto de label por medio de la variable global
                    lbl_RPotencia.Text = VariablesG.p;
                }
                else
                {
                    MessageBox.Show("Debe marcar una casilla");
                }
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
        //Llamado de metodo derivado NPuertas 
        public override void NPuertas()
        {
            //Asignacion de variable global de texto
            VariablesG.np = "2 a 4 puertas";
        }
        //Llamado de metodo derivado NLlantas
        public override void NLlantas()
        {
            //Asignacion de variable global de texto
            VariablesG.nl = "Llantas sencillas";
        }
        //Llamado de metodo derivado Potencia
        public override void Potencia()
        {
            //Asignacion de variable global de texto
            VariablesG.p = "De 90 a 110 caballos de fuerza";
        }
    }
    class DeLujo
    {
        //Creacion de metodo virtual DNPuertas
        public virtual void DNPuertas()
        {
            //Asignacion de variable global de texto
            VariablesG.np = "2 puertas";
        }
        //Creacion de metodo virtual DNLlantas
        public virtual void DNLlantas()
        {
            //Asignacion de variable global de texto
            VariablesG.nl = "Llantas reforzadas";
        }
        //Creacion de metodo virtual DPotencia
        public virtual void DPotencia()
        {
            //Asignacion de variable global de texto
            VariablesG.p = "De 110 a 350 caballos de fuerza";
        }
    }
    class Formula1 : DeLujo
    {
        //Llamado de metodo derivado DNPuertas
        public override void DNPuertas()
        {
            //Asignacion de variable global de texto
            VariablesG.np = "Sin puertas";
        }
        //Llamado de metodo derivado DNLlantas
        public override void DNLlantas()
        {
            //Asignacion de variable global de texto
            VariablesG.nl = "Llantas de alto rendimiento";
        }
        //Llamado de metodo derivado DPotencia
        public override void DPotencia()
        {
            //Asignacion de variable global de texto
            VariablesG.p = "De 600 a 750 caballos de fuerza";
        }
    }
}
