using Command_MVVM_Homework.Commands;
using Command_MVVM_Homework.Models;
using System.Windows;

namespace Command_MVVM_Homework.ViewModels
{
    public class EditCarViewModel
    {
        public Car EditedCar { get; set; } = new Car();
        public RelayCommand SaveChangesCommand { get; set; }

        public EditCarViewModel()
        {
            SaveChangesCommand = new RelayCommand(SaveChanges);
        }

        public void SaveChanges(object? param)
        {
            if (param is MainViewModel mainViewModel)
            {
                if (mainViewModel.Cars.Contains(EditedCar))
                {
                    mainViewModel.Cars.Remove(EditedCar);
                    mainViewModel.Cars.Add(EditedCar);
                }

                if (param is Window window)
                {
                    window.Close();
                }
            }
        }
    }
}