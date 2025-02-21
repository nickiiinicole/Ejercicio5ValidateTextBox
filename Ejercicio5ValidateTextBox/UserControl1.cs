using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5ValidateTextBox
{
    public partial class ValidateTextBox : UserControl
    {
        enum eTipo
        {
            Numerico,
            Textual
        }
        public ValidateTextBox()
        {

        }

        [Category("Texto")]
        [Description("Accede al text del textbox interno")]
        private string texto;
        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }

        [Category("Multilinea")]
        [Description("Accede a la propiedad multinea del textBox")]
        private bool multilinea;
        public bool Multilinea
        {
            get { return multilinea; }
            set { multilinea = value; }
        }

        [Category("Tipo")]
        [Description("Define el tipo de validación que se aplicará al texto")]
        private eTipo tipo;
        public eTipo Tipo { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        public void Position()
        {
            //alto del componente siempre será del tamaño del texbox interno +20 pixels 
            this.Height = this.textBox1.Size.Height + 20;
            // textbox será del ancho del componente -20 pixels
            this.textBox1.Width = this.Width - 20;
        }
    }
}
