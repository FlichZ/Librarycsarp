using ClassLibrary2;
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
using ProStyle;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
                // Десериализовать список заметок из файла
                List<Note> notes = Class1.Deserialize<Note>("notes");

            // Связать список заметок с элементом ListBox
            List<String> CheckedNotes = new List<String>();
            foreach (Note note in notes)
            {
                    CheckedNotes.Add(note.name);
            }
            notesListBox.ItemsSource = CheckedNotes;
            

            // Создать новую заметку
            Note newNote = new Note { name = "Новая заметка", description = "Содержимое новой заметки", date = DateTime.Now };

            // Добавить новую заметку в список
            notes.Add(newNote);

            // Сериализовать список обратно в файл JSON
            Class1.Serialize(notes, "notes");


        }
    }

    internal class Note
    {
        public string name;
        public string description;
        public DateTime date;
    }
}
