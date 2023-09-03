# DesignPatterns

## Chain of Responsibility Design Pattern : 
Chain of Responsibility (Sorumluluk Zinciri) tasarım deseni, nesne tabanlı programlamada ve yazılım mühendisliğinde kullanılan bir davranışsal desen türüdür. Bu desen, bir dizi işlemi sırayla gerçekleştiren ve her bir işlemi tek tek ele alabilen nesnelerin bir zincirini oluşturmayı amaçlar. Temel olarak, bir isteğin başlangıç noktasından itibaren işlenmesini sağlar ve bu işlemi sorumluluk zinciri boyunca farklı nesneler üzerinden geçerek gerçekleştirir.

Chain of Responsibility deseni, birçok farklı senaryoda kullanılabilir. Örneğin, kullanıcı isteklerini işlemek veya bir dizi filtreleme veya doğrulama işlemini uygulamak gibi durumlar için idealdir. Bu deseni kullanarak, isteğin işlenme sürecini esnek ve genişletilebilir hale getirebilirsiniz.

Anahtar bileşenler ve terimler:

Handler (İşleyici): Bu, desendeki zincirin elemanlarının genel arayüzünü temsil eder. Herhangi bir işlemin ele alınması için kullanılan metodları içerir.

ConcreteHandler (Somut İşleyici): Bu, gerçek işlemleri gerçekleştiren sınıflardır. İşleyici arayüzünü uygular ve gelen isteği ele alabilir veya gerektiğinde sonraki işleyiciye iletebilir.

Client (Müşteri): Bu, zinciri başlatan ve istekleri zincire ileten sınıftır.

Chain of Responsibility deseni kullanılarak iş akışı şu şekilde gerçekleşir:

İstek zinciri başlar ve bir istek oluşturulur.
İstek zincirinin ilk işleyicisi belirlenir ve istek bu işleyiciye iletilir.
İlk işleyici, isteği ele alır ve gerektiğinde işlemi gerçekleştirir.
Eğer ilk işleyici isteği ele alamazsa veya ele almak istemezse, istek bir sonraki işleyiciye iletilir.
Bu süreç isteğin zincir boyunca ilerlemesi ve uygun işleyici tarafından ele alınması veya zincir sonuna ulaşılana kadar devam eder.
Chain of Responsibility deseni, yazılımın esnekliğini ve genişletilebilirliğini artırırken, nesneler arasındaki sıkı bağımlılıkları azaltmaya yardımcı olabilir. Bu desen, özellikle birden çok işlem veya filtreleme adımının olduğu karmaşık işlemlerde kullanıldığında faydalı olabilir.

## CQRS (Command Query Responsibility Segregation) Design Pattern : 
CQRS (Command Query Responsibility Segregation) tasarım deseni, yazılım uygulamalarının karmaşık veri yönetimi gereksinimlerini ele almak için kullanılan bir mimaridir. Bu desen, veri okuma ve yazma işlemlerini ayrı işlemler olarak ele alarak, uygulamanın performansını, ölçeklenebilirliğini ve sürdürülebilirliğini artırmayı hedefler.

CQRS deseninin temel fikri, bir uygulamanın sorgulama (query) ve komut (command) işlemlerini farklı modeller kullanarak ele almasıdır:

Komut Modeli (Command Model): Veri değiştirme işlemlerini yönetir. Yani, uygulamanın durumunu değiştiren, veri tabanına yazan, güncelleyen veya silen işlemler burada gerçekleşir. Komut modeli, genellikle sadece yazma işlemlerine odaklanır ve sık değişebilir. Bu sayede yazma tarafı, daha farklı gereksinimleri ele alabilecek ve optimize edilebilecek şekilde tasarlanabilir.

Sorgu Modeli (Query Model): Veri okuma işlemlerini yönetir. Uygulama tarafından sunulan sorgularla veritabanından veri okuyarak sonuçları kullanıcılara sunar. Sorgu modeli, yazma işlemlerinin etkilenmediği bir kopya veritabanını veya önbelleği kullanarak sorgulama performansını artırabilir. Bu sayede okuma işlemleri hızlı ve ölçeklenebilir olabilir.

CQRS deseninin bazı ana faydaları şunlardır:

