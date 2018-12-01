// Kyla NeSmith
// last edited: Nov. 30, 2018
// Description: customer editor UI

using UnityEngine;
using UnityEditor;

// https://answers.unity.com/questions/1085035/how-can-i-create-a-enum-like-as-component-light.html
// https://answers.unity.com/questions/461370/displaying-tooltips-hint-for-variables-in-inspecto.html

[CustomEditor(typeof(InputController))]
public class InputControllerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        InputController ic = (InputController)target;
        
        ic.controlMode = (ControlMode)EditorGUILayout.EnumPopup(
            new GUIContent("Control Mode", "Selecting Controller still allows Keyboard inputs"), ic.controlMode);

        if(ic.controlMode == ControlMode.Controller)
        {
            ic.controllerType = (ControllerType)EditorGUILayout.EnumPopup(
                new GUIContent("Controller Type", "Why are you looking at me? I have nothing to say!"), ic.controllerType);
        }
        
    }
}
