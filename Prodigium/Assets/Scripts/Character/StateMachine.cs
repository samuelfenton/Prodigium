using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour {

    public State m_currentState = null;

    public void InitStateMachine()
    {
        //Initilise all states
        State[] m_states = GetComponentsInChildren<State>();

        for (int i = 0; i < m_states.Length; i++)
        {
            m_states[i].StateInit();
        }

        //Run first state
        m_currentState.StateStart();
    }

    public void UpdateStateMachine()
    {
        if (m_currentState.UpdateState())
        {
            //Find next valid state
            foreach (State state in m_currentState.m_nextStates)
            {
                if (state.IsValid())
                {
                    SwapState(state);
                    return; //Early break out
                }
            }

            //No valid states default to the defualt state
            if (!m_currentState.IsValid() && m_currentState.m_defaultState != null)
            {
                SwapState(m_currentState.m_defaultState);
            }
        }
    }

    private void SwapState(State p_nextState)
    {
        m_currentState.StateEnd();
        m_currentState = p_nextState;
        m_currentState.StateStart();
    }
}
