using System.Collections.ObjectModel;
using Vixen.Sys.Output;

namespace DisplayNodifyEditor.ViewModels
{
	public class ControllerViewModel : ObservableObject
	{
		private readonly OutputController _outputController;

		public ObservableCollection<ConnectorViewModel> Input { get; set; } = [];
		public ObservableCollection<ConnectorViewModel> Output { get; set; } = [];

		public string Name => _outputController.Name;
		public Guid Id => _outputController.Id;
		public int OutputCount => _outputController.OutputCount;

		public System.Windows.Point Location { get; set; }

		public ControllerViewModel(OutputController outputController)
		{
			_outputController = outputController;

			if (outputController.Name == "Teensy Serial")
			{
				Input.Add(new ConnectorViewModel { Title = "Serial" });
				for (int i = 1; i <= 8; i++)
				{
					Output.Add(new ConnectorViewModel { Title = "Ch"+i });
				}
			}
			else
			{
				Input = new ObservableCollection<ConnectorViewModel>
				{
					new ConnectorViewModel
					{
						Title = "DDP"
					}
				};
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
