using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Input;
using Task_It_Tasker.Model;


namespace Task_It_Tasker.ViewModel
{
    public class NotesPageViewModel
    {
        public ObservableCollection<NotesModel> Notes { get; set; }

        public NotesPageViewModel()
        {
            Notes = new ObservableCollection<NotesModel>
        {
            new NotesModel { Title = "Task 1", Date = "30 June 2024 11.59" },
            new NotesModel { Title = "Task 2", Date = "1 July 2024 10.00" },
            new NotesModel { Title = "Task 3", Date = "2 July 2024 14.30" },
            new NotesModel { Title = "Task 4", Date = "3 July 2024 16.00" }
        };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
        