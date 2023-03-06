using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    [SerializeField] Color32 hasPackageColor = new Color32(1,254,1,254);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,254);


    private bool hasPackage;
    [SerializeField] float destroyDelay = 0.2f;

    private SpriteRenderer spriteRenderer;

    private int playerScore = 0;
    
    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {

        Debug.Log("Collision");        

    }

    private void OnTriggerEnter2D(Collider2D other) 
    {

        if (other.tag == "Package" && !hasPackage) {
            Destroy(other.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor;
            hasPackage = true;

        }else if (other.tag == "Customer") {
            Debug.Log("Customer");
            if (hasPackage){
                spriteRenderer.color = noPackageColor;
                hasPackage = false;
                playerScore += 1;
                Debug.Log(string.Format("Package Delivered! Score : {0}", playerScore));
            } else {
                Debug.Log("Package Missing");
            }
        }

    }
}