Performans ve Ölçeklenebilirlik: CQRS, yazma ve okuma işlemlerini ayırdığı için, her taraftaki gereksinimlere göre optimize edilebilir ve böylece uygulamanın performansı artar. Ayrıca, yoğun okuma işlemleri için önbellek kullanma olanağı sağlar.

Sürdürülebilirlik: Karmaşık uygulamaların daha modüler ve sürdürülebilir bir şekilde tasarlanmasına yardımcı olur. Her model, kendi sorumluluklarına odaklanır ve bu nedenle daha az bağımlıdır.

Deneyim Odaklı Tasarım: CQRS, uygulamanın komut ve sorgu işlemlerinin farklı modellerde ele alınmasını sağlar. Bu da uygulama geliştiricilerinin, her bir işleve daha uygun olan araçları ve teknikleri kullanmalarına olanak tanır.

Ancak, CQRS desenini uygulamak, gerekli durumda artan karmaşıklık ve efor gerektirebilir. Bu nedenle, uygulamanın ihtiyaçlarına ve ölçeğine bağlı olarak, her zaman CQRS kullanmak gerekli olmayabilir. Yine de, büyük ve karmaşık uygulamalarda performans ve ölçeklenebilirlik ihtiyaçları, CQRS desenini kullanmayı cazip hale getirebilir.

Command => Insert,Update,Delete Propertyleri
Query => Select Parametreleri
Result => Select Propertyleri
Handler => CRUD

## Template Method Design Pattern :
Template Method tasarım deseni, bir sürecin temel yapısını tanımlayan ancak bazı adımların alt sınıflar tarafından uygulanmasına izin veren bir tasarım desenidir. Bu desen, bir süreç veya algoritmanın genel yapısını belirleyen bir ana sınıfı içerir ve bazı adımların alt sınıflar tarafından özelleştirilmesine olanak tanır. Böylece aynı temel süreç farklı alt sınıflar tarafından farklı davranışlarla uygulanabilir.

Template Method deseni, özellikle şu durumlar için kullanışlıdır:

Bir algoritmanın genel yapısı sabittir, ancak bazı adımların alt sınıflar tarafından farklı şekillerde uygulanması gerekmektedir.
Kod tekrarını azaltmak ve alt sınıflarda ortak olan işlemleri merkezi bir noktada tutmak istenir.
Bir temel sınıfın davranışını değiştirmeden alt sınıflarda belirli adımları özelleştirmek istenir.
Template Method deseni, genellikle bir ana sınıfın içinde abstract (soyut) metotlar ve somut metotlar olarak adlandırılan özelleştirilemeyen adımları içerir. Ana sınıf, bu adımları belirli bir sırayla çağırarak genel algoritmayı yürütür. Alt sınıflar, abstract metotları uygulayarak ve gerektiğinde somut metotları geçersiz kılarak kendi özelleştirilmiş davranışlarını sağlarlar.

Örnek olarak, bir kahve veya çay yapma sürecini düşünelim. Genel olarak su kaynatma, içeceği demleme, bardağa dökme gibi adımlar vardır. Ancak kahve ve çay bu adımları farklı şekillerde gerçekleştirir. Template Method deseni, bu genel yapının korunmasını ve alt sınıfların sadece ilgili adımları uyarlamasını sağlar.

## Observer Design Pattern :
Gözlemci Tasarım Deseni (Observer Design Pattern), davranışsal tasarım desenlerinden biridir. Bu desen, nesneler arasındaki bağımlılığı azaltmak ve bir nesnenin durumu değiştikçe diğer nesnelere otomatik olarak bildirim göndermek için kullanılır. Gözlemci deseni, birçok nesne arasında tek yönlü bir iletişim kurmanın etkili bir yolunu sunar.

Temel olarak, gözlemci deseni şu iki ana bileşeni içerir:

Subject (Özne): Bu, durumu takip edilen ve gözlemcilere bildirim gönderen nesneyi temsil eder. Özne, içerdiği gözlemcilere (observer) durum değişiklikleri hakkında haber verir.

Observer (Gözlemci): Bu, özneyi izleyen ve öznenin durumundaki değişiklikleri yakalamak isteyen nesneleri temsil eder. Gözlemciler, öznenin durumu değiştikçe haber alır ve buna göre gerekli işlemleri gerçekleştirir.

