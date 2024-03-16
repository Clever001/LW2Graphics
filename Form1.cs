using System.Security.Permissions;

namespace LW2Graphics
{
    public partial class Form1 : Form
    {
        private readonly Control[] visibleObjects;
        private Bitmap bitmap;
        private Pen pen;
        private Point[] picturePoints;
        private Point center;
        private bool centerPosition; // ������������ ������� (True - �� ������; False - ������������)

        public Form1()
        {
            InitializeComponent();

            visibleObjects = [startLabel, inputLabel1, inputLabel2, input1, input2, applyButton];
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = bitmap;
            pen = new Pen(Brushes.Black, 5);
            center = new Point(pictureBox.Width / 2, pictureBox.Height / 2);
            picturePoints = [new(center.X - 100, center.Y - 200),
                             new(center.X + 100, center.Y - 200),
                             new(center.X + 200, center.Y),
                             new(center.X + 100, center.Y + 200),
                             new(center.X - 100, center.Y + 200),
                             new(center.X - 200, center.Y)];
            centerPosition = true;
            DrawFigure();
        }

        private void DrawFigure()
        {
            using Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            for (int i = 0; i != picturePoints.Length; i++)
            {
                if (i + 1 != picturePoints.Length) // ����� � �������� i �� ��������� � �������
                {
                    g.DrawLine(pen, picturePoints[i], picturePoints[i + 1]);
                }
                else
                {
                    g.DrawLine(pen, picturePoints[0], picturePoints[i]);
                }
            }
            if (center.X >= 0 && center.Y >= 0)
                bitmap.SetPixel(center.X, center.Y, Color.Red);
            g.Flush();
            pictureBox.Invalidate();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            ChangeBitmapSize(centerPosition);
        }

        private void ChangeBitmapSize(bool centerPos)
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = bitmap;
            if (centerPos)
            {
                Point newCenter = new Point(pictureBox.Width / 2, pictureBox.Height / 2);
                int dx = newCenter.X - center.X, dy = newCenter.Y - center.Y;
                for (int i = 0; i != picturePoints.Length; i++)
                {
                    picturePoints[i].X += dx;
                    picturePoints[i].Y += dy;
                }
                center = newCenter;
            }
            DrawFigure();
        }

        private void ChangePositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeInvisible(); // ������� ������ ��� ������� ����������. ����� ��������� �����������.

            inputLabel1.Visible = true;
            inputLabel2.Visible = true;
            input1.Visible = true;
            input2.Visible = true;
            applyButton.Visible = true;
            inputLabel1.Text = "�� ������� �� ������ �������� x?";
            inputLabel2.Text = "�� ������� �� ������ �������� y?";
        }

        private void FlipObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeInvisible();

            inputLabel1.Visible = true;
            input1.Visible = true;
            applyButton.Visible = true;
            inputLabel1.Text = "������� ���� �������� (� ��������)";
        }

        private void MakeInvisible() => Array.ForEach(visibleObjects, item => item.Visible = false);

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            int dx, dy;
            if (!int.TryParse(input1.Text, out dx) || !int.TryParse(input2.Text, out dy))
            {
                MessageBox.Show("�� ���������� ���������� ������� ������.", "ERROR");
                return;
            }
            if (centerPosition)
            {
                MessageBox.Show("�������� ������������ ������� �� �������� \"������������\"", "ERROR");
                return;
            }
            center.X += dx; center.Y += dy;
            for (int i = 0; i != picturePoints.Length; i++)
            {
                picturePoints[i].X += dx;
                picturePoints[i].Y += dy;
            }
            DrawFigure();
        }

        private void placeObjectButton_Click(object sender, EventArgs e)
        {
            centerPosition = !centerPosition;
            if (centerPosition)
            {
                placeObjectButton.Text = "�� ������";
                placeObjectButton.BackColor = Color.FromArgb(0, 192, 0);
                placeObjectButton.ForeColor = Color.FromArgb(128, 255, 128);
            }
            else
            {
                placeObjectButton.Text = "������������";
                placeObjectButton.BackColor = Color.FromArgb(192, 0, 0);
                placeObjectButton.ForeColor = Color.FromArgb(255, 128, 128);
            }
            ChangeBitmapSize(centerPosition);
        }

        
    }
}
