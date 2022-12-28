using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBox : MonoBehaviour
{

    private MeshRenderer hideBox;
    // Start is called before the first frame update
    void Start()
    {
        hideBox = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            hideBox.enabled = !hideBox.enabled;
        }
    }
}