Gözlemci deseni genellikle gerçek dünya senaryolarında kullanılır. Örneğin, bir hava durumu istasyonu, hava durumu bilgilerini alarak çeşitli medya platformlarına (televizyon, radyo, internet siteleri) iletmek isteyebilir. Burada hava durumu istasyonu özne olarak, medya platformları ise gözlemciler olarak düşünülebilir. Hava durumu değiştikçe, istasyon medya platformlarına güncellemeleri ileterek haberdar eder.

Gözlemci deseninin temel amacı, nesneler arasındaki sıkı bağımlılıkları azaltmak ve bir nesnenin durumu değiştiğinde diğer nesnelere etkili bir şekilde bildirim göndermektir. Bu sayede kodun daha esnek, sürdürülebilir ve genişletilebilir olması sağlanır.

## Unit Of Work Design Pattern :
Unit of Work (Çalışma Birimi) tasarım deseni, yazılım geliştirme süreçlerinde özellikle veritabanı işlemlerini yönetmek ve işlemlerin tutarlılığını sağlamak için kullanılan bir tasarım desenidir. Bu desen, veritabanı işlemlerini gruplayarak ve koordine ederek işlemlerin daha iyi kontrol edilmesini ve veritabanı işlemlerinin daha güvenli ve tutarlı bir şekilde gerçekleştirilmesini sağlar.

Unit of Work tasarım deseninin ana bileşenleri şunlardır:

Unit of Work (Çalışma Birimi): Bu bileşen, veritabanı işlemlerini koordine eden ana sınıftır. Unit of Work sınıfı, işlemleri gruplar, sıraya koyar ve işlemlerin başarılı bir şekilde tamamlanmasını sağlar.

Repository (Depo): Repository sınıfları, veritabanı işlemleri için kullanılan özel sınıflardır. Her veri tabanı nesnesi için bir Repository sınıfı olabilir ve bu sınıflar, veritabanına erişim işlemlerini ve sorgularını gerçekleştirir.

Entity (Varlık): Entity sınıfları, veritabanındaki tablolara karşılık gelen nesnelerdir. Bu nesnelerin CRUD (Create, Read, Update, Delete) işlemleri için Repository sınıfları tarafından kullanılırlar.

Unit of Work tasarım deseninin temel amaçları şunlardır:

Veritabanı işlemlerini gruplama: Unit of Work, bir işlem veya işlem grubunu tek bir iş birimi olarak gruplar. Bu, işlemlerin daha iyi yönetilmesini ve koordine edilmesini sağlar.

İşlemlerin sırasını belirleme: Unit of Work, işlemlerin sırasını belirler ve bu sıraya göre işlemlerin gerçekleştirilmesini sağlar.

İşlemlin tutarlılığını sağlama: Unit of Work, işlemlerin başarılı bir şekilde tamamlanmasını sağlar veya hata durumunda geri alınmasını yönetir, bu sayede veritabanının tutarlılığını korur.

Tekrar kullanılabilirlik: Bu desen, veritabanı işlemlerini daha modüler hale getirir ve yeniden kullanılabilir sınıfların oluşturulmasına yardımcı olur.

Unit of Work tasarım deseni, özellikle büyük ve karmaşık uygulamalarda veritabanı işlemlerini daha etkili bir şekilde yönetmek ve veritabanı işlemlerinin güvenliğini sağlamak için yaygın olarak kullanılır. Bu desen, yazılımın bakımını kolaylaştırır ve veritabanı işlemlerinin daha düzenli bir şekilde yönetilmesini sağlar.

## Repository Design Pattern :
Repository tasarım deseni, yazılım geliştirme süreçlerinde veri erişimini düzenlemek ve yönetmek için kullanılan bir desen olarak karşımıza çıkar. Bu desen, veri tabanıyla iletişim kurmak, veri işlemlerini gerçekleştirmek ve veri kaynaklarını yönetmek gibi işlemleri soyutlamayı hedefler.

Repository deseni, genellikle nesne tabanlı programlama (OOP) ve katmanlı mimarilerle birlikte kullanılır. Bu tasarım deseni, veritabanına erişimi merkezi bir yerde toplar ve iş mantığını veri erişim detaylarından ayırarak kodun daha temiz, düzenli ve bakımı daha kolay hale gelmesini sağlar.

Repository deseninin ana amacı, veri tabanı işlemlerini ve veri erişimini izole etmek ve soyutlamaktır. Bu, aşağıdaki avantajları sağlar:

