using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneOne : MonoBehaviour {                                         

    // Use this for initialization
    void Start () {

        //set camera constraints with camera script
        levelConstants.setCameraConstraints(7.5f, -11.8f);

        //bring in the level constants: pause menu, initial overlay, johnny, camera identification
        this.gameObject.AddComponent<levelConstants>();

        levelConstants.johhnyPosOvrd = true;
        levelConstants.johnnyXOvrd = -14.5f;
        levelConstants.johnnyYOvrd = -2.76f;
        levelConstants.johnnyZOvrd = -0.5f; 
	}                                                          
    
}
