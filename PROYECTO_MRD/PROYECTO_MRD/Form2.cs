using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_MRD
{
    public partial class Form2 : Form
    {
        int puntaje;
        int indicePregunta = 0;
        List<Pregunta> bancoPreguntas = new List<Pregunta>();
        Random rnd = new Random();

        void MostrarPregunta()
        {
            var p = bancoPreguntas[indicePregunta];

            lblP1.Text = p.Texto;

            btnAP1.Text = p.Opciones[0];
            btnBP1.Text = p.Opciones[1];
            btnCP1.Text = p.Opciones[2];
            btnDP1.Text = p.Opciones[3];
        }
        void VerificarRespuesta(int opcionSeleccionada)
        {
            var p = bancoPreguntas[indicePregunta];

            if (opcionSeleccionada == p.Correcta)
            {
                puntaje++;
                MessageBox.Show("Correcto");
            }
            else
            {
                string correctaTexto = p.Opciones[p.Correcta];
                MessageBox.Show("Incorrecto.\nLa respuesta correcta es: " + correctaTexto);
            }

            indicePregunta++;

            if (indicePregunta < bancoPreguntas.Count)
            {
                MostrarPregunta();
            }
            else
            {
                MessageBox.Show("Juego terminado. Puntaje: " + puntaje + "/10");
                Form1 llamar = new Form1();
                llamar.Show();
                this.Hide();
            }
        }
        class Pregunta
        {
            public string Texto;
            public string[] Opciones;
            public int Correcta;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué es una matriz en álgebra lineal?",
                Opciones = new string[] { "Un número", "Un arreglo de números", "Una función", "Un vector" },
                Correcta = 1
            });

            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué unidad mide la corriente eléctrica?",
                Opciones = new string[] { "Voltios", "Ohmios", "Amperios", "Watts" },
                Correcta = 2
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "Si lanzas una moneda equilibrada, \n¿cuál es la probabilidad de obtener cara?",
                Opciones = new string[] { "1", "1/2", "1/3", "2" },
                Correcta = 1
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Cuál es el propósito principal de \nuna integral definida?",
                Opciones = new string[] { "Calcular la pendiente de una función", "Encontrar raíces cuadradas", "Resolver ecuaciones lineales", "Encontrar el área bajo una curva en un intervalo" },
                Correcta = 3
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué representa el determinante\n de una matriz?",
                Opciones = new string[] { "La suma de sus elementos", "Un valor que la matriz indica si tiene inversa", "El número de filas", "El número de colmunas" },
                Correcta = 1
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Cuándo una matriz tiene \ninversa?",
                Opciones = new string[] { "Cuando su determinante es 0", "Cuando es cuadrada y su determinante ≠ 0", "Siempre", "Cuando tiene más filas que columnas" },
                Correcta = 1
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué es un vector?",
                Opciones = new string[] { "Un número entero", "Una matriz cuadrada", "Un arreglo de elementos con magnitud y dirección", "Una función" },
                Correcta = 2
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué operación combina filas de matrices?",
                Opciones = new string[] { "Multiplicación escalar", "Suma de matrices", "Producto cruz", "Derivación" },
                Correcta = 1
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué significa que dos vectores \nsean ortogonales?",
                Opciones = new string[] { "Que son iguales", "Que tienen la misma magnitud", "Que son paralelos", "Que su producto punto es 0" },
                Correcta = 3
            });
            bancoPreguntas.Add(new Pregunta
            {
                Texto = "¿Qué ley relaciona voltaje, \ncorriente y resistencia?",
                Opciones = new string[] { "Ley de Faraday", "Ley de Ohm", "Ley de Coulomb", "Ley de Gauss" },
                Correcta = 1
            });

            bancoPreguntas = bancoPreguntas.OrderBy(x => rnd.Next()).ToList();
            MostrarPregunta();
        }

        private void btnSalirMamahuevo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAP1_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(0);
        }

        private void btnBP1_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(1);
        }

        private void btnCP1_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(2);
        }

        private void btnDP1_Click(object sender, EventArgs e)
        {
            VerificarRespuesta(3);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 llamar = new Form1();
            llamar.Show();
            this.Hide();
        }
    }
}
