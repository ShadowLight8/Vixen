using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nodify;

namespace VixenApplication.NodeEditor
{
	public class ControllerShelfViewModel : ObservableObject
	{
		private readonly ObservableCollection<ControllerViewModel> _availableControllers;
		public IEnumerable<ControllerViewModel> AvailableControllers => _availableControllers;

		public ControllerShelfViewModel()
		{
			_availableControllers = new ObservableCollection<ControllerViewModel>();
		}
	}
}
