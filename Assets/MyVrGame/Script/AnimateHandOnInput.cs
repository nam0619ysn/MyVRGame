using UnityEngine;
using UnityEngine.InputSystem;

namespace MyVRGame
{
    public class AnimateHandOnInput : MonoBehaviour
    {
        #region Variables
        private Animator animator;

        public InputActionProperty pinchAnimationAction;
        public InputActionProperty gripAnimationAction;

        #endregion

        #region Unity Event Method
        private void Start()
        {
            animator = this.GetComponent<Animator>();
        }

        private void Update()
        {
            float triggerValue=pinchAnimationAction.action.ReadValue<float>();
            float gripValue=pinchAnimationAction.action.ReadValue<float>();

            Debug.Log($"====={triggerValue}");
            animator.SetFloat("Trigger", triggerValue);
            animator.SetFloat("Grip", gripValue);
        }
        #endregion
    }
}