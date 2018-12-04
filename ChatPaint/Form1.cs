using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChatPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            lst = new List<Figure>();
        }
        Color cl;
        List<Figure> lst;
        Graphics g;
        Creator creator;

        static string userName;
        private const string host = "127.0.0.1";
        private const int port = 8888;
        static TcpClient client;
        static NetworkStream stream;


        private void CrCircle_Click(object sender, EventArgs e)
        {
            creator = new EllipseCreator();
        }

        private void CrRectangle_Click(object sender, EventArgs e)
        {
            creator = new RectangleCreator();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var f in lst)
            {
                f.Draw(g);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (creator != null)
            {
                Figure figure = creator.Create();
                figure.Move(e.X, e.Y);
                figure.SetCol(cl);
                figure.Draw(g);
                lst.Add(figure);
                //SendMessage(figure);
                textBox1.Text = figure.ToString() + "#" + figure.X + "#" + figure.Y + "#" + figure.W + "#" + figure.H + "#" + figure.Color; ;
            }
        }

        private void Color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                cl = colorDialog1.Color;
            }
        }
        
        private void Clear_Click(object sender, EventArgs e)
        {
            lst.Clear();
            g.Clear(panel1.BackColor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                userName = textBox1.Text;
                client = new TcpClient();
                try
                {
                    client.Connect(host, port); //подключение клиента
                    stream = client.GetStream(); // получаем поток

                    string message = userName;
                    byte[] data = Encoding.Unicode.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    // запускаем новый поток для получения данных
                    Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                    receiveThread.Start(); //старт потока
                   // Console.WriteLine("Добро пожаловать, {0}", userName);
                    SendMessage();
                }
                catch (Exception ex)
                {
                   // Console.WriteLine(ex.Message);
                }
                finally
                {
                    Disconnect();
                }
            
        }
        //send Message
        static void SendMessage()
        {
            //Console.WriteLine("Введите сообщение: ");

            while (true)
            {
                string message = Console.ReadLine();
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
        }
        static void SendMessage(Figure f)
        {
            //Console.WriteLine("Введите сообщение: ");
                string message = f.ToString()+"#"+f.X+ "#" + f.Y+"#" + f.W+ "#" + f.H+ "#" + f.Color;
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
        }


        static void ReceiveMessage()//Give message
        {
            while (true)
            {
                try
                {
                    byte[] data = new byte[64]; // буфер для получаемых данных
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    string message = builder.ToString();
                    for (int i = 0; i < length; i++)
                    { 

                    }
                }
                catch
                {
                    Console.WriteLine("Подключение прервано!"); //соединение было прервано
                    Console.ReadLine();
                    Disconnect();
                }
            }
        }
        static void Disconnect()
        {
            if (stream != null)
                stream.Close();//отключение потока
            if (client != null)
                client.Close();//отключение клиента
            Environment.Exit(0); //завершение процесса
        }

    }
}
class Figure
{
    private float x, y;
    private float w, h;
    private Color color;

    public float X { get { return x; } }
    public float Y { get { return y; } }
    public float W { get { return w; } }
    public float H { get { return h; } }
    public Color Color { get { return color; } }
    public virtual void Draw(Graphics g)
    { }
    public virtual void Resize(float aw, float ah)
    {
        w = aw; h = ah;
    }
    public virtual void Move(float ax, float ay)
    {
        x = ax; y = ay;
    }
    public virtual void SetCol(Color cl)
    {
        color = cl;
    }
}
abstract class Creator
{
    abstract public Figure Create();
}

class Ellipse : Figure
{
    public override void Draw(Graphics g)
    {
        g.DrawEllipse(new Pen(Color), X, Y, W, H);
    }
}
class EllipseCreator : Creator
{
    public override Figure Create()
    {
        Ellipse ell = new Ellipse();
        ell.Resize(40, 40);
        ell.SetCol(Color.Coral);
        return ell;
    }
}
class Rectangle : Figure
{
    public override void Draw(Graphics g)
    {
        g.DrawRectangle(new Pen(Color), X, Y, W, H);
    }
}
class RectangleCreator : Creator
{
    public override Figure Create()
    {
        Rectangle ell = new Rectangle();
        ell.Resize(40, 40);
        return ell;
    }
}