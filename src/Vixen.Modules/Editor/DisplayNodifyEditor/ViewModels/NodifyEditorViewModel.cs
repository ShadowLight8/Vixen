using System.Collections.ObjectModel;
using Vixen.Sys;

namespace DisplayNodifyEditor.ViewModels
{
	public class NodifyEditorViewModel : ObservableObject
	{
		public ObservableCollection<ControllerViewModel> ShelfControllers { get; } = new ObservableCollection<ControllerViewModel>();
		public ObservableCollection<NodeViewModel> ShelfProps { get; } = new ObservableCollection<NodeViewModel>(); 
		
		public ObservableCollection<ControllerViewModel> ControllersAndProps { get; } = new ObservableCollection<ControllerViewModel>();
		
		public NodifyEditorViewModel()
		{
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
				ShelfProps.Add(new NodeViewModel(element));
			}
		}
	}
}
