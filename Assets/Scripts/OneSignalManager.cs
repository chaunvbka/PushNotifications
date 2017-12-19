﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneSignalManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

        // Enable line below to debug issues with setuping OneSignal. (logLevel, visualLogLevel)
        OneSignal.SetLogLevel(OneSignal.LOG_LEVEL.VERBOSE, OneSignal.LOG_LEVEL.NONE);

        // The only required method you need to call to setup OneSignal to receive push notifications.
        // Call before using any other methods on OneSignal.
        // Should only be called once when your app is loaded.
        // OneSignal.Init(OneSignal_AppId);
        OneSignal.StartInit("465e5201-f620-429b-b373-a6aa2d466ccf")
                 .HandleNotificationReceived(HandleNotificationReceived)
                 .HandleNotificationOpened(HandleNotificationOpened)
                 //.InFocusDisplaying(OneSignal.OSInFocusDisplayOption.Notification)
                 .EndInit();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // Called when a notification is opened.
    // The name of the method can be anything as long as the signature matches.
    // Method must be static or this object should be marked as DontDestroyOnLoad
    public static void HandleNotificationOpened(OSNotificationOpenedResult result)
    {
        //OSNotificationPayload payload = result.notification.payload;
        //string message = payload.body;
        //string actionID = result.action.actionID;

        //print("GameControllerExample:HandleNotificationOpened: " + message);
        //extraMessage = "Notification opened with text: " + message;

        //Dictionary<string, object> additionalData = payload.additionalData;
        //if (additionalData == null)
        //    Debug.Log("[HandleNotificationOpened] Additional Data == null");
        //else
        //    Debug.Log("[HandleNotificationOpened] message " + message + ", additionalData: " + Json.Serialize(additionalData) as string);

        //if (actionID != null)
        //{
        //    // actionSelected equals the id on the button the user pressed.
        //    // actionSelected will equal "__DEFAULT__" when the notification itself was tapped when buttons were present.
        //    extraMessage = "Pressed ButtonId: " + actionID;
        //}
    }

    // Called when your app is in focus and a notificaiton is recieved.
    // The name of the method can be anything as long as the signature matches.
    // Method must be static or this object should be marked as DontDestroyOnLoad
    private static void HandleNotificationReceived(OSNotification notification)
    {
        //OSNotificationPayload payload = notification.payload;
        //string message = payload.body;

        //print("GameControllerExample:HandleNotificationReceived: " + message);
        //print("displayType: " + notification.displayType);
        //extraMessage = "Notification received with text: " + message;

        //Dictionary<string, object> additionalData = payload.additionalData;
        //if (additionalData == null)
        //    Debug.Log("[HandleNotificationReceived] Additional Data == null");
        //else
        //    Debug.Log("[HandleNotificationReceived] message " + message + ", additionalData: " + Json.Serialize(additionalData) as string);
    }
}
