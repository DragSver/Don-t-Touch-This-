using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
using System.Windows.Threading;
using System.Xml.Linq;

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
            OutputOfElementsOfTheFirstTask();
        }
        //Элементы первого задания
        public int i = 10;
        public int t;
        public DispatcherTimer timer = new DispatcherTimer()
        {
            Interval = TimeSpan.FromSeconds(1)
        };
        //Элементы второго задания
        public TextBox task2 = new TextBox
        {
            Text = "Что идет после 31 декабря?",
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            FontFamily = new FontFamily("Segoe UI Black"),
            FontSize = 20,
            IsEnabled = false,
            TextWrapping = TextWrapping.Wrap,
            BorderBrush = null,
            Background = null
        };
        public StackPanel stackPanel2 = new StackPanel
        {
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            Orientation = Orientation.Horizontal
        };
        public TextBox textBox2 = new TextBox
        {
            Text = "",
            FontSize = 40,
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            TextWrapping = TextWrapping.Wrap,
            FontFamily = new FontFamily("Segoe UI Emoji"),
            MinWidth = 250,
            MinHeight = 45
        };
        public Button button2 = new Button
        {
            Content = "Ввод",
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            FontFamily = new FontFamily("Segoe UI Black"),
            FontSize = 31,
            Padding = new Thickness(25, 7, 25, 7),
            Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xA4, 0xA4)),
            BorderBrush = null
        };
        //Элементы третьего задания
        public TextBox task3 = new TextBox
        {
            Text = "Курица или яйцо. Что было первым?",
            IsEnabled = false,
            FontSize = 20,
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            TextWrapping = TextWrapping.Wrap,
            BorderBrush = null,
            Background = null,
            FontFamily = new FontFamily("Segoe UI Black")
        };
        public StackPanel stackPanel3 = new StackPanel
        {
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            Orientation = Orientation.Horizontal
        };
        public ComboBox comboBox3 = new ComboBox
        {
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            FontFamily = new FontFamily("Segoe UI Emoji"),
            MinWidth = 250,
            MinHeight = 45,
            FontSize = 20
        };
        public Button button3 = new Button
        {
            Content = "Ввод",
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            FontFamily = new FontFamily("Segoe UI Black"),
            FontSize = 25,
            Padding = new Thickness(25, 6, 25, 6),
            Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xA4, 0xA4)),
            BorderBrush = null
        };
        //Элементы четвертого задания
        public StackPanel taskStackPanel4 = new StackPanel
        {
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center
        };
        public TextBox task4 = new TextBox
        {
            Text = "Что вы видите?",
            IsEnabled = false,
            FontSize = 20,
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            TextWrapping = TextWrapping.Wrap,
            BorderBrush = null,
            Background = null,
            FontFamily = new FontFamily("Segoe UI Black")
        };
        public Image image4 = new Image
        {
            Margin = new Thickness(0, 20, 0, 0),
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            MaxWidth = 100,
            Source = new BitmapImage(new Uri("cube.png", UriKind.Relative))
        };
        public StackPanel answerStackPanel4 = new StackPanel
        {
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center
        };
        public CheckBox checkBox1 = new CheckBox
        {
            Content = "Квадрат",
            VerticalAlignment = VerticalAlignment.Center
        };
        public CheckBox checkBox2 = new CheckBox
        {
            Content = "Гексаэдр",
            VerticalAlignment = VerticalAlignment.Center
        };
        public CheckBox checkBox3 = new CheckBox
        {
            Content = "Куб",
            VerticalAlignment = VerticalAlignment.Center
        };
        public CheckBox checkBox4 = new CheckBox
        {
            Content = "Правильный многогранник",
            VerticalAlignment = VerticalAlignment.Center
        };
        public Button button4 = new Button
        {
            Content = "Ввод",
            HorizontalAlignment = HorizontalAlignment.Stretch,
            VerticalAlignment = VerticalAlignment.Center,
            FontFamily = new FontFamily("Segoe UI Black"),
            FontSize = 20,
            Padding = new Thickness(25, 6, 25, 6),
            Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xA4, 0xA4)),
            BorderBrush = null,
            Margin = new Thickness(0,10,0,10)
        };
        public RadioButton radioButton4 = new RadioButton
        {
            Content = "Я не помню геометрию",
            VerticalAlignment = VerticalAlignment.Center
        };
        //Элементы пятого задания
        public TextBox task5 = new TextBox
        {
            Text = "Объедените автора и его произведение",
            Margin = new Thickness(0, 0, 0, 30),
            IsEnabled = false,
            FontSize = 20,
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            TextWrapping = TextWrapping.Wrap,
            BorderBrush = null,
            Background = null,
            FontFamily = new FontFamily("Segoe UI Black")
        };
        public StackPanel stackPanel5 = new StackPanel
        {
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            Orientation = Orientation.Horizontal
        };
        public ListBox listBox5 = new ListBox
        {
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            Height = 90
        };
        public Button button5 = new Button
        {
            Content = "Ввод\nпары",
            HorizontalAlignment = HorizontalAlignment.Stretch,
            VerticalAlignment = VerticalAlignment.Center,
            FontFamily = new FontFamily("Segoe UI Black"),
            FontSize = 20,
            Padding = new Thickness(25, 18, 25, 18),
            Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xA4, 0xA4)),
            BorderBrush = null,
            Margin = new Thickness(10, 0, 10, 0)
        };
        public ListView listView5 = new ListView
        {
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            Height = 90
        };
        public GridView gridView = new GridView();
        public GridViewColumn columnYear = new GridViewColumn
        {
            Header = "Year",
            DisplayMemberBinding = new Binding("Year")
        };
        public GridViewColumn columnAuthor = new GridViewColumn
        {
            Header = "Author",
            DisplayMemberBinding = new Binding("Author")
        };
        public MyItem myItem1 = new MyItem() { Year = "1854 г.", Author = "Лев Толстой" };
        public MyItem myItem2 = new MyItem() { Year = "1834 г.", Author = "Николай Гоголь" };
        public MyItem myItem3 = new MyItem() { Year = "1854 г.", Author = "Иван Тургенев" };
        List<MyItem> myItems = new List<MyItem>();
        public class MyItem
        {
            public string Year { get; set; }
            public string Author { get; set; }
        }
        //Элементы шестого задания
        public TextBox task6 = new TextBox
        {
            Text = "Нажмите на кнопку",
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            FontFamily = new FontFamily("Segoe UI Black"),
            FontSize = 20,
            IsEnabled = false,
            TextWrapping = TextWrapping.Wrap,
            BorderBrush = null,
            Background = null
        };
        public StackPanel stackPanel6 = new StackPanel
        {
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            Orientation = Orientation.Horizontal
        };
        public Button button61 = new Button
        {
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            MinWidth = 80,
            MinHeight = 60,
            Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xA4, 0xA4)),
            BorderBrush = null,
            Margin = new Thickness(10, 0, 10, 0)
        };
        public Button button62 = new Button
        {
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            MinWidth = 80,
            MinHeight = 60,
            Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xA4, 0xA4)),
            BorderBrush = null,
            Margin = new Thickness(10, 0, 10, 0)
        };
        public Button button63 = new Button
        {
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            MinWidth = 80,
            MinHeight = 60,
            Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xA4, 0xA4)),
            BorderBrush = null,
            Margin = new Thickness(10, 0, 10, 0),
            ContextMenu = new ContextMenu() { BorderBrush = null }
        };
        public MenuItem menuItem1 = new MenuItem
        {
            Header = ""
        };
        public MenuItem menuItem2 = new MenuItem
        {
            Header = ""
        };
        public Separator separator6 = new Separator();
        public MenuItem menuItem3 = new MenuItem
        {
            Header = "Кнопка"
        };
        //Элементы седьмого задания
        public StackPanel stackPanel7 = new StackPanel
        {
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center
        };
        public TextBox task7 = new TextBox
        {
            Text = "Найдите кнопку еще раз",
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            FontFamily = new FontFamily("Segoe UI Black"),
            FontSize = 20,
            IsEnabled = false,
            TextWrapping = TextWrapping.Wrap,
            BorderBrush = null,
            Background = null
        };
        public Button button7 = new Button
        {
            Content = "Ввод",
            HorizontalAlignment = HorizontalAlignment.Stretch,
            VerticalAlignment = VerticalAlignment.Center,
            FontFamily = new FontFamily("Segoe UI Black"),
            FontSize = 20,
            Padding = new Thickness(25, 6, 25, 6),
            Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xA4, 0xA4)),
            BorderBrush = null,
            Margin = new Thickness(0, 50, 0, 0)
        };
        public TreeView treeView7 = new TreeView
        {
            Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xF6, 0xEA, 0xEA)),
            BorderBrush = null
        };
        //Вывод восьмого задания
        public TextBox task8 = new TextBox
        {
            Text = "А теперь поймайте кнопку",
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center,
            FontFamily = new FontFamily("Segoe UI Black"),
            FontSize = 20,
            IsEnabled = false,
            TextWrapping = TextWrapping.Wrap,
            BorderBrush = null,
            Background = null
        };
        public Grid grid8 = new Grid();
        public Button button8 = new Button
        {
            Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xA4, 0xA4)),
            BorderBrush = null
        };
        public Random random8 = new Random();
        public byte k = 8;

        //Вывод первого задания
        private void OutputOfElementsOfTheFirstTask()
        {
            timer.Tick += Timer_Tick;
        }
        //Первое задание
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            i--;
            if (i == 9)
            {
                t = 3;
                timer.Start();
            }
            button.Content = i;
            if (i == 0)
            {
                MessageBox.Show("Вы так быстры!");
                grid.Children.Clear();
                OutputOfElementsOfTheSecondTask();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            t--;
            if (t == 0)
            {
                i = 10;
                button.Content = i;
            }
        }


        //Вывод второго задания
        private void OutputOfElementsOfTheSecondTask()
        {
            grid.Children.Add(task2);
            grid.Children.Add(stackPanel2);
            Grid.SetRow(stackPanel2, 1);
            stackPanel2.Children.Add(textBox2);
            stackPanel2.Children.Add(button2);
            button2.Click += ButtonInTwo_Click;
        }
        //Второе задание
        private void ButtonInTwo_Click(object sender, RoutedEventArgs e)
        {
            if (textBox2.Text != "?") MessageBox.Show("Попробуйте еще раз");
            else
            {
                MessageBox.Show("Верно! В тексте после 31 декабря идет \"?\"");
                grid.Children.Clear();
                OutputOfElementsOfTheThirdTask();
            }
        }


        //Вывод третьего задания
        private void OutputOfElementsOfTheThirdTask()
        {
            grid.Children.Add(task3);
            grid.Children.Add(stackPanel3);
            Grid.SetRow(stackPanel3, 1);
            stackPanel3.Children.Add(comboBox3);
            stackPanel3.Children.Add(button3);
            comboBox3.Items.Add("Яйцо");
            comboBox3.Items.Add("Курица");
            button3.Click += ButtonInThree_Click;
        }
        //Третье задание
        private void ButtonInThree_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox3.Text != "Курица") MessageBox.Show("Попробуйте еще раз");
            else
            {
                MessageBox.Show("В тексте и правда первым идет слово \"курица\"");
                grid.Children.Clear();
                OutputOfElementsOfTheFourthTask();
            }
        }


        //Вывод четвертого задания
        private void OutputOfElementsOfTheFourthTask()
        {
            grid.Children.Add(taskStackPanel4);
            taskStackPanel4.Children.Add(task4);
            taskStackPanel4.Children.Add(image4);
            grid.Children.Add(answerStackPanel4);
            Grid.SetRow(answerStackPanel4, 1);
            answerStackPanel4.Children.Add(checkBox1);
            answerStackPanel4.Children.Add(checkBox2);
            answerStackPanel4.Children.Add(checkBox3);
            answerStackPanel4.Children.Add(checkBox4);
            answerStackPanel4.Children.Add(button4);
            answerStackPanel4.Children.Add(radioButton4);
            button4.Click += ButtonInFour_Click;
            radioButton4.Checked += RadioButtonSurrender_Checked;
        }
        //Четвертое задание
        private void ButtonInFour_Click(object sender, RoutedEventArgs e)
        {
            if (!(checkBox1.IsChecked is false && checkBox2.IsChecked is true && checkBox3.IsChecked is true && checkBox4.IsChecked is true))
            {
                MessageBox.Show("Попробуйте еще раз");
            }
            else
            {
                MessageBox.Show("Да, вы правы - куб, гексаэдр и правильный многогранник - название одной и той же фигуры");
                grid.Children.Clear();
                OutputOfElementsOfTheFifthTask();
            }
        }
        private void RadioButtonSurrender_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ну что ж, тогда пройдем дальше");
            grid.Children.Clear();
            OutputOfElementsOfTheFifthTask();
        }


        //Вывод пятого задания
        private void OutputOfElementsOfTheFifthTask()
        {
            grid.Children.Add(task5);
            grid.Children.Add(stackPanel5);
            Grid.SetRow(stackPanel5, 1);
            stackPanel5.Children.Add(listBox5);
            foreach (var day in new string[] { "Вий", "Муму", "Отрочество" }) listBox5.Items.Add(day);
            stackPanel5.Children.Add(button5);
            stackPanel5.Children.Add(listView5);
            listView5.View = gridView;
            gridView.Columns.Add(columnYear);
            gridView.Columns.Add(columnAuthor);
            myItems.Add(myItem1);
            myItems.Add(myItem2);
            myItems.Add(myItem3);
            listView5.ItemsSource = myItems;
            button5.Click += Button5_Click;
        }
        //Пятое задание
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (listBox5.SelectedItem is "Вий" && listView5.SelectedValue == myItem2)
            {
                listBox5.Items.Remove("Вий");
                myItems.Remove(myItem2);
                listView5.Items.Refresh();
            }
            else if (listBox5.SelectedItem is "Муму" && listView5.SelectedValue == myItem3)
            {
                listBox5.Items.Remove("Муму");
                myItems.Remove(myItem3);
                listView5.Items.Refresh();
            }
            else if (listBox5.SelectedItem is "Отрочество" && listView5.SelectedValue == myItem1)
            {
                listBox5.Items.Remove("Отрочество");
                myItems.Remove(myItem1);
                listView5.Items.Refresh();
            }
            else MessageBox.Show("Попробуйте еще раз");
            if (myItems.Count == 0)
            {
                MessageBox.Show("А вы неплохо разбираетесь в литературе");
                grid.Children.Clear();
                OutputOfElementsOfTheSixthTask();
            }
        }

        //Вывод шестого задания
        private void OutputOfElementsOfTheSixthTask()
        {
            grid.Children.Add(task6);
            grid.Children.Add(stackPanel6);
            Grid.SetRow(stackPanel6, 1);
            foreach (var button in new Button[] { button61, button62, button63 }) stackPanel6.Children.Add(button);
            button63.ContextMenu.Items.Add(menuItem1);
            button63.ContextMenu.Items.Add(menuItem2);
            button63.ContextMenu.Items.Add(separator6);
            button63.ContextMenu.Items.Add(menuItem3);
            button61.Click += Button6_Click;
            button62.Click += Button6_Click;
            button63.Click += Button6_Click;
            menuItem1.Click += Button6_Click;
            menuItem2.Click += Button6_Click;
            menuItem3.Click += MenuItem2_Click;
        }
        //Шестое задание
        private void MenuItem2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Да, вы нашли ее!");
            grid.Children.Clear();
            OutputOfElementsOfTheSeventhTask();
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Не та кнопка");
        }

        //Вывод седьмого задания
        private void OutputOfElementsOfTheSeventhTask()
        {
            grid.Children.Add(stackPanel7);
            stackPanel7.Children.Add(task7);
            stackPanel7.Children.Add(button7);
            grid.Children.Add(treeView7);
            Grid.SetRow(treeView7, 1);
            for (int i = 0; i < 3; i++) treeView7.Items.Add(new TreeViewItem { Header = "Не кнопка", Items = { 
                    new TreeViewItem { Header = "Не кнопка", Items = { new TreeViewItem { Header = "Не кнопка", Items = { new TreeViewItem { Header = "Не кнопка", Items = { } },
                                                                                                                          new TreeViewItem { Header = "Не кнопка", Items = { } },
                                                                                                                          new TreeViewItem { Header = "Не кнопка", Items = { } } } },
                                                                       new TreeViewItem { Header = "Не кнопка", Items = { new TreeViewItem { Header = "Не кнопка", Items = { } },
                                                                                                                          new TreeViewItem { Header = "Не кнопка", Items = { } },
                                                                                                                          new TreeViewItem { Header = "Не кнопка", Items = { } } } },
                                                                       new TreeViewItem { Header = "Не кнопка", Items = { new TreeViewItem { Header = "Не кнопка", Items = { } },
                                                                                                                          new TreeViewItem { Header = "Не кнопка", Items = { } },
                                                                                                                          new TreeViewItem { Header = "Не кнопка", Items = { } } } } } },
                    new TreeViewItem { Header = "Не кнопка", Items = { new TreeViewItem { Header = "Не кнопка", Items = { new TreeViewItem { Header = "Не кнопка", Items = { } },
                                                                                                                          new TreeViewItem { Header = "Не кнопка", Items = { } },
                                                                                                                          new TreeViewItem { Header = "Не кнопка", Items = { } } } },
                                                                       new TreeViewItem { Header = "Не кнопка", Items = { new TreeViewItem { Header = "Не кнопка", Items = { } },
                                                                                                                          new TreeViewItem { Header = "Не кнопка", Items = { } },
                                                                                                                          new TreeViewItem { Header = "Не кнопка", Items = { } } } },
                                                                       new TreeViewItem { Header = "Не кнопка", Items = { new TreeViewItem { Header = "Не кнопка", Items = { } },
                                                                                                                          new TreeViewItem { Header = "Не кнопка", Items = { } },
                                                                                                                          new TreeViewItem { Header = "Не кнопка", Items = { } } } } } },
                    new TreeViewItem { Header = "Не кнопка", Items = { new TreeViewItem { Header = "Кнопка", Items = { new TreeViewItem { Header = "Не кнопка", Items = { } },
                                                                                                                          new TreeViewItem { Header = "Не кнопка", Items = { } },
                                                                                                                          new TreeViewItem { Header = "Не кнопка", Items = { } } } },
                                                                       new TreeViewItem { Header = "Не кнопка", Items = { new TreeViewItem { Header = "Не кнопка", Items = { } },
                                                                                                                          new TreeViewItem { Header = "Не кнопка", Items = { } },
                                                                                                                          new TreeViewItem { Header = "Не кнопка", Items = { } } } },
                                                                       new TreeViewItem { Header = "Не кнопка", Items = { new TreeViewItem { Header = "Не кнопка", Items = { } },
                                                                                                                          new TreeViewItem { Header = "Не кнопка", Items = { } },
                                                                                                                          new TreeViewItem { Header = "Не кнопка", Items = { } } } } } } } });
            button7.Click += Button7_Click;
        }
        //Седьмое задание
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (((TreeViewItem)treeView7.SelectedItem).Header is "Кнопка")
            {
                MessageBox.Show("Да, она здесь");
                grid.Children.Clear();
                OutputOfElementsOfTheEighthTask();
            }
            else MessageBox.Show("Попробуйте еще раз");
        }

        //Вывод восьмого задания
        private void OutputOfElementsOfTheEighthTask()
        {
            grid.Children.Add(task8);
            grid.Children.Add(grid8);
            Grid.SetRow(grid8, 1);
            grid8.RowDefinitions.Add(new RowDefinition());
            grid8.RowDefinitions.Add(new RowDefinition());
            grid8.ColumnDefinitions.Add(new ColumnDefinition());
            grid8.ColumnDefinitions.Add(new ColumnDefinition());
            grid8.Children.Add(button8);
            button8.Click += Button8_Click;
        }
        //Восьмое задание
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            k--;
            if (k == 0)
            {
                MessageBox.Show("Вы ее поймали!");
                grid.Children.Clear();
            }
            else
            {
                Grid.SetRow(button8, random8.Next(2));
                Grid.SetColumn(button8, random8.Next(2));
            }
        }
    }
}
