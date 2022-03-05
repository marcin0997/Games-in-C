using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
/// <summary>
/// Projekt JPWP - Gra edukacyjna
/// </summary>
namespace Kulka
{
    /// <summary>
    /// Klasa odpowiedzialna za generowanie okrągłego przycisku
    /// </summary>
    class ButtonEllipse: Button
    {
        /// <summary>
        /// Narysowanie przycisku w kształcie elipsy, który będzie można dodać w klasie głównej
        /// </summary>
        /// <param name="pevent">Opis rysowanego obiektu</param>
        protected override void OnPaint(PaintEventArgs pevent)
        {
            Pen myPen = new Pen(Color.Black, 2);
            GraphicsPath g = new GraphicsPath();
            
            g.AddEllipse(5,5, 50, 50); //! Określenie wielkości i kształtu obiektu rozgrywki
            this.Region = new System.Drawing.Region(g);
            base.OnPaint(pevent);
        }
    }
}
