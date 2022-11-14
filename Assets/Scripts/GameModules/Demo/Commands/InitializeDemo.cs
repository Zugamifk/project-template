using Demo.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo.Commands
{
    public class InitializeDemo : CreateModel<DemoModel>
    {
        protected override void OnCreatedModel(GameModel game, DemoModel model)
        {
            model.CurrentMessageIndex = -1;
            Game.Do(new ShowNextMessage());
        }
    }
}
