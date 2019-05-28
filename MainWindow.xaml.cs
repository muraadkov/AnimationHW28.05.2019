using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnimationLesson28._05._2019
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation animation = new DoubleAnimation();
            
            animation.From = 0;
            animation.To = rectangle.Width;
            progressBar.Value = 0;
            animation.Duration = new Duration(TimeSpan.FromSeconds(5));
            animation.Completed += ButtonAnimation_Completed;
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            Storyboard.SetTargetName(animation, progressBar.Name);
            Storyboard.SetTargetProperty(animation, new PropertyPath(WidthProperty));
            storyboard.Begin(this);
            //animation.From = rectangle.Height;
            //animation.To = rectangle.Height + 100;
            //animation.Duration = new Duration(TimeSpan.FromSeconds(3));
            //animation.RepeatBehavior = RepeatBehavior.Forever;
            //animation.AutoReverse = true;
            //Storyboard storyboard = new Storyboard();
            //storyboard.Children.Add(animation);
            //Storyboard.SetTargetName(animation, rectangle.Name);
            //Storyboard.SetTargetProperty(animation, new PropertyPath(HeightProperty));
            //storyboard.Begin(this);
        }
        private void ButtonAnimation_Completed(object sender, EventArgs e)
        {
            MessageBox.Show("Загрузка завершена");
        }
    }
}
