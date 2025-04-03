using System.Collections.ObjectModel;
using System.Windows.Input;
using Vixen.Sys;
using System.Windows;

namespace DisplayNodifyEditor.ViewModels
{
	public class NodifyEditorViewModel : ObservableObject
	{
		// General Items
		public ObservableCollection<NodeViewModel> Nodes { get; } = [];
		public ObservableCollection<ConnectionViewModel> Connections { get; } = [];
		public PendingConnectionViewModel PendingConnection { get; }
		public ObservableCollection<NodeViewModel> SelectedNodes { get; set; } = [];

		// Toolbox/Sidebar items
		public ObservableCollection<ControllerViewModel> ShelfControllers { get; } = [];
		public ObservableCollection<PropViewModel> ShelfProps { get; } = [];
		private bool _ControllerShelf_IsExpanded = true;
		public bool ControllerShelf_IsExpanded
		{
			get => _ControllerShelf_IsExpanded;
			set { _ControllerShelf_IsExpanded = value; OnPropertyChanged(); }
		}

		// Commands
		public ICommand DisconnectConnectorCommand { get; }
		public ICommand DeleteCommand { get; }

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

			// TODO: Re-add to Shelf
			DeleteCommand = new DelegateCommand(() =>
			{
				// Can't use foreach (LINQ) and ObservableCollection (WPF) since they don't support concurrent modification
				for (int i = SelectedNodes.Count - 1; i >= 0; i--)
				{
					switch (SelectedNodes[i])
					{
						// TODO: Is there a better way to return deleted nodes to there correct Shelf?
						case ControllerViewModel cvm:
							ShelfControllers.Add(cvm);
							break;
						case PropViewModel pvm:
							ShelfProps.Add(pvm);
							break;
					}
					Nodes.Remove(SelectedNodes[i]);
				}
			});

			// TODO: This is where we'll need to load the state of controllers, connections, and props for the wiring view

			// TODO: Figure out how to load the Controller Shelf
			// Should it be a separate ViewModel?

			foreach (var item in VixenSystem.OutputControllers)
			{
				ShelfControllers.Add(new ControllerViewModel(item));
			}

			int yOffset = 10;
			// TODO: This is just for testing - Will have to pull actual prop list
			List<string> propNameList = ["Garage-Right", "Garage-Top", "Garage-Left", "Flood-Garage-Upper", "Flood-Garage-Lower", "Garage-Roof-Left", "Garage-Roof-Right"];
			foreach (string propName in propNameList)
			{
				PropViewModel tmp = new PropViewModel(VixenSystem.Nodes.First(item => item.Name == propName));
				tmp.Location = new Point(600, yOffset);
				Nodes.Add(tmp); //TODO: This is just for testing
				yOffset += 100;
			}
		}
		public void Connect(ConnectorViewModel source, ConnectorViewModel target)
		{
			Connections.Add(new ConnectionViewModel(source, target));
		}
	}
}
