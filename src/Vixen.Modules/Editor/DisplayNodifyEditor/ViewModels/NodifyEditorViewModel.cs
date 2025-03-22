using System.Collections.ObjectModel;
using System.Windows.Input;
using Vixen.Sys;
using System.Windows;

namespace DisplayNodifyEditor.ViewModels
{
	public class NodifyEditorViewModel : ObservableObject
	{
		public ObservableCollection<ControllerViewModel> ShelfControllers { get; } = [];
		public ObservableCollection<NodeViewModel> ShelfProps { get; } = [];

		public ObservableCollection<NodeViewModel> Nodes { get; } = [];

		public ObservableCollection<ConnectionViewModel> Connections { get; } = [];

		public PendingConnectionViewModel PendingConnection { get; }
		public ICommand DisconnectConnectorCommand { get; }
		public NodifyEditorViewModel()
		{
			PendingConnection = new PendingConnectionViewModel(this);

			DisconnectConnectorCommand = new DelegateCommand<ConnectorViewModel>(connector =>
			{
				var connection = Connections.First(x => x.Source == connector || x.Target == connector);
				connection.Source.IsConnected = false;  // This is not correct if there are multiple connections to the same connector
				connection.Target.IsConnected = false;
				Connections.Remove(connection);
			});

			// TODO: This is where we'll need to load the state of controllers, connections, and props for the wiring view

			// TODO: Figure out how to load the Controller Shelf
			// Should it be a separate ViewModel?

			foreach (var item in VixenSystem.OutputControllers)
			{
				ShelfControllers.Add(new ControllerViewModel(item));
			}

			int yOffset = 10;
			foreach (ElementNode element in VixenSystem.Nodes.GetRootNodes())
			{
				PropViewModel tmp = new PropViewModel(element);
				tmp.Location = new Point(600, yOffset);
				Nodes.Add(tmp);
				yOffset += 40;
			}
		}
		public void Connect(ConnectorViewModel source, ConnectorViewModel target)
		{
			Connections.Add(new ConnectionViewModel(source, target));
		}
	}
}
