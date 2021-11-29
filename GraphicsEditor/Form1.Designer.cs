
using System.Windows.Forms;

namespace GraphicsEditor
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelNarzedzie = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelKolor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelGrLinii = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelWspolrzedne = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTlo = new System.Windows.Forms.Button();
            this.buttonZapisDoPliku = new System.Windows.Forms.Button();
            this.buttonCzyszczenie = new System.Windows.Forms.Button();
            this.buttonWypelnienie = new System.Windows.Forms.Button();
            this.buttonMenuGumka = new System.Windows.Forms.Button();
            this.buttonMenuKolor = new System.Windows.Forms.Button();
            this.buttonMenuGrubosc = new System.Windows.Forms.Button();
            this.buttonMenuNarzedzia = new System.Windows.Forms.Button();
            this.panelNarzedzia = new System.Windows.Forms.Panel();
            this.buttonWielokat = new System.Windows.Forms.Button();
            this.buttonWycinekKola = new System.Windows.Forms.Button();
            this.buttonLuk = new System.Windows.Forms.Button();
            this.buttonElipsa = new System.Windows.Forms.Button();
            this.buttonKwadrat = new System.Windows.Forms.Button();
            this.buttonPunkt = new System.Windows.Forms.Button();
            this.buttonKolo = new System.Windows.Forms.Button();
            this.buttonBezier = new System.Windows.Forms.Button();
            this.buttonPanelMenu1 = new System.Windows.Forms.Button();
            this.buttonPanelMenu2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelGrubosc = new System.Windows.Forms.Panel();
            this.trackBarGrubosc = new System.Windows.Forms.TrackBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelNarzedzia.SuspendLayout();
            this.panelGrubosc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrubosc)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(136, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 361);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelNarzedzie,
            this.toolStripStatusLabelKolor,
            this.toolStripStatusLabelGrLinii,
            this.toolStripStatusLabelWspolrzedne});
            this.statusStrip1.Location = new System.Drawing.Point(0, 387);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(776, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelNarzedzie
            // 
            this.toolStripStatusLabelNarzedzie.Name = "toolStripStatusLabelNarzedzie";
            this.toolStripStatusLabelNarzedzie.Size = new System.Drawing.Size(163, 17);
            this.toolStripStatusLabelNarzedzie.Text = "toolStripStatusLabelNarzedzie";
            // 
            // toolStripStatusLabelKolor
            // 
            this.toolStripStatusLabelKolor.Name = "toolStripStatusLabelKolor";
            this.toolStripStatusLabelKolor.Size = new System.Drawing.Size(140, 17);
            this.toolStripStatusLabelKolor.Text = "toolStripStatusLabelKolor";
            // 
            // toolStripStatusLabelGrLinii
            // 
            this.toolStripStatusLabelGrLinii.Name = "toolStripStatusLabelGrLinii";
            this.toolStripStatusLabelGrLinii.Size = new System.Drawing.Size(146, 17);
            this.toolStripStatusLabelGrLinii.Text = "toolStripStatusLabelGrLinii";
            // 
            // toolStripStatusLabelWspolrzedne
            // 
            this.toolStripStatusLabelWspolrzedne.Name = "toolStripStatusLabelWspolrzedne";
            this.toolStripStatusLabelWspolrzedne.Size = new System.Drawing.Size(180, 17);
            this.toolStripStatusLabelWspolrzedne.Text = "toolStripStatusLabelWspolrzedne";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonTlo);
            this.panel1.Controls.Add(this.buttonZapisDoPliku);
            this.panel1.Controls.Add(this.buttonCzyszczenie);
            this.panel1.Controls.Add(this.buttonWypelnienie);
            this.panel1.Controls.Add(this.buttonMenuGumka);
            this.panel1.Controls.Add(this.buttonMenuKolor);
            this.panel1.Controls.Add(this.buttonMenuGrubosc);
            this.panel1.Controls.Add(this.buttonMenuNarzedzia);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 342);
            this.panel1.TabIndex = 2;
            // 
            // buttonTlo
            // 
            this.buttonTlo.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonTlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTlo.Location = new System.Drawing.Point(3, 302);
            this.buttonTlo.Name = "buttonTlo";
            this.buttonTlo.Size = new System.Drawing.Size(46, 36);
            this.buttonTlo.TabIndex = 7;
            this.buttonTlo.Text = "🖥️";
            this.buttonTlo.UseVisualStyleBackColor = false;
            this.buttonTlo.Click += new System.EventHandler(this.ButtonTlo_Click);
            // 
            // buttonZapisDoPliku
            // 
            this.buttonZapisDoPliku.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonZapisDoPliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZapisDoPliku.Location = new System.Drawing.Point(3, 260);
            this.buttonZapisDoPliku.Name = "buttonZapisDoPliku";
            this.buttonZapisDoPliku.Size = new System.Drawing.Size(46, 36);
            this.buttonZapisDoPliku.TabIndex = 6;
            this.buttonZapisDoPliku.Text = "💾";
            this.buttonZapisDoPliku.UseVisualStyleBackColor = false;
            this.buttonZapisDoPliku.Click += new System.EventHandler(this.buttonZapisDoPliku_Click);
            // 
            // buttonCzyszczenie
            // 
            this.buttonCzyszczenie.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonCzyszczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCzyszczenie.Location = new System.Drawing.Point(3, 218);
            this.buttonCzyszczenie.Name = "buttonCzyszczenie";
            this.buttonCzyszczenie.Size = new System.Drawing.Size(46, 36);
            this.buttonCzyszczenie.TabIndex = 5;
            this.buttonCzyszczenie.Text = "↺";
            this.buttonCzyszczenie.UseVisualStyleBackColor = false;
            this.buttonCzyszczenie.Click += new System.EventHandler(this.ButtonCzyszczenie_Click);
            // 
            // buttonWypelnienie
            // 
            this.buttonWypelnienie.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonWypelnienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWypelnienie.Location = new System.Drawing.Point(3, 176);
            this.buttonWypelnienie.Name = "buttonWypelnienie";
            this.buttonWypelnienie.Size = new System.Drawing.Size(46, 36);
            this.buttonWypelnienie.TabIndex = 4;
            this.buttonWypelnienie.Text = "🟩";
            this.buttonWypelnienie.UseVisualStyleBackColor = false;
            this.buttonWypelnienie.Click += new System.EventHandler(this.ButtonWypelnienie_Click);
            // 
            // buttonMenuGumka
            // 
            this.buttonMenuGumka.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonMenuGumka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenuGumka.Location = new System.Drawing.Point(3, 134);
            this.buttonMenuGumka.Name = "buttonMenuGumka";
            this.buttonMenuGumka.Size = new System.Drawing.Size(46, 36);
            this.buttonMenuGumka.TabIndex = 3;
            this.buttonMenuGumka.Text = "💊";
            this.buttonMenuGumka.UseVisualStyleBackColor = false;
            this.buttonMenuGumka.Click += new System.EventHandler(this.ButtonMenuGumka_Click);
            // 
            // buttonMenuKolor
            // 
            this.buttonMenuKolor.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonMenuKolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenuKolor.Location = new System.Drawing.Point(3, 92);
            this.buttonMenuKolor.Name = "buttonMenuKolor";
            this.buttonMenuKolor.Size = new System.Drawing.Size(46, 36);
            this.buttonMenuKolor.TabIndex = 2;
            this.buttonMenuKolor.Text = "🎨";
            this.buttonMenuKolor.UseVisualStyleBackColor = false;
            this.buttonMenuKolor.Click += new System.EventHandler(this.ButtonMenuKolor_Click);
            // 
            // buttonMenuGrubosc
            // 
            this.buttonMenuGrubosc.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonMenuGrubosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenuGrubosc.Location = new System.Drawing.Point(3, 50);
            this.buttonMenuGrubosc.Name = "buttonMenuGrubosc";
            this.buttonMenuGrubosc.Size = new System.Drawing.Size(46, 36);
            this.buttonMenuGrubosc.TabIndex = 1;
            this.buttonMenuGrubosc.Text = "➖";
            this.buttonMenuGrubosc.UseVisualStyleBackColor = false;
            this.buttonMenuGrubosc.Click += new System.EventHandler(this.ButtonMenuGrubosc_Click);
            // 
            // buttonMenuNarzedzia
            // 
            this.buttonMenuNarzedzia.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonMenuNarzedzia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenuNarzedzia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMenuNarzedzia.Location = new System.Drawing.Point(3, 8);
            this.buttonMenuNarzedzia.Name = "buttonMenuNarzedzia";
            this.buttonMenuNarzedzia.Size = new System.Drawing.Size(46, 36);
            this.buttonMenuNarzedzia.TabIndex = 0;
            this.buttonMenuNarzedzia.Text = "🧰";
            this.buttonMenuNarzedzia.UseVisualStyleBackColor = false;
            this.buttonMenuNarzedzia.Click += new System.EventHandler(this.buttonMenuNarzedzia_Click);
            // 
            // panelNarzedzia
            // 
            this.panelNarzedzia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNarzedzia.Controls.Add(this.buttonWielokat);
            this.panelNarzedzia.Controls.Add(this.buttonWycinekKola);
            this.panelNarzedzia.Controls.Add(this.buttonLuk);
            this.panelNarzedzia.Controls.Add(this.buttonElipsa);
            this.panelNarzedzia.Controls.Add(this.buttonKwadrat);
            this.panelNarzedzia.Controls.Add(this.buttonPunkt);
            this.panelNarzedzia.Controls.Add(this.buttonKolo);
            this.panelNarzedzia.Controls.Add(this.buttonBezier);
            this.panelNarzedzia.Location = new System.Drawing.Point(70, 30);
            this.panelNarzedzia.Name = "panelNarzedzia";
            this.panelNarzedzia.Size = new System.Drawing.Size(60, 342);
            this.panelNarzedzia.TabIndex = 3;
            // 
            // buttonWielokat
            // 
            this.buttonWielokat.BackColor = System.Drawing.Color.Thistle;
            this.buttonWielokat.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWielokat.Location = new System.Drawing.Point(1, 259);
            this.buttonWielokat.Name = "buttonWielokat";
            this.buttonWielokat.Size = new System.Drawing.Size(55, 37);
            this.buttonWielokat.TabIndex = 7;
            this.buttonWielokat.Text = "⌂";
            this.buttonWielokat.UseVisualStyleBackColor = false;
            this.buttonWielokat.Click += new System.EventHandler(this.buttonWielokat_Click);
            // 
            // buttonWycinekKola
            // 
            this.buttonWycinekKola.BackColor = System.Drawing.Color.Thistle;
            this.buttonWycinekKola.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWycinekKola.Location = new System.Drawing.Point(1, 217);
            this.buttonWycinekKola.Name = "buttonWycinekKola";
            this.buttonWycinekKola.Size = new System.Drawing.Size(55, 37);
            this.buttonWycinekKola.TabIndex = 6;
            this.buttonWycinekKola.Text = "◔";
            this.buttonWycinekKola.UseVisualStyleBackColor = false;
            this.buttonWycinekKola.Click += new System.EventHandler(this.buttonWycinekKola_Click);
            // 
            // buttonLuk
            // 
            this.buttonLuk.BackColor = System.Drawing.Color.Thistle;
            this.buttonLuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLuk.Location = new System.Drawing.Point(1, 175);
            this.buttonLuk.Name = "buttonLuk";
            this.buttonLuk.Size = new System.Drawing.Size(55, 37);
            this.buttonLuk.TabIndex = 5;
            this.buttonLuk.Text = "(";
            this.buttonLuk.UseVisualStyleBackColor = false;
            this.buttonLuk.Click += new System.EventHandler(this.buttonLuk_Click);
            // 
            // buttonElipsa
            // 
            this.buttonElipsa.BackColor = System.Drawing.Color.Thistle;
            this.buttonElipsa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonElipsa.Image = ((System.Drawing.Image)(resources.GetObject("buttonElipsa.Image")));
            this.buttonElipsa.Location = new System.Drawing.Point(1, 133);
            this.buttonElipsa.Name = "buttonElipsa";
            this.buttonElipsa.Size = new System.Drawing.Size(55, 37);
            this.buttonElipsa.TabIndex = 4;
            this.buttonElipsa.UseVisualStyleBackColor = false;
            this.buttonElipsa.Click += new System.EventHandler(this.buttonElipsa_Click);
            // 
            // buttonKwadrat
            // 
            this.buttonKwadrat.BackColor = System.Drawing.Color.Thistle;
            this.buttonKwadrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKwadrat.Location = new System.Drawing.Point(1, 91);
            this.buttonKwadrat.Name = "buttonKwadrat";
            this.buttonKwadrat.Size = new System.Drawing.Size(55, 37);
            this.buttonKwadrat.TabIndex = 3;
            this.buttonKwadrat.Text = "□";
            this.buttonKwadrat.UseVisualStyleBackColor = false;
            this.buttonKwadrat.Click += new System.EventHandler(this.buttonKwadrat_Click);
            // 
            // buttonPunkt
            // 
            this.buttonPunkt.BackColor = System.Drawing.Color.Thistle;
            this.buttonPunkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPunkt.Location = new System.Drawing.Point(1, 7);
            this.buttonPunkt.Name = "buttonPunkt";
            this.buttonPunkt.Size = new System.Drawing.Size(55, 37);
            this.buttonPunkt.TabIndex = 2;
            this.buttonPunkt.Text = "•";
            this.buttonPunkt.UseVisualStyleBackColor = false;
            this.buttonPunkt.Click += new System.EventHandler(this.ButtonPunkt_Click);
            // 
            // buttonKolo
            // 
            this.buttonKolo.BackColor = System.Drawing.Color.Thistle;
            this.buttonKolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKolo.Location = new System.Drawing.Point(1, 49);
            this.buttonKolo.Name = "buttonKolo";
            this.buttonKolo.Size = new System.Drawing.Size(55, 37);
            this.buttonKolo.TabIndex = 1;
            this.buttonKolo.Text = "◯";
            this.buttonKolo.UseVisualStyleBackColor = false;
            this.buttonKolo.Click += new System.EventHandler(this.buttonKolo_Click);
            // 
            // buttonBezier
            // 
            this.buttonBezier.BackColor = System.Drawing.Color.Thistle;
            this.buttonBezier.Image = ((System.Drawing.Image)(resources.GetObject("buttonBezier.Image")));
            this.buttonBezier.Location = new System.Drawing.Point(1, 301);
            this.buttonBezier.Name = "buttonBezier";
            this.buttonBezier.Size = new System.Drawing.Size(55, 37);
            this.buttonBezier.TabIndex = 0;
            this.buttonBezier.UseVisualStyleBackColor = false;
            this.buttonBezier.Click += new System.EventHandler(this.buttonBezier_Click);
            // 
            // buttonPanelMenu1
            // 
            this.buttonPanelMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPanelMenu1.Location = new System.Drawing.Point(12, 12);
            this.buttonPanelMenu1.Name = "buttonPanelMenu1";
            this.buttonPanelMenu1.Size = new System.Drawing.Size(22, 20);
            this.buttonPanelMenu1.TabIndex = 4;
            this.buttonPanelMenu1.Text = "-";
            this.buttonPanelMenu1.UseVisualStyleBackColor = true;
            this.buttonPanelMenu1.Click += new System.EventHandler(this.ButtonPanelMenu1_Click);
            // 
            // buttonPanelMenu2
            // 
            this.buttonPanelMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPanelMenu2.Location = new System.Drawing.Point(70, 12);
            this.buttonPanelMenu2.Name = "buttonPanelMenu2";
            this.buttonPanelMenu2.Size = new System.Drawing.Size(22, 20);
            this.buttonPanelMenu2.TabIndex = 5;
            this.buttonPanelMenu2.Text = "-";
            this.buttonPanelMenu2.UseVisualStyleBackColor = true;
            this.buttonPanelMenu2.Click += new System.EventHandler(this.ButtonPanelMenu2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelGrubosc
            // 
            this.panelGrubosc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrubosc.Controls.Add(this.trackBarGrubosc);
            this.panelGrubosc.Location = new System.Drawing.Point(70, 30);
            this.panelGrubosc.Name = "panelGrubosc";
            this.panelGrubosc.Size = new System.Drawing.Size(60, 342);
            this.panelGrubosc.TabIndex = 6;
            // 
            // trackBarGrubosc
            // 
            this.trackBarGrubosc.Location = new System.Drawing.Point(7, 5);
            this.trackBarGrubosc.Maximum = 30;
            this.trackBarGrubosc.Minimum = 1;
            this.trackBarGrubosc.Name = "trackBarGrubosc";
            this.trackBarGrubosc.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarGrubosc.Size = new System.Drawing.Size(45, 335);
            this.trackBarGrubosc.TabIndex = 0;
            this.trackBarGrubosc.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarGrubosc.Value = 1;
            this.trackBarGrubosc.Scroll += new System.EventHandler(this.trackBarGrubosc_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 409);
            this.Controls.Add(this.buttonPanelMenu2);
            this.Controls.Add(this.buttonPanelMenu1);
            this.Controls.Add(this.panelNarzedzia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelGrubosc);
            this.MinimumSize = new System.Drawing.Size(283, 439);
            this.Name = "Form1";
            this.Text = "WinGraphics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelNarzedzia.ResumeLayout(false);
            this.panelGrubosc.ResumeLayout(false);
            this.panelGrubosc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrubosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPanelMenu1;
        private System.Windows.Forms.Panel panelNarzedzia;
        private System.Windows.Forms.Button buttonMenuKolor;
        private System.Windows.Forms.Button buttonMenuGrubosc;
        private System.Windows.Forms.Button buttonMenuNarzedzia;
        private System.Windows.Forms.Button buttonMenuGumka;
        private System.Windows.Forms.Button buttonPanelMenu2;
        private System.Windows.Forms.Button buttonWypelnienie;
        private System.Windows.Forms.Button buttonWielokat;
        private System.Windows.Forms.Button buttonWycinekKola;
        private System.Windows.Forms.Button buttonLuk;
        private System.Windows.Forms.Button buttonElipsa;
        private System.Windows.Forms.Button buttonKwadrat;
        private System.Windows.Forms.Button buttonPunkt;
        private System.Windows.Forms.Button buttonKolo;
        private System.Windows.Forms.Button buttonBezier;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNarzedzie;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelKolor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGrLinii;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelWspolrzedne;
        private System.Windows.Forms.Button buttonTlo;
        private System.Windows.Forms.Button buttonZapisDoPliku;
        private System.Windows.Forms.Button buttonCzyszczenie;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelGrubosc;
        private System.Windows.Forms.TrackBar trackBarGrubosc;
        private ToolTip toolTip1;
    }
}

