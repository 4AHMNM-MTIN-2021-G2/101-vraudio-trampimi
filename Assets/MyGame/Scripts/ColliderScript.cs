using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    public GameObject Maus;
    private void OnTriggerEnter(BoxCollider other)
    {
        Debug.Log("maus eingesammelt");

        Maus.transform.position(1, 1, 1);
        // Destroy(other.gameObject);
        //this.gameObject.SetActive(false);
    }
}