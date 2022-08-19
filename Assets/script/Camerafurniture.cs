using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafurniture : MonoBehaviour
{
   public float speed=20f;
    public void Update()
    {
        Vector3 pos=transform.position;
        if(Input.GetKey("s"))
        {
         pos.z-=8f* Time.deltaTime;
         transform.position=pos;
        }
        if(Input.GetKey("q"))
        {
          pos.z+=8f* Time.deltaTime;
          transform.position=pos;
        }
        if(Input.GetKey("a"))
         {
        transform.Rotate(Vector3.up*8);
        }
         if(Input.GetKey("z"))
         {
        transform.Rotate(Vector3.down*8);
        }
    }
}
