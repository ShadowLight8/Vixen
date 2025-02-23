using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vixen.Sys.Output;

namespace DisplayNodifyEditor.ViewModels
{
	public class ControllerViewModel : ObservableObject
	{
		private readonly OutputController _outputController;

		public string Name => _outputController.Name;
		public Guid Id => _outputController.Id;
		public int OutputCount => _outputController.OutputCount;

		public System.Windows.Point Location { get; set; }

		public ControllerViewModel(OutputController outputController)
		{
			_outputController = outputController;
		}
	}
}
