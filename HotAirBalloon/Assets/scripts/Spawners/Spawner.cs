using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawner : MonoBehaviour
{
    public GameObject border;
    void Start()
    {
        StartCoroutine(spawner());
    }
    IEnumerator spawner()           // собстна сама корутина
    {
        while (true)                // бесконечный цикл While - работает
        {
            yield return new WaitForSeconds(2);     // ждем 2 секунды
            float rand = Random.Range(-2.42f, 2.65f);     // рандомная позиция от -1 до 4 (чтоб удобнее было)
            GameObject newPipes = Instantiate(border, new Vector3(rand,5 , 0), Quaternion.identity);     // переносим отвественность на новый gameObject и создаем префаб
            Destroy(newPipes, 7);  // удаление нового gameObject'a через 10 секунд (если б удаляли Pipes - то ничего б не заработало)
        }
    }
}
