using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rasted
{
    public partial class FormRasted : Form
    {
        string[] rbName = { "Карандаш", "Линия", "Прямоугольник", "Окружность", "Ломаная", "Безье", "Закрашенный прямоугольник", "Стерка", "Текст", "Картинка" };
        int countMode;              //Число режимов       
        string mode = "Карандаш";       //Текущий режим
        string[] objectsName = Directory.GetFiles("images");    //Имена картинок = имена файлов
        bool drag = false;
        int x0, y0, x, y;
        PictureBox picObject;
        Bitmap bitObject, bitBase, bitBuffer;
        Graphics grBitBase, grBitBuffer, grPbDraw;
        RadioButton[] rbArr;  
        Pen pen;
        TrackBar tbPenWidth;

        public FormRasted()
        {
            InitializeComponent();
        }

        private void FormRasted_Load(object sender, EventArgs e)
        {
            openFileDialog.Filter = saveFileDialog.Filter = "JPG|*.jpg|PNG|*.png";
            countMode = rbName.Length;          //Число режимов=размер массива названий
            rbArr = new RadioButton[countMode];     //Выделить память под массив компонент
            for (int i = 0; i < rbArr.Length; i++)      //Для каждого компонента выполнить
            {
                rbArr[i] = new RadioButton
                {
                    Text = rbName[i],          //Задать свойства
                    Appearance = Appearance.Button,
                    AutoCheck = true
                };
                rbArr[i].Click += RadioButton_Click; //У все реакция на общее событие
            }
            this.flowLayoutPanel.Controls.AddRange(rbArr); //Добавить все на панель-родитель
            rbArr[0].Checked = true;                //Выбрать первый режим активным
            tbPenWidth = new TrackBar { Minimum = 1, Maximum = 5 };
            this.flowLayoutPanel.Controls.Add(tbPenWidth);
            tbPenWidth.ValueChanged += TrackBarPenWidth_ValueChanged;
            picObject = new PictureBox              //Динамическая картинка на панели FlowLayoutPanel
            {
                Width = 100,
                Height = 100,
                SizeMode = PictureBoxSizeMode.Zoom,
                Visible = false
            };
            this.flowLayoutPanel.Controls.Add(picObject);  //Добавить на панель-родитель
                                                            //Настраиваем панель ToolStrip
            this.toolStripComboBox.Items.AddRange(objectsName);   //CombpoBox с названиями картинок
            this.toolStripComboBox.Text = toolStripComboBox.Items[0].ToString();
            //Настраиваем панель StatusStrip
            this.toolStripStatusLabelMode.Text = mode;	//Вывести название активного режима
            bitBase = new Bitmap(pictureBoxDraw.Width, pictureBoxDraw.Height);
            grBitBase = Graphics.FromImage(bitBase);
            bitBuffer = new Bitmap(pictureBoxDraw.Width, pictureBoxDraw.Height);
            grBitBuffer = Graphics.FromImage(bitBuffer);
            //grPbDraw = pictureBoxDraw.CreateGraphics();
            pictureBoxDraw.Invalidate();
            pen = new Pen(Color.Black, tbPenWidth.Value);
            toolStripStatusLabelDateTime.Text = DateTime.Now.ToString();
            timer.Enabled = true;
        }
        private void RadioButton_Click(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            mode = rb.Text;
            this.toolStripStatusLabelMode.Text = mode;
            this.toolStripComboBox.Visible = false;
            this.toolStripTextBoxText.Visible = false;
            this.picObject.Visible = false;
            if (mode == "Картинка")
            {
                this.toolStripComboBox.Visible = true;
                bitObject = new Bitmap(toolStripComboBox.Text);
                picObject.Image = bitObject;
                picObject.Visible = true;

            }
            if (mode == "Текст")
            {
                this.toolStripTextBoxText.Visible = true;
            }
        }

        private void TrackBarPenWidth_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = tbPenWidth.Value;
        }

        //*********Выбор картинки из списка картинок
        private void ToolStripComboBoxPicture_SelectedIndexChanged(object sender, EventArgs e)
        {
            bitObject = new Bitmap(toolStripComboBox.Text);
            picObject.Image = bitObject;
        }

        private void ToolStripMenuItemOpenFile_Click(object sender, EventArgs e)
        {
            Bitmap bit;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bit = new Bitmap(openFileDialog.FileName);
                grBitBase.DrawImage(bit, 0, 0);
                pictureBoxDraw.Invalidate();
            }
        }

        private void ToolStripMenuItemSaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                bitBase.Save(saveFileDialog.FileName);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelDateTime.Text = DateTime.Now.ToString();
        }

        private void ToolStripMenuItemClear_Click(object sender, EventArgs e)
        {
            pictureBoxDraw.Image = null;
            grBitBase.Clear(Color.White);
            grBitBuffer.Clear(Color.White);
        }

        private void ToolStripButtonColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.toolStripButtonColor.BackColor = pen.Color = cd.Color;
            }
                

        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBoxDraw_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            
            toolStripStatusLabelLocation.Text = $"X: {x}; Y: {y}";

            if (drag)
            {
                grBitBuffer.Clear(Color.FromArgb(0, 0, 0, 0));
                switch (mode)
                {
                    case "Карандаш":
                        pen.StartCap = LineCap.Round;
                        pen.EndCap = LineCap.Round;
                        grBitBase.DrawLine(pen, x, y, x + 1, y + 1);
                        break;
                    case "Линия":
                        grBitBuffer.DrawLine(pen, x0, y0, x, y);
                        break;
                    default:
                        break;
                }
                pictureBoxDraw.Invalidate();
            }            
        }

        private void PictureBoxDraw_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            x0 = e.X;
            y0 = e.Y;          
        }

        private void PictureBoxDraw_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
            grBitBase.DrawImage(bitBuffer, 0, 0);
        }

        private void PictureBoxDraw_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitBase, 0, 0);
            if (drag)
            {
                e.Graphics.DrawImage(bitBuffer, 0, 0);
            }
        }


    }
}
