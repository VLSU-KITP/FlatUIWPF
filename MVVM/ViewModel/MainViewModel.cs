using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatUIWPF.Core;

//Является классом MainViewModel, который является моделью представления в шаблоне проектирования MVVM.
//Он содержит свойства и методы для управления данными и логикой приложения.
namespace FlatUIWPF.MVVM.ViewModel
{
    class MainViewModel:ObservableObject
    {
        // Определяем свойство HomeVM типа HomeViewModel
        public HomeViewModel HomeVM { get; set; }

        // Определяем свойство CurrentView типа object
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        // Определяем конструктор класса MainViewModel
        public MainViewModel()
        {
            // Создаем экземпляр класса HomeViewModel и присваиваем его свойству HomeVM
            HomeVM = new HomeViewModel();
            // Присваиваем свойству CurrentView значение HomeVM
            CurrentView = HomeVM;
        }
    }
}
//Класс MainViewModel наследует класс ObservableObject,
//который реализует интерфейс INotifyPropertyChanged для уведомления об изменениях свойств объекта.
//Он содержит свойства HomeVM и CurrentView. Свойство HomeVM представляет экземпляр класса HomeViewModel,
//который является моделью представления для представления HomeView. Свойство CurrentView представляет текущее представление,
//которое отображается в главном окне приложения. В конструкторе класса MainViewModel создается экземпляр класса HomeViewModel и присваивается свойству HomeVM.
//Затем свойство CurrentView устанавливается в значение HomeVM, чтобы отобразить представление HomeView при запуске приложения.
