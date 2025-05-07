#Unity 2D Test Case
Bu proje, Unity 2D URP şablonu kullanılarak hazırlanmış olup aşağıdaki test senaryosuna göre geliştirilmiştir. Her başlık altında kullanılan yöntemler ve kaynaklar belirtilmiştir.
Unity Hub üzerinden 2D URP template ile yeni proje oluşturuldu.
`.gitignore` dosyası [Unity.gitignore - GitHub](https://www.youtube.com/watch?v=SQ4kDdf9Bzg&t=168s) üzerinden alındı ve proje dizinine eklendi.

# 1. Sahne Kurulumu & Oyuncu Hareketi

- 2D bir sahne oluşturuldu.
- Statik bir "Ground" ve iki "wall" objesi (white block) yerleştirildi. "Ground" objesine `Ground` tag'i eklendi.
- Sprite tabanlı bir karakter sahneye eklendi.
- `playerMovement.cs` ile sağa-sola yürüme, shift ile koşma ve zemin üzerindeyken zıplama eklendi.

 ## 2. Animasyon Uygulaması

- Sprite sheet'ler Unity'e import edildi.
- `Animator` bileşeni eklendi, `player_idle`, 'player_walk', `player_run`, `player_jump` animasyon klipleri oluşturuldu.
- Animator Controller içinde `Speed` ve `isGrounded` parametreleri ile geçişler yapıldı.

## 3. Mermi Saldırısı (Object Pooling)

- `ObjectPool.cs` ile `bulletPrefab` üzerinden 20 adet mermi objesi havuzu oluşturuldu.
- `BulletMove.cs` ile mermiye yön ve hız verildi.
- Mermiler `Fire1` (left click) ile tetiklendi.

**Kaynaklar:**
[Introduction To Object Pooling In Unity]https://youtu.be/YCHJwnmUGDk?si=SPsmzylLj4OeUa8p
[2D Shooting in Unity (Tutorial)]https://youtu.be/wkKsl1Mfp5M?si=HfgqZxpobbayPL0Y

## 4. Düşman Karakteri

- Düşmanlar kare sprite ile oluşturuldu.
- `Enemy.cs` dosyasında sağlık sistemi eklendi.


**Kaynak:**
- [2D Shooting in Unity (Tutorial)]https://youtu.be/wkKsl1Mfp5M?si=HfgqZxpobbayPL0Y(Used for creating the enemy aswell)
- [Interface Kullanımı - Unity](https://learn.unity.com/tutorial/interfaces)

## 5. GameManager & UI

- `GameManager.cs` 'UIManager.cs' singleton olarak yazıldı.
- Düşman öldüğünde `AddScore()` çağrılıyor.
- Canvas içine UI Text (`TextUI`) eklendi ve skor burada güncelleniyor.

**Kaynaklar:**
- [Singleton in Unity]([https://learn.unity.com/tutorial/design-patterns-singleton](https://medium.com/@kennethmclachlan11/singleton-ui-manager-92f67099a3ae)](https://medium.com/@kennethmclachlan11/singleton-ui-manager-92f67099a3ae))

  ### Bonus: ScriptableObject ile Skor Kaydetme

- `ScoreData.cs` adında bir `ScriptableObject` oluşturuldu.
- Oyun kapanırken skor `OnApplicationQuit()` içinde ScriptableObject'e yazılıyor.
- Oyun başladığında `GameManager` bu değeri yükleyip UI'ya aktarıyor.

**Kaynaklar:**
- [Unity Docs - ScriptableObject](https://docs.unity3d.com/ScriptReference/ScriptableObject.html)
---

## Projeyi Çalıştırmak İçin

1. Unity Hub üzerinden projeyi açın.
2. `Assets/Scenes/MainScene.unity` sahnesini çalıştırın.
3. Oyunu başlatmak için `Play` tuşuna basın.
4. Hareket tuşları 'A' 'D' zıplamak 'Space' ateş etmek 'mouse0'
