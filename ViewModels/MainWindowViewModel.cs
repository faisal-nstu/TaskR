using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TaskR.Models;

namespace TaskR.ViewModels
{
    public class MainWindowViewModel
    {
        //PROPERTIES
        public ObservableCollection<TaskModel> TaskModels { get; set; }

        

        public MainWindowViewModel()
        {
            
            LoadTasks();
        }

        public void LoadTasks()
        {
            var tasks = new List<TaskModel>()
            {
                new TaskModel("t1","Task 1",false,new DateTime(2015,09,18,12,06,00)),
                new TaskModel("t2","Task 2",true,new DateTime(2015,09,18,12,06,00)),
                new TaskModel("t3","Task 3",false,new DateTime(2015,09,18,12,06,00)),
                new TaskModel("t3","Task 3",false,new DateTime(2015,09,18,12,06,00)),
                new TaskModel("t3","Task 3",false,new DateTime(2015,09,18,12,06,00)),
                new TaskModel("t3","Task 3",true,new DateTime(2015,09,18,12,06,00)),
                new TaskModel("t3","Task 3",false,new DateTime(2015,09,18,12,06,00)),
                new TaskModel("t3","Task 3",true,new DateTime(2015,09,18,12,06,00)),
                new TaskModel("t3","Task 3",true,new DateTime(2015,09,18,12,06,00)),
                new TaskModel("t3","Task 3",false,new DateTime(2015,09,18,12,06,00)),
                new TaskModel("t3","Task 3",true,new DateTime(2015,09,18,12,06,00)),
                new TaskModel("t9","Task 3",false,new DateTime(2015,09,18,12,06,00)),
                new TaskModel("t3","Task 3",false,new DateTime(2015,09,18,12,06,00)),
                new TaskModel("t3","Task 3",true,new DateTime(2015,09,18,12,06,00)),
                new TaskModel("t3","Task 3",false,new DateTime(2015,09,18,12,06,00)),
                new TaskModel("t4","Task 4",true,new DateTime(2015,09,18,12,06,00))
            };

            TaskModels = new ObservableCollection<TaskModel>(tasks.OrderByDescending(t=>t.CreationTime));
        }
    }
}
