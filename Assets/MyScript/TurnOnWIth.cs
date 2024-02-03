using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnWIth : MonoBehaviour
{
    public Outline outline;
    //public GameObject gobj;
    public List<GameObject> gobjs = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        outline = GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var item in gobjs)
        {
            Debug.Log(item);
            if (item.activeSelf)
            {
                outline.enabled = true;
                Debug.Log("Enabled");
                break;
            }
            else
            {
                outline.enabled = false;
                Debug.Log("disabled");
            }
            
        }
        
    }
}
