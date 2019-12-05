using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Task = GreenWorld.Models.Task;

namespace GreenWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePageNew : ContentPage
    {
        public IList<Task> Tasks { get; private set; }
        public ProfilePageNew()
        {
            InitializeComponent();

            Tasks = new List<Task>();

            Tasks.Add(new Task
            {
                TaskName = "Eat Less Meat",
                CompletionDate = "01/01/2020"
            });

            Tasks.Add(new Task
            {
                TaskName = "Recycle More",
                CompletionDate = "01/11/2019"
            });

            Tasks.Add(new Task
            {
                TaskName = "Use Canvas Bags",
            });

            Tasks.Add(new Task
            {
                TaskName = "Start Composting",
                CompletionDate = "10/09/2018"
            });

            Tasks.Add(new Task
            {
                TaskName = "Use LED Bulbs",
            });

            Tasks.Add(new Task
            {
                TaskName = "Walk More",
            });

            Tasks.Add(new Task
            {
                TaskName = "Give up Disposable Cups",
            });

            Tasks.Add(new Task
            {
                TaskName = "Shop at Charity Shops",
            });
            Tasks.Add(new Task
            {
                TaskName = "Have a Vegan Meal",
            });
            Tasks.Add(new Task
            {
                TaskName = "Reduce Water Waste",
            });


            BindingContext = this;
        }
    }
}