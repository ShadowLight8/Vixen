using System.Collections.ObjectModel;
using Vixen.Sys.Output;

namespace DisplayNodifyEditor.ViewModels
{
	public class ControllerViewModel : NodeViewModel
	{
		private readonly OutputController _outputController;

		public ObservableCollection<ConnectorViewModel> Input { get; set; } = [];
		public ObservableCollection<ConnectorViewModel> Output { get; set; } = [];

		public string Name => _outputController.Name;
		public Guid Id => _outputController.Id;
		public int OutputCount => _outputController.OutputCount;

		//public System.Windows.Point Location { get; set; }

		public ControllerViewModel(OutputController outputController)
		{
			_outputController = outputController;

			Input = new ObservableCollection<ConnectorViewModel>
				{
					new ConnectorViewModel
					{
						// TODO: Is this the best/right way to get the Controller Input protocol?
						Title = Vixen.Services.ApplicationServices.GetModuleDescriptor(outputController.ModuleId).TypeName
					}
				};

			if (outputController.Name == "Teensy Serial")
			{
				for (int i = 1; i <= 8; i++)
				{
					Output.Add(new ConnectorViewModel { Title = "Ch"+i });
				}
			}
			else
			{
				Output = new ObservableCollection<ConnectorViewModel>
				{
					new ConnectorViewModel
					{
						Title = "Ch1"
					}
				};
			}
		}
	}
}
