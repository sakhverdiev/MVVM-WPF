using Command_MVVM_Homework.Commands;
using Command_MVVM_Homework.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using Command_MVVM_Homework.Views;
using System.Windows.Controls;
using Bogus;

namespace Command_MVVM_Homework.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Car> Cars { get; set; } = new ObservableCollection<Car>();
        public Car SelectedCar { get; set; } = new Car();

        public RelayCommand SaveCommand { get; set; }
        public RelayCommand EditCommand { get; set; }
        public RelayCommand ShowCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }

        public MainViewModel()
        {
            ManualDataEntry();
            SaveCommand = new RelayCommand(Save);
            DeleteCommand = new RelayCommand(Delete);
            ShowCommand = new RelayCommand(Show);
            EditCommand = new RelayCommand(Edit);
        }

        public void ManualDataEntry()
        {
            var faker = new Faker<Car>()
                .RuleFor(x => x.Id, f => f.Random.Guid())
                .RuleFor(x => x.Maker, f => f.Vehicle.Manufacturer())
                .RuleFor(x => x.Model, f => f.Vehicle.Model())
                .RuleFor(x => x.Year, f => f.Random.Int(1970, 2023))
                .RuleFor(x => x.Engine, f => Convert.ToDouble(f.Random.Float(0, 5).ToString("0.00")));

            Cars.Add(faker.Generate());
            Cars.Add(faker.Generate());
            Cars.Add(faker.Generate());

            Cars.Add(new Car
            {
                Id = Guid.NewGuid(),
                Maker = "BMW",
                Model = "M5",
                Year = 2020,
                Engine = 4.5
            });

            Cars.Add(new Car
            {
                Id = Guid.NewGuid(),
                Maker = "Dodge",
                Model = "Charger",
                Year = 2012,
                Engine = 6.4
            });

            Cars.Add(new Car
            {
                Id = Guid.NewGuid(),
                Maker = "Mercedes",
                Model = "E 200",
                Year = 2017,
                Engine = 2.0
            });
        }


        public void Save(object? param)
        {
            try
            {
                if (SelectedCar != null && !Cars.Contains(SelectedCar))
                {
                    Cars.Add(SelectedCar);
                    MessageBox.Show("Saved Successfully");
                }
                else
                {
                    MessageBox.Show("Car is either null or already in the collection.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(object? param)
        {
            if (MessageBox.Show("Are you sure?", "Deletion", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Cars.Remove(SelectedCar);
            }
        }

        public void Show(object? param)
        {
            ShowCarView showCarView = new();
            ShowCarViewModel scvm = showCarView.DataContext as ShowCarViewModel;
            scvm.SelectedCar = SelectedCar;
            showCarView.ShowDialog();
        }

        public void Edit(object? param)
        {
            EditCarView editCarView = new();
            EditCarViewModel ecvm = editCarView.DataContext as EditCarViewModel;
            ecvm!.EditedCar = SelectedCar!;
            editCarView.ShowDialog();
            SelectedCar = ecvm.EditedCar;

            if (param is Window Win)
            {
                if (Win.Content is Grid Gr)
                {
                    if (Gr.Children[0] is StackPanel SP_1)
                    {
                        if (SP_1.Children[0] is ComboBox cb)
                        {
                            MessageBox.Show(SelectedCar.ToString());
                            cb.SelectedItem = SelectedCar;
                        }
                    }
                }
            }

        }


    }
}