Kodun Daha Bakımı Kolay Olması: Veri erişim kodunu merkezi bir yerde toplamak, kodun bakımını ve güncellemelerini daha kolay hale getirir. Veritabanı yapısında değişiklik yapılması gerektiğinde, sadece repository sınıflarında değişiklik yapılması yeterli olabilir.

Daha İyi Test Edilebilirlik: Repository deseni, veri erişim işlemlerini soyutladığı için, iş mantığını test etmek istediğinizde veritabanı ile ilgili detaylarla uğraşmak zorunda kalmazsınız. Bu da kodun daha iyi bir şekilde test edilmesini sağlar.

Yeniden Kullanılabilirlik: Veri erişim kodunu ayrı bir katmana yerleştirmek, aynı veri kaynaklarına farklı parçaların erişebilmesini sağlar ve böylece kodun yeniden kullanılabilirliğini artırır.

Repository desenini kullanarak, veri erişim kodu ve iş mantığı ayrılabilir. Genellikle bir arayüz veya soyut sınıf tanımlanır ve bu arayüzü veya soyut sınıfı gerçek veri kaynağına erişimi sağlayan sınıflar (örneğin, veritabanı sınıfları) uygular. Bu sayede, iş mantığı veri erişim detaylarından izole edilmiş olur.

## Composite Design Pattern :
Composite tasarım deseni, nesneleri ağaç benzeri bir hiyerarşi yapısında bir araya getirerek bütün-parça ilişkilerini temsil etmek ve işlemek için kullanılan bir tasarım desenidir. Bu desen, parça ve bütün ilişkilerini yönetmeyi kolaylaştırarak, tekil nesnelerin ve bu nesnelerin kompozit yapıların bir parçası olduğu nesnelerin birleşik bir şekilde ele alınmasını sağlar.

Ana amaç, bireysel nesneleri ve bu nesnelerin kompozit yapılarını tek bir arabirimle işlemektir. Böylece, istemci kodunun bir parça veya bütün nesneyi ayırt etmesi gerekmez, çünkü her ikisi de aynı arabirim aracılığıyla erişilebilir hale gelir.

Composite deseninde temel unsurlar şunlardır:

Component (Bileşen): Bu, hem bireysel nesneleri hem de kompozit nesneleri temsil eden ortak bir arabirimdir. Bireysel nesnelerin ve kompozit nesnelerin ortak operasyonları bu arabirimde tanımlanır.

Leaf (Yaprak): Bireysel nesneleri temsil eder ve genellikle kompozit yapının yaprak düğümleri olarak adlandırılır. Bu nesneler kompozit yapının en alt seviyesinde yer alır.

Composite (Kompozit): Bileşenleri içerebilen ve genellikle alt bileşenleri işlemek için bir dizi operasyon sunan nesnelerdir. Kendi içinde bileşenleri tutabilir ve kompozit yapının dalları olarak hizmet eder.

Composite deseninin avantajları şunlar olabilir:

Bireysel nesneler ve kompozit yapılar aynı arabirim aracılığıyla yönetildiği için istemci kodu basitleşir.
Yeni bileşen türleri eklemek kolaydır. Sadece yeni bir Leaf veya Composite türü oluşturmanız gerekir.
Kod tekrarı en aza indirgenir ve bakım daha kolay hale gelir.
Bileşenler hiyerarşik bir yapıda düzenlendiği için nesneler arasındaki ilişkiler açıkça ifade edilir.
Bu tasarım deseni, özellikle nesnelerin hiyerarşik bir yapıda organize edildiği durumlarda, örneğin grafik nesneleri, belge ağaçları veya menüler gibi durumlar için kullanışlıdır.

## Mediator Design Pattern :
Mediator tasarım deseni, nesneler arasındaki iletişimi düzenlemek ve merkezi bir noktada yönetmek amacıyla kullanılan bir yazılım tasarım desenidir. Bu desen, karmaşık ilişkileri ve etkileşimleri daha sade ve sürdürülebilir bir şekilde ele almanın yollarını sunar. Genellikle birçok nesnenin birbirleriyle doğrudan iletişim kurması yerine, iletişimin bir aracı (mediator) nesne üzerinden gerçekleşmesini sağlar.

Mediator deseni, aşağıdaki temel bileşenlerden oluşur:

