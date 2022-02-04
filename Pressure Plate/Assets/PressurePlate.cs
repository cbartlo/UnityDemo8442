using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] 
    Transform thing;
  
  private void OnTriggerEnter(Collider other) {
      thing.transform.position += new Vector3(0,3,0);
      Destroy(other.gameObject);
  }
}
