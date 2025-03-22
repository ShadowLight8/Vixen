using DisplayNodifyEditor.ViewModels;
using Nodify;
using System.Windows;
using System.Windows.Input;

namespace DisplayNodifyEditor.Views
{
	/// <summary>
	/// Interaction logic for NodifyEditorWindow.xaml
	/// </summary>
	public partial class NodifyEditorWindow : Window
	{
		public NodifyEditorWindow()
		{
			InitializeComponent();
		}
		private void OnDropNode(object sender, DragEventArgs e)
		{
			if (e.Source is NodifyEditor editor && editor.DataContext is NodifyEditorViewModel nevm
				&& e.Data.GetData(typeof(ControllerViewModel)) is ControllerViewModel cvm)
			{
				cvm.Location = editor.GetLocationInsideEditor(e);
				nevm.Nodes.Add(cvm);
				nevm.ShelfControllers.Remove(cvm);
				e.Handled = true;
			}
		}

		private void OnNodeDrag(object sender, MouseEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed && ((FrameworkElement)sender).DataContext is ControllerViewModel cvm)
			{
				DragDrop.DoDragDrop(this, cvm, DragDropEffects.Move);
			}
		}
	}
}
