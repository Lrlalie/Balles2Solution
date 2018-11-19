using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balles2
{
    //ici on a créé un composant qui va pouvoir être utilisé pour différentes balles
    //il suffit d'ajouter une balle "physique" directement
    //on a donc créé un composant physique comme un textbox, une combobox,...
    class Balles2Class : PictureBox
    {
        
            Timer tm = new Timer();
            Int32 vitesseX = 5;
            Int32 vitesseY = 5;

        public Balles2Class()
            {
            tm.Interval = 50;
            tm.Tick += bouger; ;
            tm.Enabled = true;
        }
        private void bouger(Object sender, EventArgs e)
        {
                if (this.Left < 0)
                {
                    vitesseX = -vitesseX;
                }
                if (this.Left > FindForm().Width - this.Width - 15) // je compare la largeur de ma forme avec la trajectoire de ma balle
                {
                    vitesseX = -vitesseX;
                }
                if (this.Top < 0)
                {
                    vitesseY = -vitesseY;

                }
                if (this.Top > FindForm().Height - this.Height - 38) // je compare la hauteur de ma forme avec la trajectoire de ma balle
            {
                    vitesseY = -vitesseY;
                }
                this.Left = this.Left + vitesseX;
                this.Top = this.Top + vitesseY;
            }

        //si rien ne fonctionne alors même que le code est correct : utiliser regénérer dans générer
          
        }
}
