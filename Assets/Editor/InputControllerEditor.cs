using UnityEngine;
using UnityEditor;

// https://answers.unity.com/questions/1085035/how-can-i-create-a-enum-like-as-component-light.html

[CustomEditor(typeof(InputController))]
public class InputControllerEditor : Editor
{
    [Tooltip("Selecting Controller allows Keyboard inputs as well as Controller inputs")]
    [SerializeField] protected ControlMode mode = ControlMode.Controller;

    public override void OnInspectorGUI()
    {
        InputController ic = (InputController)target;
        
        mode = (ControlMode)EditorGUILayout.EnumPopup("Control Mode", mode);
        ic.controlMode = mode;

        if(mode == ControlMode.Controller)
        {
            ic.controllerType = (ControllerType)EditorGUILayout.EnumPopup("Controller Type", ic.controllerType);
        }
        
    }
}
