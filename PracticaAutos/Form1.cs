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
            string auto = cmb_TipoAuto.SelectedItem.ToString();
            MessageBox.Show(auto.ToString());
            auto.to
            int atipo = 0;
            
            switch (auto)
            {
                case 1:
                    {
                        Convencionales c = new Convencionales();
                        c.NPuertas();
                        c.NLlantas();
                        c.Potencia();
                        break;
                    }
                case 2:
                    {
                        DeLujo l = new DeLujo();
                        l.DNPuertas();
                        l.DNLlantas();
                        l.DPotencia();
                        break;
                    }
                case 3:
                    {
                        DeLujo l = new DeLujo();
                        Formula1 f = (Formula1)l;
                        f.DNPuertas();
                        f.DNLlantas();
                        f.DPotencia();
                        break;
                    }
            }
        }
    }
    abstract class GenericMethod
    {
        public abstract void NPuertas();
        public abstract void NLlantas();
        public abstract void Potencia();
    }
    class Convencionales : GenericMethod
    {
        Form1 fm = new Form1();
        public override void NPuertas()
        {            
            string puertas = "2 a 4 puertas";
            fm.lbl_RPuertas.Text = puertas.ToString();
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
    class DeLujo : Convencionales
    {
        Form1 fm = new Form1();
        public virtual void DNPuertas()
        {
            string puertas = "2 puertas";
            fm.lbl_RPuertas.Text = puertas.ToString();
        }
        public virtual void DNLlantas()
        {
            string llantas = "Llantas reforzadas";
            fm.lbl_RLlantas.Text = llantas.ToString();
        }
        public virtual void DPotencia()
        {
            string potencia = "De 110 a 250 caballos de fuerza";
            fm.lbl_RPotencia.Text = potencia.ToString();
        }
    }
    class Formula1 : DeLujo
    {
        Form1 fm = new Form1();
        public override void DNPuertas()
        {
            string puertas = "Sin puertas";
            fm.lbl_RPuertas.Text = puertas.ToString();
        }
        public override void DNLlantas()
        {
            string llantas = "Llantas de alto rendimiento";
            fm.lbl_RLlantas.Text = llantas.ToString();
        }
        public override void DPotencia()
        {
            string potencia = "De 600 a 750 caballos de fuerza";
            fm.lbl_RPotencia.Text = potencia.ToString();
        }
    }
}
