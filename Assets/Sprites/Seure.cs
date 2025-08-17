using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections;

public class Seure : MonoBehaviour {
    public Tilemap tilemap;

    private void OnCollisionEnter2D(Collision2D other) {
         // Prüfen, ob das Objekt mit dem Tilemap-Collider kollidiert
        Vector3 worldPosition = other.contacts[0].point;
        Vector3Int tilePosition = tilemap.WorldToCell(worldPosition);

        
        // Hole die Tile an der Kollisionsposition
        TileBase tileAtPosition = tilemap.GetTile(tilePosition);

        Debug.Log(tileAtPosition);
        if(tileAtPosition != null){
            string tileName = ((Tile) tileAtPosition).sprite.name;
            switch(tileName){
                case "tilemap_packed_13":
                case "tilemap_packed_29":
                case "tilemap_packed_45":
                case "tilemap_packed_14":
                case "tilemap_packed_15":
                case "tilemap_packed_30":
                case "tilemap_packed_31":
                case "tilemap_packed_46":
                case "tilemap_packed_47":
                case "tilemap_packed_94":
                case "tilemap_packed_95": {
                            Debug.Log("Ich bin Säure, ich bin nicht basiert");
                            StartCoroutine(TeleportAfterDelay(other.gameObject));
                            break;
                }

            }
        }

    }
    private IEnumerator TeleportAfterDelay(GameObject player) {
                        yield return new WaitForSeconds(2f); // 2 Sekunden warten
                        player.transform.position = new Vector3(-15.25f, 2.14f , 0f);
    }
}