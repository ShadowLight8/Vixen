using System.Windows;
using System.Windows.Input;

namespace DisplayNodifyEditor.ViewModels
{
    public abstract class NodeViewModel : ObservableObject
	{
		private NodifyEditorViewModel _editor = default!;
		public NodifyEditorViewModel Editor
		{
			get => _editor;
			internal set => SetProperty(ref _editor, value);
		}

		private Point _location;
		public Point Location
		{ 
			get => _location;
			set => SetProperty(ref _location, value);
		}
	}
}
