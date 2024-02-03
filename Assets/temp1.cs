using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temp1 : MonoBehaviour
{
    public GameObject single;
    public GameObject multiple;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        single.SetActive(false);
        multiple.SetActive(true);
    }

    private void OnDisable()
    {
        single.SetActive(true);
        multiple.SetActive(false);
    }
}
