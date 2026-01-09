

using SimpleTodo.Models;
using System.Text.Json;

namespace MauiAppTodo;

public partial class MainPage : ContentPage
{
    List<TodoItem> todos = new();

    public MainPage()
    {
        InitializeComponent();
        LoadTodos();
    }

    void LoadTodos()
    {
        var data = Preferences.Get("todoList", "");

        if (!string.IsNullOrEmpty(data))
            todos = JsonSerializer.Deserialize<List<TodoItem>>(data);

        RefreshUI();
    }

    void SaveTodos()
    {
        var json = JsonSerializer.Serialize(todos);
        Preferences.Set("todoList", json);
    }

    void RefreshUI()
    {
        TodoLabel.Text = "";

        foreach (var t in todos)
        {
            TodoLabel.Text += $"{t.Title} - {t.Due:d}\n";
        }
    }

    void Add_Clicked(object sender, EventArgs e)
    {
        var todo = new TodoItem
        {
            Title = TitleEntry.Text,
            Due = DatePicker.Date
        };

        todos.Add(todo);
        SaveTodos();
        RefreshUI();

        TitleEntry.Text = "";
        DatePicker.Date = DateTime.Now;
    }
}
