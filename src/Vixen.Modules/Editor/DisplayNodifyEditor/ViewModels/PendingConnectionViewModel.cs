using System.Windows.Input;

namespace DisplayNodifyEditor.ViewModels
{
    public class PendingConnectionViewModel
    {
		private readonly NodifyEditorViewModel _editor;
		private ConnectorViewModel _source;

		public PendingConnectionViewModel(NodifyEditorViewModel editor)
		{
			_editor = editor;
			StartCommand = new DelegateCommand<ConnectorViewModel>(source => _source = source);
			FinishCommand = new DelegateCommand<ConnectorViewModel>(target =>
			{
				if (target != null)
					_editor.Connect(_source, target);
			});
		}

		public ICommand StartCommand { get; }
		public ICommand FinishCommand { get; }
	}
}
