using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    
    public class Class1
    {
        public static void DiceFunctions()
        {

        }

    }
    public class Class2
    {
        public static Panel p1 = new Panel();
        public static Panel p2 = new Panel();
        public static Panel p3 = new Panel();
        public static Panel p4 = new Panel();
        public static Panel p5 = new Panel();

        public static void DrawDice6()
        {
            SolidBrush B = new SolidBrush(Color.Black);

            Graphics G1 = p1.CreateGraphics();
            G1.FillEllipse(B, 15, 7, 7, 7);
            G1.FillEllipse(B, 63, 7, 7, 7);
            G1.FillEllipse(B, 15, 31, 7, 7);
            G1.FillEllipse(B, 63, 31, 7, 7);
            G1.FillEllipse(B, 15, 53, 7, 7);
            G1.FillEllipse(B, 63, 53, 7, 7);
            Graphics G2 = p2.CreateGraphics();
            G2.FillEllipse(B, 15, 7, 7, 7);
            G2.FillEllipse(B, 63, 7, 7, 7);
            G2.FillEllipse(B, 15, 31, 7, 7);
            G2.FillEllipse(B, 63, 31, 7, 7);
            G2.FillEllipse(B, 15, 53, 7, 7);
            G2.FillEllipse(B, 63, 53, 7, 7);
            Graphics G3 = p3.CreateGraphics();
            G3.FillEllipse(B, 15, 7, 7, 7);
            G3.FillEllipse(B, 63, 7, 7, 7);
            G3.FillEllipse(B, 15, 31, 7, 7);
            G3.FillEllipse(B, 63, 31, 7, 7);
            G3.FillEllipse(B, 15, 53, 7, 7);
            G3.FillEllipse(B, 63, 53, 7, 7);
            Graphics G4 = p4.CreateGraphics();
            G4.FillEllipse(B, 15, 7, 7, 7);
            G4.FillEllipse(B, 63, 7, 7, 7);
            G4.FillEllipse(B, 15, 31, 7, 7);
            G4.FillEllipse(B, 63, 31, 7, 7);
            G4.FillEllipse(B, 15, 53, 7, 7);
            G4.FillEllipse(B, 63, 53, 7, 7);
            Graphics G5 = p5.CreateGraphics();
            G5.FillEllipse(B, 15, 7, 7, 7);
            G5.FillEllipse(B, 63, 7, 7, 7);
            G5.FillEllipse(B, 15, 31, 7, 7);
            G5.FillEllipse(B, 63, 31, 7, 7);
            G5.FillEllipse(B, 15, 53, 7, 7);
            G5.FillEllipse(B, 63, 53, 7, 7);
        }


        public static void DrawDice5()
        {

            SolidBrush B = new SolidBrush(Color.Black);

            Graphics G1 = p1.CreateGraphics();
            G1.FillEllipse(B, 15, 7, 7, 7);
            G1.FillEllipse(B, 63, 7, 7, 7);
            G1.FillEllipse(B, 39, 31, 7, 7);
            G1.FillEllipse(B, 15, 53, 7, 7);
            G1.FillEllipse(B, 63, 53, 7, 7);
            Graphics G2 = p2.CreateGraphics();
            G2.FillEllipse(B, 15, 7, 7, 7);
            G2.FillEllipse(B, 63, 7, 7, 7);
            G2.FillEllipse(B, 39, 31, 7, 7);
            G2.FillEllipse(B, 15, 53, 7, 7);
            G2.FillEllipse(B, 63, 53, 7, 7);
            Graphics G3 = p3.CreateGraphics();
            G3.FillEllipse(B, 15, 7, 7, 7);
            G3.FillEllipse(B, 63, 7, 7, 7);
            G3.FillEllipse(B, 39, 31, 7, 7);
            G3.FillEllipse(B, 15, 53, 7, 7);
            G3.FillEllipse(B, 63, 53, 7, 7);
            Graphics G4 = p4.CreateGraphics();
            G4.FillEllipse(B, 15, 7, 7, 7);
            G4.FillEllipse(B, 63, 7, 7, 7);
            G4.FillEllipse(B, 39, 31, 7, 7);
            G4.FillEllipse(B, 15, 53, 7, 7);
            G4.FillEllipse(B, 63, 53, 7, 7);
            Graphics G5 = p5.CreateGraphics();
            G5.FillEllipse(B, 15, 7, 7, 7);
            G5.FillEllipse(B, 63, 7, 7, 7);
            G5.FillEllipse(B, 39, 31, 7, 7);
            G5.FillEllipse(B, 15, 53, 7, 7);
            G5.FillEllipse(B, 63, 53, 7, 7);
        }
        public static void DrawDice4()
        {
            SolidBrush B = new SolidBrush(Color.Black);

            Graphics G1 = p1.CreateGraphics();
            G1.FillEllipse(B, 15, 7, 7, 7);
            G1.FillEllipse(B, 63, 7, 7, 7);
            G1.FillEllipse(B, 15, 53, 7, 7);
            G1.FillEllipse(B, 63, 53, 7, 7);
            Graphics G2 = p2.CreateGraphics();
            G2.FillEllipse(B, 15, 7, 7, 7);
            G2.FillEllipse(B, 63, 7, 7, 7);
            G2.FillEllipse(B, 15, 53, 7, 7);
            G2.FillEllipse(B, 63, 53, 7, 7);
            Graphics G3 = p3.CreateGraphics();
            G3.FillEllipse(B, 15, 7, 7, 7);
            G3.FillEllipse(B, 63, 7, 7, 7);
            G3.FillEllipse(B, 15, 53, 7, 7);
            G3.FillEllipse(B, 63, 53, 7, 7);
            Graphics G4 = p4.CreateGraphics();
            G4.FillEllipse(B, 15, 7, 7, 7);
            G4.FillEllipse(B, 63, 7, 7, 7);
            G4.FillEllipse(B, 15, 53, 7, 7);
            G4.FillEllipse(B, 63, 53, 7, 7);
            Graphics G5 = p5.CreateGraphics();
            G5.FillEllipse(B, 15, 7, 7, 7);
            G5.FillEllipse(B, 63, 7, 7, 7);
            G5.FillEllipse(B, 15, 53, 7, 7);
            G5.FillEllipse(B, 63, 53, 7, 7);
        }

        public static void DrawDice3()
        {
            SolidBrush B = new SolidBrush(Color.Black);

            Graphics G1 = p1.CreateGraphics();
            G1.FillEllipse(B, 15, 7, 7, 7);
            G1.FillEllipse(B, 39, 31, 7, 7);
            G1.FillEllipse(B, 63, 53, 7, 7);
            Graphics G2 = p2.CreateGraphics();
            G2.FillEllipse(B, 15, 7, 7, 7);
            G2.FillEllipse(B, 39, 31, 7, 7);
            G2.FillEllipse(B, 63, 53, 7, 7);
            Graphics G3 = p3.CreateGraphics();
            G3.FillEllipse(B, 15, 7, 7, 7);
            G3.FillEllipse(B, 39, 31, 7, 7);
            G3.FillEllipse(B, 63, 53, 7, 7);
            Graphics G4 = p4.CreateGraphics();
            G4.FillEllipse(B, 15, 7, 7, 7);
            G4.FillEllipse(B, 39, 31, 7, 7);
            G4.FillEllipse(B, 63, 53, 7, 7);
            Graphics G5 = p5.CreateGraphics();
            G5.FillEllipse(B, 15, 7, 7, 7);
            G5.FillEllipse(B, 39, 31, 7, 7);
            G5.FillEllipse(B, 63, 53, 7, 7);
        }

        public static void DrawDice2()
        {
            SolidBrush B = new SolidBrush(Color.Black);

            Graphics G1 = p1.CreateGraphics();
            G1.FillEllipse(B, 15, 7, 7, 7);
            G1.FillEllipse(B, 63, 53, 7, 7);
            Graphics G2 = p2.CreateGraphics();
            G2.FillEllipse(B, 15, 7, 7, 7);
            G2.FillEllipse(B, 63, 53, 7, 7);
            Graphics G3 = p3.CreateGraphics();
            G3.FillEllipse(B, 15, 7, 7, 7);
            G3.FillEllipse(B, 63, 53, 7, 7);
            Graphics G4 = p4.CreateGraphics();
            G4.FillEllipse(B, 15, 7, 7, 7);
            G4.FillEllipse(B, 63, 53, 7, 7);
            Graphics G5 = p5.CreateGraphics();
            G5.FillEllipse(B, 15, 7, 7, 7);
            G5.FillEllipse(B, 63, 53, 7, 7);
        }

        public static void DrawDice1()
        {
            SolidBrush B = new SolidBrush(Color.Black);

            Graphics G1 = p1.CreateGraphics();
            G1.FillEllipse(B, 39, 31, 7, 7);
            Graphics G2 = p2.CreateGraphics();
            G2.FillEllipse(B, 39, 31, 7, 7);
            Graphics G3 = p3.CreateGraphics();
            G3.FillEllipse(B, 39, 31, 7, 7);
            Graphics G4 = p4.CreateGraphics();
            G4.FillEllipse(B, 39, 31, 7, 7);
            Graphics G5 = p5.CreateGraphics();
            G5.FillEllipse(B, 39, 31, 7, 7);

        }
        public static void DrawClear()
        {
            SolidBrush B = new SolidBrush(Color.WhiteSmoke);
            Graphics G1 = p1.CreateGraphics();
            G1.FillRectangle(B, 0, 0, 90, 90);            
            Graphics G2 = p2.CreateGraphics();
            G2.FillRectangle(B, 0, 0, 90, 90);
            Graphics G3 = p3.CreateGraphics();
            G3.FillRectangle(B, 0, 0, 90, 90);
            Graphics G4 = p4.CreateGraphics();
            G4.FillRectangle(B, 0, 0, 90, 90);
            Graphics G5 = p5.CreateGraphics();
            G5.FillRectangle(B, 0, 0, 90, 90);
        }
    }
}
