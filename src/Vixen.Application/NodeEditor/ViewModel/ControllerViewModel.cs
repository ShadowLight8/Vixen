using OpenTK.Platform.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vixen.Sys;
using Vixen.Sys.Output;

namespace VixenApplication.NodeEditor
{
	public class ControllerViewModel : ObservableObject
	{
		private readonly OutputController _outputController;

		public string Name => _outputController.Name;
		public Guid Id => _outputController.Id;
		public int OutputCount => _outputController.OutputCount;

		public ControllerViewModel(Vixen.Sys.Output.OutputController outputController)
		{
			_outputController = outputController;
		}
	}
}
