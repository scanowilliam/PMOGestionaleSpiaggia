using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PMOgestionale
{
    class CustomDTP : DateTimePicker
    {
        //campi che mi interessa cambiare
        private Color skinColor = Color.Black;
        private Color textColor = Color.WhiteSmoke;
        private Color borderColor = Color.WhiteSmoke;
        private int borderSize = 1;

        private Image calendarIcon = PMOgestionale.Properties.Resources.Dakirby309_Simply_Styled_Calendar;
        private RectangleF iconButtonArea;
        private const int calendarIconWidth = 1;
        private const int arrowIconWidth = 1;
        private bool dropdown = false;

        //propietà
        public Color SkinColor { get => skinColor; set => skinColor = value; }
        public Color TextColor { get => textColor; set => textColor = value; }
        public Color BorderColor { get => borderColor; set => borderColor = value; }
        public int BorderSize { get => borderSize; set => borderSize = value; }

        //construttore che sostituisce il datetime picker originale
        public CustomDTP()
        {
            //l'utente cambia lo stile non windows
            this.SetStyle(ControlStyles.UserPaint, true);
        }
        //ovverride del metodo per colorare di windows
        protected override void OnPaint(PaintEventArgs e)
        {
            //creo gli oggetti grafici per il controllo
            using (Graphics graphics = this.CreateGraphics())
            using (SolidBrush skinBrush = new SolidBrush(SkinColor))
            using (SolidBrush textBrush = new SolidBrush(TextColor))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            using (StringFormat textFormat = new StringFormat())

            {
                RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5F, this.Height - 0.5F);
                RectangleF iconArea = new RectangleF(clientArea.Width - calendarIconWidth, 0, calendarIconWidth, clientArea.Height);
                penBorder.Alignment = PenAlignment.Inset;
                textFormat.LineAlignment = StringAlignment.Center;
                //superfice
                graphics.FillRectangle(skinBrush, clientArea);
                //text
                graphics.DrawString(this.Text, this.Font, textBrush, clientArea, textFormat);
                //border
                if (borderSize >= 1)
                {
                    graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                }
                //icon
                graphics.DrawImage(calendarIcon, this.Width - calendarIcon.Width - 4, (this.Height - calendarIcon.Height) / 2);
            }

        }

    }
}
