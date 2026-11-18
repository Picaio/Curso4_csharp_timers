using System;
using System.Drawing;
using System.Windows.Forms;

namespace LedTick
{
    public partial class Form1 : Form
    {
      

        private enum ModoLed { Blink, OneShot, Pwm }

        double VoltajeHigh = 5.0;
        double VoltajeLow = 0.0;
        int IntervaloPwmMs = 50;
        int VentanaEjeX = 10;
        int MaxPuntosGrafica = 24;

        


        private static readonly bool[] PatronRafaga =
        {
            true, false, true, false, true, false, false, false, false, false
        };


        private readonly Image imagenLedOn = Properties.Resources.led__4_;
        private readonly Image imagenLedOff = Properties.Resources.led__3_;

        private ModoLed modoActual = ModoLed.Blink;
        private bool estadoLed = false;
        private int contadorTicks = 0;
        private double tiempoX = 0; // Avance en el eje X del oscilograma
        private int intervaloAntesDePwm = 500;


        public Form1()
        {
            InitializeComponent();

            numericUpDown1.Minimum = 50;
            numericUpDown1.Maximum = 5000;
            numericUpDown1.Value = 500;
            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;

            radioButton1.Checked = true; // Por defecto: Parpadeo Constante (Blink)
            label17.Text = $"HIGH (+{VoltajeHigh:0.##}V)";

            ActualizarInterfazVisual();
            ActualizarEstadoTimer();
            ConfigurarGraficoInicial();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            contadorTicks++;
            label15.Text = contadorTicks.ToString();

            switch (modoActual)
            {
                case ModoLed.Blink:
                    CambiarEstadoLed(!estadoLed);
                    break;

                case ModoLed.OneShot:
                    // El LED se encendió al pulsar Iniciar; aquí ya pasaron los N ms.
                    CambiarEstadoLed(false);
                    DetenerTimer();
                    break;

                case ModoLed.Pwm:
                    CambiarEstadoLed(PatronRafaga[(contadorTicks - 1) % PatronRafaga.Length]);
                    break;
            }
        }

        private void IniciarTimer()
        {
            if (modoActual == ModoLed.OneShot)
            {
                CambiarEstadoLed(true);
            }

            timer1.Start();
            ActualizarEstadoTimer();
        }

        private void DetenerTimer()
        {
            timer1.Stop();
            ActualizarEstadoTimer();
        }




        private void SeleccionarModo(RadioButton seleccionado, ModoLed nuevoModo)
        {
            if (!seleccionado.Checked)
            {
                return;
            }

            foreach (RadioButton radio in new[] { radioButton1, radioButton2, radioButton3 })
            {
                if (radio != seleccionado)
                {
                    radio.Checked = false;
                }
            }

            if (nuevoModo == modoActual)
            {
                return;
            }

            // Cada modo arranca limpio: timer detenido y LED apagado.
            DetenerTimer();
            if (estadoLed)
            {
                CambiarEstadoLed(false);
            }

            if (nuevoModo == ModoLed.Pwm)
            {
                intervaloAntesDePwm = (int)numericUpDown1.Value;
                AsignarIntervalo(IntervaloPwmMs);
            }
            else if (modoActual == ModoLed.Pwm)
            {
                AsignarIntervalo(intervaloAntesDePwm);
            }

            modoActual = nuevoModo;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SeleccionarModo(radioButton1, ModoLed.Blink);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SeleccionarModo(radioButton2, ModoLed.OneShot);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SeleccionarModo(radioButton3, ModoLed.Pwm);
        }

   

        private void AsignarIntervalo(int milisegundos)
        {
            // El evento ValueChanged actualiza timer1.Interval.
            numericUpDown1.Value = milisegundos;
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AsignarIntervalo(250);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AsignarIntervalo(500);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AsignarIntervalo(1000);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AsignarIntervalo(2000);
        }

    

        // Iniciar
        private void button6_Click(object sender, EventArgs e)
        {
            IniciarTimer();
        }

        // Detener
        private void button7_Click(object sender, EventArgs e)
        {
            DetenerTimer();

            // Un pulso One-Shot interrumpido no debe dejar el LED encendido.
            if (modoActual == ModoLed.OneShot && estadoLed)
            {
                CambiarEstadoLed(false);
            }
        }

        // Reiniciar
        private void button5_Click(object sender, EventArgs e)
        {
            DetenerTimer();

            contadorTicks = 0;
            tiempoX = 0;
            estadoLed = false;
            label15.Text = "0";

            ActualizarInterfazVisual();
            ConfigurarGraficoInicial();
        }

       
        private void CambiarEstadoLed(bool encendido)
        {
            estadoLed = encendido;
            ActualizarInterfazVisual();
            AgregarPuntoGrafica(encendido);
        }

        private void ActualizarInterfazVisual()
        {
            if (estadoLed)
            {
                label6.Text = "• ESTADO: ON";
                label6.ForeColor = Color.ForestGreen;
                label5.Text = $"• VOUT: +{VoltajeHigh:0.##} V";
                pictureBox3.Image = imagenLedOn;
            }
            else
            {
                label6.Text = "• ESTADO: OFF";
                label6.ForeColor = Color.DimGray;
                label5.Text = $"• VOUT: {VoltajeLow:0.00} V";
                pictureBox3.Image = imagenLedOff;
            }
        }

        private void ActualizarEstadoTimer()
        {
            bool activo = timer1.Enabled;

            label8.Text = $"• Timer1.Enabled = {activo}";
            label8.BackColor = activo ? Color.PaleGreen : Color.MistyRose;
            label8.ForeColor = activo ? Color.ForestGreen : Color.Red;

            button6.Enabled = !activo;
            button7.Enabled = activo;
        }



        private void ConfigurarGraficoInicial()
        {
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series1"].Points.AddXY(0, VoltajeLow);

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = VentanaEjeX;

            // Margen para que la línea en HIGH no se recorte en el borde superior.
            chart1.ChartAreas[0].AxisY.Maximum = VoltajeHigh + 0.5;
        }

        private void AgregarPuntoGrafica(bool encendido)
        {
            double valorY = encendido ? VoltajeHigh : VoltajeLow;
            var puntos = chart1.Series["Series1"].Points;

            // Dos puntos por tick para dibujar la onda cuadrada con StepLine.
            puntos.AddXY(tiempoX, valorY);
            tiempoX += 1.0;
            puntos.AddXY(tiempoX, valorY);

            // Sin este límite la serie crecería mientras el programa siga corriendo.
            while (puntos.Count > MaxPuntosGrafica)
            {
                puntos.RemoveAt(0);
            }

            bool ventanaLlena = tiempoX > VentanaEjeX;
            chart1.ChartAreas[0].AxisX.Minimum = ventanaLlena ? tiempoX - VentanaEjeX : 0;
            chart1.ChartAreas[0].AxisX.Maximum = ventanaLlena ? tiempoX : VentanaEjeX;

            chart1.Invalidate();
        }

    }

}