using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filters
{
    public partial class Form1 : Form
    {
        private Bitmap _image;

        private Stack<Bitmap> _history = new Stack<Bitmap>();

        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _image = new Bitmap(dialog.FileName);

                pictureBox1.Image = _image;
                pictureBox1.Refresh();
            }
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new InvertFilter());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e.Argument is string chain && chain == "glowingEdges")
            {
                Bitmap sourceImage = (Bitmap)pictureBox1.Image;

                Bitmap medianImage = new MedianFilter(3).ProcessImage(sourceImage, backgroundWorker1, 0, 33);
                if (backgroundWorker1.CancellationPending)
                    return;

                Bitmap edgeImage = new SobelFilter().ProcessImage(medianImage, backgroundWorker1, 33, 33);
                if (backgroundWorker1.CancellationPending)
                    return;

                Bitmap glowingEdges = new MaxFilter(3).ProcessImage(edgeImage, backgroundWorker1, 66, 34);
                if (backgroundWorker1.CancellationPending)
                    return;

                _image = glowingEdges;
            }
            else if (e.Argument is Filters filter)
            {
                Bitmap newImg = filter.ProcessImage(_image, backgroundWorker1, 0, 100);
                if (!backgroundWorker1.CancellationPending)
                    _image = newImg;
            }
        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = _image;
                pictureBox1.Refresh();
            }

            progressBar1.Value = 0;
        }

        private void обычноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new BlurFilter());
        }

        private void гауссToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new GaussianFilter());
        }

        private void оттенкиСерогоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new GrayScaleFilter());
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new SepiyaFilter());
        }

        private void повышениеЯркостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new BrightnessFilter());
        }

        private void собеляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new SobelFilter());
        }

        private void повышениеРезкостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new SharpnessFilter());
        }

        private void тиснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new EmbossFilter());
        }

        private void переносToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new MoveFilter());
        }

        private void поворотНа90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new RotateFilter(Math.PI / 2));
        }

        private void поворотНа180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new RotateFilter(Math.PI));
        }


        private void волны1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Wave1Filter());
        }

        private void волны2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Wave2Filter());
        }

        private void стеклоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new GlassFilter());
        }

        private void размытиеВДвиженииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new MotionBlurFilter());
        }

        private void резкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Sharpness2Filter());
        }

        private void щарраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new SharraFilter());
        }

        private void прюиттаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFilter(new PruittaFilter());
        }

        private void светящиесяКраяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync("glowingEdges");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
            saveDialog.Title = "Сохранить изображение как...";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveDialog.FileName).ToLower();
                System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;

                if (ext == ".jpg" || ext == ".jpeg")
                    format = System.Drawing.Imaging.ImageFormat.Jpeg;
                else if (ext == ".bmp")
                    format = System.Drawing.Imaging.ImageFormat.Bmp;

                try
                {
                    if (saveDialog.FileName != null) _image.Save(saveDialog.FileName, format);
                    MessageBox.Show("Изображение сохранено успешно.", "Сохранение", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении изображения: " + ex.Message, "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void ApplyFilter(Filters filter)
        {
            if (_image != null)
            {
                _history.Push((Bitmap)_image.Clone());
            }

            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_history.Count > 0)
            {
                _image = _history.Pop();
                pictureBox1.Image = _image;
                pictureBox1.Refresh();
            }
            else
            {
                MessageBox.Show("Нет предыдущего состояния!", "Информация", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}