using System;
using System.Drawing;
using System.Windows.Forms;

namespace Life
{
    public partial class MainForm : Form
    {
        private Graphics graphics;
        private GameEngine engine;
        private int generation;

        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                return;

            generation = 0;

            resolutionNum.Enabled = false;
            densityNum.Enabled = false;

            engine = new GameEngine(image.Width, image.Height, (int) resolutionNum.Value, 
                (int) (densityNum.Maximum + densityNum.Minimum - densityNum.Value));
            engine.StartGame();

            image.Image = new Bitmap(image.Width, image.Height);
            graphics = Graphics.FromImage(image.Image);
            
            DrawNextGeneration();

            timer.Start();
        }

        private void DrawNextGeneration()
        {
            graphics.Clear(Color.Black);

            var field = engine.GetField;

            for (int i = 0; i < engine.Rows; i++)
            {
                for (int j = 0; j < engine.Cols; j++)
                {
                    if (field[i, j])
                        graphics.FillRectangle(Brushes.White,
                            j * engine.Resolution, i * engine.Resolution,
                            engine.Resolution, engine.Resolution);
                }
            }

            image.Refresh();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            engine.NextGeneration();
            DrawNextGeneration();
            generation++;
            Text = $"Current generation: {generation}";
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
                return;

            resolutionNum.Enabled = true;
            densityNum.Enabled = true;

            timer.Stop();
        }

        private void image_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var col = e.Location.X / engine.Resolution;
                var row = e.Location.Y / engine.Resolution;

                if (Validator(col, row))
                    engine.AddCell(row, col);
            }
            if (e.Button == MouseButtons.Right)
            {
                var col = e.Location.X / engine.Resolution;
                var row = e.Location.Y / engine.Resolution;

                if (Validator(col, row))
                    engine.RemoveCell(row, col);
            }
        }

        private bool Validator(int x, int y)
        {
            return x >= 0 && y >= 0 && 
                   x < image.Width / engine.Resolution && y < image.Height / engine.Resolution;
        }
    }
}
