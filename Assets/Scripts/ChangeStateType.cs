using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ChangeStateType : MonoBehaviour
{
    private UIDocument UI;
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        UI = GetComponent<UIDocument>();
        button = UI.rootVisualElement.Q<Button>("Change");
        button.clicked += ChangeState;
    }

    // Update is called once per frame
    void Update()
    {
        if (!LoadManager.instance.useClassesInsteadOfIf)
            button.text = "If / Else";
        else
            button.text = "Class";
    }

    public static void ChangeState()
    {
        LoadManager.instance.useClassesInsteadOfIf = !LoadManager.instance.useClassesInsteadOfIf;
    }
}
