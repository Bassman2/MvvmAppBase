
namespace MVVMAppBase.View
{
    public class FileView : AppView
    {
        public FileView()
        {
            this.AllowDrop = true;
            this.SetEventBinding("PreviewDragEnter", "DragCommand", true);
            this.SetEventBinding("PreviewDragOver", "DragCommand", true);
            this.SetEventBinding("PreviewDrop", "DropCommand", true);
        }
    }
}
