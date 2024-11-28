<h1>Öğrenci Yönetim Sistemi</h1>
<p>
   Bu proje, bir öğrenci yönetim sistemi uygulamasıdır. Öğrenciler, öğretim görevlileri ve dersler gibi temel varlıkları yönetir. Kullanıcıdan alınan bilgilerle bu varlıklar oluşturulabilir ve birbirleriyle ilişkilendirilebilir. Sistem, kullanıcıya kayıtlı bilgileri ve ilişkileri listeleyerek sunar.
</p>

<h2>Özellikler</h2>
<ul>
    <li><strong>Öğrenci Yönetimi:</strong> Öğrenciler, ad, soyad ve öğrenci numarası bilgileriyle kayıt edilir.</li>
    <li><strong>Öğretim Görevlisi Yönetimi:</strong> Akademik unvan, ad ve soyad bilgileriyle öğretim görevlileri kayıt edilir.</li>
    <li><strong>Ders Yönetimi:</strong> Ders adı, kredi ve öğretim görevlisi bilgileriyle dersler oluşturulur ve öğrencilere atanır.</li>
    <li><strong>Kayıtlı Bilgilerin Görüntülenmesi:</strong> Öğrenciler, öğretim görevlileri ve derslerin detayları konsolda listelenir.</li>
    <li><strong>Konsol Tabanlı:</strong> Kullanıcı ile tüm etkileşim konsol üzerinden gerçekleştirilir.</li>
</ul>

<h2>Kullanım</h2>
<ol>
    <li>Program çalıştırıldığında kullanıcıdan sırasıyla:
        <ul>
            <li>Öğretim görevlisi bilgileri (ad, soyad, akademik unvan)</li>
            <li>Öğrenci bilgileri (ad, soyad, öğrenci numarası)</li>
            <li>Ders bilgileri (ders adı, kredi, öğretim görevlisi)</li>
        </ul>
        istenir.
    </li>
    <li>Girişler tamamlandıktan sonra, sistem kullanıcıya kayıtlı öğretim görevlilerini, öğrencileri ve derslerin detaylarını sunar.</li>
</ol>

<h2>Kurulum</h2>
<ol>
    <li>.NET ortamının yüklü olduğundan emin olun.</li>
    <li>Projeyi bilgisayarınıza klonlayın veya kodu bir dosyaya yapıştırın (ör. <code>OgrenciYonetimSistemi.cs</code>).</li>
    <li>Konsol üzerinden aşağıdaki komutlarla programı derleyip çalıştırın:</li>
    <pre>
        <code>
        csc OgrenciYonetimSistemi.cs
        OgrenciYonetimSistemi.exe
        </code>
    </pre>
</ol>

<h2>Çıktı Örneği</h2>
<pre>
--- Sistemdeki Bilgiler ---
Öğretim Görevlisi: Prof. Dr. Ahmet Yılmaz
Öğrenci: Ayşe Kara, No: 12345
Öğrenci: Mehmet Demir, No: 67890
Ders: Matematik, Kredi: 3, Öğretim Görevlisi: Ahmet Yılmaz
Kayıtlı Öğrenciler:
 - Ayşe Kara
 - Mehmet Demir

Öğretim Görevlisi Ahmet Yılmaz sisteme giriş yaptı.
Öğrenci Ayşe Kara sisteme giriş yaptı.
Öğrenci Mehmet Demir sisteme giriş yaptı.
</pre>

<h2>Gereksinimler</h2>
<ul>
    <li>.NET 5.0 veya üzeri</li>
    <li>Konsol tabanlı bir terminal</li>
</ul>

<h2>Katkıda Bulunma</h2>
<p>
   Bu projeye katkıda bulunmak isterseniz, lütfen bir <code>Pull Request</code> gönderin veya bir <code>Issue</code> açın.
</p>
