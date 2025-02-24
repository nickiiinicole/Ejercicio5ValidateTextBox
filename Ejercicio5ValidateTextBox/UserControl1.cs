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
    public enum eTipo
    {
        Numerico,//Números enteros: sólo son válidos los dígitos y espacios en los extremos
        Textual//(No admitirá nada que no sea una serie de letras o espacios)
    }
    public partial class ValidateTextBox : UserControl
    {

        public Pen pen = new Pen(Color.Black, 2);

        //para el tipo de validacion

        public ValidateTextBox()
        {
            InitializeComponent();
            Position();

        }

        // Propiedad Texto: acceso al contenido del TextBox interno.
        [Category("Texto")]
        [Description("Accede al texto del TextBox interno")]
        public string Texto
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        [Category("Multilinea")]
        [Description("Accede a la propiedad Multilinea del TextBox interno")]
        public bool Multilinea
        {
            get { return textBox1.Multiline; }
            set
            {
                textBox1.Multiline = value;
                Position(); //REAJUSTAR EL TAMAÑO ...

            }
        }

        [Category("Tipo")]
        [Description("Define el tipo de validación que se aplicara/ al texto")]
        private eTipo tipo;
        public eTipo Tipo
        {
            get { return tipo; }
            set
            {
                tipo = value;
                this.Refresh();
            }
        }

        /**
         * ------EVENTOS------
         */

        [Category("Text")]
        [Description("Se lanza cuando el texto cambia")]
        public event EventHandler TextChange;

        //OnXxx que será el encargado de "disparar" (o invocar) el evento
        protected virtual void OnTextChange(EventArgs e)
        {
            this.TextChange?.Invoke(this, e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            // Dibujar un rectángulo desde (5,5) hasta (Width-5, Height-5).
            bool valid = false;
            pen.Color = Color.Red;
            //Acordarse que tryParse, hace un Trim() deirectamente al txt 
            if (Tipo == eTipo.Numerico && int.TryParse(textBox1.Text, out int numbers))
            {
                valid = true;
            }
            if (Tipo == eTipo.Textual && ComprobationText())
            {
                valid = true;
            }
            pen.Color = valid ? Color.Green : Color.Red;
            e.Graphics.DrawRectangle(pen, new Rectangle(5, 5, this.Width - 10, this.Height - 10));
        }


        public void Position()
        {
            // El alto del control es el alto del TextBox +20.
            this.Height = textBox1.Height + 20;
            // El ancho del TextBox es el ancho del control -20.
            textBox1.Width = this.Width - 20;
            this.Refresh();
        }

        public bool ComprobationText()
        {
            foreach (char character in textBox1.Text)
            {
                if (!char.IsLetter(character) && character != ' ')
                {
                    return false;
                }
            }
            return true;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //disparo ele event q cree
            OnTextChange(EventArgs.Empty);
            this.Refresh(); 

        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Position();
            this.Refresh();
        }
    }
}