Mediator (Aracı): Nesneler arası iletişimi yöneten merkezi bir bileşendir. Diğer nesneler arasındaki iletişimi düzenler ve bu iletişimin nasıl gerçekleşeceğini belirler.

Concrete Mediator (Somut Aracı): Mediator arayüzünü uygulayan ve nesneler arasındaki iletişimi gerçekleştiren sınıftır. Bu sınıf, nesnelerin isteklerini alır, gerekli işlemleri yapar ve gerektiğinde diğer nesnelere iletebilir.

Colleague (İş Arkadaşı): Mediator ile iletişim kuran nesnelerdir. Bu nesneler, diğer nesnelerle doğrudan iletişim kurmak yerine istekleri ve bilgileri Mediator üzerinden paylaşırlar.

Concrete Colleague (Somut İş Arkadaşı): Colleague arayüzünü uygulayan ve Mediator ile iletişim kuran nesnelerdir. Bu nesneler, işlevsel görevleri gerçekleştirirken Mediator üzerinden diğer nesnelerle iletişim kurabilirler.

Mediator deseni, özellikle birçok nesnenin birbirleriyle sıkı sıkıya bağlı olduğu ve bir değişiklik yapıldığında diğer nesneleri etkileyebilecek bir senaryoda kullanışlıdır. Bu desen, kodun daha modüler ve bakımı daha kolay hale gelmesini sağlayarak karmaşıklığı azaltabilir.

Örnek bir senaryoda, bir uçuş rezervasyon sistemi düşünelim. Uçuşlar, yolcular, oteller ve arabalar arasında etkileşimler olabilir. Mediator deseni kullanarak uçuş rezervasyon sistemi içindeki nesnelerin iletişimini düzenlemek, kodun daha anlaşılır ve yönetilebilir olmasını sağlayabilir.

## Iterator Design Pattern :
Iterator tasarım deseni, bir koleksiyonun veya veri yapısının elemanlarını sırayla gezmek ve erişmek için bir arabirim sağlayan bir tasarım desenidir. Bu desen, koleksiyonların iç yapısına bakılmaksızın elemanlara erişim sağlar ve koleksiyonun yapısını gizler, böylece koleksiyon üzerinde yapısal değişiklikler yapılabilirken döngülerin veya iterasyonların değiştirilmesine gerek kalmaz.

Iterator tasarım deseni, genellikle aşağıdaki temel bileşenleri içerir:

Iterator Arabirimi (Iterator Interface): Bu arabirim, koleksiyon üzerinde gezinme işlevlerini tanımlar. Bu işlevler, bir sonraki elemana geçme, geçerli elemana erişme, koleksiyonun sonuna gelip gelinmediğini kontrol etme gibi işlemleri içerebilir.

Somut Iteratorlar (Concrete Iterators): Bu sınıflar, belirli bir koleksiyonun üzerinde gerçek gezinme mantığını uygular. Farklı koleksiyon türleri için farklı somut iterator sınıfları olabilir.

Koleksiyon Arabirimi (Collection Interface): Bu arabirim, iterasyon için elemanları sağlar. Iterator nesnelerini oluşturmak için kullanılır.

Somut Koleksiyonlar (Concrete Collections): Bu sınıflar, koleksiyon arabirimini uygular ve koleksiyonun gerçek yapısını yönetir. Elemanlara erişim sağlamak için bir iterator nesnesi döndürürler.

Iterator deseninin temel avantajları şunlar olabilir:

Koleksiyonun yapısı ve elemanlarının organizasyonu, istemci kodundan gizlenir.
İstemci kodu, farklı koleksiyon türlerine göre değiştirilmeden iterasyon işlemlerini gerçekleştirebilir.
Kod tekrarını azaltır ve daha temiz, düzenli bir kod yapısı sağlar.
Bu desen, özellikle dil bağımsız ve genel amaçlı programlama dillerinde sıklıkla kullanılan bir tasarım desenidir.

## Facade Design Pattern :
Facade tasarım deseni (Facade Design Pattern), yazılım mühendisliği alanında kullanılan bir tasarım deseni (design pattern) türüdür. Bu desen, bir yazılım sisteminin karmaşıklığını azaltmak ve daha kullanıcı dostu bir arayüz sağlamak amacıyla kullanılır. Genellikle büyük ve karmaşık sistemlerde bulunan alt sistemlerin karmaşıklığını gizlemek için kullanılır.

