
### Yapay Zeka Genetik Algoritma Projesi

Bu proje, yapay zeka alanında genetik algoritmaların kullanıldığı bir uygulamadır. Proje, Matyas fonksiyonunu test problemi olarak kullanır ve Windows Form App kullanılarak geliştirilmiştir.

### Nasıl Çalışır?

Projenin çalışma prensibi şu adımları içerir:

Popülasyon Oluşturma: İlk olarak, belirlenen popülasyon boyutu kadar gen oluşturulur. Her bir gen, arzu edilen aralıkta rastgele bir değere sahip olur. Matyas fonksiyonu için genler, -10 ile 10 arasında rastgele sayılar içerir.
Elitizm ve Seçilim: Elitizm kullanılarak, belirtilen sayıda en iyi performans gösteren genler seçilir ve bir sonraki nesle taşınır.
Çaprazlama: Seçilen genler, çaprazlama oranı dikkate alınarak çaprazlanır ve yeni genler oluşturulur.
Mutasyon: Yeni oluşturulan genler, mutasyon oranına bağlı olarak rastgele değiştirilir.
Yeniden Değerlendirme: Yeni oluşturulan genler, Matyas fonksiyonu kullanılarak değerlendirilir ve her birinin uygunluk değeri hesaplanır.
Sonuçlar ve Yakınsama Grafiği: Her iterasyonda, en iyi performans gösteren genin değeri kaydedilir ve yakınsama grafiği üzerinde gösterilir. Proje sonuç olarak, kullanıcıya en iyi çözümün parametre değerlerini ve amaç fonksiyon değerini sunar.
Görsel Analiz
Proje, System.Drawing kütüphanesi kullanılarak şablon bir görsel üzerinde elde edilen genlerin koordinatlarıyla çizim yapma imkanı sunar. Bu sayede, gerçekten istenen sonuçların elde edilip edilmediği görsel olarak incelenebilir ve gerekli düzeltmeler yapılabilir.

### Nasıl Kullanılır?

Proje dosyalarını bilgisayarınıza indirin.
Visual Studio veya benzer bir geliştirme ortamında projeyi açın.
Windows Form uygulamasını çalıştırarak programı başlatın.
Form üzerinden istenen parametreleri girin veya değiştirin.
"Başlat" düğmesine basarak algoritmayı çalıştırın.
Sonuçları inceleyin ve analiz edin. Gerekirse, görsel analiz aracını kullanarak düzeltmeler yapın.

### Notlar
Bu proje, Matyas fonksiyonu için özel olarak tasarlanmıştır. Farklı fonksiyonlar için kullanılacaksa, ilgili fonksiyonun formülü ve aralığı projenin kodlarında değiştirilmelidir.

