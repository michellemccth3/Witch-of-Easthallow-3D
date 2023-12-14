using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    public GameObject gameObject;
   void Start (){
           StartCoroutine(RemoveAfterSeconds(2, gameObject));
   }
   IEnumerator RemoveAfterSeconds (int seconds, GameObject obj){
       yield return new WaitForSeconds(seconds);
       obj.SetActive(false);
   }

}
