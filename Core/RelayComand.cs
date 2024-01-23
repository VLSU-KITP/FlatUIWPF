using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


//Этот код определяет класс RelayComand, который реализует интерфейс ICommand.
//Это утилитарный класс, который обычно используется для создания команд для элементов пользовательского интерфейса WPF.


namespace FlatUIWPF.Core
{
    internal class RelayComand : ICommand
    {
        private Action<object> _execute; // Действие, которое будет выполнено при вызове команды
        private Func<object, bool> _canExecute; // Функция, которая определяет, может ли команда быть выполнена

        // Событие, которое возникает, когда метод CanExecute команды изменяется
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; } // Добавляем обработчик события в событие RequerySuggested менеджера команд
            remove { CommandManager.RequerySuggested -= value; } // Удаляем обработчик события из события RequerySuggested менеджера команд
        }

        // Конструктор, который принимает действие, которое будет выполнено, и функцию, которая определяет, может ли команда быть выполнена
        public RelayComand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute; // Задаем действие, которое будет выполнено
            _canExecute = canExecute; // Задаем функцию, которая определяет, может ли команда быть выполнена
        }

        // Метод, который определяет, может ли команда быть выполнена
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter); // Если нет функции, которая определяет, может ли команда быть выполнена, или функция возвращает true, возвращаем true
        }

        // Метод, который выполняет команду
        public void Execute(object parameter) => _execute(parameter); // Выполняем действие, связанное с командой
    }
}