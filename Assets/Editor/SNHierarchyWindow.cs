// Kyla NeSmith
// Last edited: Nov. 30, 2018

using UnityEngine;
using UnityEditor;


// https://www.youtube.com/watch?v=491TSNwXTIg
// https://answers.unity.com/questions/38783/repainting-an-editorwindow-when-its-not-the-curren.html
// https://docs.unity3d.com/ScriptReference/EditorGUILayout.Toggle.html
// https://docs.unity3d.com/ScriptReference/EditorGUI.BeginDisabledGroup.html
// https://www.raywenderlich.com/939-extend-the-unity3d-editor
public class SNHierarchyWindow : EditorWindow
{
    [SerializeField] public static SceneNode root;

    [SerializeField] private static bool preview = true;

    [MenuItem("Window/SceneNode Hierarchy")]
    public static void ShowWindow()
    {
        GetWindow<SNHierarchyWindow>("SN Hierarchy");
    }

    private void OnGUI()
    {
        preview = EditorGUILayout.Toggle("Active Preview", preview);

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("The Root", EditorStyles.boldLabel);
        root = EditorGUILayout.ObjectField(root, typeof(SceneNode), true) as SceneNode;
        EditorGUILayout.EndHorizontal();
    }

    private void Update()
    {
        ShowXForm();
    }

    public static void ShowXForm()
    {
        if (root != null && preview)
        {
            SceneNode tmp = root;
            Matrix4x4 i = Matrix4x4.identity;
            tmp.CompositeXform(ref i);
        }
    }
}
