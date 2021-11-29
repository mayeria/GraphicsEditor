using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabelKolor.Text = "| " + pen.Color.ToString();
            toolStripStatusLabelNarzedzie.Text = "Rysowanie";
            toolStripStatusLabelGrLinii.Text = "| Grubość linii - " + trackBarGrubosc.Value;

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g.Flush();

            ToolTip buttonToolTip = new ToolTip();
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.ShowAlways = true;
            buttonToolTip.SetToolTip(buttonBezier, "Krzywa beziera");
            buttonToolTip.SetToolTip(buttonCzyszczenie, "Wyczyść obrazek");
            buttonToolTip.SetToolTip(buttonElipsa, "Elipsa");
            buttonToolTip.SetToolTip(buttonKolo, "Koło");
            buttonToolTip.SetToolTip(buttonKwadrat, "Kwadrat");
            buttonToolTip.SetToolTip(buttonLuk, "Łuk");
            buttonToolTip.SetToolTip(buttonMenuGrubosc, "Ustaw grubość linii");
            buttonToolTip.SetToolTip(buttonMenuGumka, "Gumka");
            buttonToolTip.SetToolTip(buttonMenuKolor, "Zmień kolor linii");
            buttonToolTip.SetToolTip(buttonMenuNarzedzia, "Wybierz narzędzie");
            buttonToolTip.SetToolTip(buttonPunkt, "Punkt");
            buttonToolTip.SetToolTip(buttonTlo, "Dodaj tło z pliku");
            buttonToolTip.SetToolTip(buttonWielokat, "Wielokąt");
            buttonToolTip.SetToolTip(buttonWycinekKola, "Wycinek koła");
            buttonToolTip.SetToolTip(buttonWypelnienie, "Rysuj z wypełnieniem lub bez");
            buttonToolTip.SetToolTip(buttonZapisDoPliku, "Zapisz do pliku graficznego");
        }

        Pen pen = new Pen(Brushes.Black, 2F);
        Point punkt;
        private Graphics g, tg;
        string narzedzie;
        bool mouseDown = false, gumka = false, wypelnienie = false;
        Bitmap bmp, tbmp;

        private void ButtonPanelMenu1_Click(object sender, EventArgs e)
        {
            if (!panel1.Visible)
            {
                if (panelNarzedzia.Visible || panelGrubosc.Visible)
                {
                    pictureBox1.Location = new Point(136, 12);
                    pictureBox1.Size = new Size(628, 361);
                }
                else
                {
                    pictureBox1.Location = new Point(98, 12);
                    pictureBox1.Size = new Size(666, 361);
                }
                buttonPanelMenu2.Location = new Point(70, 12);
                panelNarzedzia.Location = new Point(70, 30);
                panelGrubosc.Location = new Point(70, 30);
                panel1.Visible = true;
            }
            else
            {
                if (panelNarzedzia.Visible || panelGrubosc.Visible)
                {
                    panelNarzedzia.Location = new Point(40, 30);
                    panelGrubosc.Location = new Point(40, 30);
                    pictureBox1.Location = new Point(103, 12);
                    pictureBox1.Size = new Size(661, 361);
                }
                else
                {
                    pictureBox1.Location = new Point(68, 12);
                    pictureBox1.Size = new Size(696, 361);
                }
                buttonPanelMenu2.Location = new Point(40, 12);
                panel1.Visible = false;
            }
            pictureBox1_SizeChanged(sender, e);
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            tbmp = new Bitmap(bmp, pictureBox1.Width, pictureBox1.Height);
            tg = Graphics.FromImage(tbmp);
            tg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pictureBox1.Image = tbmp;
            tg.Flush();
        }

        private void ButtonMenuGumka_Click(object sender, EventArgs e)
        {
            if (buttonMenuGumka.Text == "✏️")
            {
                buttonMenuGumka.Text = "💊";
                toolStripStatusLabelNarzedzie.Text = "Rysowanie";
                gumka = false;
                panelNarzedzia.Visible = true;
                panelGrubosc.Visible = false;
            }
            else
            {
                buttonMenuGumka.Text = "✏️";
                toolStripStatusLabelNarzedzie.Text = "Gumka";
                gumka = true;
                panelNarzedzia.Visible = false;
                panelGrubosc.Visible = true;
            }
        }

        private void ButtonPanelMenu2_Click(object sender, EventArgs e)
        {
            if (!panelNarzedzia.Visible && !panelGrubosc.Visible)
            {
                panelNarzedzia.Visible = true;
                if (!panel1.Visible)
                {
                    panelNarzedzia.Location = new Point(40, 30);
                    pictureBox1.Location = new Point(103, 12);
                    pictureBox1.Size = new Size(661, 361);
                }
                else
                {
                    buttonPanelMenu2.Location = new Point(70, 12);
                    panelNarzedzia.Location = new Point(70, 30);
                    pictureBox1.Location = new Point(136, 12);
                    pictureBox1.Size = new Size(628, 361);
                }
            }
            else
            {
                panelNarzedzia.Visible = false;
                panelGrubosc.Visible = false;

                if (panel1.Visible)
                {
                    pictureBox1.Location = new Point(98, 12);
                    pictureBox1.Size = new Size(666, 361);
                }
                else
                {
                    pictureBox1.Location = new Point(68, 12);
                    buttonPanelMenu2.Location = new Point(40, 12);
                    pictureBox1.Size = new Size(696, 361);
                }
            }
            pictureBox1_SizeChanged(sender, e);
        }

        private void ButtonWypelnienie_Click(object sender, EventArgs e)
        {
            if (buttonWypelnienie.Text == "🟩")
            {
                buttonWypelnienie.Text = "⬜";
                wypelnienie = true;
            }
            else
            {
                buttonWypelnienie.Text = "🟩";
                wypelnienie = false;
            }
        }

        private void ButtonCzyszczenie_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height);
            tbmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            tg = Graphics.FromImage(bmp);
            tg.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
        }

        private void ButtonTlo_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog1.FileName;
                    bmp = new Bitmap(Image.FromFile(path), pictureBox1.Width, pictureBox1.Height);
                    g = Graphics.FromImage(bmp);
                    pictureBox1.Image = bmp;
                    g.Flush();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd podczas ładowania pliku");
                }
            }
        }

        private void ButtonMenuKolor_Click(object sender, EventArgs e)
        {
            ColorDialog kolor = new ColorDialog();
            if (kolor.ShowDialog() == DialogResult.OK)
                pen.Color = kolor.Color;
            toolStripStatusLabelKolor.Text = "|" + pen.Color.ToString();
        }

        private void ButtonMenuGrubosc_Click(object sender, EventArgs e)
        {
            panelNarzedzia.Visible = false;
            panelGrubosc.Visible = true;
        }

        private void ButtonPunkt_Click(object sender, EventArgs e)
        {
            narzedzie = "punkt";
            toolStripStatusLabelNarzedzie.Text = "Rysowanie punktu";
            List<Button> buttonsNarzedzia = new List<Button>() { buttonBezier, buttonElipsa, buttonKolo, buttonKwadrat, buttonLuk, buttonPunkt, buttonWielokat, buttonWycinekKola };
            foreach (Button button in buttonsNarzedzia)
                button.BackColor = Color.Thistle;
            buttonPunkt.BackColor = Color.Bisque;

        }
        void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            punkt = e.Location;
        }

        void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (tbmp != null) 
            {
                if (narzedzie == "punkt")
                {
                    tbmp = new Bitmap(bmp);
                    tg = Graphics.FromImage(tbmp);
                    tg.FillEllipse(pen.Brush, e.X, e.Y, trackBarGrubosc.Value, trackBarGrubosc.Value);
                }

                bmp = new Bitmap(tbmp);
                g = Graphics.FromImage(bmp);

                pictureBox1.Image = bmp;
                g.Flush();
            }
            mouseDown = false;
        }

        void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabelWspolrzedne.Text = "| Współrzędne myszy: X - " + e.X.ToString() + " Y - " + e.Y.ToString();
            if (mouseDown)
            {
                try 
                {
                    tbmp = new Bitmap(bmp);
                    tg = Graphics.FromImage(tbmp);
                    tg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    if (gumka) 
                    {
                        Pen penG = new Pen(Brushes.White, 2F);
                        tg.FillEllipse(penG.Brush, e.X, e.Y, trackBarGrubosc.Value, trackBarGrubosc.Value);
                        bmp = new Bitmap(tbmp);
                        g = Graphics.FromImage(bmp);
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        pictureBox1.Image = bmp;
                    }
                    else
                    {
                        if (narzedzie == "kolo")
                        {
                            if (wypelnienie)
                                tg.FillEllipse(pen.Brush, e.X, e.Y, e.X - punkt.X, e.X - punkt.X);
                            else
                                tg.DrawEllipse(pen, e.X, e.Y, e.X - punkt.X, e.X - punkt.X);
                        }
                        if (narzedzie == "kwadrat")
                        {
                            if (wypelnienie)
                                tg.FillRectangle(pen.Brush, e.X, e.Y, e.X - punkt.X, e.X - punkt.X);
                            else
                                tg.DrawRectangle(pen, e.X, e.Y, e.X - punkt.X, e.X - punkt.X);
                        }
                        if (narzedzie == "elipsa")
                        {
                            if (wypelnienie)
                                tg.FillEllipse(pen.Brush, e.X, e.Y, Math.Abs(e.X - punkt.X) * 2, Math.Abs(e.X - punkt.X));
                            else
                                tg.DrawEllipse(pen, e.X, e.Y, Math.Abs(e.X - punkt.X)*2, Math.Abs(e.X - punkt.X));
                        }
                        if (narzedzie == "luk")
                        {
                            if (e.X - punkt.X > 0 && e.Y - punkt.Y > 0)
                                tg.DrawArc(pen, e.X, e.Y, Math.Abs(e.X - punkt.X), Math.Abs(e.Y - punkt.Y), e.X, e.Y);
                        }
                        if (narzedzie == "wycinekKola")
                        {
                            if (e.X - punkt.X > 0) 
                            {
                                if (wypelnienie)
                                    tg.FillPie(pen.Brush, e.X, e.Y, Math.Abs(e.X - punkt.X), Math.Abs(e.X - punkt.X), Math.Abs(e.X - punkt.X), Math.Abs(e.X - punkt.X));
                                else
                                    tg.DrawPie(pen, e.X, e.Y, Math.Abs(e.X - punkt.X), Math.Abs(e.X - punkt.X), Math.Abs(e.X - punkt.X), Math.Abs(e.X - punkt.X));
                            }
                        }
                        if (narzedzie == "wielokat")
                        {
                            Point punkt0 = new Point(e.X, e.Y);
                            Point punkt1 = new Point(e.X + Math.Abs(e.X - punkt.X)*2, e.Y + Math.Abs(e.X - punkt.X)*-2);
                            Point punkt2 = new Point(e.X + Math.Abs(e.X - punkt.X)*4, e.Y);
                            Point punkt3 = new Point(e.X, e.Y + Math.Abs(e.X - punkt.X)*3);
                            Point punkt4 = new Point(e.X + Math.Abs(e.X - punkt.X)*4, e.Y + Math.Abs(e.X - punkt.X)*3);
                            Point[] punkty = { punkt0, punkt1, punkt2, punkt4, punkt3 };
                            if (wypelnienie)
                                tg.FillPolygon(pen.Brush, punkty);
                            else
                                tg.DrawPolygon(pen, punkty);
                        }
                        if (narzedzie == "bezier")
                        {
                            Point punkt0 = new Point(e.X, e.Y);
                            Point punkt1 = new Point(e.X + Math.Abs(e.X - punkt.X) * 2, e.Y + Math.Abs(e.Y - punkt.Y) * -2);
                            Point punkt2 = new Point(e.X + Math.Abs(e.X - punkt.X) * 3, e.Y + Math.Abs(e.Y - punkt.Y));
                            Point punkt3 = new Point(e.X + Math.Abs(e.X - punkt.X) * 2, e.Y + Math.Abs(e.Y - punkt.Y) * 2);
                            tg.DrawBezier(pen, punkt0, punkt1, punkt2, punkt3);
                        }
                    }
                    pictureBox1.Image = tbmp;
                    tg.Flush();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd podczas rysowania");
                }

            }
        }

        private void buttonKolo_Click(object sender, EventArgs e)
        {
            narzedzie = "kolo";
            toolStripStatusLabelNarzedzie.Text = "Rysowanie koła";
            List<Button> buttonsNarzedzia = new List<Button>() { buttonBezier, buttonElipsa, buttonKolo, buttonKwadrat, buttonLuk, buttonPunkt, buttonWielokat, buttonWycinekKola };
            foreach (Button button in buttonsNarzedzia)
                button.BackColor = Color.Thistle;
            buttonKolo.BackColor = Color.Bisque;
        }

        private void buttonKwadrat_Click(object sender, EventArgs e)
        {
            narzedzie = "kwadrat";
            toolStripStatusLabelNarzedzie.Text = "Rysowanie kwadratu";
            List<Button> buttonsNarzedzia = new List<Button>() { buttonBezier, buttonElipsa, buttonKolo, buttonKwadrat, buttonLuk, buttonPunkt, buttonWielokat, buttonWycinekKola };
            foreach (Button button in buttonsNarzedzia)
                button.BackColor = Color.Thistle;
            buttonKwadrat.BackColor = Color.Bisque;
        }

        private void buttonElipsa_Click(object sender, EventArgs e)
        {
            narzedzie = "elipsa";
            toolStripStatusLabelNarzedzie.Text = "Rysowanie elipsy";
            List<Button> buttonsNarzedzia = new List<Button>() { buttonBezier, buttonElipsa, buttonKolo, buttonKwadrat, buttonLuk, buttonPunkt, buttonWielokat, buttonWycinekKola };
            foreach (Button button in buttonsNarzedzia)
                button.BackColor = Color.Thistle;
            buttonElipsa.BackColor = Color.Bisque;
        }

        private void buttonLuk_Click(object sender, EventArgs e)
        {
            narzedzie = "luk";
            toolStripStatusLabelNarzedzie.Text = "Rysowanie łuku";
            List<Button> buttonsNarzedzia = new List<Button>() { buttonBezier, buttonElipsa, buttonKolo, buttonKwadrat, buttonLuk, buttonPunkt, buttonWielokat, buttonWycinekKola };
            foreach (Button button in buttonsNarzedzia)
                button.BackColor = Color.Thistle;
            buttonLuk.BackColor = Color.Bisque;
        }

        private void buttonWycinekKola_Click(object sender, EventArgs e)
        {
            narzedzie = "wycinekKola";
            toolStripStatusLabelNarzedzie.Text = "Rysowanie wycinku koła";
            List<Button> buttonsNarzedzia = new List<Button>() { buttonBezier, buttonElipsa, buttonKolo, buttonKwadrat, buttonLuk, buttonPunkt, buttonWielokat, buttonWycinekKola };
            foreach (Button button in buttonsNarzedzia)
                button.BackColor = Color.Thistle;
            buttonWycinekKola.BackColor = Color.Bisque;
        }

        private void buttonWielokat_Click(object sender, EventArgs e)
        {
            narzedzie = "wielokat";
            toolStripStatusLabelNarzedzie.Text = "Rysowanie wielokąta";
            List<Button> buttonsNarzedzia = new List<Button>() { buttonBezier, buttonElipsa, buttonKolo, buttonKwadrat, buttonLuk, buttonPunkt, buttonWielokat, buttonWycinekKola };
            foreach (Button button in buttonsNarzedzia)
                button.BackColor = Color.Thistle;
            buttonWielokat.BackColor = Color.Bisque;
        }

        private void trackBarGrubosc_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBarGrubosc.Value;
            toolStripStatusLabelGrLinii.Text = "| Grubość linii - " + trackBarGrubosc.Value;
        }

        private void buttonZapisDoPliku_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (saveFileDialog1.FileName != "")
                    {
                        Bitmap bmp = new Bitmap(pictureBox1.Image);
                        System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                        pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);

                        fs.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd podczas zapisywania do pliku");
                }
            }
        }

        private void buttonMenuNarzedzia_Click(object sender, EventArgs e)
        {
            panelGrubosc.Visible = false;
            panelNarzedzia.Visible = true;
        }

        private void buttonBezier_Click(object sender, EventArgs e)
        {
            narzedzie = "bezier";
            toolStripStatusLabelNarzedzie.Text = "Rysowanie krzywej beziera";
            List<Button> buttonsNarzedzia = new List<Button>() { buttonBezier, buttonElipsa, buttonKolo, buttonKwadrat, buttonLuk, buttonPunkt, buttonWielokat, buttonWycinekKola };
            foreach (Button button in buttonsNarzedzia)
                button.BackColor = Color.Thistle;
            buttonBezier.BackColor = Color.Bisque;
        }

    }
}
