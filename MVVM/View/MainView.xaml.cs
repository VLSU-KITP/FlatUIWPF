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

namespace FlatUIWPF.MVVM.View
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    // определяет класс MainView, который является представлением в шаблоне проектирования MVVM.
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }
    }
}

//Класс MainView определяет внешний вид и поведение пользовательского интерфейса (UI) 
//для приложения. В данном случае, класс MainView является пользовательским элементом управления (UserControl), 
//который содержит другие элементы управления, такие как кнопки, текстовые поля и т.д.

//Конструктор класса MainView вызывает метод InitializeComponent(), 
//который инициализирует компоненты пользовательского интерфейса, определенные в файле XAML. 
//Файл XAML определяет внешний вид и расположение элементов управления в пользовательском интерфейсе.

//Для того, чтобы использовать класс MainView в качестве представления в шаблоне MVVM, 
//необходимо связать его с соответствующей моделью представления (например, HomeViewModel) 
//и установить свойства элементов управления в соответствии с данными, хранящимися в модели представления.


