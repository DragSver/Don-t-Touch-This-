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

namespace Dont_touch_this
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int i = 10;

        //Элементы второго задания
        public TextBox question = new TextBox
        {
            Text = "Что идет после 31 декабря?",
            IsEnabled = false,
            Name = "question",
            FontSize = 20,
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            TextWrapping = TextWrapping.Wrap,
            BorderBrush = null,
            Background = null,
            FontFamily = new FontFamily("Segoe UI Black")
        };
        public TextBox answer = new TextBox
        {
            Text = "",
            Name = "answer",
            FontSize = 40,
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            TextWrapping = TextWrapping.Wrap,
            FontFamily = new FontFamily("Segoe UI Emoji"),
            MinWidth = 250,
            MinHeight = 45
        };
        //Элементы третьего задания
        public TextBox question2 = new TextBox
        {
            Text = "Вы участвуете в соревнованиях и обогнали бегуна, занимающего вторую позицию. Какую позицию вы теперь занимаете?",
            IsEnabled = false,
            Name = "question2",
            FontSize = 20,
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            TextWrapping = TextWrapping.Wrap,
            BorderBrush = null,
            Background = null,
            FontFamily = new FontFamily("Segoe UI Black")
        };
        public ComboBox choice = new ComboBox
        {
            Name="comboBox",
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            FontFamily = new FontFamily("Segoe UI Emoji"),
            MinWidth = 250,
            MinHeight = 45,
            FontSize = 20
        };
        //Первое задание
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (i == 10)
            {

            }
            i--;
            button.Content = i;
            if (i == 0)
            {
                grid.Children.Clear();
                AddQuestionAndAnswer();
            }
        }
        //Вывод второго задания
        private void AddQuestionAndAnswer()
        {
            grid.Children.Add(question);
            Grid.SetColumn(question, 0);
            Grid.SetRow(question, 0);
            grid.Children.Add(answer);
            Grid.SetColumn(answer, 0);
            Grid.SetRow(answer, 1);
            answer.KeyDown += Answer_KeyDown;
        }
        //Второе задание
        private void Answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (answer.Text != "?") MessageBox.Show("no");
                else
                {
                    grid.Children.Clear();
                    AddQuestionAndСhoice();
                }
            }
        }
        //Вывод третьего задания
        private void AddQuestionAndСhoice()
        {
            grid.Children.Add(question2);
            Grid.SetColumn(question2, 0);
            Grid.SetRow(question2, 0);
            grid.Children.Add(choice);
            Grid.SetColumn(choice, 0);
            Grid.SetRow(choice, 1);
            choice.Items.Add("На первом месте");
            choice.Items.Add("На втором месте");
            choice.Items.Add("На третьем месте");
            choice.KeyDown += Choice_KeyDown;
        }
        //Третье задание
        private void Choice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (choice.Text != "На втором месте") MessageBox.Show("no");
                else grid.Children.Clear();
            }
        }
    }
}
