#pragma strict

//this gameobject is disabled by default so that the playerPrefs saving functionality works for the scene.
//However you may come across a time when you need to delete old save data to test out new levels, or newly
//added stuff. To delete the save data, simply enable the "DELETE_ALL_PREFS" GameObject and Script attached and hit the play
//button. You can hit the play button again to stop the scene from running. You would then disable the 
//GameObject "DELETE_ALL_PREFS" and hit play again to see that all the save data is now deleted.

function Start () {
PlayerPrefs.DeleteAll();
}

public var Attention : String = "";
