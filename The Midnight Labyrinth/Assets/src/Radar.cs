using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{

    public SpriteDirection ai;
    public PlayerHandler player;

    public SpriteRenderer icon;

    float distance;

    // Start is called before the first frame update
    [SerializeField] private float minDistanceThreshold = 1.0f;
    [SerializeField] private float maxDistanceThreshold = 3.0f;
    [SerializeField] private int minSortingOrder = 4;
    [SerializeField] private int maxSortingOrder = 6;

    [SerializeField] private float minOscillationSpeed = 1.0f;
    [SerializeField] private float maxOscillationSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, ai.transform.position);
        Debug.Log(distance);
        UpdateIconSortingOrder();
    }

    private void UpdateIconSortingOrder()
    {
        float t = Mathf.InverseLerp(minDistanceThreshold, maxDistanceThreshold, distance);
        float oscillationSpeed = Mathf.Lerp(minOscillationSpeed, maxOscillationSpeed, t);

        // Use t for linear interpolation between min and max sorting order
        int sortingOrder = Mathf.RoundToInt(Mathf.Lerp(minSortingOrder, maxSortingOrder, t));
        icon.sortingOrder = sortingOrder;

    }
}
