using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{

    public SpriteDirection ai;
    public PlayerHandler player;

    public SpriteRenderer icon;

    float distance;

    private float switchTimer;

    // Start is called before the first frame update
    [SerializeField] private float minDistance = 1.0f;
    [SerializeField] private float maxDistance = 3.0f;
    [SerializeField] private int minSortingOrder = 4;
    [SerializeField] private int maxSortingOrder = 6;

    [SerializeField] private float minOscillationSpeed = 1.0f;
    [SerializeField] private float maxOscillationSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        icon = GetComponent<SpriteRenderer>();
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
        float distance = Vector2.Distance(player.transform.position, ai.transform.position);
        distance = Mathf.Clamp(distance, minDistance, maxDistance);
        float switchRate = Mathf.Lerp(1f, 0.1f, 1 - (distance - minDistance) / (maxDistance - minDistance));
        switchTimer += Time.deltaTime;

        if (switchTimer >= switchRate)
        {
            icon.sortingOrder = icon.sortingOrder == minSortingOrder ? maxSortingOrder : minSortingOrder;
            switchTimer = 0f;
        }

    }
}
