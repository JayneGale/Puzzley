using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
 //   int swapTri;
 //   int changeFactor = 0;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                IActivatable obj = hitInfo.collider.GetComponent<IActivatable>();
                if (obj != null)
                {
                    //					Player player = hitInfo.collider.GetComponent<Player>();
                    //					if (player == null || player.IsDead() == false) // if its not an IDamagable, or if its a destroyed enemy,  or if the player is NOT dead
                    {
                        obj.Activate();
                    }
                }
            }
        }
    }
}


