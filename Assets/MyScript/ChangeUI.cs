using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeUI : MonoBehaviour
{
    public List<GameObject> UIgobj = new List<GameObject>();
    public int index;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //OnUIChange();
    }

    public void OnUIChange()
    {
        index += 1;
        int listIndex = index % UIgobj.Count;
        foreach (var item in UIgobj)
        {
            item.SetActive(false);
        }
        UIgobj[listIndex].SetActive(true);
    }
}
