using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("FirstPersonPlayer").SendMessage("Exited");
    }
}
