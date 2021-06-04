using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    public GameObject Maus;
    private Vector3 m_Position = new Vector3(1, 1, 1);
    private void OnTriggerEnter(BoxCollider other)
    {
        Debug.Log("maus eingesammelt");

        Maus.collider = tranform.Translate(1,1,1);
        // Destroy(other.gameObject);
        //this.gameObject.SetActive(false);
    }
}