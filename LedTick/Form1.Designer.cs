namespace LedTick
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel6 = new Panel();
            label6 = new Label();
            panel7 = new Panel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel11 = new Panel();
            button5 = new Button();
            label15 = new Label();
            label14 = new Label();
            pictureBox6 = new PictureBox();
            panel10 = new Panel();
            label13 = new Label();
            radioButton3 = new RadioButton();
            panel9 = new Panel();
            label12 = new Label();
            radioButton2 = new RadioButton();
            panel8 = new Panel();
            label11 = new Label();
            radioButton1 = new RadioButton();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label10 = new Label();
            numericUpDown1 = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            panel4 = new Panel();
            button7 = new Button();
            button6 = new Button();
            label16 = new Label();
            panel5 = new Panel();
            panel12 = new Panel();
            label18 = new Label();
            label17 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1119, 116);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(111, 50);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(505, 44);
            label2.TabIndex = 2;
            label2.Text = "Control automático de encendido y apagado de LED mediante \r\nTimer y representación gráfica PNG.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(378, 27);
            label1.TabIndex = 1;
            label1.Text = "Controlador de LED por Temporizador";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.procesador;
            pictureBox1.Location = new Point(15, 15);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(21, 131);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(566, 359);
            panel2.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(label6);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(22, 70);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(519, 256);
            panel6.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.ForestGreen;
            label6.Location = new Point(198, 182);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 22);
            label6.TabIndex = 7;
            label6.Text = "• ESTADO: ON";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(pictureBox3);
            panel7.Location = new Point(190, 48);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(145, 125);
            panel7.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.led__4_;
            pictureBox3.Location = new Point(38, 32);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(355, 219);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(137, 22);
            label5.TabIndex = 6;
            label5.Text = "• VOUT: +3.32 V";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(46, 12);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(227, 22);
            label3.TabIndex = 4;
            label3.Text = "PictureBox: pictureBoxLED";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.imagen__1_;
            pictureBox2.Location = new Point(10, 8);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(panel10);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(pictureBox5);
            panel3.Location = new Point(619, 131);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 558);
            panel3.TabIndex = 3;
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.Control;
            panel11.Controls.Add(button5);
            panel11.Controls.Add(label15);
            panel11.Controls.Add(label14);
            panel11.Controls.Add(pictureBox6);
            panel11.Location = new Point(30, 455);
            panel11.Margin = new Padding(4);
            panel11.Name = "panel11";
            panel11.Size = new Size(426, 76);
            panel11.TabIndex = 21;
            // 
            // button5
            // 
            button5.BackColor = Color.Gainsboro;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Roboto", 9F);
            button5.ForeColor = Color.Black;
            button5.Image = Properties.Resources.reiniciar;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(285, 19);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(118, 38);
            button5.TabIndex = 22;
            button5.Text = "Reiniciar";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Roboto Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(48, 30);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(31, 34);
            label15.TabIndex = 3;
            label15.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Roboto", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ControlDarkDark;
            label14.Location = new Point(42, 9);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(184, 18);
            label14.TabIndex = 19;
            label14.Text = "Pulsos Ejecutados (Ticks)";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.reloj_inteligente__2_;
            pictureBox6.Location = new Point(6, 4);
            pictureBox6.Margin = new Padding(4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 24);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.Control;
            panel10.Controls.Add(label13);
            panel10.Controls.Add(radioButton3);
            panel10.Location = new Point(30, 374);
            panel10.Margin = new Padding(4);
            panel10.Name = "panel10";
            panel10.Size = new Size(428, 66);
            panel10.TabIndex = 20;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Roboto", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlDarkDark;
            label13.Location = new Point(36, 32);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(310, 18);
            label13.TabIndex = 18;
            label13.Text = "Disparo en ráfagas rápidas de alta frecuencia";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Roboto Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(11, 9);
            radioButton3.Margin = new Padding(4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(307, 26);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "Pulso Modulado (PWM Simulado)";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.Control;
            panel9.Controls.Add(label12);
            panel9.Controls.Add(radioButton2);
            panel9.Location = new Point(30, 300);
            panel9.Margin = new Padding(4);
            panel9.Name = "panel9";
            panel9.Size = new Size(428, 66);
            panel9.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Roboto", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(36, 32);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(321, 18);
            label12.TabIndex = 18;
            label12.Text = "Enciende por N ms y detiene automáticamente";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Roboto Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(11, 9);
            radioButton2.Margin = new Padding(4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(285, 26);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "Temporizado Único (One-Shot)";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.Control;
            panel8.Controls.Add(label11);
            panel8.Controls.Add(radioButton1);
            panel8.Location = new Point(30, 226);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(428, 66);
            panel8.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Roboto", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(36, 32);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(321, 18);
            label11.TabIndex = 18;
            label11.Text = "Alterna HIGH/LOW en cada evento timer1_Tick";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Roboto Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(11, 9);
            radioButton1.Margin = new Padding(4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(259, 26);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Parpadeo Constante (Blink)";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ControlDarkDark;
            button4.Location = new Point(356, 176);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(100, 38);
            button4.TabIndex = 16;
            button4.Text = "2000ms";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ControlDarkDark;
            button3.Location = new Point(249, 176);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(100, 38);
            button3.TabIndex = 15;
            button3.Text = "1000ms";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(141, 176);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(100, 38);
            button2.TabIndex = 14;
            button2.Text = "500ms";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(34, 176);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(100, 38);
            button1.TabIndex = 13;
            button1.Text = "250ms";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Roboto", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(30, 142);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(141, 18);
            label10.TabIndex = 12;
            label10.Text = "Preajustes Rápidos:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = SystemColors.Control;
            numericUpDown1.BorderStyle = BorderStyle.None;
            numericUpDown1.Location = new Point(30, 92);
            numericUpDown1.Margin = new Padding(4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(432, 27);
            numericUpDown1.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(24, 61);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(361, 18);
            label9.TabIndex = 3;
            label9.Text = "Intervalo del Timer (timer1.Interval en milisegundos):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.PaleGreen;
            label8.Font = new Font("Roboto", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(290, 21);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(160, 18);
            label8.TabIndex = 8;
            label8.Text = "• Timer1.Enable = True";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(50, 18);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(205, 22);
            label7.TabIndex = 6;
            label7.Text = "Configuración del Timer";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.cronografo__1_;
            pictureBox5.Location = new Point(15, 12);
            pictureBox5.Margin = new Padding(4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(button7);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(label16);
            panel4.Location = new Point(619, 710);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(480, 110);
            panel4.TabIndex = 5;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Roboto", 9F);
            button7.ForeColor = Color.Red;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(249, 48);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(195, 38);
            button7.TabIndex = 24;
            button7.Text = "Detener";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.MenuHighlight;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Roboto", 9F);
            button6.ForeColor = Color.White;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(30, 48);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(194, 38);
            button6.TabIndex = 23;
            button6.Text = "Iniciar";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Roboto", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ControlDarkDark;
            label16.Location = new Point(15, 14);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(148, 18);
            label16.TabIndex = 22;
            label16.Text = "Control de Ejecución";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(panel12);
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(15, 528);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(566, 292);
            panel5.TabIndex = 6;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.Control;
            panel12.Controls.Add(label18);
            panel12.Controls.Add(label17);
            panel12.Controls.Add(chart1);
            panel12.Location = new Point(20, 59);
            panel12.Margin = new Padding(4);
            panel12.Name = "panel12";
            panel12.Size = new Size(528, 209);
            panel12.TabIndex = 7;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Roboto", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.ControlDarkDark;
            label18.Location = new Point(404, 171);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(83, 18);
            label18.TabIndex = 23;
            label18.Text = "LOW (0.0V)";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Roboto", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.ControlDarkDark;
            label17.Location = new Point(21, 171);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(85, 18);
            label17.TabIndex = 22;
            label17.Text = "HIGH (+5V)";
            // 
            // chart1
            // 
            chart1.BackColor = SystemColors.Control;
            chart1.BorderlineColor = SystemColors.Window;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LineColor = Color.Transparent;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Interval = 2.5D;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.LineColor = Color.Transparent;
            chartArea1.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Maximum = 5D;
            chartArea1.AxisY.Minimum = -0.5D;
            chartArea1.BackColor = SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Location = new Point(21, 19);
            chart1.Margin = new Padding(4);
            chart1.Name = "chart1";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(489, 130);
            chart1.TabIndex = 6;
            chart1.Text = "chart1";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.aumentar__1_;
            pictureBox4.Location = new Point(11, 11);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(46, 18);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(345, 22);
            label4.TabIndex = 3;
            label4.Text = "Oscilograma de Señal Lógica (Tick Event)";
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 849);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            Text = "LED Timer Controller v1.0";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Panel panel6;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label6;
        private Panel panel7;
        private PictureBox pictureBox4;
        private Label label7;
        private PictureBox pictureBox5;
        private Label label8;
        private NumericUpDown numericUpDown1;
        private Label label9;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label10;
        private Panel panel8;
        private RadioButton radioButton1;
        private Panel panel11;
        private PictureBox pictureBox6;
        private Panel panel10;
        private Label label13;
        private RadioButton radioButton3;
        private Panel panel9;
        private Label label12;
        private RadioButton radioButton2;
        private Label label11;
        private Button button5;
        private Label label15;
        private Label label14;
        private Button button7;
        private Button button6;
        private Label label16;
        private Panel panel12;
        private Label label18;
        private Label label17;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
    }
}
