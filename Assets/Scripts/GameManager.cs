using CarGame.Pickables;
using CarGame.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private PlayerController _player;

    [SerializeField]
    private IntEventChanel _scoreChannel;

    [SerializeField]
    public int numberOfDiamonds;

    [SerializeField]
    private GameObject portal;

    [SerializeField]
    private List<Diamond> diamonds;

    public int _score;
   
    void Start()
    {
        _player.OnPickableCollected += OnPickableCollected;
        portal.SetActive(false);
        Init();

        for (int i = 1; i < diamonds.Count; i++) {
            diamonds[i].gameObject.SetActive(false);
        }
    }

    private void Init()
    {
        _scoreChannel.Publish(_score);
    }

    private void OnPickableCollected(IPickable pickable)
    {
        if (pickable != null)
        {
            _score += pickable.ScoreIncrement;
        }

        _scoreChannel.Publish(_score);

        if(_score < numberOfDiamonds)
        diamonds[_score].gameObject.SetActive(true);
    }

    private void Update()
    {
        if (numberOfDiamonds == _score) {
            portal.SetActive(true);
        }
    }
}
