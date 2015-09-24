using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace LaClínicaDelCelular
{
    class BotonCircular: Control
    {
        private Bitmap _ImagenNormal;
        private Bitmap _ImagenSobre;
        private Bitmap _ImagenPresionado;

        public BotonCircular()
        {
            this._ImagenNormal = new Bitmap(LaClínicaDelCelular.Properties.Resources.perfil);
            this._ImagenSobre = new Bitmap(LaClínicaDelCelular.Properties.Resources.perfil);
            this._ImagenPresionado = new Bitmap(LaClínicaDelCelular.Properties.Resources.perfil);
            this.Size = this._ImagenNormal.Size;

            this.BackgroundImage = this._ImagenNormal;

            this.MouseEnter += new EventHandler(_MouseEnter);
            this.MouseDown += new MouseEventHandler(_MouseDown);
            this.MouseUp += new MouseEventHandler(_MouseUp);
            this.MouseLeave += new EventHandler(_MouseLeave);
        }

        public void _MouseEnter(Object sender, EventArgs e)
        {
            this.BackgroundImage = this._ImagenSobre;
        }

        public void _MouseDown(Object sender, MouseEventArgs e)
        {
            this.BackgroundImage = this._ImagenPresionado;
        }

        public void _MouseLeave(Object sender, EventArgs e)
        {
            this.BackgroundImage = this._ImagenNormal;
        }

        public void _MouseUp(Object sender, MouseEventArgs e)
        {
            this.BackgroundImage = this._ImagenSobre;
        }


        public Bitmap ImagenNormal
        {
            set
            {
                this._ImagenNormal = value;
            }
            get
            {
                return this._ImagenNormal;
            }
        }

        public Bitmap ImagenSobre
        {
            set
            {
                this._ImagenSobre = value;
            }
            get
            {
                return this._ImagenSobre;
            }
        }

        public Bitmap ImagenPreisionado
        {
            set
            {
                this._ImagenPresionado = value;
            }
            get
            {
                return this._ImagenPresionado;
            }
        }
    
    }
}
