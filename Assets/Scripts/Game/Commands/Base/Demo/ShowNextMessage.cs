using UnityEngine;

namespace Demo
{
    public class ShowNextMessage : ICommand
    {
        public void Execute(GameModel model)
        {
            var data = DataService.GetData<DemoMessageData>();
            int index = (model.DemoUI.CurrentMessageIndex + 1) % data.Messages.Length;
            model.DemoUI.CurrentMessageIndex = index;
            model.DemoUI.CurrentMessage.Value = data.Messages[index];
        }
    }
}