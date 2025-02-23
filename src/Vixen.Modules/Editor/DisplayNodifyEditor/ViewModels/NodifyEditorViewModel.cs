using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vixen.Sys;

namespace DisplayNodifyEditor.ViewModels
{
	public class NodifyEditorViewModel : ObservableObject
	{
		public ObservableCollection<ControllerViewModel> ShelfControllers { get; } = new ObservableCollection<ControllerViewModel>();
		public NodifyEditorViewModel()
		{
			// TODO: This is where we'll need to load the state of controllers, connections, and props for the wiring view

			// TODO: Figure out how to load the Controller Shelf
			// Should it be a separate ViewModel?

			foreach (var item in VixenSystem.OutputControllers)
			{
				ShelfControllers.Add(new ControllerViewModel(item));
			}
			//PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ShelfControllers)));


			//foreach (var item in VixenSystem.OutputControllers)
			//{
			//	Controllers.Add(new ControllerViewModel(item));
			//	
			//}
		}
	}
}
