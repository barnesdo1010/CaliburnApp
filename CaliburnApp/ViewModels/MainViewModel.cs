using Caliburn.Micro;

namespace CaliburnApp.ViewModels
{
    public class MainViewModel : Conductor<IScreen>.Collection.AllActive, PropertyChangedBase
    {
        private string messageTo;

        public string MessageTo { get => messageTo; set => messageTo = value; }
        public MainViewModel()
        {

        }

        public void _MouseOver()
        {

        }


    }
}
