using UnityEngine;
using UnityEngine.Events;

public class AnimBehaviour : StateMachineBehaviour
{
    public UnityEvent stateEnterEvent;
   
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        stateEnterEvent.Invoke();
    }
}