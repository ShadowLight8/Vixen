using System.Collections.ObjectModel;
using Vixen.Sys;

namespace DisplayNodifyEditor.ViewModels
{
	public class PropViewModel : NodeViewModel
	{
		private readonly ElementNode _elementNode;

		public ObservableCollection<ConnectorViewModel> Input { get; set; } = [];
		public ObservableCollection<ConnectorViewModel> Output { get; set; } = [];

		public string Name => _elementNode.Name;
		public Guid Id => _elementNode.Id;
		//public int OutputCount => _elementNode.OutputCount;

		public string ExtraInfo { get; }

		public PropViewModel(ElementNode elementNode)
		{
			_elementNode = elementNode;

			if (elementNode.Name == "Garage-Top")
			{
				Input.Add(new ConnectorViewModel { Title = "In - Pixel 1" });
				Input.Add(new ConnectorViewModel { Title = "In - Pixel 101" });
				Output.Add(new ConnectorViewModel { Title = "Pixel 100 - Out" });
				Output.Add(new ConnectorViewModel { Title = "Pixel 128 - Out" });
				ExtraInfo = "128 Pixels - Split prop after pixel 100";
			}
			else
			{
				Input.Add(new ConnectorViewModel { Title = "In" });
				Output.Add(new ConnectorViewModel { Title = "Out" });
				if (_elementNode.IsLeaf)
				{
					ExtraInfo = "1 Pixel";
				}
				else
				{
					ExtraInfo = _elementNode.Children.Count().ToString() + " Pixels";
				}
			}
		}
	}
}
