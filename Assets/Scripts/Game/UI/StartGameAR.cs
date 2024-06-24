using Niantic.Lightship.SharedAR.Colocalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGameAR : MonoBehaviour
{
    [SerializeField] private SharedSpaceManager spaceManager;

    [SerializeField] private Texture2D targetImage;
    [SerializeField] private float targetImageSize;

    [SerializeField] private Button startGameButton;
    [SerializeField] private Button createRoomButton;
    [SerializeField] private Button joinRoomButton;

    private const int MAX_CLIENTS = 2;
    private string roomName = "TestRoom";
    private bool isHost;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        spaceManager.sharedSpaceManagerStateChanged += SharedSpaceManagerOnSharedSpaceManagerStateChanged;

    }

    private void SharedSpaceManagerOnSharedSpaceManagerStateChanged(SharedSpaceManager.SharedSpaceManagerStateChangeEventArgs obj)
    {
        if (obj.Tracking)
        {

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
