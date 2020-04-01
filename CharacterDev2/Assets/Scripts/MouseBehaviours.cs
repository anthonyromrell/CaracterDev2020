using UnityEngine;
using UnityEngine.Events;

public class MouseBehaviours : MonoBehaviour
    {
        public UnityEvent mouseDownEvent, mouseEnterEvent;

        private void OnMouseDown()
        {
            mouseDownEvent.Invoke();
        }

        private void OnMouseEnter()
        {
            mouseEnterEvent.Invoke();
        }
}
