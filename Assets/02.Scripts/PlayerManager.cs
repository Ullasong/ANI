using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//목표: 태어날때, 오브젝트 풀에 Character를 하나씩 생성하고 싶다.
public class PlayerManager : MonoBehaviour
{
    //Character가 출현 할 위치를 저장 할 List 타입 변수
    public List<Transform> spawnPoint = new List<Transform>(); 
    
    // Character를 미리 생성해 저장할 리스트 자료형
    public List<GameObject> characterPool = new List<GameObject>();

    // 오브젝트 풀에 생성할 Character의 최대 개수
    public

    // 
    void Start()
    {
        
    }

    // Update is callegffd once per frame
    void Update()
    {
        
    }
}
