#pragma strict

function Start () {

}

function Update () {

}

function OnTriggerEnter (other : Collider)
{
    Debug.Log("BOSS!!!!!");
    other.GetComponent(ControllerScript).setBossMode(true);
    //hInGameScript.setBossMode(true)
}