using FairyGUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneButtonLayout : MonoBehaviour
{
    GComponent mainwindow;
    Transition transition;
    Controller controller;

    private void Awake()
    {
        //使用全局滚动条时，一定要注意，需要在通过全局进行设置
        UIPackage.AddPackage("FairyGUI/OneButtonPackage");
        UIConfig.verticalScrollBar = "ui://OneButtonPackage/ScrollBar_VT";
        UIConfig.horizontalScrollBar = "ui://OneButtonPackage/ScrollBar_HZ";
        UIConfig.defaultScrollBarDisplay = ScrollBarDisplayType.Visible;


    }
    // Start is called before the first frame update
    void Start()
    {
        mainwindow = GetComponent<UIPanel>().ui;
        transition = mainwindow.GetTransition("start");
        controller = mainwindow.GetController("Page");
        Stage.inst.onKeyDown.Add(OnKeyDown);
    }


    void OnKeyDown(EventContext context)
    {
        if (context.inputEvent.keyCode == KeyCode.A)
        {
            if (transition != null)
            {
                transition.Play();
            }
        }
        if (context.inputEvent.keyCode == KeyCode.Q)
        {
            if (controller != null)
            {
                controller.SetSelectedIndex(0);
            }
        }
        if (context.inputEvent.keyCode == KeyCode.E)
        {
            if (controller != null)
            {
                controller.SetSelectedIndex(1);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
