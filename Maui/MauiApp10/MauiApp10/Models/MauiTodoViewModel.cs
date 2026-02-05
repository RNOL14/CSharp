using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace MauiApp10.Models;

public class MauiTodoViewModel : INotifyPropertyChanged
{
  public ObservableCollection<TodoItem> Todos { get; } =
      new ObservableCollection<TodoItem>();

  public ICommand CompleteTodoCommand { get; }
  public ICommand DeleteTodoCommand { get; }

  public MauiTodoViewModel()
  {
    Todos.Add(new TodoItem { Title = "Learn .NET MAUI" });
    Todos.Add(new TodoItem { Title = "Understand MVVM" });
    Todos.Add(new TodoItem { Title = "Practice SwipeView" });
    CompleteTodoCommand = new Command<TodoItem>(CompleteTodo);
    DeleteTodoCommand = new Command<TodoItem>(DeleteTodo);
  }

  void CompleteTodo(TodoItem todo)
  {
    if (todo == null)
      return;

    todo.IsCompleted = true;
  }

  void DeleteTodo(TodoItem todo)
  {
    if (todo == null)
      return;

    Todos.Remove(todo);
  }

  public event PropertyChangedEventHandler PropertyChanged;
}
