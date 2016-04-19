#pragma strict

function Start () {
    print("BOSS created");
}

function Update () {

}

function OnTriggerEnter (other : Collider)
{
    print("BOSS!!!!!");
    other.GetComponent(ControllerScript).setBossMode(true);
    //hInGameScript.setBossMode(true)
}