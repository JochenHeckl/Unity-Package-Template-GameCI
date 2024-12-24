using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace PackageNamespace.Editor
{
    [CustomEditor(typeof(ExampleMonoBehaviour))]
    public class ExampleMonoBehaviourEditor : UnityEditor.Editor
    {
        public override VisualElement CreateInspectorGUI()
        {
            var root = new VisualElement();
            InspectorElement.FillDefaultInspector(root, serializedObject, this);

            root.Add(new Label("This is an example editor."));

            return root;
        }
    }
}
