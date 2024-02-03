using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomInputManager : MonoBehaviour
{
    public MyEvent OnOnePress;
    public MyEvent OnTwoPress;
    public MyEvent OnThreePress;
    public MyEvent OnFourPress;
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One)) { OnOnePress.Invoke(); }
        if (OVRInput.GetDown(OVRInput.Button.Two)) { OnTwoPress.Invoke(); }
        if (OVRInput.GetDown(OVRInput.Button.Three)) { OnThreePress.Invoke(); }
        if (OVRInput.GetDown(OVRInput.Button.Four)) { OnFourPress.Invoke(); }
    }
}
