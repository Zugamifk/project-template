using UnityEngine;

namespace Demo
{
    public class ShowNextMessage : ICommand
    {
        public void Execute(GameModel model)
        {
            var data = DataService.GetData<DemoMessageData>();
            int index = (model.UI.CurrentMessageIndex + 1) % data.Messages.Length;
            model.UI.CurrentMessageIndex = index;
            model.UI.CurrentMessage.Value = data.Messages[index];
        }
    }
}