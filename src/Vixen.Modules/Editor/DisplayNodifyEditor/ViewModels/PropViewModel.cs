using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vixen.Sys;

namespace DisplayNodifyEditor.ViewModels
{
	class PropViewModel : NodeViewModel
	{
		private readonly ElementNode _elementNode;

		public ObservableCollection<ConnectorViewModel> Input { get; set; } = [];
		public ObservableCollection<ConnectorViewModel> Output { get; set; } = [];

		public string Name => _elementNode.Name;
		public Guid Id => _elementNode.Id;
		//public int OutputCount => _elementNode.OutputCount;

		public PropViewModel(ElementNode elementNode)
		{
			_elementNode = elementNode;
		}
	}
}
