using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OchoReinasAlexisLapo
{
    public partial class Problema8Reinas : Form
    {
        private int numeroReinas = 8;
        private int celdaSize = 40; // Tamaño de cada celda en el tablero
        private int[,] tablero;
        PictureBox[,] P;

        public Problema8Reinas()
        {
            InitializeComponent();
        }

        private void Problema8Reinas_Load(object sender, EventArgs e)
        {
            pictureBox2.Parent = pictureBox1; // Establece pictureBox1 como el control principal que se encuentra debajo de pictureBox2
            pictureBox2.BackColor = Color.Transparent; // Hace que el fondo de pictureBox2 sea transparente
            pictureBox2.Location = new Point(0, 0); // Asegura que pictureBox2 se coloque en la misma posición que pictureBox1
            Bitmap emptyBoardImage = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Image = emptyBoardImage;
        }

        bool estanAtacandose(int x1, int y1, int x2, int y2)
        {
            // 1. Horizontal y vertical
            // Las reinas se atacan si coinciden en cualquiera de los dos parámetros
            if ((x1 == x2) || (y1 == y2)) return true;

            // 2. Diagonal principal
            int tx, ty; // variables adicionales

            // 2.1. Izquierda-Arriba
            tx = x1 - 1; ty = y1 - 1;
            while ((tx >= 1) && (ty >= 1))
            {
                if ((tx == x2) && (ty == y2)) return true;
                tx--; ty--;
            }

            // 2.2. Derecha-Abajo
            tx = x1 + 1; ty = y1 + 1;
            while ((tx <= numeroReinas) && (ty <= numeroReinas))
            {
                if ((tx == x2) && (ty == y2)) return true;
                tx++; ty++;
            }

            // 3. Diagonal adicional
            // 3.1. Derecha-Arriba
            tx = x1 + 1; ty = y1 - 1;
            while ((tx <= numeroReinas) && (ty >= 1))
            {
                if ((tx == x2) && (ty == y2)) return true;
                tx++; ty--;
            }

            // 3.2. Izquierda-Abajo
            tx = x1 - 1; ty = y1 + 1;
            while ((tx >= 1) && (ty <= numeroReinas))
            {
                if ((tx == x2) && (ty == y2)) return true;
                tx--; ty++;
            }
            return false;
        }
        bool estaAtacando(int[] tablero, int posicion)
        {
            int posicionX, posicionY, x, y;
            int i;

            posicionX = tablero[posicion];
            posicionY = posicion;

            for (i = 1; i <= posicion - 1; i++)
            {
                x = tablero[i];
                y = i;
                if (estanAtacandose(x, y, posicionX, posicionY))
                    return true;
            }
            return false;
        }

        //DATAGRIEW

        void InicializarDataGridView(int N)
        {
            dataGridView1.Columns.Clear();
            for (int i = 1; i <= N; i++)
            {
                dataGridView1.Columns.Add("i" + i.ToString(), i.ToString());
                dataGridView1.Columns[i - 1].Width = 30;
            }
            dataGridView1.Rows.Add(N);
            for (int i = 0; i < N; i++)
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void LimpiarDataGridView()
        {
            for (int i = 0; i < numeroReinas; i++)
            {
                for (int j = 0; j < numeroReinas; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = "";
                }
            }
        }

        void AgregarAListBox(int[] M, int N)
        {
            string s = "";
            for (int i = 1; i <= N; i++)
                s += M[i].ToString() + "," + i.ToString() + "-";
            listaColocacionesListBox.Items.Add(s);
        }
        //INTERACIONES
        private void listBox1_Click(object sender, EventArgs e)
        {
            accionesListBox();
        }

        private void listBox1_KeyUp(object sender, KeyEventArgs e)
        {
            accionesListBox();
        }
        private void accionesListBox()
        {
            if (listaColocacionesListBox.Items.Count <= 0) return;
            int num = listaColocacionesListBox.SelectedIndex;
            if (num < 0) return; // No se seleccionó ningún elemento
            string s = listaColocacionesListBox.Items[num].ToString();
            mostrarenDataPicture(s, numeroReinas);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            const int MaxN = 20;
            int[] M = new int[MaxN]; // el arreglo de colocaciones
            int p; // número de reina
            int k; // número de opciones de colocación

            // Obtener el número de reinas
            numeroReinas = Convert.ToInt32(numeroReinasTextBox.Text);

            // Generar la imagen del tablero
            Bitmap boardImage = GenerateBoardImage(pictureBox1.Size, numeroReinas);

            // Establecer la imagen del tablero en el PictureBox
            pictureBox1.Image = boardImage;

            // Inicializar dataGridView1
            InicializarDataGridView(numeroReinas);

            // Limpiar listBox1
            listaColocacionesListBox.Items.Clear();

            // ALGORITMO PARA GENERAR COLOCACIONES
            // configuraciones iniciales
            p = 1;
            M[p] = 0;
            M[0] = 0;
            k = 0;

            // el ciclo de búsqueda de colocaciones
            while (p > 0) // si p==0, entonces salir del bucle
            {
                M[p] = M[p] + 1;
                if (p == numeroReinas) // último ítem
                {
                    if (M[p] > numeroReinas)
                    {
                        while (M[p] > numeroReinas) p--; // rebobinar
                    }
                    else
                    {
                        if (!estaAtacando(M, p))
                        {
                            // fijar la colocación
                            AgregarAListBox(M, numeroReinas);
                            k++;
                            p--;
                        }
                    }
                }
                else // no es el último ítem
                {
                    if (M[p] > numeroReinas)
                    {
                        while (M[p] > numeroReinas) p--; // rebobinar
                    }
                    else
                    {
                        if (!estaAtacando(M, p)) // Si M[p] no se superpone con M[1], M[2], ..., M[p-1]
                        {
                            p++; // avanzar a la colocación de la siguiente reina
                            M[p] = 0;
                        }
                    }
                }
            }

            // mostrar el número de opciones de colocación
            if (k > 0)
            {
                listaColocacionesListBox.SelectedIndex = 0;
                listBox1_Click(sender, e);
                label2.Text = "Número de colocaciones = " + k.ToString();
            }
        }

        // Picture Box 

        private Bitmap GenerateBoardImage(Size pictureBoxSize, int n)
        {
            int boardSize = Math.Min(pictureBoxSize.Width, pictureBoxSize.Height);
            int cellSize = boardSize / n;

            Bitmap boardImage = new Bitmap(boardSize, boardSize);

            using (Graphics g = Graphics.FromImage(boardImage))
            {
                Color[] colors = new Color[] { Color.White, Color.Black };

                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0) { colors[0] = Color.White; colors[1] = Color.Black; }
                    else { colors[0] = Color.Black; colors[1] = Color.White; }

                    for (int j = 0; j < n; j++)
                    {
                        Brush squareBrush = new SolidBrush(colors[j % 2]);
                        g.FillRectangle(squareBrush, j * cellSize, i * cellSize, cellSize, cellSize);
                    }
                }
            }

            return boardImage;
        }

        private void MostrarEnPictureBox2(int x, int y)
        {
            int cellSize = pictureBox2.Width / numeroReinas;
            using (Graphics g = Graphics.FromImage(pictureBox2.Image))
            {
                Font font = new Font("Arial", cellSize / 2, FontStyle.Bold);
                Brush textBrush = new SolidBrush(Color.Red);
                g.DrawString("X", font, textBrush, x * cellSize, y * cellSize);
                pictureBox2.Refresh();
            }
        }
        private void LimpiarPictureBox2()
        {
            using (Graphics g = Graphics.FromImage(pictureBox2.Image))
            {
                g.Clear(Color.Transparent);
                pictureBox2.Refresh();
            }
        }

        private void mostrarenDataPicture(string datos, int N)
        {
            LimpiarPictureBox2();
            LimpiarDataGridView();
            int j = 0;
            for (int i = 0; i < N; i++)
            {

                string xs = "";
                while (datos[j] != ',')
                {
                    xs += datos[j].ToString();
                    j++;
                }
                j++;
                string ys = "";
                while (datos[j] != '-')
                {
                    ys += datos[j].ToString();
                    j++;
                }
                j++;
                int x = Convert.ToInt32(xs);
                int y = Convert.ToInt32(ys);
                dataGridView1.Rows[y - 1].Cells[x - 1].Value = "X";
                MostrarEnPictureBox2(x - 1, y - 1);
            }
        }
    }
}