using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Input
{
    public class InputUpdater : IUpdater, IInputStateMachine
    {
        InputStateContext stateContext;
        InputState currentState;
        Stack<InputState> stateStack = new();

        public InputUpdater()
        {
            stateContext = new();
            // put start state here
            // TODO: set to empty state
            //currentState = new PlayerControlState() { Context = stateContext };
        }

        public void Update(GameModel model)
        {
            currentState.Update(this);
        }

        public void SetState(InputState state)
        {
            currentState = state;
        }

        public void PushState(InputState state)
        {
            stateStack.Push(currentState);
            SetState(state);
        }

        public void PopState()
        {
            if (stateStack.Count == 0)
            {
                throw new InvalidOperationException($"State stack is empty, can not pop state.");
            }

            currentState = stateStack.Pop();
        }
    }
}