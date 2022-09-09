using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour
{
   public GameObject duck;
   public void OnEnable()
   {
      duck.SetActive(true);
   }

   public void OnDisable()
   { 
     duck.SetActive(false);
   }
   private void OnTriggerEnter2D(Collider2D other)
   {
      if(other.tag == "Player")
      {
        enabled = true;
        FindObjectOfType<GameManager>().HomeOccupied();
        
      }
   }
}
