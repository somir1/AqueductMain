using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this makes it so we can edit this in the engine. 
[System.Serializable]
public class Dialogue {
    //name of NPC
    public string name;
    //sentences you are loading into the queue
    [TextArea(3,10)]
    public string[] sentences;
    

}
