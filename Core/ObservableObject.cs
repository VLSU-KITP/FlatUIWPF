using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace FlatUIWPF.Core
{
//Этот код определяет базовый класс ObservableObject,
//который реализует интерфейс INotifyPropertyChanged.
//Этот интерфейс определяет событие PropertyChanged, которое возникает, когда изменяется значение свойства объекта.
//ObservableObject содержит метод OnPropertyChanged, который вызывается каждый раз, когда изменяется значение свойства объекта.
//Метод OnPropertyChanged генерирует событие PropertyChanged и передает имя свойства в качестве параметра.
//Это позволяет привязке данных (data binding) автоматически обновлять значение свойства в пользовательском интерфейсе, когда оно изменяется в модели представления.
//ObservableObject является базовым классом для всех моделей представления (view models) в приложении,
//которые должны реализовывать интерфейс INotifyPropertyChanged и использовать метод OnPropertyChanged для уведомления привязки данных об изменении свойств.
    internal class ObservableObject: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