Facade tasarım deseni, birçok alt sistemi tek bir arayüz üzerinden kullanıcıya sunar. Bu sayede, kullanıcılar karmaşıklığı azaltmak için her alt sistemi ayrı ayrı anlamak zorunda kalmazlar. Facade, kullanıcıların sistemi daha kolay anlamalarına ve kullanmalarına yardımcı olur.

Bu desenin temel amacı şunlardır:

Alt sistemlerin karmaşıklığını gizlemek: Facade, alt sistemlerin karmaşıklığını gizler ve kullanıcıya sadece gerekli olan bilgileri ve işlevleri sunar.

Kolay kullanım: Facade, kullanıcıların sistemi daha kolay anlamalarına ve kullanmalarına yardımcı olur, böylece sistemi daha verimli bir şekilde kullanabilirler.

Bağımsızlık: Facade, alt sistemlerin değişikliklerine karşı kullanıcıları korur. Alt sistemlerde yapılan değişiklikler facade üzerinde minimum etki yapar.

Facade tasarım deseni genellikle aşağıdaki bileşenlerden oluşur:

Facade: Kullanıcıya sunulan ana arayüzdür. Kullanıcı, sistemi bu arayüz üzerinden kullanır.

Alt Sistemler (Subsystems): Sistemin karmaşıklığını gizlemek için kullanılan alt sistemlerdir. Facade, bu alt sistemlere erişir ve kullanıcıya sunar.

Kullanıcı (Client): Sistemi kullanacak olan taraf, facade üzerinden sistemi kullanır.

Facade tasarım deseni, özellikle büyük ve karmaşık yazılım sistemlerinde kullanıcı dostu bir arayüz sağlamak ve sistemin bakımını kolaylaştırmak için oldukça yararlıdır. Bu desen, sistemin genel tasarımını daha modüler hale getirerek daha iyi bir kod organizasyonu sağlar.

## Decorator Design Pattern :
Decorator tasarım deseni (Decorator Design Pattern), nesne yönelimli programlamada kullanılan bir yapısal tasarım desenidir. Bu desen, bir nesneye dinamik olarak davranışlar eklemek veya nesnenin davranışını değiştirmek istediğiniz durumlarda kullanılır. Bu eklemeleri veya değişiklikleri alt sınıflar oluşturmadan yapmanızı sağlar, böylece sınıf yapısını daha esnek hale getirir.

Decorator tasarım deseninin temel amacı, sınıfın açık genişlemesi (open for extension) ve kapalı değişmezliği (closed for modification) prensiplerini uygulayarak mevcut bir nesneye ek işlevsellik eklemektir. Bu desen, aşağıdaki ana bileşenleri içerir:

Component (Bileşen): Decorator deseninin temel arayüzünü tanımlar. Bu arayüz, değiştirilmesi veya genişletilmesi gereken nesnenin temel işlevlerini içerir.

ConcreteComponent (Somut Bileşen): Component arayüzünü uygulayan somut sınıftır. Ek işlevsellik eklemek veya değiştirmek istediğiniz nesnedir.

Decorator: Abstract Decorator olarak da adlandırılır ve Component arayüzünü uygular. Bu sınıf, ek işlevselliği sağlamak için kullanılır. Decorator sınıfı içinde bir Component nesnesini sarmalar ve bu nesneye ek işlevselliği ekler.

ConcreteDecorator (Somut Dekoratör): Decorator sınıfını genişleten somut sınıflardır. Bu sınıflar, belirli işlevselliği ekleyen veya değiştiren sınıflardır.

Decorator tasarım deseni, özellikle aynı nesne üzerinde farklı işlevselliği dinamik olarak birleştirmek veya kullanmak gerektiğinde kullanışlıdır. Bu desen, özellikle açık kaynak kodlu veya dışarıdan gelen kütüphanelerle çalışırken mevcut sınıfları değiştirmek istemeden ek işlevselliği eklemek için kullanışlıdır.

Özetle, Decorator tasarım deseni, nesnelerin işlevselliğini dinamik olarak genişletmek veya değiştirmek istediğiniz durumlarda kullanılır ve bu sayede daha esnek ve sürdürülebilir bir kod tasarımı sağlar.
