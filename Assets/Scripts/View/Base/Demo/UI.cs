using TMPro;
using UnityEngine;

namespace Demo
{
    public class UI : MonoBehaviour
    {
        [SerializeField]
        TextMeshProUGUI messageText;

        void Start()
        {
            Game.Model.DemoUI.CurrentMessage.ValueChanged += OnMessageChanged;
        }

        void OnMessageChanged(string _, string newMessage)
        {
            messageText.text = newMessage;
        }

        public void Clicked_NextButton()
        {
            Game.Do(new ShowNextMessage());
        }
    }
}
