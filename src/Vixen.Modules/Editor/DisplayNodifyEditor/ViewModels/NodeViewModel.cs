using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vixen.Sys;
using Vixen.Sys.Output;

namespace DisplayNodifyEditor.ViewModels
{
    public class NodeViewModel : ObservableObject
	{
		private readonly ElementNode _elementNode;

		public string Name => _elementNode.Name;
		//public Guid Id => _outputController.Id;
		//public int OutputCount => _outputController.OutputCount;

		public System.Windows.Point Location { get; set; }

		public NodeViewModel(ElementNode elementNode)
		{
			_elementNode = elementNode;
		}
	}
}
