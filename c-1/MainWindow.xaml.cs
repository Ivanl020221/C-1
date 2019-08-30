using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using Microsoft.Win32;
using System.Windows.Threading;

namespace c_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            Random r = new Random();
            InitializeComponent();
            this.MouseMove += this.MainWindow_MouseMove;
            this.KeyDown += this.MainWindow_KeyDown;
            timer.Interval = new TimeSpan(0, 0, 20);
            timer.Tick += this.Timer_Tick;
            timer.Start();
           
            context.SaveChanges();
        }

        private void Timer_Tick(object sender, EventArgs e) => Close();

        public void Rebut()
        {
            timer.Stop();
            timer.Start();
        }

        public void Close() => Application.Current.Shutdown();

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            Rebut();
        }
        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            Rebut();
        }

        GIBDDEntities context = new GIBDDEntities();

        private void GetJson(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if ((bool)openFile.ShowDialog())
            {
                this.Json.ItemsSource = new Utilites().Deserializer<IEnumerable<Test>>(File.ReadAllText(openFile.FileName));
            }
        }

        private void LoadAllPhoto(object sender, RoutedEventArgs e)
        {
            SaveFileDialog openFile = new SaveFileDialog();
            //openFile.Multiselect = true;
            if ((bool)openFile.ShowDialog())
            {
                SaveImage(this,openFile.FileName);
                //byte[] Photo = File.ReadAllBytes(openFile.FileName);
                //SaveFileDialog saveFileDialog = new SaveFileDialog();
                //saveFileDialog.Filter = "*.jpeg | *.jpeg | *.png | *.png ";
                //if ((bool)saveFileDialog.ShowDialog())
                //{
                //    File.WriteAllBytes(saveFileDialog.FileName, Photo);
                //}
                //int index = 0;
                //foreach (var obj in new List<Test>())
                //{
                    ////obj.value = new Utilites().ImageToByte(openFile.FileNames[index]);
                    //index++;
                    //if(index + 1 == openFile.FileNames.Length)
                    //{
                        //index = 0;
                    //}

                //}
            }
        }

        private void AllEncrypt(object sender, RoutedEventArgs e)
        {
            foreach (var item in new List<Test>())
            {
                //item.value = new Utilites().Ctypt(item.value); 
            }
        }
        public void SaveImage(Visual visual, string filePath)
        {
            Rect bounds = VisualTreeHelper.GetDescendantBounds(visual);
            RenderTargetBitmap bitmap = new RenderTargetBitmap((Int32)bounds.Width, (Int32)bounds.Height, 96, 96, PixelFormats.Pbgra32);
            bitmap.Render(visual);
            PngBitmapEncoder image = new PngBitmapEncoder();
            image.Frames.Add(BitmapFrame.Create(bitmap));
            using (Stream fs = File.Create(filePath))
            {
                image.Save(fs);
            }
        }

        public void Ssave(Visual visual, string path)
        {
            Rect bounds = VisualTreeHelper.GetDescendantBounds(visual);
            RenderTargetBitmap bitmap = new RenderTargetBitmap((int)bounds.Width, (int)bounds.Height, 96, 96, PixelFormats.Pbgra32);
            bitmap.Render(visual);
            PngBitmapEncoder image = new PngBitmapEncoder();
            image.Frames.Add(BitmapFrame.Create(bitmap));
            using (Stream fs = File.Create(path))
            {
                image.Save(fs);
            }
        }

        public void Save(Visual visual, string path)
        {
            Rect bounce = VisualTreeHelper.GetDescendantBounds(visual);
            RenderTargetBitmap bitmap = new RenderTargetBitmap((int)bounce.Width, (int)bounce.Height, 96, 96, PixelFormats.Pbgra32);
            bitmap.Render(visual);
            PngBitmapEncoder image = new PngBitmapEncoder();
            image.Frames.Add(BitmapFrame.Create(bitmap));
            using (Stream sm = File.Create(path))
            {
                image.Save(sm);
            }
        }

        public void sasdda(Visual visual, string path)
        {
            Rect bounce = VisualTreeHelper.GetDescendantBounds(visual);
            RenderTargetBitmap bitmap = new RenderTargetBitmap((int)bounce.Width, (int)bounce.Height,96,96 ,PixelFormats.Pbgra32);
            bitmap.Render(visual);
            PngBitmapEncoder image = new PngBitmapEncoder();
            image.Frames.Add(BitmapFrame.Create(bitmap));
            using (Stream ssrce = File.Create(path))
            {
                image.Save(ssrce);   
            }
        }

        public void sadfadsa(Visual visual,string Path)
        {
            Rect bounce = VisualTreeHelper.GetDescendantBounds(visual);
            RenderTargetBitmap bitmap = new RenderTargetBitmap((int)bounce.Width, (int)bounce.Height, 96, 96, PixelFormats.Pbgra32);
            bitmap.Render(visual);
            PngBitmapEncoder image = new PngBitmapEncoder();
            image.Frames.Add(BitmapFrame.Create(bitmap));
            using (Stream ssad = File.Create(Path))
            {
                image.Save(ssad);
            }
        }


        public void adsdsasadd(Visual visual, string path)
        {
            Rect bouce = VisualTreeHelper.GetDescendantBounds(visual);
            RenderTargetBitmap bitmap = new RenderTargetBitmap((int)bouce.Width, (int)bouce.Height, 96, 96, PixelFormats.Pbgra32);
            bitmap.Render(visual);
            PngBitmapEncoder image = new PngBitmapEncoder();
            image.Frames.Add(BitmapFrame.Create(bitmap));
            using (Stream s = File.Create(path))
            {
                image.Save(s);
            }
        }

        public void Sdadas(Visual visual, string path)
        {
            Rect bounce = VisualTreeHelper.GetDescendantBounds(visual);
            RenderTargetBitmap bitmap = new RenderTargetBitmap((int)bounce.Width, (int)bounce.Height, 96, 96, PixelFormats.Pbgra32);
            bitmap.Render(visual);
            PngBitmapEncoder image = new PngBitmapEncoder();
            image.Frames.Add(BitmapFrame.Create(bitmap));
            using (Stream ssad = File.Create(path))
            {
                image.Save(ssad);
            }
        }

        private void SaveVideo(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = true;
            if ((bool)openFile.ShowDialog())
            {
                int index = 0;
                foreach (var obj in context.Media.Where(i =>i.Type == 1))
                {
                    obj.Media1 = File.ReadAllBytes(openFile.FileNames[index]);
                    index++;
                    if (index + 1 == openFile.FileNames.Length)
                    {
                        index = 0;
                    }

                }
                    context.SaveChanges();
            }
        }
    }
    class MediaRead
    {
        String Path = AppDomain.CurrentDomain.BaseDirectory;
        string ReturPath { get; set; }

        public MediaRead(Type type, byte[] Array)
        {
            Random ra = new Random();
            ReturPath = $"{Path}\\{ra}.{type}";
            File.WriteAllBytes(ReturPath, Array);
        }

        public string ReturnPath()
        {
            return ReturPath;
        }

        ~MediaRead()
        {
            File.Delete(this.ReturPath);
        }
    }

    public class Utilites
    {
        public T Deserializer<T>(string Json) where T : class
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            return serializer.ReadObject(new MemoryStream(Encoding.Default.GetBytes(Json))) as T;
        }
        public T Deserializer<T>(byte[] Json) where T : class
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            return serializer.ReadObject(new MemoryStream(Json)) as T;
        }
        public byte[] ImageToByte(string path)
        {
            Bitmap bitmap = new Bitmap(path);
            var Converter = System.Drawing.Image.FromFile(path);
            using (MemoryStream ms = new MemoryStream())
            {
                Converter.Save(ms, bitmap.RawFormat);
                return ms.ToArray();
            }
        }
        public string Ctypt(string Raw)
        {
            MD5 mD = new MD5CryptoServiceProvider();
            byte[] raw = Encoding.ASCII.GetBytes(Raw);
            byte[] CryptData = mD.ComputeHash(raw);
            return BitConverter.ToString(CryptData);
        }

    }


    public class Test
    {
        public long id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public long role { get; set; }
    }
}
