using CommunityToolkit.Mvvm.ComponentModel;
using HTTPClient.Models;
using HTTPClient.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HTTPClient.ViewModels
{
    public partial class TodoViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Todo> todos;

        private ICommand getTodoCommand { get; }

        public TodoViewModel()
        {
            getTodoCommand = new Command(getTodo);
        }

        public async void getTodo()
        {
            TodoService todoService = new TodoService();
            Todos = await todoService.getTodos();
        }
    }
}
