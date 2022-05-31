using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandController : MonoBehaviour
{
    [SerializeField] InputActionReference controllerActionGrip;
    [SerializeField] InputActionReference controllerActionTrigger;

    private Animator _handAnimator;

    private void Awake()
    {
        controllerActionGrip.action.performed += GripPress;
        controllerActionTrigger.action.performed += TriggerPress;
    }

    private void GripPress(InputAction.CallbackContext obj) => _handAnimator.SetFloat("Trigger", obj.ReadValue<float>());

    private void TriggerPress(InputAction.CallbackContext obj) => _handAnimator.SetFloat("Trigger", obj.ReadValue<float>());

}
