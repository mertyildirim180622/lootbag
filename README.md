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
