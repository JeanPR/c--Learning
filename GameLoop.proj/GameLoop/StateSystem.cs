using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLoop
{
    class StateSystem
    {
        Dictionary<string, IGameObject> _stateStore = new Dictionary<string, IGameObject>();
        IGameObject _currentState = null;

        public void Update(double elapsedTime)
        {
            if (_currentState == null)
            {
                return; // nothing to update
            }
            _currentState.Update(elapsedTime);
        }

        public void Render()
        {
            if (_currentState == null)
            {
                return; // noting to Render
            }
            _currentState.Render();
        }

        public void AddState(string stateId, IGameObject state)
        {
            System.Diagnostics.Debug.Assert(Exists(stateId) == false);
            _stateStore.Add(stateId, state);
        }

        public void ChangeState(string stateId)
        {
            System.Diagnostics.Debug.Assert(Exists(stateId));
            _currentState = _stateStore[stateId];
        }

        public bool Exists(string stateId)
        {
            return _stateStore.ContainsKey(stateId);
        }

    }
}
